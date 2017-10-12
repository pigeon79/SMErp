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

namespace G.Erp.Shop
{
    public partial class SM_SHOPINEDIT : G.APP.BaseForm.BaseEditor
    {
        public SM_SHOPINEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "完工入库";
            this.listTool = new List<string>() { "新增", "保存", "|", "审核", "|", "退出" };
            this.T = typeof(SM_SHOPIN);
            this.orderby = "SHOPINID DESC";
            this.Logic = new G.BLL.ERP.Shop.SM_SHOPINLogic();
            this.Edapter = initAdapter();
            InitDrop();
        }
        private EditorAdapter<SM_SHOPIN, object> initAdapter()
        {
            EditorAdapter<SM_SHOPIN, object> adapter = new EditorAdapter<SM_SHOPIN, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "车间订单号", FieldName = "SHOPORDERID", Editor = this.TXT_SHOPORDERID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "完工入库单号", FieldName = "SHOPINID", Editor = this.TXT_SHOPINID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "车间", FieldName = "WORKSHOP", Editor = this.DROP_WORKSHOP });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "完工日期", FieldName = "FINISHDATE", Editor = this.DATE_FINISHDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品", FieldName = "ITEMCODE", Editor = this.DROP_ITEMCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "计量单位", FieldName = "INVUNIT", Editor = this.TXT_INVUNIT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "色号", FieldName = "ATTRIBUTEA", Editor = this.DROP_ATTRIBUTEA });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "花模", FieldName = "ATTRIBUTEB", Editor = this.DROP_ATTRIBUTEB });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "尺寸", FieldName = "ATTRIBUTEC", Editor = this.NUM_ATTRIBUTEC });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "仓库", FieldName = "WRHSCODE", Editor = this.DROP_WRHSCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "库位", FieldName = "LOCCODE", Editor = this.DROP_LOCCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "入库数", FieldName = "INQTY", Editor = this.TXT_INQTY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "公斤数", FieldName = "WEIGHT", Editor = this.TXT_WEIGHT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "折率", FieldName = "RATE", Editor = this.TXT_RATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核员", FieldName = "AUDITOR", Editor = this.DROP_AUDITOR, IsReadOnly = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核日期", FieldName = "AUDITDATE", Editor = this.DATE_AUDITDATE, IsReadOnly = true });
          return adapter;
        }
        private void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new G.BLL.ERP.BaseData.DM_ITEMLogic();
            G.BLL.ERP.BaseData.DM_COLORLogic colorlogic = new G.BLL.ERP.BaseData.DM_COLORLogic();
            G.BLL.ERP.BaseData.DM_MOULDLogic mouldlogic = new G.BLL.ERP.BaseData.DM_MOULDLogic();
            G.BLL.Sys.ND_ORGINAZITIONLogic orglogic = new G.BLL.Sys.ND_ORGINAZITIONLogic();
            G.BLL.ERP.BaseData.DM_WAREHOUSELogic warelogic = new G.BLL.ERP.BaseData.DM_WAREHOUSELogic();
            G.BLL.ERP.BaseData.DM_LOCATIONLogic loclogic = new G.BLL.ERP.BaseData.DM_LOCATIONLogic();
            DROP_ITEMCODE.RowSelect += DROP_ITEMCODE_RowSelect;
            Initialize.InitDropDown(DROP_AUDITOR, "USER", userlogic,true);
            DROP_ITEMCODE.CustomerDropDownForm = new G.Erp.BaseData.ItemSearch();
            Initialize.InitDropDown(DROP_ITEMCODE, "ITEM", itemlogic, true);
            Initialize.InitDropDown(DROP_ATTRIBUTEA, "COLORNAME", colorlogic, true);
            Initialize.InitDropDown(DROP_ATTRIBUTEB, "MOULD", mouldlogic, true);
            Initialize.InitDropDown(DROP_WORKSHOP, "ORG", orglogic, true);
            Initialize.InitDropDown(DROP_WRHSCODE, "WAREHOUSE", warelogic, true);
            Initialize.InitDropDown(DROP_LOCCODE, "LOCATION", loclogic, true);
            
        }

        private void DROP_ITEMCODE_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            DataRow dr = e.DataRow;
            if (dr != null)
            {
                this.TXT_INVUNIT.SetValue(dr["INVUNIT"]);
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
        private void Audit()
        {
            try
            {
                SM_SHOPIN shopin = this.editData as SM_SHOPIN;
                new G.BLL.ERP.Shop.SM_SHOPINLogic().Audit(G.AppInfo.GGlobal.User, shopin);
                MessageBox.Show("审核完成！");
                this.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void DROP_WRHSCODE_ValueChanged(object sender, EventArgs e)
        {
            this.DROP_LOCCODE.ClearValue();
            this.DROP_LOCCODE.DefaultCondition = CK.K["WRHSCODE"].Eq(DROP_WRHSCODE.Value);
        }

    }
}
