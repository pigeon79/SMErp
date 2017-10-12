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

namespace G.Erp.Assist
{
    public partial class SM_ASSISTMENTRYREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_ASSISTMENTRYREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "外协入库单查询";
            this.listTool = new List<string>() { "刷新", "-", "过滤", "|", "退出" };
            this.orderby = "ASSISTMECODE DESC";
            this.Logic = new G.BLL.ERP.Assist.SM_ASSISTMENTRYLogic();
            this.Csql = "RPT_WX0002";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("外协入库单号","ASSISTMECODE","String",80),
                new ColumnInfo("外协领料单号","ASSISTMSCODE","String",80),
                new ColumnInfo("外协入库日期","ASSISTMEDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("物品名称","ITEMNAME","String",80),
                new ColumnInfo("色号","ATTRIBUTEA","String",80),
                new ColumnInfo("花模","ATTRIBUTEBNAME","String",80),
                new ColumnInfo("尺寸","ATTRIBUTEC","Decimal",80),
                new ColumnInfo("领料单数量","FACTQTY","Decimal",80),
                new ColumnInfo("合格数","CHECKQTY","Decimal",80),
                new ColumnInfo("验收员","CHECKEDPERNAME","String",80),
                new ColumnInfo("计量单位","UNIT","String",80),
                new ColumnInfo("仓库","WRHSNAME","String",80),
                new ColumnInfo("库位","LOCNAME","String",80),
                new ColumnInfo("状态","STATUSNAME","String",80),
                new ColumnInfo("审核人","AFFIRMERNAME","String",80),
                new ColumnInfo("审核日期","AFFIRMDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("备注","MEMO","String",80),
                new ColumnInfo("制单人","OPERATORNAME","String",80),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80)
            });
        }

        public override void InitFilter()
        {
            //this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A", defaultvalue = "N" });
            this.FilterInfos.Add(new FilterInfo() { caption = "外协领料单号", fieldname = "ASSISTMSCODE", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "外协入库日期", fieldname = "ASSISTMEDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "外协入库单号", fieldname = "ASSISTMECODE", fieldtype = "String", islike = true });
        }
    }
}
