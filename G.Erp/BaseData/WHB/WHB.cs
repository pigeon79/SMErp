using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.BLL;
using G.Entity.ERP;
using G.Data.Model.Linq;
using G.Data;
using C1.Win.C1Command;
using G.Controls.Base;

namespace G.Erp.BaseData
{
    public partial class WHB : G.Controls.Base.BasicForm
    {
        public WHB()
        {
            InitializeComponent();
        }

        private void Menus_Load(object sender, EventArgs e)
        {
            LoadDM_WHBLB();
            InitToolBar();
            InitList();
        }
        G.BLL.ERP.BaseData.DM_WHBLBLogic whblblogic = new BLL.ERP.BaseData.DM_WHBLBLogic();
        private void LoadDM_WHBLB()
        {
            int totalRowCount = 0;
            treeView_menu.Nodes.Clear();
            List<DM_WHBLB> list = whblblogic.ExecuteSelect(Condition.Empty, OrderBy.Parse("id"), 0, 1, ref totalRowCount);
            TreeNode node = new TreeNode();
            node.Text = "辅助资料";
            this.treeView_menu.Nodes.Add(node);
            FillTree(node, list, -1);
            this.treeView_menu.Nodes[0].Expand();
        }
        private void FillTree(TreeNode pnode, List<DM_WHBLB> list, int parentid)
        {
            var whbls = from m in list
                        where m.PARENTID == parentid
                        orderby m.SORTID
                        select m;
            foreach (DM_WHBLB m in whbls)
            {
                TreeNode node = new TreeNode();
                node.Text = m.WHLBNAME;
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
                int pid = DropNode.Tag != null ? (DropNode.Tag as DM_WHBLB).Id : -1;
                whblblogic.MoveTo(myNode.Tag as DM_WHBLB, pid);
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
        DM_WHBLB Curwhbl = null;
        private void treeView_menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var whbl = (sender as TreeView).SelectedNode.Tag as DM_WHBLB;
            if (whbl != null)
            {
                Curwhbl = whbl;
                LoadWHBData(whbl.Id);
            }
        }
        private void InitToolBar()
        {
            this.gToolBar1.AddButton("新增");
            this.gToolBar1.AddButton("修改");
            this.gToolBar1.AddButton("退出");
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "新增":
                        NewWHB();
                        break;
                    case "修改":
                        ModifyWHB();
                        break;
                    case "退出":
                        BasicForm f = this.ParentForm as BasicForm;
                        if (f != null)
                        {
                            this.Close();
                            f.DisplayOut((int)this.MenuId);
                        }
                        else { this.Close(); }
                        break;
                }
            });
        }
        private void NewWHB()
        {
            DM_WHB whb = new DM_WHB();
            whb.WHBLBID = Curwhbl.Id;
            DM_WHBEDIT frm = new DM_WHBEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ParentID = Curwhbl.Id;
            frm.SetData(whb);
            frm.ShowDialog();
            LoadWHBData(Curwhbl.Id);
        }
        private void ModifyWHB()
        {
            DM_WHBEDIT frm = new DM_WHBEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ParentID = Curwhbl.Id;
            frm.SetData(gGrid1.GetCurSelect<DM_WHB>());
            frm.ShowDialog();
            LoadWHBData(Curwhbl.Id);
        }
        #region 处理辅助资料
        private void InitList() {
            gGrid1.AddGridColumn("FZDM", "辅助代码", "String", 80);
            gGrid1.AddGridColumn("FZNAME", "辅助名称", "String", 80);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }
        G.BLL.ERP.BaseData.DM_WHBLogic whblogic = new BLL.ERP.BaseData.DM_WHBLogic();
        private void LoadWHBData(int whblbid)
        {
            List<DM_WHB> EditData = whblogic.ExecuteSelect(CK.K["WHBLBID"].Eq(whblbid), OrderBy.Parse("ID"), 0, 0);
            gGrid1.DataBind<DM_WHB>(EditData);
        }
        #endregion
        #region 处理类别
        private void CMS_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "新增":
                    NewDM_WHBLB();
                    break;
                case "修改":
                    ModifyDM_WHBLB();
                    break;
                case "删除":
                    DeleteDM_WHBLB();
                    break;
                case "删除子菜单":
                    DeleteAllDM_WHBLB();
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
                    LoadDM_WHBLB();
                    break;
            }
        }
        private void NewDM_WHBLB()
        {
            var parenetmenu = this.treeView_menu.SelectedNode.Tag as DM_WHBLB;
            Curwhbl = new DM_WHBLB();
            int pid = -1;
            if (parenetmenu != null)
            {
                pid=Curwhbl.Id;
            }
            DM_WHBLBEDIT frm = new DM_WHBLBEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ParentID = pid;
            Curwhbl.PARENTID = pid;
            frm.SetData(Curwhbl);
            frm.ShowDialog();
            this.LoadDM_WHBLB();
        }
        private void ModifyDM_WHBLB() {
            Curwhbl = this.treeView_menu.SelectedNode.Tag as DM_WHBLB;
            DM_WHBLBEDIT frm = new DM_WHBLBEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ParentID = (int)Curwhbl.PARENTID;
            frm.SetData(Curwhbl);            
            frm.ShowDialog();
            this.LoadDM_WHBLB();
        }
        private void DeleteDM_WHBLB() {
            try
            {
                var curmenu = this.treeView_menu.SelectedNode.Tag as DM_WHBLB;
                if (MessageBox.Show("是否删除" + curmenu.WHLBNAME, "信息提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    whblblogic.ExecuteDelete(curmenu);
                    this.treeView_menu.SelectedNode.Remove();
                }
            }
            catch (Exception e) { }
        }
        private void DeleteAllDM_WHBLB() {
            try
            {
                var curmenu = this.treeView_menu.SelectedNode.Tag as DM_WHBLB;
                if (MessageBox.Show("是否删除" + curmenu.WHLBNAME+"下面所有的", "信息提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    whblblogic.DeleteChild(curmenu);
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
                var curmenu = curNode.Tag as DM_WHBLB;
                var firstmenu = firstNode.Tag as DM_WHBLB;
                whblblogic.MoveFirst(curmenu, firstmenu);
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
                var curmenu = curNode.Tag as DM_WHBLB;
                var prvmenu = prvNode.Tag as DM_WHBLB;
                whblblogic.MovePrv(curmenu, prvmenu);
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
                var curmenu = curNode.Tag as DM_WHBLB;
                var nextmenu = nextNode.Tag as DM_WHBLB;
                whblblogic.MoveNext(curmenu, nextmenu);
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
                var curmenu = curNode.Tag as DM_WHBLB;
                var lastmenu = lastNode.Tag as DM_WHBLB;
                whblblogic.MoveLast(curmenu, lastmenu);
                TreeNode newNode = (TreeNode)curNode.Clone();
                this.treeView_menu.SelectedNode.Parent.Nodes.Insert(lastNode.Index + 1, newNode);
                curNode.Remove();
                this.treeView_menu.SelectedNode = newNode;
            }
            catch (Exception e) { }
        }
        #endregion

        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            ModifyWHB();
        }
    }
}
