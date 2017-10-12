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
    public partial class SM_SALEORDERLIST : G.APP.BaseForm.BaseList
    {
        public SM_SALEORDERLIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单列表";
            this.listTool = new List<string>() { "导出", "打印", "过滤", "-", "新增", "修改", "删除", "刷新", "|", "退出" };
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
                new ColumnInfo("状态","STATUSNAME","String",80),
                new ColumnInfo("物品类型","SALEITEMTYPE","String",80)
            });
            this.EditorT = typeof(SM_SALEORDEREDIT);
        }
        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A", defaultvalue = "N" });
            this.FilterInfos.Add(new FilterInfo() { caption = "日期", fieldname = "ORDERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTID", fieldtype = "Int32", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "物品类型", fieldname = "SALEITEMTYPE", fieldtype = "String", controltype = "combox", controldata = "全部:,塑胶:塑胶,五金:五金" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单类型", fieldname = "ORDERTYPE", fieldtype = "String", controltype = "combox", controldata = "全部:,销售订单:1,打样订单:2,备料订单:3" });
        }

        public override void Delete()
        {
            try
            {
                
                SM_SALEORDER saleorderobj = this.gGrid1.GetCurSelect<SM_SALEORDER>();
                if (saleorderobj == null) return;
                string orderid = G.Core.GConvert.ToString(saleorderobj.ORDERID);
                string sql = string.Format("select * from SM_POCKET where ORDERID='{0}'", orderid);
                DataSet ds = DbEntry.Provider.ExecuteDataset(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("该订单已装箱不能删除！");
                    return;
                }
                DialogResult dr = MessageBox.Show("是否删除单据!", "提示", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DbEntry.UsingTransaction(delegate
                    {
                        string csql = string.Format("exec SMProc_SaleOrderDelete '{0}','{1}'", orderid,G.AppInfo.GGlobal.User.USERDM);
                        DbEntry.Provider.ExecuteNonQuery(csql);
                    });
                    this.RefreshData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
