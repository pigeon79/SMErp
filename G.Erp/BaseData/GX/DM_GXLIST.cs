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
    public partial class DM_GXLIST : G.APP.BaseForm.BaseList
    {
        public DM_GXLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo() {
            this.listCaption = "工序列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "|", "退出" };
            this.EntityT = typeof(DM_GX);
            this.EditorT = typeof(DM_GXEDIT);
            this.orderby = "GXDM";
            this.Logic = new G.BLL.ERP.BaseData.DM_GXLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("是否停用","STOPTAG","Boolean",60),
                new ColumnInfo("工序代码","GXDM","String",80),
                new ColumnInfo("工序名称","GXNAME","String",100)                
            });
        }
    }
}
