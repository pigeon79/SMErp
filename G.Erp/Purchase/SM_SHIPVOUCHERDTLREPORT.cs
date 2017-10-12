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

namespace G.Erp.Purchase
{
    public partial class SM_SHIPVOUCHERDTLREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_SHIPVOUCHERDTLREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "采购收货明细查询";
            this.listTool = new List<string>() { "刷新", "-", "导出", "过滤", "|", "退出" };
            this.orderby = "SHIPVID DESC";
            this.Logic = new G.BLL.Base.BaseDataBLL();
            this.Csql = "RPT_CG0005";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("收货单号","SHIPVID","String",80),
                new ColumnInfo("收货日期","SHIPDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("状态","STATUSNAME","String",30),
                new ColumnInfo("供应商","SUPPNAME","String",100),
                new ColumnInfo("采购订单号","POID","String",80),
                new ColumnInfo("收货人","SHIPUSERNAME","String",80),
                new ColumnInfo("送货单号","DELIVERCODE","String",80),
                new ColumnInfo("是否补差价单","ISPRICEDIFF","Boolean",80),
                new ColumnInfo("审核人","AUDITORNAME","String",60),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("制单人","OPERATORNAME","String",60),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("税率","TAXRATE","Decimal",30),
                new ColumnInfo("物品代码","ITEMCODE","String",80),
                new ColumnInfo("物品名称","ITEMNAME","String",100),
                new ColumnInfo("单位","INVUNIT","String",40),
                new ColumnInfo("申请数量","PREPURQTY","Decimal",60),
                ColumnInfo.Initialize("合格数量","CHECKEDQTY","Decimal","#0.0",60,true),
                new ColumnInfo("采购单价","PRICE","Decimal",60),
                new ColumnInfo("金额","SHIPAMOUNT","Decimal",60),
                new ColumnInfo("是否检验","CHECKFLAG","Boolean",60),
                new ColumnInfo("仓库","WRHSNAME","String",80),
                new ColumnInfo("库位","LOCNAME","String",80),
                new ColumnInfo("色号","ATTRIBUTEA","String",80),
                new ColumnInfo("花模","ATTRIBUTEBNAME","String",80),
                new ColumnInfo("尺寸","ATTRIBUTEC","Decimal",60),
                new ColumnInfo("收货重量","SHWEIGHT","Decimal",60),
                new ColumnInfo("明细备注","REMARKS","String",100)
            });
        }

        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A" });
            this.FilterInfos.Add(new FilterInfo() { caption = "收货日期", fieldname = "SHIPDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "收货人", fieldname = "SHIPUSER", fieldtype = "String", controltype = "dropdown", controldata = "USER", searchLogic = new G.BLL.Sys.ND_UserLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "收货单号", fieldname = "SHIPVID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "采购订单号", fieldname = "POID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "审核日期", fieldname = "AUDITDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "供应商", fieldname = "SUPCODE", fieldtype = "String", controltype = "dropdown", controldata = "SUPPLIER", searchLogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "是否补差价单", fieldname = "ISPRICEDIFF", fieldtype = "Boolean", controltype = "combox", controldata = "全部:,是:1,否:0" });
        }
    }
}
