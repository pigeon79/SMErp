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
    public partial class DM_COLORLIST : G.APP.BaseForm.BaseList
    {
        public DM_COLORLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo() {
            this.listCaption = "色号列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "|", "退出" };
            this.EntityT = typeof(DM_COLOR);
            this.EditorT = typeof(DM_COLOREDIT);
            this.orderby = "CCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_COLORLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("色号代码","CCODE","String",80),
                new ColumnInfo("色号名称","CNAME","String",100),
                new ColumnInfo("加价","ADDPRICE","Decimal",60),
                new ColumnInfo("是否外协","ISWX","Boolean",80)
            });
            
        }
    }
}
