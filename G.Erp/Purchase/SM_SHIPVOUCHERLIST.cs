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
    public partial class SM_SHIPVOUCHERLIST : G.APP.BaseForm.BaseList
    {
        public SM_SHIPVOUCHERLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "采购收货";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_SHIPVOUCHER);
            this.EditorT = typeof(SM_SHIPVOUCHEREDIT);
            this.orderby = "SHIPVID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_SHIPVOUCHERLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("收货单号","SHIPVID","String",80),
                new ColumnInfo("收货日期","SHIPDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("状态","STATUSNAME","String",30),
                new ColumnInfo("供应商","SUPPNAME","String",100),
                new ColumnInfo("采购订单号","POID","String",80),
                new ColumnInfo("收货人","SHIPUSERNAME","String",80),
                new ColumnInfo("送货单号","DELIVERCODE","String",80),
                new ColumnInfo("是否补差价单","ISPRICEDIFF","Boolean",100),
                new ColumnInfo("审核人","AUDITORNAME","String",60),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("制单人","OPERATORNAME","String",60),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("税率","TAXRATE","Decimal",30)
            });
        }

        public override void InitFilter()
        {
            //this.DefaultCondition = CK.K["ISPRICEDIFF"].Eq("0");
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A" ,defaultvalue="N"});
            this.FilterInfos.Add(new FilterInfo() { caption = "收货日期", fieldname = "SHIPDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "收货人", fieldname = "SHIPUSER", fieldtype = "String", controltype = "dropdown", controldata = "USER", searchLogic = new G.BLL.Sys.ND_UserLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "收货单号", fieldname = "SHIPVID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "审核日期", fieldname = "AUDITDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "供应商", fieldname = "SUPCODE", fieldtype = "String", controltype = "dropdown", controldata = "SUPPLIER", searchLogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic(), islike = false });
            //this.FilterInfos.Add(new FilterInfo() { caption = "是否补差价单", fieldname = "ISPRICEDIFF", fieldtype = "Boolean", controltype = "checkbox" });
            this.FilterInfos.Add(new FilterInfo() { caption = "是否补差价单", fieldname = "ISPRICEDIFF", fieldtype = "Boolean", controltype = "combox", controldata = "全部:,是:1,否:0" });
        }
    }
}
