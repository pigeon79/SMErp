using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Data;
using G.Data.Definition;
using G.Controls.Base;
using G.BLL.Base;
using G.Entity.ERP;

namespace G.Erp.Purchase
{
    public partial class SM_PREPURORDEREDIT : G.APP.BaseForm.BaseEditor
    {
        public SM_PREPURORDEREDIT()
        {
            InitializeComponent();
            InitInfo();
        }

        private void InitInfo()
        {
            this.listCaption = "采购申请单";
            this.listTool = new List<string>() { "新增", "保存", "|", "审核", "|", "退出" };
            this.T = typeof(SM_PREPURORDER);
            this.orderby = "PREPURORDID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_PREPURORDERLogic();
            this.Edapter = initAdapter();
            InitDrop();
        }
        private EditorAdapter<SM_PREPURORDER, object> initAdapter()
        {
            EditorAdapter<SM_PREPURORDER, object> adapter = new EditorAdapter<SM_PREPURORDER, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "申请单号", FieldName = "PREPURORDID", Editor = this.TXT_PREPURORDID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "申请日期", FieldName = "APPLYDATE", Editor = this.DATE_APPLYDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "申请人", FieldName = "APPLYUSER", Editor = this.DROP_APPLYUSER, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUS", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单号", FieldName = "ORDERID", Editor = this.TXT_ORDERID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "行号", FieldName = "ORDLNNO", Editor = this.NUM_ORDLNNO });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "需求部门", FieldName = "DEPCODE", Editor = this.DROP_DEPCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "需求日期", FieldName = "DEMANDDATE", Editor = this.DATE_DEMANDDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品", FieldName = "ITEMCODE", Editor = this.DROP_ITEMCODE, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "计量单位", FieldName = "INVUNIT", Editor = this.TXT_INVUNIT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "色号", FieldName = "ATTRIBUTEA", Editor = this.DROP_ATTRIBUTEA });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "花模", FieldName = "ATTRIBUTEB", Editor = this.DROP_ATTRIBUTEB });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "尺寸", FieldName = "ATTRIBUTEC", Editor = this.NUM_ATTRIBUTEC });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商", FieldName = "SUPCODE", Editor = this.DROP_SUPCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "请购数", FieldName = "PREPURQTY", Editor = this.NUM_PREPURQTY, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购员", FieldName = "PURUSER", Editor = this.DROP_PURUSER, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购类别", FieldName = "PURTYPE", Editor = this.COMB_PURTYPE, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单员", FieldName = "OPERATOR", Editor = this.DROP_OPERATOR, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核员", FieldName = "AUDITOR", Editor = this.DROP_AUDITOR, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核日期", FieldName = "AUDITDATE", Editor = this.DATE_AUDITDATE, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商单价", FieldName = "SUPPRICE", Editor = this.NUM_SUPPRICE });
            return adapter;
        }
        private void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.BaseData.DM_SUPPLIERLogic supplierlogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic();
            G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new G.BLL.ERP.BaseData.DM_ITEMLogic();
            G.BLL.ERP.BaseData.DM_COLORLogic colorlogic = new G.BLL.ERP.BaseData.DM_COLORLogic();
            G.BLL.ERP.BaseData.DM_MOULDLogic mouldlogic = new G.BLL.ERP.BaseData.DM_MOULDLogic();
            G.BLL.Sys.ND_ORGINAZITIONLogic orglogic = new G.BLL.Sys.ND_ORGINAZITIONLogic();
            Initialize.InitDropDown(DROP_APPLYUSER, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_PURUSER, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_SUPCODE, "SUPPLIER", supplierlogic, true);
            DROP_ITEMCODE.CustomerDropDownForm = new G.Erp.BaseData.ItemSearch();
            Initialize.InitDropDown(DROP_ITEMCODE, "ITEM", itemlogic, true);
            Initialize.InitDropDown(DROP_ATTRIBUTEA, "COLORNAME", colorlogic, true);
            DROP_ATTRIBUTEB.CustomerDropDownForm = new G.Erp.BaseData.MouldSearch();
            Initialize.InitDropDown(DROP_ATTRIBUTEB, "MOULD", mouldlogic, true);
            Initialize.InitDropDown(DROP_DEPCODE, "ORG", orglogic, true);
        }
        private void DROP_ITEMCODE_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            DataRow dr = e.DataRow;
            if (dr != null)
            {
                this.TXT_INVUNIT.SetValue(dr["INVUNIT"]);
                this.DROP_SUPCODE.Value = G.Core.GConvert.ToString(dr["SUPCODE"]);
                this.DROP_SUPCODE.Text = G.Core.GConvert.ToString(dr["SUPPNAME"]);
                if (G.Core.GConvert.ToString(dr["SUPCODE"]) == "" || G.Core.GConvert.ToString(dr["SUPCODE"]) == "0")
                {
                    this.DROP_SUPCODE.ReadOnly = false;
                    this.NUM_SUPPRICE.ReadOnly = false;
                }
                this.NUM_SUPPRICE.SetValue(dr["SUPPRICE"]);
            }
        }
        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "审核":
                    Audit();
                    break;
            }
            base.ToolButtonClick(name);
        }
        public override bool Save()
        {
            bool ispass = false;

            ispass = base.Save();
            if (ispass)
            {
                this.DialogResult = DialogResult.OK;
            }
            return ispass;

        }
        private void Audit()
        {
            try
            {
                SM_PREPURORDER prepurorder = this.editData as SM_PREPURORDER;
                new G.BLL.ERP.Purchase.SM_PREPURORDERLogic().Audit(G.AppInfo.GGlobal.User, prepurorder);
                MessageBox.Show("审核完成！");
                this.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
