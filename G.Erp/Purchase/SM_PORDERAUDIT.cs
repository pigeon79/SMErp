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
using G.Data.Definition;

namespace G.Erp.Purchase
{
    public partial class SM_PORDERAUDIT : G.APP.BaseForm.BaseList
    {
        public SM_PORDERAUDIT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "采购订单审核";
            this.listTool = new List<string>() {  "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_PORDER);
            this.EditorT = typeof(SM_PORDEREDIT);
            this.orderby = "POID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_PORDERLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("采购订单号","POID","String",80),
                new ColumnInfo("订单类型","POTYPENAME","String",80),
                new ColumnInfo("状态","STATUSNAME","String",30),
                new ColumnInfo("供应商","SUPPNAME","String",100),
                new ColumnInfo("合计金额","TOTALAMT","Decimal",60),
                new ColumnInfo("税率","TAXRATE","Decimal",30),
                new ColumnInfo("备注","REMARK","String",100),
                new ColumnInfo("审核人","AUDITORNAME","String",60),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("制单人","OPERATORNAME","String",60),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80)
            });
        }

        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A,结清:C", defaultvalue = "N" });
            this.FilterInfos.Add(new FilterInfo() { caption = "制单日期", fieldname = "OPERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "采购订单号", fieldname = "POID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "供应商", fieldname = "SUPCODE", fieldtype = "String", controltype = "dropdown", controldata = "SUPPLIER", searchLogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic(), islike = false });
        }
        public override void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.EditorT != null)
                {
                    DateTime time1 = DateTime.Now;
                    BaseEditor editor = System.Activator.CreateInstance(this.EditorT) as BaseEditor;
                    editor.ShowInTaskbar = false;
                    editor.StartPosition = FormStartPosition.CenterScreen;
                    IDbObject obj = gGrid1.GetCurSelect<IDbObject>();
                    editor.SetData(obj);
                    var audit = G.Core.ClassHelper.GetFieldValue(obj, AuditField) != null ? G.Core.ClassHelper.GetFieldValue(obj, AuditField).ToString() : "";

                    editor.CurEditStatus = EditorStatus.Audit;
                    editor.listTool = new List<string>() { "预览", "打印", "|", "审核", "反审", "|", "供应商","|","结清","反结清", "|", "退出" };

                    DateTime time2 = DateTime.Now;
                    G.AppInfo.GGlobal.SetInfo((time2 - time1).TotalSeconds.ToString());
                    editor.ShowDialog();
                    RefreshData();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
