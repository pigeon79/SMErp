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

namespace G.Erp.BaseData.PriceBill
{
    public partial class DM_PRICEBILLEditor : G.APP.BaseForm.BaseMultipleEditor
    {
        public DM_PRICEBILLEditor()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "";
            this.listTool = new List<string>() { "新增", "保存", "|", "增行", "删行", "|", "退出" };
            this.T = typeof(DM_PRICEBILL);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.DM_PRICEBILLLogic();
            this.Edapter = initAdapter();
            InitGrid();
        }
        public override Controls.Base.IEditorAdapter initAdapter()
        {
            EditorAdapter<DM_PRICEBILL, DM_PRICEBILLDTL> adapter = new EditorAdapter<DM_PRICEBILL, DM_PRICEBILLDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "使用标志", FieldName = "USETAG", Editor = this.check_USETAG });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "价格簿", FieldName = "PBILLNAME", Editor = this.TXT_PBILLNAME });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "价格明细", FieldName = "PRICEBILLDTL", Editor = this.gGrid1 });
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
            C1.Win.C1Input.C1NumericEdit priceedit = new C1.Win.C1Input.C1NumericEdit();

            priceedit.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            priceedit.DropDownForm = new PriceCacu();

            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, dropdown, "ITEMCODE");
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("BASICSIZE", "基准尺寸", "Decimal", 80);
            gGrid1.AddGridColumn("BASICPRICE", "基准价格", "Decimal", 80, priceedit, "BASICPRICE");
            gGrid1.AddGridColumn("ADDPRICE", "加1MM价格", "Decimal", 60);
            gGrid1.AddGridColumn("SUBPRICE", "减1MM价格", "Decimal", 60);
            gGrid1.FrozenCell = 2;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }


        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                  gGrid1.GetCurSelect<DM_PRICEBILLDTL>().ITEMNAME = G.Core.GConvert.ToString(e.DataRow["ItemName"]);

            }
        }
        public override void AddRow()
        {
            DM_PRICEBILLDTL saledtl = gGrid1.AddRow<DM_PRICEBILLDTL>();
        }
        public override void DeleteRow()
        {
            gGrid1.DeleteRow<DM_PRICEBILLDTL>();
        }

        private void gGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            var i = e.Row;
        }
    }
}
