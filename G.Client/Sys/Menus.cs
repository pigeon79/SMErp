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

namespace G.Client.Sys
{
    public partial class Menus : G.Controls.Base.BasicForm
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void Menus_Load(object sender, EventArgs e)
        {
            LoadMenu();
            LoadToolBar();
        }
        G.BLL.Sys.ND_MenuLogic menulogic = new BLL.Sys.ND_MenuLogic();
        private void LoadMenu()
        {
            int totalRowCount = 0;
            treeView_menu.Nodes.Clear();
            List<ND_MENU> list = menulogic.ExecuteSelect(ExpressionParser<ND_MENU>.Parse(m => m.SYSTEMNAME == "ERP"), OrderBy.Parse("id"), 0, 1, ref totalRowCount);
            TreeNode node = new TreeNode();
            node.Text = "菜单";
            this.treeView_menu.Nodes.Add(node);
            FillTree(node, list, -1);
            this.treeView_menu.Nodes[0].Expand();
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
        #region 树拖动
        private Point Position = new Point(0, 0);
        /// <summary>
        /// 开始拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_menu_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
        /// <summary>
        /// 拖入控件边缘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_menu_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// 完成拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_menu_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode myNode = null;
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                myNode = (TreeNode)(e.Data.GetData(typeof(TreeNode)));
            }
            else
            {
                MessageBox.Show("error");
            }
            Position.X = e.X;
            Position.Y = e.Y;
            Position = this.treeView_menu.PointToClient(Position);
            TreeNode DropNode = this.treeView_menu.GetNodeAt(Position);
            // 1.目标节点不是空。2.目标节点不是被拖拽接点的子节点。3.目标节点不是被拖拽节点本身
            if (DropNode != null && DropNode.Parent != myNode && DropNode != myNode)
            {
                TreeNode DragNode = myNode;
                // 将被拖拽节点从原来位置删除。
                myNode.Remove();
                // 在目标节点下增加被拖拽节点
                DropNode.Nodes.Add(DragNode);
                int pid = DropNode.Tag != null ? (DropNode.Tag as ND_MENU).Id : -1;
                menulogic.MoveTo(myNode.Tag as ND_MENU, pid);
            }
            // 如果目标节点不存在，即拖拽的位置不存在节点，那么就将被拖拽节点放在根节点之下
            if (DropNode == null)
            {
                TreeNode DragNode = myNode;
                myNode.Remove();
                treeView_menu.Nodes.Add(DragNode);
            }
        }

        #endregion
        ND_MENU CurMenu = null;
        private void treeView_menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var menu = (sender as TreeView).SelectedNode.Tag as ND_MENU;
            if (menu != null)
            {
                CurMenu = menu;
                TXT_MENUCAPTION.Text = menu.MENUCAPTION;
                TXT_SYSTEMNAME.Text = menu.SYSTEMNAME;
                TXT_ASSEMBLYNAME.Text = menu.ASSEMBLYNAME;
                TXT_ACTIONTYPE.Text = menu.ACTIONTYPE;
                TXT_DJLX.Text = menu.DJLX;
                txt_Target.Text = menu.TARGET;
                CB_ISVISIBLE.Checked = (bool)menu.ISVISIBLE;
                this.CB_OUTLOOK.Checked = (bool)menu.OUTLOOKTAG;
            }
        }

        private void LoadToolBar()
        {
            C1.Win.C1Command.C1Command command = new C1.Win.C1Command.C1Command();
            command.Text = "保存";
            c1CommandHolder1.Commands.Add(command);
            C1.Win.C1Command.C1CommandLink link = new C1.Win.C1Command.C1CommandLink();
            link.Text = "保存";
            link.ButtonLook = ButtonLookFlags.TextAndImage;
            link.Command = command;
            c1ToolBar1.CommandLinks.Add(link);
        }
        private void UpdateMenu()
        {
            if (CurMenu != null)
            {
                CurMenu.MENUCAPTION = TXT_MENUCAPTION.Text;
                CurMenu.SYSTEMNAME = TXT_SYSTEMNAME.Text;
                CurMenu.ASSEMBLYNAME = TXT_ASSEMBLYNAME.Text;
                CurMenu.ACTIONTYPE = TXT_ACTIONTYPE.Text;
                CurMenu.ISVISIBLE = CB_ISVISIBLE.Checked;
                CurMenu.DJLX = TXT_DJLX.Text;
                CurMenu.OUTLOOKTAG = this.CB_OUTLOOK.Checked;
                CurMenu.TARGET = txt_Target.Text;
                CurMenu.Save();
            }

        }
        private void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {
            switch (e.Command.Text)
            {
                case "保存":
                    UpdateMenu();
                    break;
            }
        }

        private void CMS_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "新增":
                    NewMenu();
                    break;
                case "删除":
                    DeleteMenu();
                    break;
                case "删除子菜单":
                    DeleteAllMenu();
                    break;
                case "最上":
                    MoveFist();
                    break;
                case "上移":
                    MoveUp();
                    break;
                case "下移":
                    MoveDown();
                    break;
                case "最下":
                    MoveLast();
                    break;
                case "刷新":
                    LoadMenu();
                    break;
            }
        }
        private void NewMenu()
        {
            try
            {
                var parenetmenu = this.treeView_menu.SelectedNode.Tag as ND_MENU;
                CurMenu = new ND_MENU();
                CurMenu.PARENTID = parenetmenu != null ? parenetmenu.Id : -1;
                TXT_MENUCAPTION.Text = CurMenu.MENUCAPTION;
                TXT_SYSTEMNAME.Text = CurMenu.SYSTEMNAME;
                TXT_ASSEMBLYNAME.Text = CurMenu.ASSEMBLYNAME;
                TXT_ACTIONTYPE.Text = CurMenu.ACTIONTYPE;
                TXT_DJLX.Text = CurMenu.DJLX;
                txt_Target.Text = CurMenu.TARGET;
                CB_ISVISIBLE.Checked = (bool)CurMenu.ISVISIBLE;
                this.CB_OUTLOOK.Checked = (bool)CurMenu.OUTLOOKTAG;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void DeleteMenu() {
            try
            {
                var curmenu = this.treeView_menu.SelectedNode.Tag as ND_MENU;
                if (MessageBox.Show("是否删除" + curmenu.MENUCAPTION, "信息提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    menulogic.ExecuteDelete(curmenu);
                    this.treeView_menu.SelectedNode.Remove();
                }
            }
            catch (Exception e) { }
        }
        private void DeleteAllMenu() {
            try
            {
                var curmenu = this.treeView_menu.SelectedNode.Tag as ND_MENU;
                if (MessageBox.Show("是否删除" + curmenu.MENUCAPTION+"下面所有菜单", "信息提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    menulogic.DeleteChild(curmenu);
                    this.treeView_menu.SelectedNode.Remove();
                }
            }
            catch (Exception e) { }
        }
        private void MoveFist() {
            try
            {
                TreeNode curNode=this.treeView_menu.SelectedNode;
                TreeNode firstNode=this.treeView_menu.SelectedNode.Parent.FirstNode;
                var curmenu = curNode.Tag as ND_MENU;
                var firstmenu = firstNode.Tag as ND_MENU;
                menulogic.MoveFirst(curmenu,firstmenu);
                TreeNode newNode=(TreeNode)curNode.Clone();
                this.treeView_menu.SelectedNode.Parent.Nodes.Insert(firstNode.Index, newNode);
                curNode.Remove();
                this.treeView_menu.SelectedNode = newNode;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void MoveUp()
        {
            try
            {
                TreeNode curNode = this.treeView_menu.SelectedNode;
                TreeNode prvNode = this.treeView_menu.SelectedNode.PrevNode;
                var curmenu = curNode.Tag as ND_MENU;
                var prvmenu = prvNode.Tag as ND_MENU;
                menulogic.MovePrv(curmenu, prvmenu);
                TreeNode newNode = (TreeNode)curNode.Clone();
                this.treeView_menu.SelectedNode.Parent.Nodes.Insert(prvNode.Index, newNode);
                curNode.Remove();
                this.treeView_menu.SelectedNode = newNode;
            }
            catch (Exception e) { }
        }
        private void MoveDown()
        {
            try
            {
                TreeNode curNode = this.treeView_menu.SelectedNode;
                TreeNode nextNode = this.treeView_menu.SelectedNode.NextNode;
                var curmenu = curNode.Tag as ND_MENU;
                var nextmenu = nextNode.Tag as ND_MENU;
                menulogic.MoveNext(curmenu, nextmenu);
                TreeNode newNode = (TreeNode)curNode.Clone();
                this.treeView_menu.SelectedNode.Parent.Nodes.Insert(nextNode.Index+1, newNode);
                curNode.Remove();
                this.treeView_menu.SelectedNode = newNode;
            }
            catch (Exception e) { }
        }
        private void MoveLast()
        {
            try
            {
                TreeNode curNode = this.treeView_menu.SelectedNode;
                TreeNode lastNode = this.treeView_menu.SelectedNode.Parent.LastNode;
                var curmenu = curNode.Tag as ND_MENU;
                var lastmenu = lastNode.Tag as ND_MENU;
                menulogic.MoveLast(curmenu, lastmenu);
                TreeNode newNode = (TreeNode)curNode.Clone();
                this.treeView_menu.SelectedNode.Parent.Nodes.Insert(lastNode.Index + 1, newNode);
                curNode.Remove();
                this.treeView_menu.SelectedNode = newNode;
            }
            catch (Exception e) { }
        }
    }
}
