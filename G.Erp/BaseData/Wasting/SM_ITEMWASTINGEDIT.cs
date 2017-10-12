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

namespace G.Erp.BaseData
{
    public partial class SM_ITEMWASTINGEDIT : G.APP.BaseForm.BaseEditor
    {
        public SM_ITEMWASTINGEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "损耗量";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(SM_ITEMWASTING);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.SM_ITEMWASTINGLogic();
            this.Edapter = initAdapter();
            this.InitDrop();
        }
        private EditorAdapter<SM_ITEMWASTING, object> initAdapter()
        {
            EditorAdapter<SM_ITEMWASTING, object> adapter = new EditorAdapter<SM_ITEMWASTING, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品类别", FieldName = "ITEMTYPEID", Editor = this.DROP_ITEMTYPEID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "起始值", FieldName = "FQTY", Editor = this.NUM_FQTY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "终止值", FieldName = "TQTY", Editor = this.NUM_TQTY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "损耗量", FieldName = "WASTING", Editor = this.NUM_WASTING });
          return adapter;
        }

        private void InitDrop()
        {
            G.BLL.ERP.BaseData.SM_ITEMTYPELogic itemtypelogic = new G.BLL.ERP.BaseData.SM_ITEMTYPELogic();
            Initialize.InitDropDown(DROP_ITEMTYPEID, "ITEMTYPE", itemtypelogic, true);
        }
    }
}
