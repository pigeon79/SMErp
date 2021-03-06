﻿using G.Controls.Base;
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

namespace G.Erp.Assist
{
    public partial class SM_ASSISTMSUPPLYEDIT : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_ASSISTMSUPPLYEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "外协领料单";
            this.listTool = new List<string>() {"新增", "保存", "|", "增行", "删行", "|", "审核", "|", "退出" };
            this.T = typeof(SM_ASSISTMSUPPLY);
            this.orderby = "ASSISTMSCODE DESC";
            this.Logic = new G.BLL.ERP.Assist.SM_ASSISTMSUPPLYLogic();
            this.Edapter = initAdapter();
            InitGrid();
            InitDrop();
        }
        public override Controls.Base.IEditorAdapter initAdapter()
        {
            EditorAdapter<SM_ASSISTMSUPPLY, SM_ASSISTMSUPPLYDTL> adapter = new EditorAdapter<SM_ASSISTMSUPPLY, SM_ASSISTMSUPPLYDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "外协领料单号", FieldName = "ASSISTMSCODE", Editor = this.TXT_ASSISTMSCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "领料日期", FieldName = "ASSISTMSDATE", Editor = this.DATE_ASSISTMSDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "订单号", FieldName = "ORDERID", Editor = this.TXT_ORDERID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购员", FieldName = "PURUSER", Editor = this.DROP_PURUSER, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "外协加工单位", FieldName = "ASUPCODE", Editor = this.DROP_ASUPCODE, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "外协交期", FieldName = "ADELIVERYDATE", Editor = this.DATE_ADELIVERYDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "客户单位", FieldName = "ACUSTID", Editor = this.DROP_ACUSTID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "MEMO", Editor = this.TXT_MEMO });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售员", FieldName = "SALESMANNAME", Editor = this.TXT_SALESMANNAME });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售代表", FieldName = "SALESREPNAME", Editor = this.TXT_SALESREPNAME });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单员", FieldName = "OPERATOR", Editor = this.DROP_OPERATOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单日期", FieldName = "OPERDATE", Editor = this.DATE_OPERDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核人", FieldName = "AFFIRMER", Editor = this.DROP_AUDITOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核日期", FieldName = "AFFIRMDATE", Editor = this.DATE_AUDITDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "外协领料单明细", FieldName = "ASSISTMSUPPLYDTL", Editor = this.gGrid1 });
            return adapter;
        }
        DropDown dropWarehouse = new DropDown();
        DropDown dropLocation = new DropDown();
        DropDown dropAttributea = new DropDown();
        DropDown dropAttributeb = new DropDown();
        public override void InitGrid()
        {
            DropDown dropdown = new DropDown();
            dropdown.ValueField = "ItemCode";
            dropdown.TextField = "ItemName";
            dropdown.CustomerDropDownForm = new G.Erp.BaseData.ItemSearch();
            dropdown.RowSelected += dropdown_RowSelected;
            dropdown.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            Initialize.InitDropDown(dropdown, "ITEM", new G.BLL.ERP.BaseData.DM_ITEMLogic());

            Initialize.InitDropDown(dropWarehouse, "WAREHOUSE", new G.BLL.ERP.BaseData.DM_WAREHOUSELogic(), "WRHSCODE", "WRHSNAME");

            Initialize.InitDropDown(dropLocation, "LOCATION", new G.BLL.ERP.BaseData.DM_LOCATIONLogic(), "LOCCODE", "LOCNAME");

            Initialize.InitDropDown(dropAttributea, "COLORNAME", new G.BLL.ERP.BaseData.DM_COLORLogic(), "COLORNAME", "COLORNAME");
            dropAttributeb.CustomerDropDownForm = new G.Erp.BaseData.MouldSearch();
            Initialize.InitDropDown(dropAttributeb, "MOULD", new G.BLL.ERP.BaseData.DM_MOULDLogic(), "MDCODE", "MDNAME");

            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, dropdown, "ITEMCODE");
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            //gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, dropColor, "ATTRIBUTEANAME");
            //gGrid1.AddGridColumn("ATTRIBUTEB", "花模", "String", 80, dropMould, "ATTRIBUTEBNAME");
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, dropAttributea, "ATTRIBUTEA");
            gGrid1.AddGridColumn("ATTRIBUTEB", "花模", "String", 80, dropAttributeb, "ATTRIBUTEBNAME");
            gGrid1.AddGridColumn("ATTRIBUTEC", "尺寸", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("UNIT", "单位", "String", 40, true);
            gGrid1.AddGridColumn("PLANQTY", "计划数", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("FACTQTY", "发货数", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("KGQTY", "公斤数", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("RATE", "折率", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("WRHSCODE", "仓库", "String", 80, dropWarehouse, "WRHSNAME");
            gGrid1.AddGridColumn("LOCCODE", "库位", "String", 80, dropLocation, "LOCNAME");
            gGrid1.AddGridColumn("NEEDING", "注意事项", "String", 100);
            gGrid1.AddGridColumn("REMARK", "备注", "String", 100);
            gGrid1.FrozenCell = 6;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        public override void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.BaseData.DM_SUPPLIERLogic supplierlogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic();
            G.BLL.ERP.BaseData.DM_CUSTOMERLogic custlogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic();
            Initialize.InitDropDown(DROP_OPERATOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_AUDITOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_PURUSER, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_ASUPCODE, "SUPPLIER", supplierlogic, true);
            Initialize.InitDropDown(DROP_ACUSTID, "CUSTOMER", custlogic, true);
        }

        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().ITEMNAME = G.Core.GConvert.ToString(e.DataRow["ItemName"]);
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().UNIT = G.Core.GConvert.ToString(e.DataRow["INVUNIT"]);
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().WRHSCODE = G.Core.GConvert.ToString(e.DataRow["WRHSCODE"]);
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().WRHSNAME = G.Core.GConvert.ToString(e.DataRow["WRHSNAME"]);
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().LOCCODE = G.Core.GConvert.ToString(e.DataRow["LOCCODE"]);
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().LOCNAME = G.Core.GConvert.ToString(e.DataRow["LOCNAME"]);
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().ISATTRIBUTEA = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEA"]);
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().ISATTRIBUTEB = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEB"]);
                gGrid1.GetCurSelect<SM_ASSISTMSUPPLYDTL>().ISATTRIBUTEC = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEC"]);
            }
            gGrid1.Refresh();
        }
        public override void AddRow()
        {            
            SM_ASSISTMSUPPLYDTL assistmsupplydtl = gGrid1.AddRow<SM_ASSISTMSUPPLYDTL>();
        }
        public override void DeleteRow()
        {
            gGrid1.DeleteRow<SM_ASSISTMSUPPLYDTL>();
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
                }
                base.ToolButtonClick(name);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void Audit()
        {
            SM_ASSISTMSUPPLY assistmsuppply = this.editData as SM_ASSISTMSUPPLY;
            if (assistmsuppply.STATUS == "N")
            {
                new G.BLL.ERP.Assist.SM_ASSISTMSUPPLYLogic().Audit(G.AppInfo.GGlobal.User, assistmsuppply);
                MessageBox.Show("审核完成！");
                this.Close();
            }
            else { MessageBox.Show("订单已审核！"); }
        }

        private void DROP_ACUSTCODE_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            DataRow dr = e.DataRow;
            if (dr != null)
            {
                this.TXT_SALESMANNAME.SetValue(dr["SALESMANNAME"]);
                this.TXT_SALESREPNAME.SetValue(dr["SALESREPNAME"]);
            }
        }

        private void gGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == 10)
            {
                dropLocation.DefaultCondition = CK.K["WRHSCODE"].Eq(dropWarehouse.Value);
                dropLocation.Clear();
            }
        }
    }
}