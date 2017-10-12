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

namespace G.Erp.Purchase
{
    public partial class SM_SHIPVOUCHEREDIT : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_SHIPVOUCHEREDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "采购收货";
            this.listTool = new List<string>() { "预览", "打印", "|", "新增", "保存", "|", "增行", "删行", "|", "审核", "|", "退出" };
            this.T = typeof(SM_SHIPVOUCHER);
            this.orderby = "SHIPVID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_SHIPVOUCHERLogic();
            this.Edapter = initAdapter();
            InitGrid();
            InitDrop();
        }
        public override Controls.Base.IEditorAdapter initAdapter()
        {
            EditorAdapter<SM_SHIPVOUCHER, SM_SHIPVOUCHERDTL> adapter = new EditorAdapter<SM_SHIPVOUCHER, SM_SHIPVOUCHERDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购收货单号", FieldName = "SHIPVID", Editor = this.TXT_SHIPVID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "收货日期", FieldName = "SHIPDATE", Editor = this.DATE_SHIPDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商", FieldName = "SUPCODE", Editor = this.DROP_SUPCODE, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购订单号", FieldName = "POID", Editor = this.DROP_POID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单员", FieldName = "OPERATOR", Editor = this.DROP_OPERATOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单日期", FieldName = "OPERDATE", Editor = this.DATE_OPERDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "收货员", FieldName = "SHIPUSER", Editor = this.DROP_SHIPUSER, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核人", FieldName = "AUDITOR", Editor = this.DROP_AUDITOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "审核日期", FieldName = "AUDITDATE", Editor = this.DATE_AUDITDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否补差价单", FieldName = "ISPRICEDIFF", Editor = this.CHECK_ISPRICEDIFF });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "送货单号", FieldName = "DELIVERCODE", Editor = this.TXT_DELIVERCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "税率", FieldName = "TAXRATE", Editor = this.TXT_TAXRATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购收货明细", FieldName = "SHIPVOUCHERDTL", Editor = this.gGrid1 });
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

            //DropDown dropColor = new DropDown();
            //Initialize.InitDropDown(dropColor, "COLOR", new G.BLL.ERP.BaseData.DM_COLORLogic(), "CCODE", "CNAME");
            //DropDown dropMould = new DropDown();
            //Initialize.InitDropDown(dropMould, "MOULD", new G.BLL.ERP.BaseData.DM_MOULDLogic(), "MDCODE", "MDNAME");

            Initialize.InitDropDown(dropWarehouse, "WAREHOUSE", new G.BLL.ERP.BaseData.DM_WAREHOUSELogic(), "WRHSCODE", "WRHSNAME");

            Initialize.InitDropDown(dropLocation, "LOCATION", new G.BLL.ERP.BaseData.DM_LOCATIONLogic(), "LOCCODE", "LOCNAME");

            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, dropdown, "ITEMCODE");
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            //gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, dropColor, "ATTRIBUTEANAME");
            //gGrid1.AddGridColumn("ATTRIBUTEB", "花模", "String", 80, dropMould, "ATTRIBUTEBNAME");
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, true);
            gGrid1.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            gGrid1.AddGridColumn("ATTRIBUTEC", "尺寸", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("INVUNIT", "单位", "String", 40, true);
            gGrid1.AddGridColumn("PREPURQTY", "申请数量", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("UNFINISHQTY", "待收货数", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("CHECKEDQTY", "合格数量", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("PRICE", "采购单价", "Decimal", "#0.0000", 60);
            gGrid1.AddGridColumn("SHIPAMOUNT", "金额", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("CHECKFLAG", "是否检验", "Boolean", 60);
            gGrid1.AddGridColumn("WRHSCODE", "仓库", "String", 80, dropWarehouse, "WRHSNAME");
            gGrid1.AddGridColumn("LOCCODE", "库位", "String", 80, dropLocation, "LOCNAME");
            gGrid1.AddGridColumn("SHWEIGHT", "收货重量", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("REMARKS", "备注", "String", 100);
            gGrid1.FrozenCell = 6;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        public override void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.BaseData.DM_SUPPLIERLogic supplierlogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic();
            G.BLL.ERP.Purchase.SM_PORDERLogic porderlogic = new G.BLL.ERP.Purchase.SM_PORDERLogic();
            Initialize.InitDropDown(DROP_SUPCODE, "SUPPLIER", supplierlogic, true);
            Initialize.InitDropDown(DROP_OPERATOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_AUDITOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_SHIPUSER, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_POID, "PORDER", porderlogic, true);
        }

        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>().ITEMNAME = G.Core.GConvert.ToString(e.DataRow["ItemName"]);
                gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>().INVUNIT = G.Core.GConvert.ToString(e.DataRow["INVUNIT"]);
                gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>().WRHSCODE = G.Core.GConvert.ToString(e.DataRow["WRHSCODE"]);
                gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>().WRHSNAME = G.Core.GConvert.ToString(e.DataRow["WRHSNAME"]);
                gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>().LOCCODE = G.Core.GConvert.ToString(e.DataRow["LOCCODE"]);
                gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>().LOCNAME = G.Core.GConvert.ToString(e.DataRow["LOCNAME"]);
            }
            gGrid1.Refresh();
        }
        public override void AddRow()
        {
            SM_SHIPVOUCHERDTL shipvoucherdtl = gGrid1.AddRow<SM_SHIPVOUCHERDTL>();
        }
        public override void DeleteRow()
        {
            gGrid1.DeleteRow<SM_SHIPVOUCHERDTL>();
        }

        private void gGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (G.Core.GConvert.ToBool(this.CHECK_ISPRICEDIFF.GetValue()) == false)
            {
                if (e.Col == 7 || e.Col == 8)
                {
                    SM_SHIPVOUCHERDTL dtl = gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>();
                    dtl.SHIPAMOUNT = dtl.PRICE * dtl.CHECKEDQTY;
                    this.gGrid1.Refresh();
                }
                if (e.Col == 9)
                {
                    SM_SHIPVOUCHERDTL dtl = gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>();
                    dtl.SHIPAMOUNT = dtl.PRICE * dtl.CHECKEDQTY;
                    this.gGrid1.Refresh();
                    MessageBox.Show("不是补差价单，不能更改金额！");
                }
            }
            else
            {
                if (e.Col == 6 || e.Col == 7 || e.Col == 8)
                {
                    SM_SHIPVOUCHERDTL dtl = gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>();
                    dtl.PREPURQTY = 0;
                    dtl.CHECKEDQTY = 0;
                    dtl.PRICE = 0;
                    this.gGrid1.Refresh();
                    MessageBox.Show("补差价单，数量、单价应为零，不能更改！");
                }
                if (e.Col == 9)
                {
                    SM_SHIPVOUCHERDTL dtl = gGrid1.GetCurSelect<SM_SHIPVOUCHERDTL>();
                    dtl.PREPURQTY = 0;
                    dtl.CHECKEDQTY = 0;
                    dtl.PRICE = 0;
                    this.gGrid1.Refresh();
                }
            }
            if (e.Col == 11)
            {
                dropLocation.DefaultCondition = CK.K["WRHSCODE"].Eq(dropWarehouse.Value);
            }
        }

        private void DROP_POID_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                try
                {
                    this.DROP_SUPCODE.Text = G.Core.GConvert.ToString(e.DataRow["SUPPNAME"]);
                    this.DROP_SUPCODE.Value = G.Core.GConvert.ToString(e.DataRow["SUPCODE"]);
                    string poid = G.Core.GConvert.ToString(e.DataRow["POID"]);
                    G.BLL.ERP.Purchase.SM_PORDERLogic porderlogic = new G.BLL.ERP.Purchase.SM_PORDERLogic();
                    SM_PORDER pobj = porderlogic.ExecuteSelect(CK.K["POID"].Eq(poid), OrderBy.Parse("POID"), 0, 0)[0];
                    if (pobj != null)
                    {
                        //SM_SHIPVOUCHER shipv = this.editData as SM_SHIPVOUCHER;
                        //shipv.SHIPVOUCHERDTL.Clear();
                        BindingList<SM_SHIPVOUCHERDTL> shipvd = this.gGrid1.DataSource as BindingList<SM_SHIPVOUCHERDTL>;
                        shipvd.Clear();
                        foreach (SM_PORDERDTL r in pobj.PORDERDTL)
                        {
                            if (r.PREPURQTY > r.SHIFTQTY)
                            {
                                G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new G.BLL.ERP.BaseData.DM_ITEMLogic();
                                DM_ITEM itemobj = itemlogic.ExecuteSelect(CK.K["ITEMCODE"].Eq(r.ITEMCODE), OrderBy.Parse("ITEMCODE"), 0, 0)[0];
                                SM_SHIPVOUCHERDTL shipd = new SM_SHIPVOUCHERDTL();
                                shipd.POLNNO = r.POLNNO;
                                shipd.ITEMCODE = r.ITEMCODE;
                                shipd.ITEMNAME = r.ITEMNAME;
                                shipd.INVUNIT = r.INVUNIT;
                                shipd.PREPURQTY = r.PREPURQTY;
                                shipd.PRICE = r.PURPRICE;
                                shipd.ATTRIBUTEA = r.ATTRIBUTEA;
                                shipd.ATTRIBUTEB = r.ATTRIBUTEB;
                                shipd.ATTRIBUTEBNAME = r.ATTRIBUTEBNAME;
                                shipd.ATTRIBUTEC = r.ATTRIBUTEC;
                                shipd.WRHSCODE = itemobj.WrhsCode;
                                shipd.WRHSNAME = itemobj.WRHSNAME;
                                shipd.LOCCODE = itemobj.LocCode;
                                shipd.LOCNAME = itemobj.LOCNAME;
                                shipd.UNFINISHQTY = r.PREPURQTY - r.SHIFTQTY;
                                shipd.ISATTRIBUTEA = (bool)itemobj.IsAttributeA;
                                shipd.ISATTRIBUTEB = (bool)itemobj.IsAttributeB;
                                shipd.ISATTRIBUTEC = (bool)itemobj.IsAttributeC;
                                shipvd.Add(shipd);
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            gGrid1.Refresh();
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
                    case "预览":
                        SHIPVPrint(false);
                        break;
                    case "打印":
                        SHIPVPrint(true);
                        break;
                }
                base.ToolButtonClick(name);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void Audit()
        {
            SM_SHIPVOUCHER shipvoucher = this.editData as SM_SHIPVOUCHER;
            if (shipvoucher.STATUS == "N")
            {
                new G.BLL.ERP.Purchase.SM_SHIPVOUCHERLogic().Audit(G.AppInfo.GGlobal.User, shipvoucher.Id);
                MessageBox.Show("审核完成！");
                this.Close();
            }
            else { MessageBox.Show("订单已审核！"); }
        }

        public void SHIPVPrint(bool isPrint)
        {
            try
            {
                string shipvid = G.Core.GConvert.ToString(this.TXT_SHIPVID.Text);
                string condition = string.Format("SHIPVID='{0}'", shipvid);
                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Pur\SHIPVOUCHERLIST.frx", new List<string>() { "QryMaster", "QryDetail" }, "shipvprint", condition);
                printobj.Print(isPrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CHECK_ISPRICEDIFF_CheckStateChanged(object sender, EventArgs e)
        {
            BindingList<SM_SHIPVOUCHERDTL> shipvd = this.gGrid1.DataSource as BindingList<SM_SHIPVOUCHERDTL>;
            if (G.Core.GConvert.ToBool(this.CHECK_ISPRICEDIFF.GetValue()) == true && shipvd != null)
            {
                foreach (SM_SHIPVOUCHERDTL dtl in shipvd)
                {
                    dtl.PREPURQTY = 0;
                    dtl.CHECKEDQTY = 0;
                    dtl.PRICE = 0;
                }
                this.gGrid1.Refresh();
            }
        }
    }
}