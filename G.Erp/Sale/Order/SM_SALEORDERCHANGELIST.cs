﻿using System;
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
    public partial class SM_SALEORDERCHANGELIST : G.APP.BaseForm.BaseList
    {
        public SM_SALEORDERCHANGELIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单列表";
            this.listTool = new List<string>() { "过滤", "-",  "刷新", "|", "退出" };
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
            this.EditorT = typeof(SM_SALEORDEREDIT);
        }
        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("B");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "审核:A,变动:B", defaultvalue = "B" });
            this.FilterInfos.Add(new FilterInfo() { caption = "日期", fieldname = "ORDERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTID", fieldtype = "Int32", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
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
                        string csql = string.Format("INSERT INTO SM_SALEORDER_DEL(ID,ORDERID,ORDERDATE,CUSTID,INVCUSTID,ORDERTYPE,FTTAG,RECADDRESS,STATUS,SALESMAN,SALESREP,INOFC,REMARK,INVTAG,ORDQTY,ORDAMOUNT,ORDDISCOUNT,MAGTAG,CLOTHTYPE,THICK,REQDATE,PROTAG,OPERATOR,OPERDATE,CUSTORDNB,AUDITOR,AUDITDATE,SUPPTAG,OTHAMOUNT) SELECT ID,ORDERID,ORDERDATE,CUSTID,INVCUSTID,ORDERTYPE,FTTAG,RECADDRESS,STATUS,SALESMAN,SALESREP,INOFC,REMARK,INVTAG,ORDQTY,ORDAMOUNT,ORDDISCOUNT,MAGTAG,CLOTHTYPE,THICK,REQDATE,PROTAG,OPERATOR,OPERDATE,CUSTORDNB,AUDITOR,AUDITDATE,SUPPTAG,OTHAMOUNT FROM SM_SALEORDER WHERE ORDERID='{0}'", orderid);
                        DbEntry.Provider.ExecuteNonQuery(csql);
                        string csql1 = string.Format("INSERT INTO SM_SALEORDERDTL_DEL(ID,SALEORDERID,ORDERID,ORDLNNO,ITEMCODE,COLOR,TCOLORA,TCOLORB,SIZEA,MOULDA,MOULDB,MOULDC,MOULDD,STYLENO,LNQTY,BASICPRICE,MOULDPRICE,TCOLORPRICE,OTHERPRICE,ADDPRICE,PLANPRICE,LNPRICE,LNAMOUNT,NEEDING,LNDISCOUNT,SAMPLETAG,QCTAG) SELECT * FROM SM_SALEORDERDTL WHERE ORDERID='{0}'", orderid);
                        DbEntry.Provider.ExecuteNonQuery(csql1);
                        string csql2 = string.Format("delete from SM_SALEORDER where ORDERID='{0}'", orderid);
                        DbEntry.Provider.ExecuteNonQuery(csql2);
                        string csql3 = string.Format("delete from SM_SALEORDERDTL where ORDERID='{0}'", orderid);
                        DbEntry.Provider.ExecuteNonQuery(csql3);
                    });
                    this.RefreshData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Modify()
        {
            try
            {
                if (this.EditorT != null)
                {
                    BaseEditor editor = System.Activator.CreateInstance(this.EditorT) as BaseEditor;
                    editor.ShowInTaskbar = false;
                    editor.StartPosition = FormStartPosition.CenterScreen;
                    SM_SALEORDER obj = gGrid1.GetCurSelect<SM_SALEORDER>();
                    editor.SetData(obj);
                    var audit = G.Core.ClassHelper.GetFieldValue(obj, AuditField) != null ? G.Core.ClassHelper.GetFieldValue(obj, AuditField).ToString() : "";
                    //if (audit == "A") { editor.CurEditStatus = EditorStatus.Look; }
                    //else
                    //{
                        editor.CurEditStatus = EditorStatus.Modify;
                    //} 
                    editor.ShowDialog();
                    RefreshData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
