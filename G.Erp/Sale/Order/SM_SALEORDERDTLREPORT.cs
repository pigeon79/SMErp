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

namespace G.Erp.Sale.Order
{
    public partial class SM_SALEORDERDTLREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_SALEORDERDTLREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单明细查询";
            this.listTool = new List<string>() { "刷新", "-", "导出", "过滤", "|", "退出" };
            this.orderby = "ORDERID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_SALEORDERLogic();
            this.Csql = "RPT_XS0002";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("下单客户","CUSTNAME","String",120),
                new ColumnInfo("销售订单","ORDERID","String",80),
                new ColumnInfo("订单日期","ORDERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("物品代码","ITEMCODE","String",80),
                new ColumnInfo("物品名称","ITEMNAME","String",120),
                new ColumnInfo("色号","COLOR","String",80),
                new ColumnInfo("工艺色号A","TCOLORA","String",80),
                new ColumnInfo("工艺色号B","TCOLORB","String",120),
                new ColumnInfo("规格mm","SIZEA","Decimal","#0.0",60),
                new ColumnInfo("花模A","MOULDA","String",80),
                new ColumnInfo("花模B","MOULDBNAME","String",80),
                new ColumnInfo("花模C","MOULDC","String",80),
                new ColumnInfo("花模D","MOULDD","String",80),
                new ColumnInfo("款号","STYLENO","String",80),
                ColumnInfo.Initialize("数量","LNQTY","Decimal","#0",60,true),
                new ColumnInfo("基本价格","BASICPRICE","Decimal","#0.00",60),
                new ColumnInfo("花模加价","MOULDPRICE","Decimal","#0.00",60),
                new ColumnInfo("工艺色号加价","TCOLORPRICE","Decimal","#0.00",60),
                new ColumnInfo("其他加价","OTHERPRICE","Decimal","#0.00",60),
                new ColumnInfo("计划价格","PLANPRICE","Decimal","#0.00",60),
                new ColumnInfo("实际价格","LNPRICE","Decimal","#0.00",60),
                new ColumnInfo("实际金额","LNAMOUNT","Decimal","#0.00",60),
                new ColumnInfo("折扣","LNDISCOUNT","Decimal",60),
                new ColumnInfo("是否出样","SAMPLETAG","Boolean",60),
                new ColumnInfo("合同号","CUSTORDNB","String",100),
                new ColumnInfo("开票客户","INVCUSTNAME","String",120),
                new ColumnInfo("订单类型","ORDERTYPENAME","String",80),
                new ColumnInfo("业务员","SALESMANNAME","String",80),
                new ColumnInfo("业务代表","SALESREPNAME","String",80),
                new ColumnInfo("内勤","INOFCNAME","String",80),
                new ColumnInfo("不开票","INVTAG","Boolean",80),
                new ColumnInfo("交期","PRODATE","DateTime",80),
                new ColumnInfo("状态","STATUSNAME","String",80)
            });
        }

        public override void InitFilter()
        {
            this.DefaultCondition = CK.K["STATUS"].Eq("A");
            this.FilterInfos.Add(new FilterInfo() { caption = "日期", fieldname = "ORDERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTID", fieldtype = "Int32", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单类型", fieldname = "ORDERTYPE", fieldtype = "String", controltype = "combox", controldata = "全部:,销售订单:1,打样订单:2,备料订单:3" });
        }
    }
}
