using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.Base;
using G.Controls.Input;
using G.Data;
using G.Entity.ERP;

namespace G.Erp.Sale.Pocket
{
    public partial class SM_POCKETLOOK : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_POCKETLOOK()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "装箱单";
            this.listTool = new List<string>() { "退出" };
            this.T = typeof(SM_POCKET);
            this.orderby = "POCKID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_POCKETLogic();
            this.Edapter = initAdapter();
            InitGrid();
            InitDrop();
        }
        public override Controls.Base.IEditorAdapter initAdapter()
        {
            EditorAdapter<SM_POCKET, SM_POCKETDTL> adapter = new EditorAdapter<SM_POCKET, SM_POCKETDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱单号", FieldName = "POCKID", Editor = this.TXT_POCKID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱人", FieldName = "POCKETER", Editor = this.DROP_POCKETER, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱日期", FieldName = "POCKETDATE", Editor = this.DATE_POCKETDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售订单号", FieldName = "ORDERID", Editor = this.DROP_ORDERID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单员", FieldName = "OPERATOR", Editor = this.DROP_OPERATOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单日期", FieldName = "OPERDATE", Editor = this.DATE_OPERDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "条形码", FieldName = "BARCODE", Editor = this.TXT_BARCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱总数量", FieldName = "TOTALQTY", Editor = this.TXT_TOTALQTY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱明细", FieldName = "POCKETDTL", Editor = this.gGrid1 });
            return adapter;
        }
        public override void InitGrid()
        {
            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("UNIT", "单位", "String", 40, true);
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, true);
            gGrid1.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            gGrid1.AddGridColumn("ATTRIBUTEC", "尺寸", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("STYLENO", "款号", "String", 80, true);
            gGrid1.AddGridColumn("ORDQTY", "订单数", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("UNFINISHQTY", "可装箱数", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("POCKETQTY", "装箱数", "Decimal", "#0.00", 60);
            gGrid1.AddGridColumn("GIFTQTY", "赠送数", "Decimal", "#0.00", 60);
            
            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        public override void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.Sale.SM_SALEORDERLogic salelogic = new BLL.ERP.Sale.SM_SALEORDERLogic();
            Initialize.InitDropDown(DROP_OPERATOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_POCKETER, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_ORDERID, "SALEORDER", salelogic, true);
            DROP_ORDERID.DefaultCondition = CK.K["POCKETTAG"].Eq(0);
            DROP_ORDERID.IsText = true;
        }
    }
}