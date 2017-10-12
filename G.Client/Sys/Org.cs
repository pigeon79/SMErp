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
    public partial class Org : G.Controls.Base.BasicForm
    {
        public Org()
        {
            InitializeComponent();
        }

        private void Org_Load(object sender, EventArgs e)
        {
            LoadOrg();
            LoadToolBar();
        }
        G.BLL.Sys.ND_ORGINAZITIONLogic orglogic = new BLL.Sys.ND_ORGINAZITIONLogic();
        private void LoadOrg()
        {
            int totalRowCount = 0;
            treeView_menu.Nodes.Clear();

            List<ND_ORGINAZITION> list = orglogic.ExecuteSelect(Condition.Empty, OrderBy.Parse("id"), 0, 1, ref totalRowCount);
            TreeNode node = new TreeNode();
            node.Text = "部门";
            this.treeView_menu.Nodes.Add(node);
            FillTree(node, list, -1);
            this.treeView_menu.Nodes[0].Expand();
        }
        private void FillTree(TreeNode pnode, List<ND_ORGINAZITION> list, int parentid)
        {
            var menus = from m in list
                        where m.PARENTID == parentid
                        orderby m.SORTID
                        select m;
            foreach (ND_ORGINAZITION m in menus)
            {
                TreeNode node = new TreeNode();
                node.Text = m.ORGNAME;
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
                G.BLL.Sys.ND_ORGINAZITIONLogic menulogic = new BLL.Sys.ND_ORGINAZITIONLogic();
                int pid = DropNode.Tag != null ? (DropNode.Tag as ND_ORGINAZITION).Id : -1;
                menulogic.MoveTo(myNode.Tag as ND_ORGINAZITION, pid);
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
        ND_ORGINAZITION CurOrg = null;
        private void treeView_menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var org = (sender as TreeView).SelectedNode.Tag as ND_ORGINAZITION;
            if (org != null)
            {
                CurOrg = org;
                TXT_ORGDM.Text = org.ORGDM;
                TXT_ORGNAME.Text = org.ORGNAME;
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
        private void UpdateOrg()
        {
            if (CurOrg != null)
            {
                CurOrg.ORGDM = TXT_ORGDM.Text;
                CurOrg.ORGNAME = TXT_ORGNAME.Text;
                CurOrg.Save();
            }

        }
        private void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {
            switch (e.Command.Text)
            {
                case "保存":
                    UpdateOrg();
                    break;
            }
        }

        private void CMS_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "新增":
                    NewOrg();
                    break;
                case "删除":
                    DeleteOrg();
                    break;
                case "删除子菜单":
                    DeleteAllOrg();
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
                    LoadOrg();
                    break;
            }
        }
        private void NewOrg()
        {
            try
            {
                var parenetmenu = this.treeView_menu.SelectedNode.Tag as ND_ORGINAZITION;
                CurOrg = new ND_ORGINAZITION();
                CurOrg.PARENTID = parenetmenu != null ? parenetmenu.Id : -1;
                this.TXT_ORGDM.Text = CurOrg.ORGDM;
                this.TXT_ORGNAME.Text = CurOrg.ORGNAME;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void DeleteOrg()
        {
            try
            {
                var curorg = this.treeView_menu.SelectedNode.Tag as ND_ORGINAZITION;
                if (MessageBox.Show("是否删除" + curorg.ORGNAME, "信息提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    orglogic.ExecuteDelete(curorg);
                    this.treeView_menu.SelectedNode.Remove();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void DeleteAllOrg()
        {
            try
            {
                var curorg = this.treeView_menu.SelectedNode.Tag as ND_ORGINAZITION;
                if (MessageBox.Show("是否删除" + curorg.ORGNAME + "下面所有部门", "信息提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    orglogic.DeleteChild(curorg);
                    this.treeView_menu.SelectedNode.Remove();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void MoveFist()
        {
            try
            {
                TreeNode curNode = this.treeView_menu.SelectedNode;
                TreeNode firstNode = this.treeView_menu.SelectedNode.Parent.FirstNode;
                var curorg = curNode.Tag as ND_ORGINAZITION;
                var firstorg = firstNode.Tag as ND_ORGINAZITION;
                orglogic.MoveFirst(curorg, firstorg);
                TreeNode newNode = (TreeNode)curNode.Clone();
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
                var curorg = curNode.Tag as ND_ORGINAZITION;
                var prvorg = prvNode.Tag as ND_ORGINAZITION;
                orglogic.MovePrv(curorg, prvorg);
                TreeNode newNode = (TreeNode)curNode.Clone();
                this.treeView_menu.SelectedNode.Parent.Nodes.Insert(prvNode.Index, newNode);
                curNode.Remove();
                this.treeView_menu.SelectedNode = newNode;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void MoveDown()
        {
            try
            {
                TreeNode curNode = this.treeView_menu.SelectedNode;
                TreeNode nextNode = this.treeView_menu.SelectedNode.NextNode;
                var curorg = curNode.Tag as ND_ORGINAZITION;
                var nextorg = nextNode.Tag as ND_ORGINAZITION;
                orglogic.MoveNext(curorg, nextorg);
                TreeNode newNode = (TreeNode)curNode.Clone();
                this.treeView_menu.SelectedNode.Parent.Nodes.Insert(nextNode.Index + 1, newNode);
                curNode.Remove();
                this.treeView_menu.SelectedNode = newNode;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void MoveLast()
        {
            try
            {
                TreeNode curNode = this.treeView_menu.SelectedNode;
                TreeNode lastNode = this.treeView_menu.SelectedNode.Parent.LastNode;
                var curorg = curNode.Tag as ND_ORGINAZITION;
                var lastorg = lastNode.Tag as ND_ORGINAZITION;
                orglogic.MoveLast(curorg, lastorg);
                TreeNode newNode = (TreeNode)curNode.Clone();
                this.treeView_menu.SelectedNode.Parent.Nodes.Insert(lastNode.Index + 1, newNode);
                curNode.Remove();
                this.treeView_menu.SelectedNode = newNode;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
