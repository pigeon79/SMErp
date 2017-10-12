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
    public partial class SM_ITEMTYPEEDIT : G.APP.BaseForm.BaseEditor
    {
        public SM_ITEMTYPEEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "物品大类";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(SM_ITEMTYPE);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.SM_ITEMTYPELogic();
            this.Edapter = initAdapter();
        }
        private EditorAdapter<SM_ITEMTYPE, object> initAdapter()
        {
            EditorAdapter<SM_ITEMTYPE, object> adapter = new EditorAdapter<SM_ITEMTYPE, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品大类", FieldName = "ITEMTYPENAME", Editor = this.TXT_ITEMTYPENAME });
            return adapter;
        } 
    }
}
