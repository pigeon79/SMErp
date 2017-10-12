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
    public partial class DM_SUPPLIEREDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_SUPPLIEREDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "供应商";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_SUPPLIER);
            this.orderby = "SUPPCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic();
            this.Edapter = initAdapter();
            InitDrop();
        }
        private EditorAdapter<DM_SUPPLIER, object> initAdapter()
        {
            EditorAdapter<DM_SUPPLIER, object> adapter = new EditorAdapter<DM_SUPPLIER, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商代码", FieldName = "SUPPCODE", Editor = this.TXT_SUPPCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商名称", FieldName = "SUPPNAME", Editor = this.TXT_SUPPNAME });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商等级", FieldName = "SUPPLEV", Editor = this.COMB_SUPPLEV });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "建立日期", FieldName = "FOUNDDATE", Editor = this.DATE_FOUNDDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "助记符", FieldName = "PY", Editor = this.TXT_PY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商类别", FieldName = "SUPPTYPE", Editor = this.COMB_SUPPTYPE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商主业", FieldName = "SUPPOR", Editor = this.TXT_SUPPOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "主业描述", FieldName = "SUPPDESC", Editor = this.TXT_SUPPDESC });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "法人代表", FieldName = "BOSS", Editor = this.TXT_BOSS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "法人电话", FieldName = "TEL", Editor = this.TXT_TEL });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "联系人", FieldName = "CONTACTS", Editor = this.TXT_CONTACTS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "联系电话", FieldName = "CONTEL", Editor = this.TXT_CONTEL });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "地址", FieldName = "ADDRESS", Editor = this.TXT_ADDRESS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "传真", FieldName = "FAX", Editor = this.TXT_FAX });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "业务电话", FieldName = "SUPPTEL", Editor = this.TXT_SUPPTEL });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "产量", FieldName = "PRDCOUNT", Editor = this.TXT_PRDCOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "品质", FieldName = "QS", Editor = this.TXT_QS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "服务", FieldName = "SERVER", Editor = this.TXT_SERVER });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "付款方式", FieldName = "PAYTYPE", Editor = this.COMB_PAYTYPE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "区域", FieldName = "AREA", Editor = this.DROP_AREA });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开户银行", FieldName = "BANK", Editor = this.TXT_BANK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开户账号", FieldName = "BANKACCOUNT", Editor = this.TXT_BANKCOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否开票", FieldName = "INVTAG", Editor = this.CHECK_INVTAG });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "付款时间", FieldName = "PAYTIME", Editor = this.TXT_PAYTIME });
          return adapter;
        }

        private void TXT_SUPPNAME_Leave(object sender, EventArgs e)
        {
            if (this.TXT_PY.Text == "")
            {
                this.TXT_PY.Text = G.Core.PinYin.GetCodeString(this.TXT_SUPPNAME.Text);
            }
        }

        private void InitDrop()
        {
            G.BLL.ERP.BaseData.DM_AREALogic arealogic = new G.BLL.ERP.BaseData.DM_AREALogic();
            Initialize.InitDropDown(DROP_AREA, "AREA", arealogic, "DQNAME", "DQNAME");
        }
    }
}
