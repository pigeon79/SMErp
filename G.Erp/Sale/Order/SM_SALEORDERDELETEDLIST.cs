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
    public partial class SM_SALEORDERDELETEDLIST : G.APP.BaseForm.BaseList
    {
        public SM_SALEORDERDELETEDLIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单撤销列表";
            this.listTool = new List<string>() { "过滤", "-", "撤销", "刷新", "|", "退出" };
            this.EntityT = typeof(SM_SALEORDER);
            this.orderby = "ORDERID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_SALEORDERLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                //new ColumnInfo("选择","ISSELECT","Boolean",60,false),
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
                new ColumnInfo("状态","STATUSNAME","String",80)
            });
            this.EditorT = typeof(SM_SALEORDERDELETED);
        }
        public override void InitFilter()
        {
            this.DefaultCondition = CK.K["STATUS"].Ne("N");
            this.CurCondition = CK.K["STATUS"].Eq("A");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A,撤销:C", defaultvalue = "A" });
            this.FilterInfos.Add(new FilterInfo() { caption = "日期", fieldname = "ORDERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTID", fieldtype = "Int32", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
        }

        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "撤销":
                    DELETED();
                    break;
            }
            base.ToolButtonClick(name);
        }

        private void DELETED()
        {
            try
            {
                SM_SALEORDER saleorderobj = this.gGrid1.GetCurSelect<SM_SALEORDER>();
                if (saleorderobj == null) return;
                int id = G.Core.GConvert.ToInt(saleorderobj.Id);
                DbEntry.UsingTransaction(delegate
                {
                    string csql = string.Format("UPDATE A SET STATUS='C' FROM SM_SALEORDER A WHERE ID={0}", id);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
                this.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
