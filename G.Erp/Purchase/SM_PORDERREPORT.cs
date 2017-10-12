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

namespace G.Erp.Purchase
{
    public partial class SM_PORDERREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_PORDERREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "采购订单查询";
            this.listTool = new List<string>() { "预览", "打印", "-", "刷新", "-", "过滤", "|", "退出" };
            this.orderby = "POID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_PORDERLogic();
            this.Csql = "RPT_CG0002";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("采购订单号","POID","String",80),
                //new ColumnInfo("采购申请单号","PREPURORDID","String",80),
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
            //this.DefaultCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A,结清:C" });
            this.FilterInfos.Add(new FilterInfo() { caption = "制单日期", fieldname = "OPERDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "采购订单号", fieldname = "POID", fieldtype = "String", islike = true });
            //this.FilterInfos.Add(new FilterInfo() { caption = "采购申请单号", fieldname = "PREPURORDID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "供应商", fieldname = "SUPCODE", fieldtype = "String", controltype = "dropdown", controldata = "SUPPLIER", searchLogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic(), islike = false });
            //this.FilterInfos.Add(new FilterInfo() { caption = "物品名称", fieldname = "ITEMCODE", fieldtype = "String", controltype = "dropdown", controldata = "ITEM", searchLogic = new G.BLL.ERP.BaseData.DM_ITEMLogic(), islike = false });
            //this.FilterInfos.Add(new FilterInfo() { caption = "供应商", fieldname = "SUPCODE", fieldtype = "String", controltype = "dropdown", controldata = "SUPPLIER", searchLogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic(), islike = false });
        }

        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "预览":
                    POPrint(false);
                    break;
                case "打印":
                    POPrint(true);
                    break;
            }
            base.ToolButtonClick(name);
        }

        public void POPrint(bool isPrint)
        {
            try
            {
                DataRow drow = this.GetCurSelect();
                if (drow == null) return;
                string poid = G.Core.GConvert.ToString(drow["POID"]);
                string condition = string.Format("poid='{0}'", poid);
                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Pur\PORDER.frx", new List<string>() { "Master", "Detail" }, "poprint", condition);
                printobj.Print(isPrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
    }
}
