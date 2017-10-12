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

namespace G.Erp.AccRec
{
    public partial class SM_XSKPLIST : G.APP.BaseForm.BaseList
    {
        public SM_XSKPLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "销售开票列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_XSKP);
            this.EditorT = typeof(SM_XSKPEDIT);
            this.orderby = "ID DESC";
            this.Logic = new G.BLL.ERP.AccRec.SM_XSKPLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("开票单号","NO","String",80),
                new ColumnInfo("金穗发票","FPNO","String",80),
                new ColumnInfo("状态","STATUSNAME","String",30),
                new ColumnInfo("下单客户","CUSTNAME","String",200),
                new ColumnInfo("开票客户","INVCUSTNAME","String",200),
                new ColumnInfo("销售员","JBRLBNAME","String",60),
                new ColumnInfo("合计数量","SUMQTY","Decimal",60),
                new ColumnInfo("合计含税金额","SUMVAT","Decimal",80),
                new ColumnInfo("合计不含税金额","SUMVOT","Decimal",80),
                new ColumnInfo("合计税金","SUMTAX","Decimal",60),
                new ColumnInfo("审核人","AUDITORNAME","String",60),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("制单人","OPERATORNAME","String",60),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("作废","ISINVALID","Boolean",80),
                new ColumnInfo("冲回","ISREVERSE","Boolean",80),
                new ColumnInfo("红冲","ISRED","Boolean",80)
            });
        }

        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A,结清:C" ,defaultvalue="N"});
            this.FilterInfos.Add(new FilterInfo() { caption = "开票单号", fieldname = "NO", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "金穗发票", fieldname = "FPNO", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "制单日期", fieldname = "OPERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "审核日期", fieldname = "AUDITDATE", fieldtype = "DateTime", controltype = "datetime", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "下单客户", fieldname = "CUSTID", fieldtype = "String", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "开票客户", fieldname = "INVCUSTID", fieldtype = "String", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
        }
    }
}
