using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.GGrid;
using G.Data;
using G.Controls.Base;
using G.BLL.Base;
using G.Entity.ERP;
using G.APP.BaseForm;

namespace G.Erp.Plan
{
    public partial class SM_PLANREPORT : G.APP.BaseForm.BaseReport
    {
        public SM_PLANREPORT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "计划报表";
            this.listTool = new List<string>() {"过滤","-","刷新","|","退出" };
            this.EntityT = typeof(SM_SHOPORDER);
            this.orderby = "SHOPORDID DESC";
            this.Logic = new G.BLL.ERP.Shop.SM_SHOPORDERLogic();
            gGrid1.AddGridColumn("SHOPORDID", "派工单号", "String", 80, true);
            gGrid1.AddGridColumn("RDATE", "生产交期", "DateTime", 100, true);
            gGrid1.AddGridColumn("REQQTY", "计划数量", "Decimal", "#0.0", 100, true);
            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 100, true);
            gGrid1.AddGridColumn("ATTRIBUTEC", "规格mm", "Decimal", "#0.0", 60, true);
            gGrid1.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            gGrid1.AddGridColumn("ATTRIBUTED", "款号", "String", 120, true);
            gGrid1.AddGridColumn("MEMO", "注意事项", "String", 120, true);

            gGrid1.FrozenCell = 1;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }
        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "日期", fieldname = "RDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
            //this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
            //this.FilterInfos.Add(new FilterInfo() { caption = "客户", fieldname = "CUSTID", fieldtype = "Int32", controltype = "dropdown", controldata = "CUSTOMER", searchLogic = new G.BLL.ERP.BaseData.DM_CUSTOMERLogic(), islike = false });
        }
    }
}
