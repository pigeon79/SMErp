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
    public partial class DM_GXEDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_GXEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "工序";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_GX);
            this.orderby = "GXDM";
            this.Logic = new G.BLL.ERP.BaseData.DM_GXLogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<DM_GX, object> initAdapter()
        {
            EditorAdapter<DM_GX, object> adapter = new EditorAdapter<DM_GX, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "工序代码", FieldName = "GXDM", Editor = this.TXT_GXDM });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "工序名称", FieldName = "GXNAME", Editor = this.TXT_GXNAME });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "助记符", FieldName = "PY", Editor = this.TXT_PY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否停用", FieldName = "STOPTAG", Editor = this.CHECK_STOPTAG });
          return adapter;
        }
        public override bool LoadForm()
        {
            return base.LoadForm();
        }

        private void TXT_GXNAME_Leave(object sender, EventArgs e)
        {
            this.TXT_PY.Text = G.Core.PinYin.GetCodeString(this.TXT_GXNAME.Text);
        }
    }
}
