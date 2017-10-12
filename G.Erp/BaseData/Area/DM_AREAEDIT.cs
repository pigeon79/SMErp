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
    public partial class DM_AREAEDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_AREAEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "地区";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_AREA);
            this.orderby = "DQDM";
            this.Logic = new G.BLL.ERP.BaseData.DM_AREALogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<DM_AREA, object> initAdapter()
        {
            EditorAdapter<DM_AREA, object> adapter = new EditorAdapter<DM_AREA, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "地区代码", FieldName = "DQDM", Editor = this.TXT_DQDM });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "地区", FieldName = "DQNAME", Editor = this.TXT_DQNAME });
          return adapter;
        }
        public override bool LoadForm()
        {
            return base.LoadForm();
        }
    }
}
