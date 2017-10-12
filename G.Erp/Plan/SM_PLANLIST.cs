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

namespace G.Erp.Plan
{
    public partial class SM_PLANLIST : G.APP.BaseForm.BaseList
    {
        public SM_PLANLIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "计划列表";
            this.listTool = new List<string>() { "过滤", "-", "刷新", "|", "退出" };
            this.EntityT = typeof(SM_SALEORDER);
            this.orderby = "ORDERID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_SALEORDERLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("计划状态","ORDSTATUSNAME","String",80),
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
                new ColumnInfo("订单状态","STATUSNAME","String",80)
            });
        }
        public override void Modify()
        {
            try
            {
                SM_SALEORDER order = this.gGrid1.GetCurSelect<SM_SALEORDER>();
                if (order != null)
                {
                    string csql = string.Format("exec SMProc_SaleOrder2BomTemp '{0}','{1}' ", order.ORDERID, G.AppInfo.GGlobal.User.USERDM);
                    DbEntry.Provider.ExecuteNonQueryUsingTransaction(csql);
                    SM_PLAN planform = new SM_PLAN();
                    planform.SetPara(order);
                    planform.ShowDialog();

                    RefreshData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public override void InitFilter()
        {
            this.DefaultCondition = CK.K["STATUS"].Eq("A") & CK.K["POCKETTAG"].Eq(0); 
            this.FilterInfos.Add(new FilterInfo() { caption = "日期", fieldname = "ORDERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTID", fieldtype = "Int32", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
        }
    }
}

