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

namespace G.Erp.BaseData
{
    public partial class DM_INVOPRTLIST : G.APP.BaseForm.BaseList
    {
        public DM_INVOPRTLIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "库存事务列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "|", "退出" };
            this.EntityT = typeof(DM_INVOPRT);
            this.EditorT = typeof(DM_INVOPRTEDIT);
            this.orderby = "INVTRNCDE";
            this.Logic = new G.BLL.ERP.BaseData.DM_INVOPRTLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("库存事务代码","INVTRNCDE","String",80),
                new ColumnInfo("库存事务名称","INVTDESC","String",80),
                new ColumnInfo("是否影响发出","ONISSUE","Boolean",80),
                new ColumnInfo("是否影响收入","ONREV","Boolean",80),
                new ColumnInfo("是否影响调整","ONADJUST","Boolean",80),
                new ColumnInfo("是否参与车间分配","ONSHOPA","Boolean",110),
                new ColumnInfo("是否订单分配","ONORDERA","Boolean",80),
                new ColumnInfo("是否计算销售量","ONSALEQTY","Boolean",110),
                new ColumnInfo("是否记录订单号","ISORDERNO","Boolean",110),
                new ColumnInfo("是否记录采购订单号","ISPONO","Boolean",120),
                //new ColumnInfo("是否记录车间订单号","ISSFCNO","Boolean",80),
                //new ColumnInfo("是否产生凭证","ISVOUCHER","Boolean",80),
                new ColumnInfo("是否参与MRP运算","ISHMERP","Boolean",100)
            });
        }
    }
}
