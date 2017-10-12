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
    public partial class SM_SHOPORDERREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_SHOPORDERREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "车间计划查询";
            this.listTool = new List<string>() { "入库", "刷新", "-", "过滤", "|", "退出" };
            this.orderby = "SHOPORDERID DESC";
            this.Logic = new G.BLL.ERP.Shop.SM_SHOPORDERLogic();
            this.Csql = "RPT_SC0001";
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("派工单号","SHOPORDID","String",80),
                new ColumnInfo("生产交期","RDATE","DateTime","yyyy-MM-dd",80),
                new ColumnInfo("物品代码","ITEMCODE","String",80),
                new ColumnInfo("物品名称","ITEMNAME","String",80),
                new ColumnInfo("色号","ATTRIBUTEA","String",80),
                new ColumnInfo("花模","ATTRIBUTEBNAME","String",80),
                new ColumnInfo("尺寸","ATTRIBUTEC","Decimal",80),
                new ColumnInfo("款号","ATTRIBUTED","String",80),
                new ColumnInfo("计划数量","REQQTY","Decimal",80),
                new ColumnInfo("注意事项","MEMO","String",120),
            });
        }

        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "生产交期", fieldname = "RDATE", fieldtype = "DateTime", controltype = "date", isdouble = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "订单号", fieldname = "ORDERID", fieldtype = "String", islike = true });
        }

        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "入库":
                    InStorage();
                    break;
            }
            base.ToolButtonClick(name);
        }

        public void InStorage()
        {
            DataRow drow = this.GetCurSelect();
            if (drow == null) return;
            SM_SHOPINEDIT oFrm = new SM_SHOPINEDIT();
            G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new G.BLL.ERP.BaseData.DM_ITEMLogic();
            DM_ITEM itemobj = itemlogic.ExecuteSelect(CK.K["ITEMCODE"].Eq(drow["ITEMCODE"]), OrderBy.Parse("ITEMCODE"), 0, 0)[0];
            SM_SHOPIN shopin = new SM_SHOPIN();
            shopin.ITEMCODE = G.Core.GConvert.ToString(drow["ITEMCODE"]);
            shopin.ITEMNAME = G.Core.GConvert.ToString(drow["ITEMNAME"]);
            shopin.INVUNIT = itemobj.InvUnit;
            shopin.ATTRIBUTEA = G.Core.GConvert.ToString(drow["ATTRIBUTEA"]);
            shopin.ATTRIBUTEB = G.Core.GConvert.ToString(drow["ATTRIBUTEB"]);
            shopin.ATTRIBUTEC = G.Core.GConvert.ToInt(drow["ATTRIBUTEC"]);
            shopin.INQTY = G.Core.GConvert.ToInt(drow["UNFINQTY"]);
            shopin.SHOPORDERID = G.Core.GConvert.ToString(drow["SHOPORDID"]);
            shopin.STATUS = "N";
            shopin.STATUSNAME = "新增";
            oFrm.SetData(shopin);
            oFrm.ShowDialog();
            this.RefreshData();
        }
    }
}
