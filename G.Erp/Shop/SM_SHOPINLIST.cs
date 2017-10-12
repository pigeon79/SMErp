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

namespace G.Erp.Shop
{
    public partial class SM_SHOPINLIST : G.APP.BaseForm.BaseList
    {
        public SM_SHOPINLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "完工入库";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_SHOPIN);
            this.EditorT = typeof(SM_SHOPINEDIT);
            this.orderby = "SHOPINID DESC";
            this.Logic = new G.BLL.ERP.Shop.SM_SHOPINLogic();
            this.AuditField = "STATUS";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("完工入库单号","SHOPINID","String",80),
                new ColumnInfo("物品名称","ITEMNAME","String",80),
                new ColumnInfo("色号","ATTRIBUTEA","String",80),
                new ColumnInfo("花模","ATTRIBUTEBNAME","String",80),
                new ColumnInfo("尺寸","ATTRIBUTEC","Decimal",80),
                new ColumnInfo("入库数量","INQTY","Decimal",80),
                new ColumnInfo("计量单位","INVUNIT","String",80),
                new ColumnInfo("公斤数","WEIGHT","Decimal",80),
                new ColumnInfo("折率","RATE","Decimal",80),
                new ColumnInfo("仓库","WRHSNAME","String",80),
                new ColumnInfo("库位","LOCNAME","String",80),
                new ColumnInfo("状态","STATUSNAME","String",80),
                new ColumnInfo("车间","WORKSHOPNAME","String",80),
                new ColumnInfo("完工日期","FINISHDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("审核人","AUDITORNAME","String",80),
                new ColumnInfo("审核日期","AUDITDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("备注","REMARK","String",80),
                new ColumnInfo("制单人","OPERATORNAME","String",80),
                new ColumnInfo("制单日期","OPERDATE","DateTime","yyyy-MM-dd",80)
            });
        }

        public override void InitFilter()
        {
            this.CurCondition = CK.K["STATUS"].Eq("N");
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A", defaultvalue = "N" });
            this.FilterInfos.Add(new FilterInfo() { caption = "完工日期", fieldname = "FINISHDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "完工入库单号", fieldname = "SHOPINID", fieldtype = "String", islike = true });

        }
    }
}
