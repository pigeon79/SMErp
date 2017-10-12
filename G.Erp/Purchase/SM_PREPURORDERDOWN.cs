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
    public partial class SM_PREPURORDERDOWN : G.APP.BaseForm.BaseReport
    {
        public SM_PREPURORDERDOWN()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "采购申请下达";
            this.listTool = new List<string>() { "刷新", "-", "过滤", "-", "下达", "|", "退出" };
            this.EntityT = typeof(SM_PREPURORDER);
            this.orderby = "PREPURORDID DESC";
            this.Logic = new G.BLL.ERP.Purchase.SM_PREPURORDERLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("选择","ISSELECT","Boolean",60,false),
                new ColumnInfo("申请单号","PREPURORDID","String",80),
                new ColumnInfo("物品名称","ITEMNAME","String",80),
                new ColumnInfo("色号","ATTRIBUTEA","String",80),
                new ColumnInfo("花模","ATTRIBUTEBNAME","String",80),
                new ColumnInfo("尺寸","ATTRIBUTEC","Decimal",80),
                new ColumnInfo("需求数量","PREPURQTY","Decimal",80),
                new ColumnInfo("计量单位","INVUNIT","String",80),
                new ColumnInfo("供应商","SUPPNAME","String",80),
                new ColumnInfo("状态","STATUSNAME","String",80),
                new ColumnInfo("需求部门","DEPNAME","String",80),
                new ColumnInfo("需求日期","DEMANDDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("申请人","APPLYUSERNAME","String",80),
                new ColumnInfo("申请日期","APPLYDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("审核人","AUDITORNAME","String",80),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("采购员","PURUSERNAME","String",80),
                new ColumnInfo("采购类别","PURTYPE","String",80),
                new ColumnInfo("订单号","ORDERID","String",80),
                new ColumnInfo("订单行号","ORDLNNO","Int32",80),
                new ColumnInfo("备注","REMARK","String",80),
                new ColumnInfo("制单人","OPERATORNAME","String",80),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80)
            });
            IsChecked();
            this.DefaultCondition = CK.K["STATUS"].Eq("A");
        }

        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A" });
            this.FilterInfos.Add(new FilterInfo() { caption = "申请日期", fieldname = "APPLYDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "申请人", fieldname = "APPLYUSER", fieldtype = "String", controltype = "dropdown", controldata = "USER", searchLogic = new G.BLL.Sys.ND_UserLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "申请单号", fieldname = "PREPURORDID", fieldtype = "String", islike = true });
        }

        public override void ToolButtonClick(string name)
        {
            try
            {
                switch (name)
                {
                    case "下达":
                        XDPorder();
                        break;
                }
                base.ToolButtonClick(name);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void XDPorder()
        {
            string id = "";
            foreach (object o in this.DataSource)
            {
                SM_PREPURORDER d = o as SM_PREPURORDER;
                if (d.ISSELECT == true)
                {
                    id += d.Id.ToString() + ",";
                }
            }
            id = id.Substring(0, id.Length - 1);
            new G.BLL.ERP.Purchase.SM_PREPURORDERLogic().XD(G.AppInfo.GGlobal.User, id);
            //MessageBox.Show("下达完成！");
            this.RefreshData();
        }
    }
}
