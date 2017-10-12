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
    public partial class SM_ITEMWASTINGLIST : G.APP.BaseForm.BaseList
    {
        public SM_ITEMWASTINGLIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "损耗量列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_ITEMWASTING);
            this.EditorT = typeof(SM_ITEMWASTINGEDIT);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.SM_ITEMWASTINGLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("物品类别","ITEMTYPENAME","String",80),
                new ColumnInfo("起始值","FQTY","Int",80),
                new ColumnInfo("终止值","TQTY","Int",80),
                new ColumnInfo("损耗量","WASTING","Decimal",80)
            });
        }
        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "物品类别", fieldname = "ITEMTYPEID", fieldtype = "String", controltype = "dropdown", controldata = "ITEMTYPE", searchLogic = new G.BLL.ERP.BaseData.SM_ITEMTYPELogic(), islike = false });
        }
    }
}
