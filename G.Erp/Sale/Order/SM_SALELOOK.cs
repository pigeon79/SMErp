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
using G.Controls.Printer;

namespace G.Erp.Sale.Order
{
    public partial class SM_SALELOOK : G.APP.BaseForm.BaseEditor
    {
        public SM_SALELOOK()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单查询";
            this.listTool = new List<string>() { "预览", "打印", "|", "退出" };
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
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "环保", FieldName = "PROTAG", Editor = this.CHECK_PROTAG, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购", FieldName = "SUPPTAG", Editor = this.CHECK_SUPPTAG, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "检针", FieldName = "INVTAG", Editor = this.CHECK_INVTAG, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "收货地址", FieldName = "RECADDRESS", Editor = this.TXT_RECADDRESS, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "服装类型", FieldName = "CLOTHTYPE", Editor = this.COMB_CLOTHTYPE, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "层数", FieldName = "THICK", Editor = this.NTXT_THICK, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "其他费用", FieldName = "OTHAMOUNT", Editor = this.NTXT_OTHAMOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱", FieldName = "POCKETTAG", Editor = this.CHECK_POCKETTAG, IsReadOnly = true });
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
            //gGrid1.AddGridColumn("BASICPRICE", "基本价格", "Decimal", "#0.00", 60, true);
            //gGrid1.AddGridColumn("MOULDAPRICE", "花模A加价", "Decimal", "#0.00", 60, true);
            //gGrid1.AddGridColumn("MOULDBPRICE", "花模B加价", "Decimal", "#0.00", 60, true);
            //gGrid1.AddGridColumn("PLANPRICE", "计划价格", "Decimal", "#0.00", 60, true);
            //gGrid1.AddGridColumn("LNPRICE", "实际价格", "Decimal", "#0.00", 60, true);
            //gGrid1.AddGridColumn("LNAMOUNT", "实际金额", "Decimal", "#0.00", 80, true);
            //gGrid1.AddGridColumn("LNDISCOUNT", "折扣", "Decimal", "#0.00", 60, true);
            //gGrid1.AddGridColumn("SAMPLETAG", "是否出样", "Boolean", 50, true);
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
                    case "退出":
                        this.Close();
                        break;
                    case "预览":
                        SOPrint(false);
                        break;
                    case "打印":
                        SOPrint(true);
                        break;
                    default:
                        break;
                }
            });
        }
        bool loadtag = true;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 1 && loadtag)
            {
                this.InitGrid2();
                this.LoadGrid2Data();
                loadtag = false;
            }
        }

        #region 生产信息
        private void InitGrid2()
        {
            gGrid2.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            gGrid2.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid2.AddGridColumn("UNIT", "单位", "String", 40, true);
            gGrid2.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, true);
            gGrid2.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            gGrid2.AddGridColumn("ATTRIBUTEC", "尺寸", "Decimal", "#0.00", 60, true);
            gGrid2.AddGridColumn("STYLENO", "款号", "String", 80, true);
            gGrid2.AddGridColumn("BOMQTY", "订单数", "Decimal", "#0.0", 80, true);
            gGrid2.AddGridColumn("POCKETQTY", "装箱数", "Decimal", "#0.0", 60, true);
            gGrid2.AddGridColumn("CKQTY", "出库数", "Decimal", "#0.00", 80, true);
            gGrid2.AddGridColumn("PRODATE", "交期", "DateTime", 80, true);

            gGrid2.FrozenCell = 3;
            gGrid2.AutoGenerateColumns = false;
            gGrid2.InitGrid();
        }
        private void LoadGrid2Data()
        {
            string orderid=G.Core.GConvert.ToString(this.TXT_ORDERID.Text);
            string sql = string.Format("SELECT POCKLNNO,ITEMCODE,ITEMNAME,InvUnit,ATTRIBUTEA,ATTRIBUTEBNAME,ATTRIBUTEC,ATTRIBUTED,PRODATE,BOMQTY,SUM(POCKETQTY)POCKETQTY,SUM(CKQTY) AS CKQTY FROM (SELECT B.POCKLNNO,A.*,CASE WHEN C.STATUS='O' THEN POCKETQTY ELSE 0 END CKQTY,B.POCKETQTY FROM SM_BOMTEMP_V1 A LEFT JOIN SM_POCKETDTL B ON A.ID=B.BOMTEMPID LEFT JOIN SM_POCKET C ON B.POCKETID=C.ID WHERE A.ORDERID='{0}' )Q GROUP BY POCKLNNO,ITEMCODE,ITEMNAME,InvUnit,ATTRIBUTEA,ATTRIBUTEBNAME,ATTRIBUTEC,ATTRIBUTED,PRODATE,BOMQTY", orderid);
            DataSet ds = DbEntry.Provider.ExecuteDataset(sql);
            gGrid2.DataBind(ds.Tables[0]);
        }
        #endregion

        public void SOPrint(bool isPrint)
        {
            try
            {
                SM_SALEORDER saleorder = this.editData as SM_SALEORDER;
                string orderid = G.Core.GConvert.ToString(saleorder.ORDERID);
                string je = G.Core.GConvert.ToRMB(G.Core.GConvert.ToDecimal(saleorder.ORDAMOUNT));
                string condition = string.Format("ORDERID='{0}'", orderid).Replace("'", "''");
                string sqlstr = string.Format("EXEC Pro_PrintData '{0}','{1}'", "salecontract", condition);
                DataSet ds = DbEntry.Provider.ExecuteDataset(sqlstr);
                ds.Tables[0].Columns.Add("JERMB");
                ds.Tables[0].Rows[0]["JERMB"] = je;
                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Sale\SALECONTRACT.frx", new List<string>() { "Master", "Detail" }, ds);
                printobj.Print(isPrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}