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
using G.APP.BaseForm;

namespace G.Erp.BaseData
{
    public partial class DM_WHBEDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_WHBEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        public int ParentID { get; set; }
        private void InitInfo()
        {
            this.listCaption = "辅助资料";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_WHB);
            this.orderby = "WHBDM";
            this.Logic = new G.BLL.ERP.BaseData.DM_WHBLogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<DM_WHB, object> initAdapter()
        {
            EditorAdapter<DM_WHB, object> adapter = new EditorAdapter<DM_WHB, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "代码", FieldName = "FZDM", Editor = this.TXT_WHBDM });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "名称", FieldName = "FZNAME", Editor = this.TXT_WHBNAME });
          return adapter;
        }
        public override void New()
        {
            editData = new DM_WHB();
            ((DM_WHB)editData).WHBLBID = this.ParentID;
            this.CurEditStatus = EditorStatus.New;
            this.LoadData();
        }
    }
}
