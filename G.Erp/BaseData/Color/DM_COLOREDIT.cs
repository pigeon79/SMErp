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
    public partial class DM_COLOREDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_COLOREDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "色号";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_COLOR);
            this.orderby = "CCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_COLORLogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<DM_COLOR, object> initAdapter()
        {
            EditorAdapter<DM_COLOR, object> adapter = new EditorAdapter<DM_COLOR, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "色号代码", FieldName = "CCODE", Editor = this.TXT_CCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "色号", FieldName = "CNAME", Editor = this.TXT_CNAME });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "加价", FieldName = "ADDPRICE", Editor = this.NUM_ADDPRICE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "外协", FieldName = "ISWX", Editor = this.CHECK_ISWX });
          return adapter;
        }
        public override bool LoadForm()
        {
            return base.LoadForm();
        }
    }
}
