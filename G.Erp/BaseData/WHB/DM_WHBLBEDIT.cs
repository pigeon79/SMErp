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
    public partial class DM_WHBLBEDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_WHBLBEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        public int ParentID { get; set; }
        private void InitInfo()
        {
            this.listCaption = "辅助资料类别";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_WHBLB);
            this.orderby = "WHLBDM";
            this.Logic = new G.BLL.ERP.BaseData.DM_WHBLBLogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<DM_WHBLB, object> initAdapter()
        {
            EditorAdapter<DM_WHBLB, object> adapter = new EditorAdapter<DM_WHBLB, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "代码", FieldName = "WHLBDM", Editor = this.TXT_WHBLDM });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "名称", FieldName = "WHLBNAME", Editor = this.TXT_WHBLBNAME });
          return adapter;
        }
        public override void New()
        {
            editData = new DM_WHBLB();
            ((DM_WHBLB)editData).PARENTID = this.ParentID;
            this.CurEditStatus = EditorStatus.New;
            this.LoadData();
        }
    }
}
