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

namespace G.Erp.Storage
{
    public partial class SM_LOCSTORAGEREPORT : G.APP.BaseForm.DataBaseReport
    {
        public SM_LOCSTORAGEREPORT()
        {
            InitializeComponent();
            InitInfo();            
        }
        private void InitInfo()
        {
            this.listCaption = "物料库存状态查询";
            this.listTool = new List<string>() { "刷新", "-", "过滤","导出", "|", "退出" };
            this.orderby = "ID DESC";
            this.Logic = new G.BLL.Base.BaseDataBLL();
            this.Csql = "RPT_KC0002";
            //this.CutPageType = Core.Common.CutPageType.server;
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("仓库代码","WRHSCODE","String",80),
                new ColumnInfo("仓库名称","WRHSNAME","String",80),
                new ColumnInfo("库位代码","LOCCODE","String",80),
                new ColumnInfo("库位名称","LOCNAME","String",80),
                new ColumnInfo("物品代码","ITEMCODE","String",80),
                new ColumnInfo("物品名称","ITEMNAME","String",100),
                new ColumnInfo("在库数","ONHANDQTY","Decimal","#0.00",100),
                new ColumnInfo("单位","UNIT","String",40),
                new ColumnInfo("色号","ATTRIBUTEA","String",80),
                new ColumnInfo("花模","ATTRIBUTEBNAME","String",100),
                new ColumnInfo("尺寸","ATTRIBUTEC","Decimal","#0.00",60)
            });
        }


        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "状态", fieldname = "STATUS", fieldtype = "String", controltype = "combox", controldata = "全部:,新增:N,审核:A" });
            //this.FilterInfos.Add(new FilterInfo() { caption = "采购申请单号", fieldname = "PREPURORDID", fieldtype = "String", islike = true });
            this.FilterInfos.Add(new FilterInfo() { caption = "仓库", fieldname = "WRHSCODE", fieldtype = "String", controltype = "dropdown", controldata = "WAREHOUSE", searchLogic = new G.BLL.ERP.BaseData.DM_WAREHOUSELogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "库位", fieldname = "LOCNAME", fieldtype = "String", controltype = "dropdown", controldata = "LOCATION", searchLogic = new G.BLL.ERP.BaseData.DM_LOCATIONLogic(), islike = false });
            this.FilterInfos.Add(new FilterInfo() { caption = "物品名称", fieldname = "ITEMCODE", fieldtype = "String", controltype = "dropdown", controldata = "ITEM", searchLogic = new G.BLL.ERP.BaseData.DM_ITEMLogic(), islike = false });
            //this.FilterInfos.Add(new FilterInfo() { caption = "供应商", fieldname = "SUPCODE", fieldtype = "String", controltype = "dropdown", controldata = "SUPPLIER", searchLogic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic(), islike = false });
        }
    }
}
