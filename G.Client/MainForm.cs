using C1.Win.C1Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using G.Controls.Base;
using System.Xml;
using C1.Win.C1Command;
using G.BLL;
using G.Controls.Core;
using G.Entity.SysEnt;
using G.Data.Model.Linq;
using G.Data;

namespace G.Client
{
    public partial class MainForm : BasicForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
            LoadMenu();
        }
        public void LoadInfo()
        {
            this.Text = G.AppInfo.SysInfo.sysname;
            G.AppInfo.GGlobal.infolab = this.status_Info;
            this.info_company.Text = "公司：" + G.AppInfo.SysInfo.company;
            this.info_logname.Text = "操作员：" + G.AppInfo.SysInfo.logname;
            this.info_curdate.Text = "当前日期：" + DateTime.Now.ToShortDateString();
            this.info_version.Text = "版本：" + G.AppInfo.SysInfo.version;
        }
        private void LoadMenu()
        {

            G.BLL.Sys.ND_MenuLogic menulogic = new BLL.Sys.ND_MenuLogic();
            List<ND_MENU> list = menulogic.GetMenusByAuthority(G.AppInfo.GGlobal.User);
            mainMenu.CommandLinks.Clear();
            TopicBar_Menu.Pages.Clear();
            AddMainMenu(mainMenu, list);
            LoadTopicBar(list);
        }
        #region 菜单
        //private void FillMenu(List<ND_MENU> list, int parentid)
        //{
        //    int pageIndex = 0;
        //    foreach (ND_MENU m in list.FindAll(p => p.PARENTID == parentid))
        //    {
        //        if (m.ISDETAIL==true)
        //        {

        //            C1TopicPage tp = new C1TopicPage(m.MENUCAPTION);
        //            pageIndex = TopicBar_Menu.Pages.Add(tp);
        //            tp.ImageIndex = pageIndex;
        //            //tp.ImageList = sampleIcons;
        //            FillMenu(list, m.Id);
        //        }
        //        else
        //        {
        //            C1TopicLink tl = new C1TopicLink(m.MENUCAPTION);
        //            tl.ToolTipText = m.MENUCAPTION;
        //            TopicBar_Menu.Pages[pageIndex].Links.Add(tl);
        //        }
        //    }
        //}
        private BasicForm form = new BasicForm();
        private void AddMainMenu(C1MainMenu mainMenu, List<ND_MENU> menus)
        {
            AddFixMenu(mainMenu);
            var list = (from m in menus
                        where m.PARENTID == -1
                        orderby m.SORTID
                        select m).Take(20).ToList();
            foreach (ND_MENU m in list)
            {
                var commMenu = this.AddMainLink(mainMenu, m.MENUCAPTION);
                AddMenu(commMenu, menus, m.Id);
            }

        }
        private void AddFixMenu(C1MainMenu mainMenu)
        {
            var commMenu = this.AddMainLink(mainMenu, "系统");
            var commenu = this.AddLink(commMenu, new ND_MENU() { MENUCAPTION = "重新登录", SYSTEMNAME = "SYS" });
        }
        private C1CommandMenu AddMainLink(C1MainMenu mainMenu, string menuname)
        {
            C1CommandMenu commandMenu = new C1CommandMenu();
            C1.Win.C1Command.C1CommandLink link = new C1.Win.C1Command.C1CommandLink();
            link.Text = menuname;
            link.Command = commandMenu;
            mainMenu.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] { link });
            commandHolder.Commands.Add(commandMenu);
            return commandMenu;
        }
        private void AddMenu(C1.Win.C1Command.C1CommandMenu menu, List<ND_MENU> menus, int parentid)
        {
            var list = from m in menus
                       where m.PARENTID == parentid
                       orderby m.SORTID
                       select m;
            foreach (ND_MENU m in list)
            {
                var commenu = this.AddLink(menu, m);
                if (m.ISDETAIL == false)
                {
                    AddMenu(commenu, menus, m.Id);
                }
            }
        }
        private C1CommandMenu AddLink(C1.Win.C1Command.C1CommandMenu cmenu, ND_MENU m)
        {
            C1CommandMenu commandMenu = new C1CommandMenu();
            C1.Win.C1Command.C1CommandLink link = new C1.Win.C1Command.C1CommandLink();
            link.Text = m.MENUCAPTION;
            link.Command = commandMenu;

            cmenu.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] { link });
            commandMenu.Text = m.MENUCAPTION;
            commandMenu.UserData = m;
            commandHolder.Commands.Add(commandMenu);
            return commandMenu;
        }
        private void commandHolder_CommandClick(object sender, CommandClickEventArgs e)
        {
            ND_MENU menu = e.Command.UserData as ND_MENU;
            if (menu != null)
            {
                if (menu.SYSTEMNAME == "SYS")
                {
                    switch (menu.MENUCAPTION)
                    {
                        case "重新登录":
                            if (Program.StartLogin())
                            {
                                LoadInfo();
                                LoadMenu();
                            }
                            break;
                    }
                }
                else
                {
                    OpenForm(menu);
                }
            }

        }
        #endregion
        #region Topic
        private void LoadTopicBar(List<ND_MENU> menus)
        {
            var list = (from m in menus
                        where m.OUTLOOKTAG == true
                        orderby m.SORTID
                        select m).ToList();

            int pageIndex = 0;
            foreach (ND_MENU m in list)
            {
                //if ((bool)m.OUTLOOKTAG) continue;
                C1TopicPage tp = new C1TopicPage(m.MENUCAPTION);
                pageIndex = this.TopicBar_Menu.Pages.Add(tp);
                AddTopicBarLink(tp, menus, m.Id);
            }
            this.TopicBar_Menu.CollapseAll();
            if (this.TopicBar_Menu.Pages.Count > 0)
            {
                this.TopicBar_Menu.Pages[0].Expand();
            }
        }
        private void AddTopicBarLink(C1TopicPage tp, List<ND_MENU> menus, int parentid)
        {
            var list = from m in menus
                       where m.PARENTID == parentid
                       orderby m.SORTID
                       select m;

            foreach (ND_MENU m in list)
            {
                C1TopicLink tl = new C1TopicLink(m.MENUCAPTION);
                tl.Tag = m;
                tl.ToolTipText = m.MENUCAPTION;
                tp.Links.Add(tl);
            }
        }
        private void TopicBar_Menu_LinkClick(object sender, C1.Win.C1Command.C1TopicBarClickEventArgs e)
        {
            if (e.Link.Tag != null)
            {
                ND_MENU menu = e.Link.Tag as ND_MENU;
                this.Cursor = Cursors.AppStarting;
                if (menu.ASSEMBLYNAME != "")
                {
                    OpenForm(menu);
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void LoadBill()
        {
            int totalRowCount = 0;
            G.BLL.Sys.ND_BillLogic billlogic = new BLL.Sys.ND_BillLogic();
            List<ND_BILL> list = billlogic.ExecuteSelect(Condition.Empty, OrderBy.Parse("id"), 0, 1, ref totalRowCount);
            G.APP.BaseForm.BaseList baselist = new APP.BaseForm.BaseList();

            var t = typeof(G.APP.BaseForm.BaseList);
            string dllname = t.ToString() + "," + System.Reflection.Assembly.GetAssembly(t).GetName().Name;
            //OpenForm(dllname, "");
            Viewer viewer = new Viewer();
            viewer.Run(dllname, "", -1);
            Attach(viewer, "", -1);
        }
        #endregion
        #region openform
        private void OpenForm(ND_MENU menu)
        {
            if (menu.ASSEMBLYNAME != "" && menu.ASSEMBLYNAME != null)
            {
                Viewer viewer = new Viewer();
                if (menu.TARGET.IsNullOrEmpty()) { 
                    viewer.Run(menu.ASSEMBLYNAME, "", menu.Id);
                    Attach(viewer, menu.MENUCAPTION, menu.Id); }
                else
                    if (menu.TARGET.ToUpper() == "OPEN")
                    {
                        viewer.ShowDialogForm(menu.ASSEMBLYNAME, "", menu.Id);
                    }
                    else
                    {
                        viewer.Run(menu.ASSEMBLYNAME, "", menu.Id);
                        Attach(viewer, menu.MENUCAPTION, menu.Id);
                    }
            }
        }
        private void AddOrRemove(Control control, string pagename, int menuid)
        {
            try
            {
                string pageindex = "tabpage_" + menuid;
                if (!dockingTab_Main.Controls.ContainsKey(pageindex))
                {
                    if (control.Visible)
                    {
                        C1DockingTabPage page = new C1DockingTabPage();
                        page.Text = pagename;
                        page.Name = "tabpage_" + menuid;
                        page.ImageIndex = dockingTab_Main.TabPages.Count % 3;
                        page.Controls.Add(control);
                        control.Dock = DockStyle.Fill;
                        control.Visible = true;
                        dockingTab_Main.Controls.Add(page);
                        dockingTab_Main.SelectedTab = page;
                    }
                    else { control.Dispose(); }
                }
                else
                {
                    Control[] cts = dockingTab_Main.Controls.Find(pageindex, false);
                    if (cts.Count() > 0)
                    {
                        C1DockingTabPage page = (C1DockingTabPage)cts[0];
                        dockingTab_Main.SelectedTab = page;
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public void Attach(Viewer viewer, string pagename, int menuid)
        {
            AddOrRemove(viewer, pagename, menuid);
        }
        public void Remove(int menuid)
        {
            string pageindex = "tabpage_" + menuid;
            if (dockingTab_Main.Controls.ContainsKey(pageindex))
            {
                Control[] cts = dockingTab_Main.Controls.Find(pageindex, false);
                if (cts.Count() > 0)
                {
                    dockingTab_Main.Controls.RemoveByKey(pageindex);
                }
            }
        }
        public override void DisplayOut(int menuid)
        {
            Remove(menuid);
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            Sys.Org menuform = new Sys.Org();
            menuform.ShowDialog();
        }

        private void dockingTab_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dockingTab_Main.SelectedIndex == 0)
            {
                dockingTab_Main.CanCloseTabs = false;
            }
            else { dockingTab_Main.CanCloseTabs = true; }
        }



    }
}
