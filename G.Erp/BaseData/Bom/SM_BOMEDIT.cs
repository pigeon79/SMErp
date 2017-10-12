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

namespace G.Erp.BaseData
{
    public partial class SM_BOMEDIT : G.APP.BaseForm.BaseEditor
    {
        public SM_BOMEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "BOM";
            this.listTool = new List<string>() { "预览", "打印", "|", "保存", "|", "增行", "删行", "|", "退出" };
            this.T = typeof(SM_BOM);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.SM_BOMLogic();
            InitDrop();
            InitGrid();
            this.DROP_FITEM.RowSelect += DROP_FITEM_RowSelect;
        }
        private string fitem = "";
        void DROP_FITEM_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            DataRow dr = e.DataRow;
            if (dr != null)
            {
                fitem = e.DataRow["ItemCode"].ToString();
                this.LoadData();
            }
        }
        private void InitDrop()
        {
            Initialize.InitDropDown(DROP_FITEM, "ITEM", new G.BLL.ERP.BaseData.DM_ITEMLogic(), "ItemCode", "ItemName");
            DROP_FITEM.CustomerDropDownForm = new G.Erp.BaseData.ItemSearch();
        }

        private void InitGrid()
        {
            DropDown dropdown = new DropDown();
            dropdown.CustomerDropDownForm = new G.Erp.BaseData.ItemSearch();
            dropdown.RowSelected += dropdown_RowSelected;
            dropdown.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            Initialize.InitDropDown(dropdown, "ITEM", new G.BLL.ERP.BaseData.DM_ITEMLogic(), "ItemCode", "ItemName");

            //gGrid1.AddGridColumn("ID", "ID", "Int32", 20,true);
            gGrid1.AddGridColumn("CITEM", "子物品代码", "String", 100, dropdown, "CITEM");
            gGrid1.AddGridColumn("CITEMNAME", "子物品名称", "String", 150, true);
            gGrid1.AddGridColumn("CQTY", "数量", "Decimal", "#0", 60);
            gGrid1.FrozenCell = 0;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }


        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                SM_BOM cur = gGrid1.GetCurSelect<SM_BOM>();
                cur.CITEMNAME = e.DataRow["ItemName"].ToString();
            }
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

        public override void LoadData()
        {
            if (!fitem.IsNullOrEmpty()) {
               List<SM_BOM> list= ((SM_BOMLogic)this.Logic).GetBomByFItem(fitem);
               this.gGrid1.SetValue<SM_BOM>(list);
               if (list.Count == 0) {
                   this.AddRow();
               }
            }
        }
        public override void onBeforeSave()
        {
            this.gGrid1.FinishEditing();
            base.onBeforeSave();
        }
        public override bool Save()
        {
            bool ispass = false;
            try
            {
                onBeforeSave();
                List<SM_BOM> list = ((BindingList<SM_BOM>)gGrid1.GetValue()).ToList<SM_BOM>();
                foreach (SM_BOM s in list)
                {
                    s.FITEM = fitem;
                }
                ((SM_BOMLogic)this.Logic).ExecuteUpdate(G.AppInfo.GGlobal.User, list);
                MessageBox.Show("保存成功！");
                this.LoadData();
                ispass = true;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return ispass;
        }
        public override void New()
        {
            base.New();
            AddRow();
        }
        private void AddRow()
        {
            SM_BOM saledtl = gGrid1.AddRow<SM_BOM>();
        }
        private void DeleteRow()
        {
            gGrid1.DeleteRow<SM_BOM>();
        }

    }
}
