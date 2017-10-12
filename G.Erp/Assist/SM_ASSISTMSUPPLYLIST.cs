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

namespace G.Erp.Assist
{
    public partial class SM_ASSISTMSUPPLYLIST : G.APP.BaseForm.BaseList
    {
        public SM_ASSISTMSUPPLYLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "外协领料单";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_ASSISTMSUPPLY);
            this.EditorT = typeof(SM_ASSISTMSUPPLYEDIT);
            this.orderby = "ASSISTMSCODE DESC";
            this.Logic = new G.BLL.ERP.Assist.SM_ASSISTMSUPPLYLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("外协领料","ASSISTMSCODE","String",80),
                new ColumnInfo("外协加工单位","SUPPNAME","String",80),
                new ColumnInfo("状态","STATUSNAME","String",80),
                new ColumnInfo("客户单位","CUSTNAME","String",80),
                new ColumnInfo("外协交期","ADELIVERYDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("审核人","AFFIRMERNAME","String",80),
                new ColumnInfo("审核日期","AFFIRMDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("采购员","PURUSERNAME","String",80),
                new ColumnInfo("订单号","ORDERID","String",80),
                new ColumnInfo("备注","MEMO","String",80),
                new ColumnInfo("制单人","OPERATORNAME","String",80),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80)
            });
        }

        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A", defaultvalue = "N" });
            this.FilterInfos.Add(new FilterInfo() { caption = "外协领料单号", fieldname = "ASSISTMSCODE", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "外协交期", fieldname = "ADELIVERYDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
        }
    }
}
