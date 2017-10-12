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
    public partial class DM_INVOPRTEDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_INVOPRTEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "库存事务维护";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_INVOPRT);
            this.orderby = "INVTRNCDE";
            this.Logic = new G.BLL.ERP.BaseData.DM_INVOPRTLogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<DM_INVOPRT, object> initAdapter()
        {
            EditorAdapter<DM_INVOPRT, object> adapter = new EditorAdapter<DM_INVOPRT, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "库存事务代码", FieldName = "INVTRNCDE", Editor = this.TXT_INVTRNCDE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "库存事务名称", FieldName = "INVTDESC", Editor = this.TXT_INVTDESC });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否影响发出", FieldName = "ONISSUE", Editor = this.CHECK_ONISSUE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否影响收入", FieldName = "ONREV", Editor = this.CHECK_ONREV });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否影响调整", FieldName = "ONADJUST", Editor = this.CHECK_ONADJUST });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否参与车间分配", FieldName = "ONSHOPA", Editor = this.CHECK_ONSHOPA });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否计算销售量", FieldName = "ONSALEQTY", Editor = this.CHECK_ONSALEQTY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否记录订单号", FieldName = "ISORDERNO", Editor = this.CHECK_ISORDERNO });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否记录采购订单号", FieldName = "ISPONO", Editor = this.CHECK_ISPONO });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否参与MRP运算", FieldName = "ISHMERP", Editor = this.CHECK_ISHMERP });
            return adapter;
        }
        public override bool LoadForm()
        {
            return base.LoadForm();
        }
    }
}
