using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using G.Controls.GGrid;
using G.Data;
using G.Controls.Base;
using G.BLL.Base;
using G.Entity.ERP;

namespace G.Erp.BaseData
{
    public partial class DM_AREALIST : G.APP.BaseForm.BaseList
    {
        public DM_AREALIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo() {
            this.listCaption = "地区列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "|", "退出" };
            this.EntityT = typeof(DM_AREA);
            this.EditorT = typeof(DM_AREAEDIT);
            this.orderby = "DQDM";
            this.Logic = new G.BLL.ERP.BaseData.DM_AREALogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("地区代码","DQDM","String",80),
                new ColumnInfo("地区名称","DQNAME","String",80)
            });
        }
    }
}
