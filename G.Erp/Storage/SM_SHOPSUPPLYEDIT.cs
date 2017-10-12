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
using G.Erp.BaseData;

namespace G.Erp.Storage
{
    public partial class SM_SHOPSUPPLYEDIT : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_SHOPSUPPLYEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "领料单";
            this.listTool = new List<string>() { "预览", "打印", "|", "新增", "保存", "|", "增行", "删行", "|", "审核", "库存情况", "|", "退出" };
            this.T = typeof(SM_SHOPSUPPLY);
            this.orderby = "SUPPLYID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_SHOPSUPPLYLogic();
            this.Edapter = initAdapter();
            InitGrid();
            InitDrop();
        }
        public override Controls.Base.IEditorAdapter initAdapter()
        {
            EditorAdapter<SM_SHOPSUPPLY, SM_SHOPSUPPLYDTL> adapter = new EditorAdapter<SM_SHOPSUPPLY, SM_SHOPSUPPLYDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "领料单号", FieldName = "SUPPLYID", Editor = this.TXT_SUPPLYID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "领料部门", FieldName = "WORKSHOP", Editor = this.DROP_WORKSHOP, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单员", FieldName = "OPERATOR", Editor = this.DROP_OPERATOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单日期", FieldName = "OPERDATE", Editor = this.DATE_OPERDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核人", FieldName = "AUDITOR", Editor = this.DROP_AUDITOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核日期", FieldName = "AUDITDATE", Editor = this.DATE_AUDITDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "申请人", FieldName = "APPLYER", Editor = this.DROP_APPLYER, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "申请日期", FieldName = "APPLYDATE", Editor = this.DATE_APPLYDATE, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "领料明细", FieldName = "SHOPSUPPLYDTL", Editor = this.gGrid1 });
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

            DropDown dropColor = new DropDown();
            dropColor.IsText = true;
            Initialize.InitDropDown(dropColor, "COLORNAME", new G.BLL.ERP.BaseData.DM_COLORLogic(), "COLORNAME", "COLORNAME");
            DropDown dropMould = new DropDown();
            dropMould.CustomerDropDownForm = new G.Erp.BaseData.MouldSearch();
            Initialize.InitDropDown(dropMould, "MOULD", new G.BLL.ERP.BaseData.DM_MOULDLogic(), "MDCODE", "MDNAME");

            Initialize.InitDropDown(dropWarehouse, "WAREHOUSE", new G.BLL.ERP.BaseData.DM_WAREHOUSELogic(), "WRHSCODE", "WRHSNAME");

            Initialize.InitDropDown(dropLocation, "LOCATION", new G.BLL.ERP.BaseData.DM_LOCATIONLogic(), "LOCCODE", "LOCNAME");

            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, dropdown, "ITEMCODE");
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("UNIT", "单位", "String", 40, true);
            //gGrid1.AddGridColumn("REQQTY", "需求数量", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("ACTQTY", "领料数量", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("WRHSCODE", "仓库", "String", 80, dropWarehouse, "WRHSNAME");
            gGrid1.AddGridColumn("LOCCODE", "库位", "String", 80, dropLocation, "LOCNAME");
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, dropColor, "ATTRIBUTEA");
            gGrid1.AddGridColumn("ATTRIBUTEB", "花模", "String", 80, dropMould, "ATTRIBUTEBNAME");
            gGrid1.AddGridColumn("ATTRIBUTEC", "尺寸", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("KGQTY", "公斤数", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("RATE", "折率", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("MEMO", "备注", "String", 100);
            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        public override void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.Sys.ND_ORGINAZITIONLogic orglogic = new G.BLL.Sys.ND_ORGINAZITIONLogic();
            Initialize.InitDropDown(DROP_WORKSHOP, "ORG", orglogic, true);
            Initialize.InitDropDown(DROP_OPERATOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_AUDITOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_APPLYER, "USER", userlogic, true);
        }

        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                try
                {
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().ITEMNAME = G.Core.GConvert.ToString(e.DataRow["ItemName"]);
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().UNIT = G.Core.GConvert.ToString(e.DataRow["INVUNIT"]);
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().WRHSCODE = G.Core.GConvert.ToString(e.DataRow["WRHSCODE"]);
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().WRHSNAME = G.Core.GConvert.ToString(e.DataRow["WRHSNAME"]);
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().LOCCODE = G.Core.GConvert.ToString(e.DataRow["LOCCODE"]);
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().LOCNAME = G.Core.GConvert.ToString(e.DataRow["LOCNAME"]);
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().ISATTRIBUTEA = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEA"]);
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().ISATTRIBUTEB = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEB"]);
                    gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>().ISATTRIBUTEC = G.Core.GConvert.ToBool(e.DataRow["ISATTRIBUTEC"]);
                }
                catch { }
            }
            gGrid1.Refresh();
        }
        public override void AddRow()
        {
            SM_SHOPSUPPLYDTL shopsupplydtl = gGrid1.AddRow<SM_SHOPSUPPLYDTL>();
        }
        public override void DeleteRow()
        {
            gGrid1.DeleteRow<SM_SHOPSUPPLYDTL>();
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
                    case "库存情况":
                        KuCun();
                        break;
                    case "预览":
                        ShopSupplyPrint(false);
                        break;
                    case "打印":
                        ShopSupplyPrint(true);
                        break;
                }
                base.ToolButtonClick(name);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        private void KuCun()
        {
            SM_SHOPSUPPLYDTL shopsupplydtl = gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>();
            ItemLocStorage itemlocstorageform = new ItemLocStorage();
            itemlocstorageform.EventRowSelected += ItemLoc_RowSelected;
            itemlocstorageform.SetItemCode(shopsupplydtl);
            itemlocstorageform.ShowDialog();
            this.gGrid1.Refresh();
        }
        void ItemLoc_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                SM_SHOPSUPPLYDTL cur = gGrid1.GetCurSelect<SM_SHOPSUPPLYDTL>();
                cur.ITEMCODE = e.DataRow["ITEMCODE"].ToString();
                cur.ITEMNAME = e.DataRow["ITEMNAME"].ToString();
                cur.WRHSCODE = e.DataRow["WRHSCODE"].ToString();
                cur.WRHSNAME = e.DataRow["WRHSNAME"].ToString();
                cur.LOCCODE = e.DataRow["LOCCODE"].ToString();
                cur.LOCNAME = e.DataRow["LOCNAME"].ToString();
                cur.ATTRIBUTEA = e.DataRow["ATTRIBUTEA"].ToString();
                cur.ATTRIBUTEB = e.DataRow["ATTRIBUTEB"].ToString();
                cur.ATTRIBUTEBNAME = e.DataRow["ATTRIBUTEBNAME"].ToString();
                cur.ATTRIBUTEC = G.Core.GConvert.ToDecimal(e.DataRow["ATTRIBUTEC"]);
            }
        }
        private void Audit()
        {
            SM_SHOPSUPPLY shopsupply = this.editData as SM_SHOPSUPPLY;
            new G.BLL.ERP.Purchase.SM_SHOPSUPPLYLogic().Audit(G.AppInfo.GGlobal.User, shopsupply);
            MessageBox.Show("审核完成！");
            this.Close();
        }

        private void gGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == 4)
            {
                dropLocation.DefaultCondition = CK.K["WRHSCODE"].Eq(dropWarehouse.Value);
            }
        }

        public void ShopSupplyPrint(bool isPrint)
        {
            try
            {
                SM_SHOPSUPPLY shopsupply = this.editData as SM_SHOPSUPPLY;
                string supplyid = G.Core.GConvert.ToString(shopsupply.SUPPLYID);
                string condition = string.Format("supplyid='{0}'", supplyid);
                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Storage\STORAGE.frx", new List<string>() { "Master", "Detail" }, "shopsupplyprint", condition);
                printobj.Print(isPrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}