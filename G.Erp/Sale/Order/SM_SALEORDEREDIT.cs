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
using G.Controls.Base;
using G.BLL.Base;
using G.Entity.ERP;
using G.Controls.Input;
using G.APP.BaseForm;
using G.BLL.ERP.BaseData;

namespace G.Erp.Sale.Order
{
    public partial class SM_SALEORDEREDIT : G.APP.BaseForm.BaseEditor
    {
        public SM_SALEORDEREDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单";
            this.listTool = new List<string>() { "新增", "保存", "|", "增行", "删行","|","退出" };
            this.T = typeof(SM_SALEORDER);
            this.orderby = "ORDERID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_SALEORDERLogic();
            this.Edapter = initAdapter();
            InitDrop();
            InitGrid();
            this.DROP_CUSTID.RowSelect += DROP_CUSTID_RowSelect;
        }

        void DROP_CUSTID_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            DataRow dr = e.DataRow;
            if (dr != null)
            {
                this.DROP_INVCUSTID.SetValue(dr["ID"]);
                this.DROP_SALESMAN.SetValue(dr["SALESMAN"]);
                this.DROP_SALESREP.SetValue(dr["SALESREP"]);
                this.DROP_INOFC.SetValue(dr["INOFC"]);
                this.TXT_CUSTLEV.SetValue(dr["CUSTLEV"]);
            }
        }
        private EditorAdapter<SM_SALEORDER, SM_SALEORDERDTL> initAdapter()
        {
            EditorAdapter<SM_SALEORDER, SM_SALEORDERDTL> adapter = new EditorAdapter<SM_SALEORDER, SM_SALEORDERDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售订单号", FieldName = "ORDERID", Editor = this.TXT_ORDERID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单日期", FieldName = "ORDERDATE", Editor = this.DATE_ORDERDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "下单客户", FieldName = "CUSTID", Editor = this.DROP_CUSTID, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "客户等级", FieldName = "CUSTLEV", Editor = this.TXT_CUSTLEV });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开票客户", FieldName = "INVCUSTID", Editor = this.DROP_INVCUSTID, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售员", FieldName = "SALESMAN", Editor = this.DROP_SALESMAN });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售代表", FieldName = "SALESREP", Editor = this.DROP_SALESREP });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "内勤", FieldName = "INOFC", Editor = this.DROP_INOFC });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "合同号", FieldName = "CUSTORDNB", Editor = this.TXT_CUSTORDNB });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单类型", FieldName = "ORDERTYPE", Editor = this.COMB_ORDERTYPE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "总数量", FieldName = "ORDQTY", Editor = this.TXT_ORDQTY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "总金额", FieldName = "ORDAMOUNT", Editor = this.TXT_ORDAMOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "折扣", FieldName = "ORDDISCOUNT", Editor = this.TXT_ORDDISCOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "外贸", FieldName = "FTTAG", Editor = this.CHECK_FTTAG });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "环保", FieldName = "PROTAG", Editor = this.CHECK_PROTAG });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "检针", FieldName = "SUPPTAG", Editor = this.CHECK_SUPPTAG });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "不开票", FieldName = "INVTAG", Editor = this.CHECK_INVTAG });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "收货地址", FieldName = "RECADDRESS", Editor = this.TXT_RECADDRESS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "服装类型", FieldName = "CLOTHTYPE", Editor = this.COMB_CLOTHTYPE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "层数", FieldName = "THICK", Editor = this.NTXT_THICK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "其他费用", FieldName = "OTHAMOUNT", Editor = this.NTXT_OTHAMOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品类型", FieldName = "SALEITEMTYPE", Editor = this.COMB_SALEITEMTYPE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单明细", FieldName = "SALEORDERDTL", Editor = this.gGrid1 });
            return adapter;
        }
        private void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.BaseData.DM_CUSTOMERLogic custlogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic();
            Initialize.InitDropDown(DROP_INOFC, "USER", userlogic,false);
            Initialize.InitDropDown(DROP_SALESMAN, "USER", userlogic, false);
            Initialize.InitDropDown(DROP_SALESREP, "USER", userlogic, false);
            Initialize.InitDropDown(DROP_CUSTID, "CUSTOMER", custlogic, false);
            Initialize.InitDropDown(DROP_INVCUSTID, "CUSTOMER", custlogic, false);
        }

        private void InitGrid()
        {
            DropDown dropdown = new DropDown();
            dropdown.CustomerDropDownForm = new G.Erp.BaseData.ItemSearch();
            dropdown.RowSelected += dropdown_RowSelected;
            dropdown.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            Initialize.InitDropDown(dropdown, "ITEM", new G.BLL.ERP.BaseData.DM_ITEMLogic(), "ItemCode", "ItemName");

            DropDown dropColor = new DropDown();
            Initialize.InitDropDown(dropColor, "COLOR", new G.BLL.ERP.BaseData.DM_COLORLogic(), "CCODE", "CNAME");

            DropDown dropMould = new DropDown();
            dropMould.CustomerDropDownForm = new G.Erp.BaseData.MouldSearch();
            Initialize.InitDropDown(dropMould, "MOULD", new G.BLL.ERP.BaseData.DM_MOULDLogic(), "MDCODE", "MDNAME");

            gGrid1.AddGridColumn("ORDLNNO", "序号", "Int32", 20);
            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, dropdown, "ITEMCODE");
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("COLOR", "色号", "String", 80);
            gGrid1.AddGridColumn("TCOLORA", "工艺色号A", "String", 80, dropColor, "TCOLORANAME");
            gGrid1.AddGridColumn("TCOLORB", "工艺色号B", "String", 80, dropColor, "TCOLORBNAME");
            gGrid1.AddGridColumn("SIZEA", "规格mm", "Decimal", "#0.0", 60);
            gGrid1.AddGridColumn("MOULDA", "花模A", "String", 80, dropMould, "MOULDA");
            gGrid1.AddGridColumn("MOULDB", "花模B", "String", 80, dropMould, "MOULDB");
            gGrid1.AddGridColumn("MOULDC", "花模C", "String", 80, dropMould, "MOULDC");
            gGrid1.AddGridColumn("MOULDD", "花模D", "String", 80, dropMould, "MOULDD");
            gGrid1.AddGridColumn("STYLENO", "款号", "String", 80);
            gGrid1.AddGridColumn("LNQTY", "数量", "Decimal", 80, new C1.Win.C1Input.C1NumericEdit(), "");
            gGrid1.AddGridColumn("NEEDING", "注意事项", "String", 120);
            gGrid1.AddGridColumn("BASICPRICE", "基本价格", "Decimal", "#0.000", 60, true);
            //gGrid1.AddGridColumn("MOULDPRICE", "花模加价", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("TCOLORPRICE", "工艺色号加价", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("OTHERPRICE", "其他加价", "Decimal", "#0.000", 60);
            gGrid1.AddGridColumn("PLANPRICE", "计划价格", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("LNPRICE", "实际价格", "Decimal","#0.000", 60);
            gGrid1.AddGridColumn("LNAMOUNT", "实际金额", "Decimal", "#0.00", 80, true);
            gGrid1.AddGridColumn("LNDISCOUNT", "折扣", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("SAMPLETAG", "是否出样", "Boolean", 60);
            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        public override bool LoadForm()
        {
            base.LoadForm();
            if (this.CurEditStatus == EditorStatus.New)
                AddRow();
            getCurPrice();
            return true;
        }

        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                SM_SALEORDERDTL cur = gGrid1.GetCurSelect<SM_SALEORDERDTL>();
                cur.ITEMNAME = e.DataRow["ItemName"].ToString();
                cur.ITEMCODE = e.DataRow["ItemCode"].ToString();
                //CacuCurPrice(cur);
            }
        }
        
        DM_PRICEBILL pricebill = null;
        List<DM_MOULD> mouldlist = new List<DM_MOULD>();
        List<DM_COLOR> colorlist = new List<DM_COLOR>();
        private void getCurPrice()
        {
            DM_PRICEBILLLogic pricelogic = new DM_PRICEBILLLogic();
            pricebill = pricelogic.GetUsePrice();

            mouldlist = new DM_MOULDLogic().ExecuteSelect(Condition.Empty, OrderBy.Parse("ID"), 0, 0);
            colorlist = new DM_COLORLogic().ExecuteSelect(Condition.Empty, OrderBy.Parse("ID"), 0, 0);
        }
        private decimal getItemPrice(string itemcode, decimal size)
        {
            decimal p = 0;
            var pdlist = from d in pricebill.PRICEBILLDTL
                         where d.ITEMCODE == itemcode
                         select d;
            if (pdlist.Count() > 0)
            {
                DM_PRICEBILLDTL pd = pdlist.First();
                decimal c = size - pd.BASICSIZE;

                if (c >= 0) { p = pd.BASICPRICE + c * pd.ADDPRICE; }
                else { p = pd.BASICPRICE + c * pd.SUBPRICE; }
            }
            return p;
        }
        //private void getMouldPrice(SM_SALEORDERDTL cur)
        //{
        //    decimal v = 0;
        //    var ml = from m in mouldlist
        //             where m.MDCODE == cur.MOULDA || m.MDCODE == cur.MOULDB
        //             select m.MDPRICE;
        //    if (ml.ToArray().Count() <= 2) {
        //        foreach (decimal d in ml) {
        //            v += d;
        //        }
        //    }
        //    cur.MOULDPRICE = v;
        //}
        private void getTColorPrice(SM_SALEORDERDTL cur)
        {
            decimal v = 0;
            var ml = from c in colorlist
                     where c.CCODE == cur.TCOLORA || c.CCODE == cur.TCOLORB
                     select c.ADDPRICE;
            if (ml.ToArray().Count() <= 2)
            {
                foreach (decimal d in ml)
                {
                    v += d;
                }
            }
            cur.TCOLORPRICE = v;
        }
        private void CacuCurPrice(SM_SALEORDERDTL cur) {
            cur.BASICPRICE = getItemPrice(cur.ITEMCODE, G.Core.GConvert.ToDecimal(cur.SIZEA));
            //getMouldPrice(cur);
            getTColorPrice(cur);
            cur.LNPRICE = cur.BASICPRICE + cur.ADDPRICE;
            cur.PLANPRICE = cur.BASICPRICE + cur.ADDPRICE;
            CacuActPrice(cur);
            this.gGrid1.Refresh();
        }
        //计算实际金额及行折扣
        private void CacuActPrice(SM_SALEORDERDTL cur)
        {
            if (cur.BASICPRICE !=0)
            {
                cur.LNDISCOUNT = Decimal.Round((decimal)((cur.LNPRICE - cur.ADDPRICE) / cur.BASICPRICE), 4);
            }
            else { cur.LNDISCOUNT = 0; }
            cur.LNAMOUNT = cur.LNPRICE * cur.LNQTY;
            this.gGrid1.Refresh();
        }
        public override void InitToolBar()
        {
            this.gToolBar1.ClearButton();
            foreach (string s in listTool)
            {
                this.gToolBar1.AddButton(s);
            }
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "新增":
                        this.New();
                        break;
                    case "保存":
                        this.Save();
                        break;
                    case "增行":
                        AddRow();
                        break;
                    case "删行":
                        DeleteRow();
                        break;
                    case "打印":
                        PrintSale(true);
                        break;
                    case "预览":
                        PrintSale(false);
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
                    default:
                        break;
                }
            });
        }
        private void PrintSale(bool isprint) {
        }
        public override void onBeforeSave()
        {
            this.gGrid1.FinishEditing();
            base.onBeforeSave();
        }
        public override void New()
        {
            base.New();
            AddRow();
        }
        private void AddRow()
        {
            SM_SALEORDERDTL saledtl = gGrid1.AddRow<SM_SALEORDERDTL>();
            saledtl.ORDLNNO = ((SM_SALEORDER)editData).SALEORDERDTL.Count;
        }
        private void DeleteRow()
        {
            gGrid1.DeleteRow<SM_SALEORDERDTL>();
        }

        private void gGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == 6 || e.Col == 1 || e.Col == 4 || e.Col == 5 || e.Col == 7 || e.Col == 8 )
            {
                SM_SALEORDERDTL cur = gGrid1.GetCurSelect<SM_SALEORDERDTL>();
                CacuCurPrice(cur);
            }
            if ( e.Col == 10|| e.Col == 16)
            {
                SM_SALEORDERDTL cur = gGrid1.GetCurSelect<SM_SALEORDERDTL>();
                CacuActPrice(cur);
            }

        }
    }
}
