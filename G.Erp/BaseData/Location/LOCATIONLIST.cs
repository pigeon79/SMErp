using G.Controls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.GGrid;
using G.Data;
using G.Entity.ERP;

namespace G.ERP.BaseData
{
    public partial class LOCATIONLIST : G.APP.BaseForm.BaseList
    {
        public LOCATIONLIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "库位列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "|", "退出" };
            this.EntityT = typeof(DM_LOCATION);
            this.EditorT = typeof(LOCATIONEDIT);
            this.orderby = "WRHSCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_LOCATIONLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("仓库","WRHSNAME","String",80),
                new ColumnInfo("库位代码","LOCCODE","String",80),
                new ColumnInfo("库位名称","LOCNAME","String",80)
            });
        }
    }
}
