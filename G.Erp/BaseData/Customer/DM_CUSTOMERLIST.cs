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
    public partial class DM_CUSTOMERLIST : G.APP.BaseForm.BaseList
    {
        public DM_CUSTOMERLIST()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo() {
            this.listCaption = "客户列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(DM_CUSTOMER);
            this.EditorT = typeof(DM_CUSTOMEREDIT);
            this.orderby = "CUSTCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("客户代码","CUSTCODE","String",80),
                new ColumnInfo("客户名称","CUSTNAME","String",80),
                new ColumnInfo("客户等级","CUSTLEV","String",80),
                new ColumnInfo("建立日期","FOUNDDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("销售员","SALESMANNAME","String",80),
                new ColumnInfo("销售代表","SALESREPNAME","String",80),
                new ColumnInfo("销售内勤","INOFCNAME","String",80),
                new ColumnInfo("客户类型","CUSTTYPE","String",80),
                new ColumnInfo("法人代表","BOSS","String",80),
                new ColumnInfo("法人电话","TEL","String",80),
                new ColumnInfo("联系人","CONTACTS","String",80),
                new ColumnInfo("联系电话","CONTEL","String",80),
                new ColumnInfo("地址","ADDRESS","String",80),
                new ColumnInfo("传真","FAX","String",80),
                new ColumnInfo("采购员","BUYERNAME","String",80),
                new ColumnInfo("采购员电话","BUYTEL","String",80),
                new ColumnInfo("开票客户","INVCUSTNAME","String",80),
                new ColumnInfo("结算方式","JSFS","String",80),
                new ColumnInfo("付款方式","PAYTYPE","String",80),
                new ColumnInfo("折扣率","DISCOUNT","Decimal",80),
                new ColumnInfo("区域","AREA","String",80),
                new ColumnInfo("开户银行","BANK","String",80),
                new ColumnInfo("开户账号","BANKACCOUNT","String",80),
                new ColumnInfo("行业","TRADE","String",80),
                new ColumnInfo("备注","REMARK","String",80)
            });
            
        }

        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "申请日期", fieldname = "FOUNDDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTCODE", fieldtype = "String", islike = true });

        }
    }
}
