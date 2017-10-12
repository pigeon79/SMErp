using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.GGrid;
using G.Data;
using G.Controls.Base;
using G.BLL.Base;
using G.Entity.ERP;
using G.APP.BaseForm;

namespace G.Erp.Sale.Order
{
    public partial class SM_SALEAUDITLIST : G.APP.BaseForm.BaseList
    {
        public SM_SALEAUDITLIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单审核列表";
            this.listTool = new List<string>() { "导出","打印","过滤","-","新增", "修改", "删除", "刷新" ,"|","退出"};
            this.EntityT = typeof(SM_SALEORDER);
            this.orderby = "ORDERID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_SALEORDERLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("销售订单","ORDERID","String",80),
                new ColumnInfo("订单日期","ORDERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("下单客户","CUSTNAME","String",120),
                new ColumnInfo("开票客户","INVCUSTNAME","String",120),
                new ColumnInfo("订单类型","ORDERTYPENAME","String",80),
                new ColumnInfo("业务员","SALESMANNAME","String",80),
                new ColumnInfo("业务代表","SALESREPNAME","String",80),
                new ColumnInfo("内勤","INOFCNAME","String",80),
                new ColumnInfo("总数量","ORDQTY","Decimal",80),
                new ColumnInfo("总金额","ORDAMOUNT","Decimal",80),
                new ColumnInfo("折扣","ORDDISCOUNT","Decimal",80),
                new ColumnInfo("不开票","INVTAG","Boolean",80),
                new ColumnInfo("状态","STATUS","String",80)
            });
            this.EditorT = typeof(SM_SALEAUDIT);
        }
        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,变动:B", defaultvalue = "N" });
            this.FilterInfos.Add(new FilterInfo() { caption = "日期", fieldname = "ORDERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            
        }
    }
}
