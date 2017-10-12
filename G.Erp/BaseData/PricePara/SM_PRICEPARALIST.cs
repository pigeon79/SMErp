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
    public partial class SM_PRICEPARALIST : G.APP.BaseForm.BaseList
    {
        public SM_PRICEPARALIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo() {
            this.listCaption = "基本价格设置";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "|", "退出" };
            this.EntityT = typeof(SM_PRICEPARA);
            this.EditorT = typeof(SM_PRICEPARAEDIT);
            this.orderby = "TYPECODE,SWEIGHT";
            this.Logic = new G.BLL.ERP.BaseData.SM_PRICEPARALogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("类别","TYPECODE","String",80),
                new ColumnInfo("起始重量","SWEIGHT","Decimal",80),
                new ColumnInfo("终止重量","EWEIGHT","Decimal",80),
                new ColumnInfo("单价","PRICE","Decimal",80)
            });
            
            this.gGrid1.ExtendLastCol = false;
        }
    }
}
