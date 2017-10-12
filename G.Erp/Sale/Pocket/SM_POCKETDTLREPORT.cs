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

namespace G.Erp.Sale.Pocket
{
    public partial class SM_POCKETDTLREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_POCKETDTLREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "装箱单明细查询";
            this.listTool = new List<string>() { "刷新", "-", "导出", "过滤", "|", "退出" };
            this.orderby = "POCKID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_POCKETLogic();
            this.Csql = "RPT_XS0003";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("下单客户","SALECUSTNAME","String",120),
                new ColumnInfo("订单日期","ORDERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("装箱单号","POCKID","String",80),
                new ColumnInfo("销售订单号","ORDERID","String",80),
                new ColumnInfo("装箱人","POCKETERNAME","String",80),
                new ColumnInfo("装箱日期","POCKETDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("状态","STATUSNAME","String",30),
                new ColumnInfo("物品代码","ITEMCODE","String",80),
                new ColumnInfo("物品名称","ITEMNAME","String",80),
                new ColumnInfo("单位","UNIT","String",30),
                new ColumnInfo("装箱数","POCKETQTY","Decimal",80),
                new ColumnInfo("色号","ATTRIBUTEA","String",80),
                new ColumnInfo("花模","ATTRIBUTEBNAME","String",80),
                new ColumnInfo("尺寸","ATTRIBUTEC","Decimal",60),
                new ColumnInfo("款号","STYLENO","String",80),

                new ColumnInfo("审核人","AUDITORNAME","String",60),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("制单人","OPERATORNAME","String",60),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("备注","REMARK","String",100),
                new ColumnInfo("条码","BARCODE","String",80),

                //new ColumnInfo("开票客户","INVCUSTNAME","String",120),
                //new ColumnInfo("订单类型","ORDERTYPENAME","String",80),
                //new ColumnInfo("业务员","SALESMANNAME","String",80),
                //new ColumnInfo("业务代表","SALESREPNAME","String",80),
                //new ColumnInfo("内勤","INOFCNAME","String",80),
                //new ColumnInfo("不开票","INVTAG","Boolean",80)
            });
        }

        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "订单日期", fieldname = "ORDERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "装箱日期", fieldname = "POCKETDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTID", fieldtype = "Int32", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "装箱状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A,入库:I,出库:O" });
            this.FilterInfos.Add(new FilterInfo() { caption = "入库日期", fieldname = "RKDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "出库日期", fieldname = "CKDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            
        }
    }
}
