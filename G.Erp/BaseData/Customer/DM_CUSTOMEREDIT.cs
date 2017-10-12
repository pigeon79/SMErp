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
    public partial class DM_CUSTOMEREDIT : G.APP.BaseForm.BaseEditor
    {
        public DM_CUSTOMEREDIT()
        {
            InitializeComponent();
            InitInfo(); 
        }
        private void InitInfo()
        {
            this.listCaption = "客户";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_CUSTOMER);
            this.orderby = "CUSTCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic();
            this.Edapter = initAdapter();
            InitDrop();
        }
        private EditorAdapter<DM_CUSTOMER, object> initAdapter()
        { 
            EditorAdapter<DM_CUSTOMER, object> adapter = new EditorAdapter<DM_CUSTOMER, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "客户代码", FieldName = "CUSTCODE", Editor = this.TXT_CUSTCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "客户名称", FieldName = "CUSTNAME", Editor = this.TXT_CUSTNAME, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "客户等级", FieldName = "CUSTLEV", Editor = this.COMB_CUSTLEV });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "建立日期", FieldName = "FOUNDDATE", Editor = this.DATE_FOUNDDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售员", FieldName = "SALESMAN", Editor = this.DROP_SALESMAN, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售代表", FieldName = "SALESREP", Editor = this.DROP_SALESREP, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "内勤", FieldName = "INOFC", Editor = this.DROP_INOFC, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "助记符", FieldName = "PY", Editor = this.TXT_PY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "客户类型", FieldName = "CUSTTYPE", Editor = this.COMB_CUSTTYPE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "法人代表", FieldName = "BOSS", Editor = this.TXT_BOSS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "法人电话", FieldName = "TEL", Editor = this.TXT_TEL });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "联系人", FieldName = "CONTACTS", Editor = this.TXT_CONTACTS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "联系电话", FieldName = "CONTEL", Editor = this.TXT_CONTEL });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "地址", FieldName = "ADDRESS", Editor = this.TXT_ADDRESS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "传真", FieldName = "FAX", Editor = this.TXT_FAX });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购员", FieldName = "BUYER", Editor = this.TXT_BUYER });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "采购员电话", FieldName = "BUYTEL", Editor = this.TXT_BUYTEL });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "结算方式", FieldName = "JSFS", Editor = this.COMB_JSFS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "付款方式", FieldName = "PAYTYPE", Editor = this.COMB_PAYTYPE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "折扣率", FieldName = "DISCOUNT", Editor = this.TXT_DISCOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "区域", FieldName = "AREA", Editor = this.DROP_AREA, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开户银行", FieldName = "BANK", Editor = this.TXT_BANK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "开户账号", FieldName = "BANKACCOUNT", Editor = this.TXT_BANKACCOUNT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "行业", FieldName = "TRADE", Editor = this.TXT_TRADE});
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "打单信息", FieldName = "ORDERINFO", Editor = this.TXT_ORDERINFO });
            return adapter;
        }
        private void InitDrop() {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            Initialize.InitDropDown(DROP_AREA, "AREA", new G.BLL.ERP.BaseData.DM_AREALogic(), false);
            Initialize.InitDropDown(DROP_INOFC, "USER", userlogic, false);
            Initialize.InitDropDown(DROP_SALESMAN, "USER", userlogic, false);
            Initialize.InitDropDown(DROP_SALESREP, "USER", userlogic, false);
        }
        public override bool LoadForm()
        {
            return base.LoadForm();
        }

        private void TXT_CUSTNAME_Leave(object sender, EventArgs e)
        {
            this.TXT_PY.Text = G.Core.PinYin.GetCodeString(this.TXT_CUSTNAME.Text);
        }
        
    }
}
