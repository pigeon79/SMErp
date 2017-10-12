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
    public partial class SM_PRICEPARAEDIT : G.APP.BaseForm.BaseEditor
    {
        public SM_PRICEPARAEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "基本价格设置";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(SM_PRICEPARA);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.SM_PRICEPARALogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<SM_PRICEPARA, object> initAdapter()
        {
            EditorAdapter<SM_PRICEPARA, object> adapter = new EditorAdapter<SM_PRICEPARA, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "类别", FieldName = "TYPECODE", Editor = this.comb_Type });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "起始值", FieldName = "SWEIGHT", Editor = this.TXT_SWEIGHT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "终止值", FieldName = "EWEIGHT", Editor = this.TXT_EWEIGHT });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "价格", FieldName = "PRICE", Editor = this.TXT_PRICE });
          return adapter;
        }
    }
}
