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

namespace G.Erp.BaseData
{
    public partial class DM_SUPPLIERLIST : G.APP.BaseForm.BaseList
    {
        public DM_SUPPLIERLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "供应商";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(DM_SUPPLIER);
            this.EditorT = typeof(DM_SUPPLIEREDIT);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("供应商代码","SUPPCODE","String",80),
                new ColumnInfo("供应商名称","SUPPNAME","String",80),
                new ColumnInfo("供应商等级","SUPPLEV","String",80),
                //new ColumnInfo("物品类别","PRDTYPE","String",80),
                new ColumnInfo("建立日期","FOUNDDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("助记符","PY","String",80),
                new ColumnInfo("供应商类型","SUPPTYPE","String",80),
                new ColumnInfo("供应商主业","SUPPOR","String",80),
                new ColumnInfo("主业描述","SUPPDESC","String",80),
                new ColumnInfo("法人代表","BOSS","String",80),
                new ColumnInfo("法人电话","TEL","String",80),
                new ColumnInfo("联系人","CONTACTS","String",80),
                new ColumnInfo("联系电话","CONTEL","String",80),
                new ColumnInfo("地址","ADDRESS","String",80),
                new ColumnInfo("传真","FAX","String",80),
                new ColumnInfo("业务电话","SUPPTEL","String",80),
                new ColumnInfo("产量","PRDCOUNT","Int32",80),
                new ColumnInfo("品质","QS","String",80),
                new ColumnInfo("服务","SERVER","String",80),
                new ColumnInfo("付款方式","PAYTYPE","String",80),
                new ColumnInfo("区域","AREA","String",80),
                new ColumnInfo("开户银行","BANK","String",80),
                new ColumnInfo("开户账号","BANKACCOUNT","String",80),
                new ColumnInfo("备注","REMARK","String",80)
            });
        }

        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "建立日期", fieldname = "FOUNDDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "供应商名称", fieldname = "SUPPNAME", fieldtype = "String", islike = true });

        }
    }
}
