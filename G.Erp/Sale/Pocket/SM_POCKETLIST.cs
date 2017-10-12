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
    public partial class SM_POCKETLIST : G.APP.BaseForm.BaseList
    {
        public SM_POCKETLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "装箱单列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_POCKET);
            this.EditorT = typeof(SM_POCKETEDIT);
            this.orderby = "POCKID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_POCKETLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("装箱单号","POCKID","String",80),
                new ColumnInfo("销售订单号","ORDERID","String",80),
                new ColumnInfo("装箱人","POCKETERNAME","String",80),
                new ColumnInfo("装箱日期","POCKETDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("状态","STATUSNAME","String",30),
                new ColumnInfo("装箱总数量","TOTALQTY","Decimal","#0.0",70),
                new ColumnInfo("入库单号","RKID","String",80),
                new ColumnInfo("入库日期","RKDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("出库单号","CKID","String",80),
                new ColumnInfo("出库日期","CKDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("审核人","AUDITORNAME","String",60),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("制单人","OPERATORNAME","String",60),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("备注","REMARK","String",100),
                new ColumnInfo("条码","BARCODE","String",80)
            });
        }
        public override void Modify()
        {
            try
            {
                if (this.EditorT != null)
                {
                    DateTime time1 = DateTime.Now;

                    BaseEditor editor = System.Activator.CreateInstance(this.EditorT) as BaseEditor;
                    editor.ShowInTaskbar = false;
                    editor.StartPosition = FormStartPosition.CenterScreen;
                    SM_POCKET obj = gGrid1.GetCurSelect<SM_POCKET>();
                    editor.SetData(obj);
                    var audit = G.Core.ClassHelper.GetFieldValue(obj, AuditField) != null ? G.Core.ClassHelper.GetFieldValue(obj, AuditField).ToString() : "";
                    if (audit != "N") { editor.CurEditStatus = EditorStatus.Look; }
                    else
                    {
                        editor.CurEditStatus = EditorStatus.Modify;
                    } DateTime time2 = DateTime.Now;
                    G.AppInfo.GGlobal.SetInfo((time2 - time1).TotalSeconds.ToString());
                    editor.ShowDialog();
                    RefreshData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A", defaultvalue = "N" });
            this.FilterInfos.Add(new FilterInfo() { caption = "装箱日期", fieldname = "POCKETDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "装箱人", fieldname = "POCKETER", fieldtype = "String", controltype = "dropdown", controldata = "USER", searchLogic = new G.BLL.Sys.ND_UserLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "装箱单号", fieldname = "POCKID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "审核日期", fieldname = "AUDITDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "入库单号", fieldname = "RKID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "入库日期", fieldname = "RKDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "出库单号", fieldname = "CKID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "出库日期", fieldname = "CKDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "销售订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            //this.FilterInfos.Add(new FilterInfo() { caption = "是否补差价单", fieldname = "ISPRICEDIFF", fieldtype = "Boolean", controltype = "checkbox" });
        }
    }
}
