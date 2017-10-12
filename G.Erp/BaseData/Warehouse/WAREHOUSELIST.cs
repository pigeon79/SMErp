using G.Controls.Base;
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
using G.Entity.ERP;

namespace G.ERP.BaseData
{
    public partial class WAREHOUSELIST : G.APP.BaseForm.BaseList
    {
        public WAREHOUSELIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "仓库列表";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "|", "退出" };
            this.EntityT = typeof(DM_WAREHOUSE);
            this.EditorT = typeof(WAREHOUSEEDIT);
            this.orderby = "WRHSCODE";
            this.Logic = new G.BLL.ERP.BaseData.DM_WAREHOUSELogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("仓库代码","WRHSCODE","String",80),
                new ColumnInfo("仓库名称","WRHSNAME","String",80)
            });
        }

        //public override void InitFilter()
        //{
        //    //this.FilterInfos.Add(new FilterInfo() { caption = "建立日期", fieldname = "FOUNDDATE", fieldtype = "DateTime", controltype = "date", isdouble = true, controldata = "本月" });
        //    //this.FilterInfos.Add(new FilterInfo() { caption = "供应商名称", fieldname = "SUPPNAME", fieldtype = "String", islike = true });

        //}

    }
}
