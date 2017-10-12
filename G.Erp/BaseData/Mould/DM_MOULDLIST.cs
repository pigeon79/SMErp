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
using G.APP.BaseForm;

namespace G.Erp.BaseData
{
    public partial class DM_MOULDLIST : G.APP.BaseForm.BaseList
    {
        public DM_MOULDLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo() {
            this.listCaption = "花模列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(DM_MOULD);
            this.EditorT = typeof(DM_MOULDEDIT);
            this.orderby = "MDCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_MOULDLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("基础模代码","BASICCODE","String",80),
                new ColumnInfo("花模代码","MDCODE","String",80),
                new ColumnInfo("花模名称","MDNAME","String",80),
                new ColumnInfo("总价","MDPRICE","Decimal",80),
                new ColumnInfo("基本价","BASICPRICE","Decimal",80),
                new ColumnInfo("加价","ADDPRICE","Decimal",80),
                new ColumnInfo("克重","WEIGHT","Decimal",80),
                //new ColumnInfo("全新损耗","WASTING1","Decimal",80),
                //new ColumnInfo("颜色损耗","WASTING2","Decimal",80),
                //new ColumnInfo("黑色损耗","WASTING3","Decimal",80)
                
                new ColumnInfo("规格","ISIZE","Decimal",80),
                new ColumnInfo("模数","MCOUNT","Int32",80)
            });
           
        }
        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "花模代码", fieldname = "MDCODE", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "花模名称", fieldname = "MDNAME", fieldtype = "String", islike = true });
        }
    }
}
