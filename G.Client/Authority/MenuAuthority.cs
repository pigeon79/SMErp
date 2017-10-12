using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.BLL;
using G.Entity.SysEnt;
using G.Data.Model.Linq;
using G.Data;
using C1.Win.C1Command;

namespace G.Client.Authority
{
    public partial class MenuAuthority : G.Controls.Base.BasicForm
    {
        public MenuAuthority()
        {
            InitializeComponent();
        }

        private void Menus_Load(object sender, EventArgs e)
        {
            LoadMenu();
            InitToolBar();
            drop_User.TextField = "USERNAME";
            drop_User.ValueField = "ID";
            drop_User.AddGridColumn("USERDM", "工号", "String", 80);
            drop_User.AddGridColumn("USERNAME", "姓名", "String", 80);
            this.drop_User.Logic = new BLL.Sys.ND_UserLogic();
            this.drop_User.GridEndInit();
        }
        private void InitToolBar()
        {
            this.gToolBar1.AddButton("保存");
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "保存":
                        Save();
                        break;
                    default:
                        break;
                }
            });
        }
        G.BLL.Sys.ND_USER_MENUACCESSLogic numlogic = new BLL.Sys.ND_USER_MENUACCESSLogic();
        int userid = 0;
        private void Save()
        {
            try
            {
                mas = new List<ND_USER_MENUACCESS>();
                userid = G.Core.GConvert.ToInt(this.drop_User.Value);
                if (userid > 0)
                {
                    foreach (TreeNode node in treeView_menu.Nodes)
                    {
                        //ND_USER_MENUACCESS num = new ND_USER_MENUACCESS();
                        //num.USERID = userid;
                        //num.MENUID = ((ND_MENU)node.Tag).Id;
                        //mas.Add(num);
                        GetTreeNodes(node);
                    }
                }
                numlogic.SaveAccess(userid, mas);
                MessageBox.Show("设置成功！");
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        List<ND_USER_MENUACCESS> mas = new List<ND_USER_MENUACCESS>();
        private void GetTreeNodes(TreeNode node)
        {
            foreach (TreeNode n in node.Nodes)
            {
                if (n.Checked)
                {
                    ND_USER_MENUACCESS num = new ND_USER_MENUACCESS();
                    num.USERID = userid;
                    num.MENUID = ((ND_MENU)n.Tag).Id;
                    mas.Add(num);
                }
                GetTreeNodes(n);
            }

        }
        private void LoadMenu()
        {
            int totalRowCount = 0;
            G.BLL.Sys.ND_MenuLogic menulogic = new BLL.Sys.ND_MenuLogic();
            List<ND_MENU> list = menulogic.ExecuteSelect(ExpressionParser<ND_MENU>.Parse(m => m.SYSTEMNAME == "ERP"), OrderBy.Parse("id"), 0, 1, ref totalRowCount);
            TreeNode node = new TreeNode();
            node.Text = "菜单";
            this.treeView_menu.Nodes.Add(node);
            FillTree(node, list, -1);
        }
        private void FillTree(TreeNode pnode, List<ND_MENU> list, int parentid)
        {
            var menus = from m in list
                        where m.PARENTID == parentid
                        orderby m.SORTID
                        select m;
            foreach (ND_MENU m in menus)
            {
                TreeNode node = new TreeNode();
                node.Text = m.MENUCAPTION;
                node.Tag = m;
                pnode.Nodes.Add(node);
                this.FillTree(node, list, m.Id);
            }
        }
        private void treeView_menu_AfterCheck(object sender, TreeViewEventArgs e)
        {
            G.Controls.TreeView.TreeViewCheck.CheckControl(e);
        }

        private void drop_User_ValueChanged(object sender, EventArgs e)
        {
            userid = G.Core.GConvert.ToInt(this.drop_User.Value);
            List<ND_USER_MENUACCESS> list = numlogic.GetMenusAccess(userid);
            //int menuid=0;

            foreach (TreeNode tn in this.treeView_menu.Nodes)
            {
                if (list.Count > 0)
                {
                    tn.Checked = true;
                }
                else { tn.Checked = false; }
                if (tn.Nodes.Count > 0)
                {
                    CheckNode(tn, list);
                }
            }
        }
        private void CheckNode(TreeNode node, List<ND_USER_MENUACCESS> list)
        {
            int menuid = 0;
            foreach (TreeNode tn in node.Nodes)
            {
                menuid = ((ND_MENU)tn.Tag).Id;
                if (list.Exists((ND_USER_MENUACCESS u) => u.MENUID == menuid))
                {
                    tn.Checked = true;
                }
                else { tn.Checked = false; }
                if (tn.Nodes.Count > 0)
                {
                    CheckNode(tn, list);
                }
            }
        }
    }
}
