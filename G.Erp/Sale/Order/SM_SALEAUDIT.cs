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
using G.BLL.ERP.Sale;

namespace G.Erp.Sale.Order
{
    public partial class SM_SALEAUDIT : G.APP.BaseForm.BaseEditor
    {
        public SM_SALEAUDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单审核";
            this.listTool = new List<string>() { "审核","退出" };
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
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售订单号", FieldName = "ORDERID", Editor = this.TXT_ORDERID,IsReadOnly=true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单日期", FieldName = "ORDERDATE", Editor = this.DATE_ORDERDATE, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "下单客户", FieldName = "CUSTID", Editor = this.DROP_CUSTID, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "客户等级", FieldName = "CUSTLEV", Editor = this.TXT_CUSTLEV, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开票客户", FieldName = "INVCUSTID", Editor = this.DROP_INVCUSTID, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售员", FieldName = "SALESMAN", Editor = this.DROP_SALESMAN, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售代表", FieldName = "SALESREP", Editor = this.DROP_SALESREP, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "内勤", FieldName = "INOFC", Editor = this.DROP_INOFC, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "合同号", FieldName = "CUSTORDNB", Editor = this.TXT_CUSTORDNB, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单类型", FieldName = "ORDERTYPE", Editor = this.COMB_ORDERTYPE, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "总数量", FieldName = "ORDQTY", Editor = this.TXT_ORDQTY, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "总金额", FieldName = "ORDAMOUNT", Editor = this.TXT_ORDAMOUNT, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "折扣", FieldName = "ORDDISCOUNT", Editor = this.TXT_ORDDISCOUNT, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "外贸", FieldName = "FTTAG", Editor = this.CHECK_FTTAG, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购", FieldName = "SUPPTAG", Editor = this.CHECK_SUPPTAG, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "环保", FieldName = "PROTAG", Editor = this.CHECK_PROTAG, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "检针", FieldName = "INVTAG", Editor = this.CHECK_INVTAG, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "收货地址", FieldName = "RECADDRESS", Editor = this.TXT_RECADDRESS, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "服装类型", FieldName = "CLOTHTYPE", Editor = this.COMB_CLOTHTYPE, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "层数", FieldName = "THICK", Editor = this.NTXT_THICK, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "其他费用", FieldName = "OTHAMOUNT", Editor = this.NTXT_OTHAMOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单明细", FieldName = "SALEORDERDTL", Editor = this.gGrid1, IsReadOnly = true });
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
            gGrid1.AddGridColumn("ORDLNNO", "序号", "Int32", 20,true);
            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("COLOR", "色号", "String", 80, true);
            gGrid1.AddGridColumn("TCOLORANAME", "工艺色号A", "String", 80, true);
            gGrid1.AddGridColumn("TCOLORBNAME", "工艺色号B", "String", 80, true);
            gGrid1.AddGridColumn("SIZEA", "规格mm", "Decimal", "#0.0", 60, true);
            gGrid1.AddGridColumn("MOULDANAME", "花模A", "String", 80, true);
            gGrid1.AddGridColumn("MOULDBNAME", "花模B", "String", 80, true);
            gGrid1.AddGridColumn("MOULDCNAME", "花模C", "String", 80, true);
            gGrid1.AddGridColumn("MOULDDNAME", "花模D", "String", 80, true);
            gGrid1.AddGridColumn("STYLENO", "款号", "String", 80, true);
            gGrid1.AddGridColumn("LNQTY", "数量", "Decimal", 80, true);
            gGrid1.AddGridColumn("NEEDING", "注意事项", "String", 120, true);
            gGrid1.AddGridColumn("BASICPRICE", "基本价格", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("MOULDAPRICE", "花模A加价", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("MOULDBPRICE", "花模B加价", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("PLANPRICE", "计划价格", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("LNPRICE", "实际价格", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("LNAMOUNT", "实际金额", "Decimal", "#0.00", 80, true);
            gGrid1.AddGridColumn("LNDISCOUNT", "折扣", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("SAMPLETAG", "是否出样", "Boolean", 50, true);
            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
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
                    case "审核":
                        this.Audit();
                        break;
                    case "退出":
                        this.Close();
                        break;
                    default:
                        break;
                }
            });
        }
        private void Audit()
        {
            try
            {
                ((SM_SALEORDERLogic)this.Logic).Audit(G.AppInfo.GGlobal.User, (SM_SALEORDER)this.editData);
                MessageBox.Show("审核完成！");
                this.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
