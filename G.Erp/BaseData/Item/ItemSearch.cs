using G.Data;
using G.Entity.ERP;
using G.Interface.CLIENT;
using G.Interface.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Erp.BaseData
{
    public partial class ItemSearch : G.Controls.Input.BaseSearchForm
    {
        public ItemSearch()
        {
            InitializeComponent();
            InitColumn();
            LoadItemType();
        }
        //public event EventHandler<DataRowEvent> EventRowSelected;
        //public event EventHandler<EventArgs> EventRequestClose;

        G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new BLL.ERP.BaseData.DM_ITEMLogic();
        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            Condition c = null;
            string itemcode = txt_ITEMCODE.Text;
            string itemname = txt_ITEMDESC.Text;
            var itemtype = this.treeView_ItemType.SelectedNode.Tag as SM_ITEMTYPE;
            if (itemtype != null)
            { 
                c &= CK.K["ItemType"].Eq(itemtype.Id);
            }
           
            if (!String.IsNullOrEmpty(itemcode))
            {
                c &= CK.K["ItemCode"].LeftLike(itemcode);
            }
            if (!String.IsNullOrEmpty(itemname))
            {
                string[] name = itemname.Split(' ');
                foreach (string s in name)
                {
                    if (!String.IsNullOrEmpty(s))
                    { c &= CK.K["ItemName"].Like(s); }
                }
            }
            if (c == null)
                c = Condition.Empty;

            DataTable list = itemlogic.ExecuteSelect(c, OrderBy.Parse(""), 0, 0).ToDataTable();
            gGrid1.DataSource = list;
        }

        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (this.gGrid1.DataSource != null)
            {
                if (this.gGrid1.Row > 0)
                {
                    int rs = this.gGrid1.Row;
                    rs -= gGrid1.Rows.Fixed;
                    if (rs >= 0)
                    {
                        DataRow dr = ((DataTable)this.gGrid1.DataSource).DefaultView[rs].Row;
                        OnRowSelected(new DataRowEvent { DataRow = dr });
                    }
                }
            }
            this.Close();
        }
        private void InitColumn()
        {
            gGrid1.AddGridColumn("ItemCode", "物品代码", "String", 80);
            gGrid1.AddGridColumn("ItemDesc", "物品名称", "String", 100);
            gGrid1.AddGridColumn("Py", "辅助符", "String", 100);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }
        private void ItemSearch_Load(object sender, EventArgs e)
        {
            this.drop_InvClassID.Logic = new G.BLL.ERP.BaseData.DM_INVCLASSLogic();
            drop_InvClassID.AddGridColumn("InvClass", "类别代码", "String", 80);
            drop_InvClassID.AddGridColumn("InvDesc", "类别名称", "String", 80);
            this.drop_InvClassID.GridEndInit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadItemType()
        {
            treeView_ItemType.Nodes.Clear();
            List<SM_ITEMTYPE> list = new G.BLL.ERP.BaseData.SM_ITEMTYPELogic().ExecuteSelect(Condition.Empty, OrderBy.Parse("id"), 0, 0);
            TreeNode node = new TreeNode();
            node.Text = "物品类别";
            this.treeView_ItemType.Nodes.Add(node);
            FillTree(node, list, -1);
            this.treeView_ItemType.Nodes[0].Expand();
        }
        private void FillTree(TreeNode pnode, List<SM_ITEMTYPE> list, int parentid)
        {
            //var menus = from m in list
            //            where m.PARENTID == parentid
            //            orderby m.SORTID
            //            select m;
            foreach (SM_ITEMTYPE m in list)
            {
                TreeNode node = new TreeNode();
                node.Text = m.ITEMTYPENAME;
                node.Tag = m;
                pnode.Nodes.Add(node);
                //this.FillTree(node, list, m.Id);
            }
        }
        private TreeNode curNode = null;
        private void treeView_ItemType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (curNode != null) { curNode.BackColor = Color.White; }
            curNode=this.treeView_ItemType.SelectedNode;
            curNode.BackColor = Color.SkyBlue;
            var itemtype = this.treeView_ItemType.SelectedNode.Tag as SM_ITEMTYPE;
            if (itemtype != null)
            {
                SearchData();
            }
        }
    }
}
