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
    public partial class SM_POCKETIN : G.APP.BaseForm.BaseList
    {
        public SM_POCKETIN()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "装箱单入库";
            this.listTool = new List<string>() { "入库", "-", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_POCKET);
            this.orderby = "POCKID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_POCKETLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("装箱单号","POCKID","String",80),
                new ColumnInfo("销售订单号","ORDERID","String",80),
                new ColumnInfo("装箱人","POCKETERNAME","String",80),
                new ColumnInfo("装箱日期","POCKETDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("状态","STATUSNAME","String",30),
                new ColumnInfo("装箱总数量","TOTALQTY","Decimal",60),
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

        public override void InitFilter()
        {
            this.DefaultCondition = CK.K["STATUS"].Eq("A");
            this.FilterInfos.Add(new FilterInfo() { caption = "装箱日期", fieldname = "POCKETDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "装箱人", fieldname = "POCKETER", fieldtype = "String", controltype = "dropdown", controldata = "USER", searchLogic = new G.BLL.Sys.ND_UserLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "装箱单号", fieldname = "POCKID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "审核日期", fieldname = "AUDITDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
        }

        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "入库":
                    PocketIn();
                    break;
            }
            base.ToolButtonClick(name);
        }
        private void PocketIn()
        {
            try
            {
                SM_POCKET pocketobj = this.gGrid1.GetCurSelect<SM_POCKET>();
                if (pocketobj == null) return;
                int id = G.Core.GConvert.ToInt(pocketobj.Id);
                string rkid = BaseExtends.GetNewAutoNo("RK");
                string rker = G.Core.GConvert.ToString(G.AppInfo.GGlobal.User.USERDM);
                DbEntry.UsingTransaction(delegate
                {
                    string csql = string.Format("update a set STATUS='I',RKID='{0}',RKDATE=GETDATE(),RKER='{1}' FROM SM_POCKET a where ID={2} ", rkid, rker, id);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
                this.RefreshData();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public override void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            SM_POCKET pocketobj = this.gGrid1.GetCurSelect<SM_POCKET>();
            if (pocketobj == null) return;
            SM_POCKETLOOK oFrm = new SM_POCKETLOOK();
            oFrm.CurEditStatus = EditorStatus.Look;
            oFrm.SetData(pocketobj);
            oFrm.ShowDialog();
            this.RefreshData();
        }
    }
}