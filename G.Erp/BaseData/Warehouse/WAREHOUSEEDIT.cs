using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Entity.ERP;
using C1.Win.C1Input;
using G.Controls.Base;

namespace G.ERP.BaseData
{
    public partial class WAREHOUSEEDIT : G.APP.BaseForm.BaseEditor
    {
        public WAREHOUSEEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "仓库";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_WAREHOUSE);
            this.orderby = "WRHSCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_WAREHOUSELogic();
            this.Edapter = initAdapter();;
        }
        private EditorAdapter<DM_WAREHOUSE, object> initAdapter()
        {
            EditorAdapter<DM_WAREHOUSE, object> adapter = new EditorAdapter<DM_WAREHOUSE, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "仓库代码", FieldName = "WRHSCODE", Editor = this.txt_WRHSCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "仓库名称", FieldName = "WRHSNAME", Editor = this.txt_WRHSNAME });
            return adapter;
        }

    }
}
