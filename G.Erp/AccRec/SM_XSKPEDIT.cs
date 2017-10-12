using G.Controls.Base;
using G.Controls.Input;
using G.Entity.ERP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Data;
using G.Erp.Sale;
using G.BLL.ERP.AccRec;

namespace G.Erp.AccRec
{
    public partial class SM_XSKPEDIT : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_XSKPEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售开票维护";
            this.listTool = new List<string>() { "新增", "保存", "-", "增行", "删行", "-", "关联", "-", "审核", "|", "作废", "红冲", "|", "退出" };
            this.T = typeof(SM_XSKP);
            this.orderby = "ID DESC";
            this.Logic = new SM_XSKPLogic();
            this.Edapter = initAdapter();
            InitGrid();
            InitDrop();
        }
        public override Controls.Base.IEditorAdapter initAdapter()
        {
            EditorAdapter<SM_XSKP, SM_XSKPDTL> adapter = new EditorAdapter<SM_XSKP, SM_XSKPDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开票单号", FieldName = "NO", Editor = this.TXT_NO });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "发票号", FieldName = "FPNO", Editor = this.TXT_FPNO });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "收款期限", FieldName = "SKDAYS", Editor = this.TXT_SKDAYS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "下单客户", FieldName = "CUSTID", Editor = this.DROP_CUSTID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开票客户", FieldName = "INVCUSTID", Editor = this.DROP_INVCUSTID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售员", FieldName = "SALEREP", Editor = this.DROP_SALEREP });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "合计数量", FieldName = "SUMQTY", Editor = this.TXT_SUMQTY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "合计金额", FieldName = "SUMVOT", Editor = this.TXT_SUMVOT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "价税合计", FieldName = "SUMVAT", Editor = this.TXT_SUMVAT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单员", FieldName = "OPERATOR", Editor = this.DROP_OPERATOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单日期", FieldName = "OPERDATE", Editor = this.DATE_OPERDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核人", FieldName = "AUDITOR", Editor = this.DROP_AUDITOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核日期", FieldName = "AUDITDATE", Editor = this.DATE_AUDITDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开票明细", FieldName = "XSKPDTL", Editor = this.gGrid1 });
            return adapter;
        }
        DropDown dropWarehouse = new DropDown();
        DropDown dropLocation = new DropDown();
        public override void InitGrid()
        {
            DropDown dropdown = new DropDown();
            dropdown.ValueField = "ItemCode";
            dropdown.TextField = "ItemName";
            dropdown.CustomerDropDownForm = new G.Erp.BaseData.ItemSearch();
            dropdown.RowSelected += dropdown_RowSelected;
            dropdown.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            Initialize.InitDropDown(dropdown, "ITEM", new G.BLL.ERP.BaseData.DM_ITEMLogic());

            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, dropdown, "ITEMCODE");
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("JLDW", "单位", "String", 40, true);
            gGrid1.AddGridColumn("QTY", "数量", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("OTPRICE", "单价", "Decimal", "#0.00", 80, true);
            gGrid1.AddGridColumn("OTMONEY", "货品金额", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("TAXRATE", "税率", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("TAXMONEY", "税金", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("ATMONEY", "含税金额", "Decimal", "#0.0000", 80, true);
            gGrid1.AddGridColumn("REMARK", "备注", "String", 150);
            gGrid1.AddGridColumn("ORDERID", "订单号", "String", 80, true);
            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        public override void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.BaseData.DM_CUSTOMERLogic custlogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic();
            Initialize.InitDropDown(DROP_OPERATOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_AUDITOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_SALEREP, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_CUSTID, "CUSTOMER", custlogic, true);
            Initialize.InitDropDown(DROP_INVCUSTID, "CUSTOMER", custlogic, true);
        }

        public override void AddRow()
        {
            SM_XSKPDTL shipvoucherdtl = gGrid1.AddRow<SM_XSKPDTL>();
        }
        public override void DeleteRow()
        {
            gGrid1.DeleteRow<SM_XSKPDTL>();
        }

        private void gGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == 8)
            {
                SM_XSKPDTL dtl = gGrid1.GetCurSelect<SM_XSKPDTL>();
                if (dtl.QTY == 0)
                {
                    MessageBox.Show("数量不能为0！");
                    return;
                }
                dtl.OTMONEY = dtl.ATMONEY / (1 + dtl.TAXRATE / 100);
                dtl.OTPRICE = (dtl.ATMONEY / (1 + dtl.TAXRATE / 100)) / dtl.QTY;
                dtl.TAXMONEY = dtl.ATMONEY - dtl.OTMONEY;//dtl.TAXRATE * dtl.ATMONEY / (100 + dtl.TAXRATE);

                ExecuteSum();

                this.gGrid1.Refresh();
            }
        }
        private void ExecuteSum()
        {
            SM_XSKP xskp = this.editData as SM_XSKP;
            decimal sumqty = 0;
            decimal sumvat = 0;
            decimal sumvot = 0;
            decimal sumtax = 0;
            foreach (SM_XSKPDTL d in xskp.XSKPDTL)
            {
                sumqty += G.Core.GConvert.ToDecimal(d.QTY);
                sumvat += G.Core.GConvert.ToDecimal(d.ATMONEY);
                sumvot += G.Core.GConvert.ToDecimal(d.OTMONEY);
                sumtax += G.Core.GConvert.ToDecimal(d.TAXMONEY);
            }
            xskp.SUMQTY = Math.Round(sumqty, 2);
            xskp.SUMVAT = Math.Round(sumvat, 2);
            xskp.SUMVOT = Math.Round(sumvot, 2);
            xskp.SUMTAX = Math.Round(sumtax, 2);
            this.TXT_SUMQTY.SetValue(xskp.SUMQTY);
            this.TXT_SUMVAT.SetValue(xskp.SUMVAT);
            this.TXT_SUMVOT.SetValue(xskp.SUMVOT);
        }
        public override void ToolButtonClick(string name)
        {
            try
            {
                switch (name)
                {
                    case "审核":
                        Audit();
                        break;
                    case "关联":
                        Related();
                        break;
                    case "预览":
                        SHIPVPrint(false);
                        break;
                    case "打印":
                        SHIPVPrint(true);
                        break;
                    case "作废":
                        InValid();
                        break;
                    case "红冲":
                        Red();
                        break;
                }
                base.ToolButtonClick(name);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void Audit()
        {
            try
            {
                SM_XSKP xskp = this.editData as SM_XSKP;
                new G.BLL.ERP.AccRec.SM_XSKPLogic().Audit(G.AppInfo.GGlobal.User, xskp);
                MessageBox.Show("审核完成！");
                this.Close();
                //this.LoadData();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void InValid() { }
        private void Red()
        {
            SM_XSKP xskp = this.editData as SM_XSKP;
            ((SM_XSKPLogic)this.Logic).Red(G.AppInfo.GGlobal.User, xskp);
        }
        public void SHIPVPrint(bool isPrint)
        {
            try
            {
                //string shipvid = G.Core.GConvert.ToString(this.TXT_SALEREP.Text);
                //string condition = string.Format("SHIPVID='{0}'", shipvid);
                //G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Pur\SHIPVOUCHERLIST.frx", new List<string>() { "QryMaster", "QryDetail" }, "shipvprint", condition);
                //printobj.Print(isPrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                gGrid1.GetCurSelect<SM_XSKPDTL>().ITEMNAME = G.Core.GConvert.ToString(e.DataRow["ItemName"]);
                gGrid1.GetCurSelect<SM_XSKPDTL>().JLDW = G.Core.GConvert.ToString(e.DataRow["INVUNIT"]);
            }
            gGrid1.Refresh();
        }
        private void DROP_CUSTID_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                this.DROP_SALEREP.SetValue(G.Core.GConvert.ToString(e.DataRow["SALESMAN"]));
            }
        }

        SaleOrderSearch oFrm = new SaleOrderSearch();
        private void Related()
        {
            DialogResult yn = oFrm.ShowDialog();
            if (yn == DialogResult.OK)
            {
                this.DROP_CUSTID.SetValue(oFrm.ds.Tables[0].Rows[0]["CUSTID"]);
                this.DROP_INVCUSTID.SetValue(oFrm.ds.Tables[0].Rows[0]["INVCUSTID"]);
                this.DROP_SALEREP.SetValue(oFrm.ds.Tables[0].Rows[0]["SALESMAN"]);
                SM_XSKP xskp = this.editData as SM_XSKP;
                xskp.XSKPDTL.Clear();
                foreach (DataRow dr in oFrm.ds.Tables[0].Select("ISSELECT=1"))
                {
                    SM_XSKPDTL xskpdtl = new SM_XSKPDTL();
                    xskpdtl.ORDERID = G.Core.GConvert.ToString(dr["ORDERID"]);
                    xskpdtl.ITEMCODE = G.Core.GConvert.ToString(dr["ITEMCODE"]);
                    xskpdtl.ITEMNAME = G.Core.GConvert.ToString(dr["ITEMNAME"]);
                    xskpdtl.JLDW = G.Core.GConvert.ToString(dr["JLDW"]);
                    xskpdtl.QTY = G.Core.GConvert.ToDecimal(dr["QTY"]);
                    xskpdtl.ATPRICE = G.Core.GConvert.ToDecimal(dr["ATPRICE"]);
                    xskpdtl.ATMONEY = G.Core.GConvert.ToDecimal(dr["ATMONEY"]);
                    xskpdtl.OTPRICE = G.Core.GConvert.ToDecimal(dr["OTPRICE"]);
                    xskpdtl.OTMONEY = G.Core.GConvert.ToDecimal(dr["OTMONEY"]);
                    xskpdtl.TAXMONEY = G.Core.GConvert.ToDecimal(dr["TAXMONEY"]);
                    xskpdtl.SALEORDERDTLID = G.Core.GConvert.ToInt(dr["ID"]);
                    xskpdtl.TAXRATE = 17;
                    xskp.XSKPDTL.Add(xskpdtl);
                }
                this.gGrid1.SetValue<SM_XSKPDTL>(xskp.XSKPDTL);
            }
            ExecuteSum();
            this.Refresh();
        }


    }
}