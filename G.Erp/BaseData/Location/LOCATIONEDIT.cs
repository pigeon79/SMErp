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
    public partial class LOCATIONEDIT : G.APP.BaseForm.BaseEditor
    {
        public LOCATIONEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "库位";
            this.listTool = new List<string>() { "新增", "保存", "|", "退出" };
            this.T = typeof(DM_LOCATION);
            this.orderby = "SUPPCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_LOCATIONLogic();
            this.Edapter = initAdapter();
            InitDrop();
        }
        private EditorAdapter<DM_LOCATION, object> initAdapter()
        {
            EditorAdapter<DM_LOCATION, object> adapter = new EditorAdapter<DM_LOCATION, object>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "仓库代码", FieldName = "WRHSCODE", Editor = this.drop_WRHSCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "库位代码", FieldName = "LOCCODE", Editor = this.txt_LOCCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "库位名称", FieldName = "LOCNAME", Editor = this.txt_LOCNAME });
            return adapter;
        }
        private void InitDrop()
        {
            G.BLL.ERP.BaseData.DM_WAREHOUSELogic arealogic = new G.BLL.ERP.BaseData.DM_WAREHOUSELogic();
            Initialize.InitDropDown(drop_WRHSCODE, "WAREHOUSE", arealogic,false);
        }
    }
}
