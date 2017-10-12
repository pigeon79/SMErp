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
using G.Erp.BaseData;
using G.APP.BaseForm;
using G.Data;

namespace G.Erp.Purchase
{
    public partial class SM_PORDEREDIT : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_PORDEREDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "采购订单";
            this.listTool = new List<string>() { "预览", "打印", "|", "新增", "保存", "|", "增行", "删行", "|", "退出" };
            this.T = typeof(SM_PORDER);
            this.orderby = "POID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_PORDERLogic();
            this.Edapter = initAdapter();
            InitGrid();
            InitDrop();
        }
        public override Controls.Base.IEditorAdapter initAdapter()
        {
            EditorAdapter<SM_PORDER, SM_PORDERDTL> adapter = new EditorAdapter<SM_PORDER, SM_PORDERDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购订单号", FieldName = "POID", Editor = this.TXT_POID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商", FieldName = "SUPCODE", Editor = this.DROP_SUPCODE, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单员", FieldName = "OPERATOR", Editor = this.DROP_OPERATOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单日期", FieldName = "OPERDATE", Editor = this.DATE_OPERDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核人", FieldName = "AUDITOR", Editor = this.DROP_AUDITOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核日期", FieldName = "AUDITDATE", Editor = this.DATE_AUDITDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "合计金额", FieldName = "TOTALAMT", Editor = this.TXT_TOTALAMT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单类型", FieldName = "POTYPE", Editor = this.COMB_POTYPE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "税率", FieldName = "TAXRATE", Editor = this.TXT_TAXRATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购明细", FieldName = "PORDERDTL", Editor = this.gGrid1 });
            return adapter;
        }
        public override void InitGrid()
        {
            DropDown dropdown = new DropDown();
            dropdown.ValueField = "ItemCode";
            dropdown.TextField = "ItemName";
            dropdown.CustomerDropDownForm = new G.Erp.BaseData.ItemSearch();
            dropdown.RowSelected += dropdown_RowSelected;
            dropdown.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            Initialize.InitDropDown(dropdown, "ITEM", new G.BLL.ERP.BaseData.DM_ITEMLogic());

            DropDown dropColor = new DropDown();
            Initialize.InitDropDown(dropColor, "COLORNAME", new G.BLL.ERP.BaseData.DM_COLORLogic(), "COLORNAME", "COLORNAME",true);
            DropDown dropMould = new DropDown();
            dropMould.CustomerDropDownForm = new G.Erp.BaseData.MouldSearch();
            Initialize.InitDropDown(dropMould, "MOULD", new G.BLL.ERP.BaseData.DM_MOULDLogic(), "MDCODE", "MDNAME");

            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, dropdown, "ITEMCODE");
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("INVUNIT", "单位", "String", 40, true);
            gGrid1.AddGridColumn("PREPURQTY", "采购数量", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("PURPRICE", "采购单价", "Decimal", "#0.0000", 80);
            gGrid1.AddGridColumn("PORTOTTAL", "采购金额", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("DEMANDDATE", "需求日期", "DateTime", "yyyy-MM-dd", 80);
            gGrid1.AddGridColumn("REMARK", "备注", "String", 100);
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, dropColor, "ATTRIBUTEA");
            gGrid1.AddGridColumn("ATTRIBUTEB", "花模", "String", 80, dropMould, "ATTRIBUTEBNAME");
            gGrid1.AddGridColumn("ATTRIBUTEC", "尺寸", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("KGRATE", "折率", "Decimal", "#0.00", 60);
            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        public override void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.BaseData.DM_SUPPLIERLogic supplierlogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic();
            Initialize.InitDropDown(DROP_SUPCODE, "SUPPLIER", supplierlogic, true);
            Initialize.InitDropDown(DROP_OPERATOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_AUDITOR, "USER", userlogic, true);
        }

        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                gGrid1.GetCurSelect<SM_PORDERDTL>().ITEMNAME = G.Core.GConvert.ToString(e.DataRow["ItemName"]);
                gGrid1.GetCurSelect<SM_PORDERDTL>().INVUNIT = G.Core.GConvert.ToString(e.DataRow["INVUNIT"]);
                gGrid1.GetCurSelect<SM_PORDERDTL>().ISATTRIBUTEA = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEA"]);
                gGrid1.GetCurSelect<SM_PORDERDTL>().ISATTRIBUTEB = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEB"]);
                gGrid1.GetCurSelect<SM_PORDERDTL>().ISATTRIBUTEC = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEC"]);
            }
        }
        public override void AddRow()
        {
            SM_PORDERDTL porderdtl = gGrid1.AddRow<SM_PORDERDTL>();
        }
        public override void DeleteRow()
        {
            gGrid1.DeleteRow<SM_PORDERDTL>();
        }

        private void gGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == 3 || e.Col == 4)
            {
                SM_PORDERDTL dtl = gGrid1.GetCurSelect<SM_PORDERDTL>();
                dtl.PORTOTTAL = dtl.PURPRICE * dtl.PREPURQTY;
                SM_PORDER porder = this.editData as SM_PORDER;
                decimal total = 0;
                foreach (SM_PORDERDTL d in porder.PORDERDTL)
                {
                    total += d.PORTOTTAL;
                }
                porder.TOTALAMT = total;
                TXT_TOTALAMT.SetValue(total);
                this.gGrid1.Refresh();
            }
            if (e.Col == 5)
            {
                SM_PORDERDTL dtl = gGrid1.GetCurSelect<SM_PORDERDTL>();
                if (dtl.PREPURQTY == 0)
                {
                    dtl.PORTOTTAL = 0;
                }
                else
                {
                    dtl.PURPRICE = dtl.PORTOTTAL / dtl.PREPURQTY;
                }
                SM_PORDER porder = this.editData as SM_PORDER;
                decimal total = 0;
                foreach (SM_PORDERDTL d in porder.PORDERDTL)
                {
                    total += d.PORTOTTAL;
                }
                porder.TOTALAMT = total;
                TXT_TOTALAMT.SetValue(total);
                this.gGrid1.Refresh();
            }
        }
        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "预览":
                    POPrint(false);
                    break;
                case "打印":
                    POPrint(true);
                    break;
                case "审核":
                    Audit();
                    break;
                case "反审":
                    UnAudit();
                    break;
                case "供应商":
                    GYS();
                    break;
                case "结清":
                    Closed();
                    break;
                case "反结清":
                    UnClosed();
                    break;
            }
            base.ToolButtonClick(name);
        }
        private void Audit()
        {
            try
            {
                SM_PORDER porder = this.editData as SM_PORDER;
                new G.BLL.ERP.Purchase.SM_PORDERLogic().Audit(G.AppInfo.GGlobal.User, porder);
                MessageBox.Show("审核完成！");
                this.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void UnAudit()
        {
            try
            {
                SM_PORDER porder = this.editData as SM_PORDER;
                new G.BLL.ERP.Purchase.SM_PORDERLogic().UnAudit(G.AppInfo.GGlobal.User, porder);
                MessageBox.Show("反审成功！");
                this.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void Closed()
        {
            try
            {
                SM_PORDER porder = this.editData as SM_PORDER;
                new G.BLL.ERP.Purchase.SM_PORDERLogic().Closed(G.AppInfo.GGlobal.User, porder);
                MessageBox.Show("结清完成！");
                this.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void UnClosed()
        {
            try
            {
                SM_PORDER porder = this.editData as SM_PORDER;
                new G.BLL.ERP.Purchase.SM_PORDERLogic().UnClosed(G.AppInfo.GGlobal.User, porder);
                MessageBox.Show("反结清成功！");
                this.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public void POPrint(bool isPrint)
        {
            try
            {
                SM_PORDER porder = this.editData as SM_PORDER;
                if (porder.STATUS == "A")
                {
                    string poid = G.Core.GConvert.ToString(porder.POID);
                    string condition = string.Format("poid='{0}'", poid);
                    G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Pur\PORDER.frx", new List<string>() { "Master", "Detail" }, "poprint", condition);
                    printobj.Print(isPrint);
                }
                else {
                    MessageBox.Show("该订单没有审核不能打印！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GYS()
        {
            try
            {
                SM_PORDER porder = this.editData as SM_PORDER;
                if (porder.SUPCODE != "")
                {
                    string supcode = G.Core.GConvert.ToString(porder.SUPCODE);
                    G.BLL.ERP.BaseData.DM_SUPPLIERLogic logic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic();
                    DM_SUPPLIER obj = logic.ExecuteSelect(CK.K["SUPPCODE"].Eq(supcode), OrderBy.Parse("SUPPCODE"), 0, 0)[0];

                    DM_SUPPLIEREDIT supplieredit = new DM_SUPPLIEREDIT();
                    supplieredit.CurEditStatus = EditorStatus.Look;
                    supplieredit.SetData(obj);
                    supplieredit.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
