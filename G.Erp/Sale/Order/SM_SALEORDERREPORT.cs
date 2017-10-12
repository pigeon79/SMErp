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
    public partial class SM_SALEORDERREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_SALEORDERREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单查询";
            this.listTool = new List<string>() { "刷新", "-", "导出", "过滤", "|", "退出" };
            this.orderby = "ORDERID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_SALEORDERLogic();
            this.Csql = "RPT_XS0001";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("销售订单","ORDERID","String",80),
                new ColumnInfo("订单日期","ORDERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("下单客户","CUSTNAME","String",120),
                new ColumnInfo("开票客户","INVCUSTNAME","String",120),
                new ColumnInfo("订单类型","ORDERTYPENAME","String",60),
                new ColumnInfo("业务员","SALESMANNAME","String",60),
                new ColumnInfo("业务代表","SALESREPNAME","String",60),
                new ColumnInfo("内勤","INOFCNAME","String",60),
                ColumnInfo.Initialize("总数量","ORDQTY","Decimal","#0",80,true),
                ColumnInfo.Initialize("装箱数","CKQTY","Decimal","#0",80,true),
                ColumnInfo.Initialize("出库数","POCKETQTY","Decimal","#0",80,true),
                ColumnInfo.Initialize("总金额","ORDAMOUNT","Decimal","#0.00",80,true),
                new ColumnInfo("折扣","ORDDISCOUNT","Decimal","#0.00",40),
                new ColumnInfo("不开票","INVTAG","Boolean",40),
                new ColumnInfo("状态","STATUSNAME","String",40),
                new ColumnInfo("物品类型","SALEITEMTYPE","String",80),
                new ColumnInfo("装箱完成","POCKETTAG","Boolean",40)
            });
        }

        public override void InitFilter()
        {
            this.DefaultCondition = CK.K["STATUS"].Eq("A");
            this.FilterInfos.Add(new FilterInfo() { caption = "日期", fieldname = "ORDERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTID", fieldtype = "Int32", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "物品类型", fieldname = "SALEITEMTYPE", fieldtype = "String", controltype = "combox", controldata = "全部:,塑胶:塑胶,五金:五金" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单类型", fieldname = "ORDERTYPE", fieldtype = "String", controltype = "combox", controldata = "全部:,销售订单:1,打样订单:2,备料订单:3" });
        }

        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            DataRow drow = this.GetCurSelect();
            if (drow == null) return;
            SM_SALELOOK oFrm = new SM_SALELOOK();
            int id = G.Core.GConvert.ToInt(drow["ID"]);
             var data=(this.Logic as IBaseBLL).IFindObject(G.AppInfo.GGlobal.User, id);
             oFrm.CurEditStatus = EditorStatus.Look;
             oFrm.SetData(data);
            oFrm.ShowDialog();
            this.RefreshData();
        }
    }
}
