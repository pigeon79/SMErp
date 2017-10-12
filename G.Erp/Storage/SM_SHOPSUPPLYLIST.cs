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

namespace G.Erp.Storage
{
    public partial class SM_SHOPSUPPLYLIST : G.APP.BaseForm.BaseList
    {
        public SM_SHOPSUPPLYLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "领料列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_SHOPSUPPLY);
            this.EditorT = typeof(SM_SHOPSUPPLYEDIT);
            this.orderby = "SUPPLYID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_SHOPSUPPLYLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("领料单号","SUPPLYID","String",80),
                new ColumnInfo("状态","STATUSNAME","String",30),
                new ColumnInfo("领料部门","ORGNAME","String",80),
                new ColumnInfo("备注","REMARK","String",80),
                new ColumnInfo("申请人","APPLYERNAME","String",80),
                new ColumnInfo("申请日期","APPLYDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("审核人","AUDITORNAME","String",60),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("制单人","OPERATORNAME","String",60),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80),
            });
        }

        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A", defaultvalue = "N" });
            this.FilterInfos.Add(new FilterInfo() { caption = "申请日期", fieldname = "APPLYDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "申请人", fieldname = "APPLYER", fieldtype = "String", controltype = "dropdown", controldata = "USER", searchLogic = new G.BLL.Sys.ND_UserLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "领料单号", fieldname = "SUPPLYID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "领料部门", fieldname = "WORKSHOP", fieldtype = "String", controltype = "dropdown", controldata = "ORG", searchLogic = new G.BLL.Sys.ND_ORGINAZITIONLogic(), islike = false });

        }
    }
}
