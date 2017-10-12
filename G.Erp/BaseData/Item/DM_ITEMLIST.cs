using G.Controls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.GGrid;
using G.Data;
using G.Entity.ERP;
using G.APP.BaseForm;

namespace G.Erp.BaseData
{
    public partial class DM_ITEMLIST : BasicForm
    {
        public DM_ITEMLIST()
        {
            InitializeComponent();
        }
        public override bool LoadForm()
        {
            this.Text = "物品列表";
            this.c1SplitterPanel1.Text = "物品列表";
            InitToolBar();
            InitForm();
            InitFilter();
            LoadData();
            return true;
        }
        private void InitToolBar() {
            this.gToolBar1.AddButton("新增");
            this.gToolBar1.AddButton("修改");
            this.gToolBar1.AddButton("删除");
            this.gToolBar1.AddButton("刷新");
            this.gToolBar1.AddButton("-");
            this.gToolBar1.AddButton("过滤");
            this.gToolBar1.AddButton("|");
            this.gToolBar1.AddButton("退出");
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "新增":
                        AddNew();
                        break;
                    case "修改":
                        Modify();
                        break;
                    case "刷新":
                        RefreshData();
                        break;
                    case "删除":
                        this.Delete();
                        break;
                    case "过滤":
                        Filter();
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
        private void Delete()
        {
            try
            {
                DialogResult dr = MessageBox.Show("是否删除单据!", "提示", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    G.BLL.ERP.BaseData.DM_ITEMLogic logic = new BLL.ERP.BaseData.DM_ITEMLogic();
                    logic.ExecuteDelete(gGrid1.GetCurSelect<DM_ITEM>());
                    this.LoadData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        List<DM_ITEM> EditData = new List<DM_ITEM>();
        private void InitForm() {
            gGrid1.AddGridColumn("ItemCode", "物品代码", "String", 80);
            gGrid1.AddGridColumn("ItemDesc", "物品名称", "String", 100);
            gGrid1.AddGridColumn("ItemName", "物品简称", "String", 100);
            gGrid1.AddGridColumn("Py", "辅助符", "String", 60);
            gGrid1.AddGridColumn("InvUnit", "单位", "String", 60);
            gGrid1.AddGridColumn("WRHSNAME", "默认仓库", "String", 80);
            gGrid1.AddGridColumn("LOCNAME", "默认库位", "String", 80);
            gGrid1.AddGridColumn("INVCLASSNAME", "库存类别", "String", 80);
            gGrid1.AddGridColumn("FINACLASSNAME", "财务类别", "String", 80);
            gGrid1.AddGridColumn("ITEMTYPENAME", "物品类别", "String", 80);
            gGrid1.AddGridColumn("IsAttributeA", "是否色号", "Boolean", 60);
            gGrid1.AddGridColumn("IsAttributeB", "是否花模", "Boolean", 60);
            gGrid1.AddGridColumn("IsAttributeC", "是否规格", "Boolean", 60);
            gGrid1.AddGridColumn("QltFlag", "是否检验", "Boolean", 60);
            gGrid1.AddGridColumn("ISPUR", "是否采购", "Boolean", 60);
            gGrid1.AddGridColumn("ORGNAME", "车间", "String", 80);
            gGrid1.AddGridColumn("BreakPer", "折率", "Decimal", 80);
            gGrid1.AddGridColumn("MaxStock", "最大库存", "Decimal", 80);
            gGrid1.AddGridColumn("SafeStock", "安全库存", "Decimal", 80);
            gGrid1.AddGridColumn("MaxCap", "最大产能", "Decimal", 80);
            gGrid1.AddGridColumn("CertQty", "合格证批量", "Int32", 80);
            gGrid1.AddGridColumn("WorkOrdQty", "派工单批量", "Int32", 60);
            gGrid1.AddGridColumn("SUPPNAME", "供应商", "String", 120);
            gGrid1.AddGridColumn("SUPPRICE", "采购单价", "Decimal", 60);
            gGrid1.AddGridColumn("METNAME", "材料名称", "String", 120);
            gGrid1.AddGridColumn("WEIGHT", "克重", "Decimal", 60);
            gGrid1.AddGridColumn("ISIZE", "规格", "Decimal", 60);
            gGrid1.AddGridColumn("SCRAPRATE", "废料比列", "Decimal", 60);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
           
        }
        private void AddNew() {
            DM_ITEMEDIT frm = new DM_ITEMEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            RefreshData();
        }
        private void Modify() { 
        DM_ITEMEDIT frm = new DM_ITEMEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.SetData(gGrid1.GetCurSelect<DM_ITEM>());
            frm.ShowDialog();
            RefreshData();
        }
        private void LoadData() {
            int tcount = 0;
            G.BLL.ERP.BaseData.DM_ITEMLogic logic = new BLL.ERP.BaseData.DM_ITEMLogic();
            EditData = logic.ExecuteSelect(CurCondition, OrderBy.Parse("ItemCode"), 0, 0, ref tcount);//logic.GetData();

            gGrid1.DataBind<DM_ITEM>(EditData);
        }
        private void RefreshData() {
            LoadData();
        }
        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            Modify();
        }

        public void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "物品名称", fieldname = "ITEMCODE", fieldtype = "String", controltype = "dropdown", controldata = "ITEM", searchLogic = new G.BLL.ERP.BaseData.DM_ITEMLogic(), islike = false,SearchForm=new ItemSearch() });
            this.FilterInfos.Add(new FilterInfo() { caption = "物品类别", fieldname = "ITEMTYPE", fieldtype = "Int32", controltype = "dropdown", controldata = "ITEMTYPE", searchLogic = new G.BLL.ERP.BaseData.SM_ITEMTYPELogic(), islike = false });
        }
        private Data.Condition _defaultCondition = Data.Condition.Empty;
        public Data.Condition DefaultCondition { set { _defaultCondition = value; this.CurCondition = value; } get { return _defaultCondition; } }
        public Data.Condition CurCondition = Data.Condition.Empty;
        public List<FilterInfo> FilterInfos = new List<FilterInfo>();
        public BaseFilter fform = null;
        private void Filter()
        {
            try
            {
                if (fform == null)
                {
                    fform = new BaseFilter();
                }
                fform.FilterInfos = this.FilterInfos;
                fform.DefaultCondition = this.DefaultCondition;
                DialogResult rst = fform.ShowDialog(this); ;
                if (rst == DialogResult.OK)
                {
                    this.CurCondition = fform.GetCondition();
                    this.RefreshData();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
