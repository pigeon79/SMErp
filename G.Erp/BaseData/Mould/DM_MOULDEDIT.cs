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
    public partial class DM_MOULDEDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_MOULDEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "花模";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_MOULD);
            this.orderby = "MDCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_MOULDLogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<DM_MOULD, object> initAdapter()
        {
            EditorAdapter<DM_MOULD, object> adapter = new EditorAdapter<DM_MOULD, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "花模代码", FieldName = "MDCODE", Editor = this.TXT_MDCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "花模", FieldName = "MDNAME", Editor = this.TXT_DQNAME });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "基本价格", FieldName = "BASICPRICE", Editor = this.NUM_BASICPRICE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "加价", FieldName = "ADDPRICE", Editor = this.NUM_ADDPRICE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "克重", FieldName = "WEIGHT", Editor = this.NUM_WEIGHT });
            //adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "全新损耗", FieldName = "WASTING1", Editor = this.NUM_WASTING1 });
            //adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "颜色损耗", FieldName = "WASTING2", Editor = this.NUM_WASTING2 });
            //adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "黑色损耗", FieldName = "WASTING3", Editor = this.NUM_WASTING3 });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "基础模代码", FieldName = "BASICCODE", Editor = this.TXT_BASICCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "规格", FieldName = "ISIZE", Editor = this.NUM_ISIZE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "模数", FieldName = "MCOUNT", Editor = this.NUM_MCOUNT });
          return adapter;
        }
    }
}
