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

namespace G.Erp.Storage
{
    public partial class SM_INVHISTORYREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_INVHISTORYREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "库存操作查询";
            this.listTool = new List<string>() { "刷新", "-", "过滤", "|", "退出" };
            this.orderby = "ID DESC";
            this.Logic = new G.BLL.Base.BaseDataBLL();
            this.Csql = "RPT_KC0001";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("事务日期","TRANDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("原始单号","ORDERID","String",80),
                new ColumnInfo("库存操作","INVTDESC","String",80),
                new ColumnInfo("物品代码","ITEMCODE","String",80),
                new ColumnInfo("物品名称","ITEMNAME","String",100),
                new ColumnInfo("单位","OPERUNIT","String",40),
                new ColumnInfo("色号","ATTRIBUTEA","String",80),
                new ColumnInfo("花模","ATTRIBUTEBNAME","String",80),
                new ColumnInfo("尺寸","ATTRIBUTEC","Decimal",60),
                new ColumnInfo("入库数","INQTY","Decimal",60),
                new ColumnInfo("出库数","OUTQTY","Decimal",60),
                new ColumnInfo("公斤数","WEIGHT","Decimal",60),
                new ColumnInfo("仓库","WRHSNAME","String",80),
                new ColumnInfo("库位","LOCNAME","String",80),
                new ColumnInfo("操作员","OPERATORNAME","String",60),
                new ColumnInfo("操作日期","OPERDATE","DateTime","yyyy-MM-dd",80)
            });
        }


        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A" });
            this.FilterInfos.Add(new FilterInfo() { caption = "事务日期", fieldname = "TRANDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "原始单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            //this.FilterInfos.Add(new FilterInfo() { caption = "采购申请单号", fieldname = "PREPURORDID", fieldtype = "String", islike = true });
            //this.FilterInfos.Add(new FilterInfo() { caption = "供应商", fieldname = "SUPCODE", fieldtype = "String", controltype = "dropdown", controldata = "SUPPLIER", searchLogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic(), islike = false });
            //this.FilterInfos.Add(new FilterInfo() { caption = "物品名称", fieldname = "ITEMCODE", fieldtype = "String", controltype = "dropdown", controldata = "ITEM", searchLogic = new G.BLL.ERP.BaseData.DM_ITEMLogic(), islike = false });
            //this.FilterInfos.Add(new FilterInfo() { caption = "供应商", fieldname = "SUPCODE", fieldtype = "String", controltype = "dropdown", controldata = "SUPPLIER", searchLogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic(), islike = false });
        }
    }
}
