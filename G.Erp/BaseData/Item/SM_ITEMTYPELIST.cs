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
    public partial class SM_ITEMTYPELIST : G.APP.BaseForm.BaseList
    {
        public SM_ITEMTYPELIST()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "物品大类";
            this.listTool = new List<string>() { "新增", "修改", "删除", "刷新", "-", "工艺", "-", "过滤", "|", "退出" };
            this.EntityT = typeof(SM_ITEMTYPE);
            this.EditorT = typeof(SM_ITEMTYPEEDIT);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.SM_ITEMTYPELogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("ID","Id","Int32",80),
                new ColumnInfo("物品大类","ITEMTYPENAME","String",80),
            });
        }

        public override void InitFilter()
        {
            this.FilterInfos.Add(new FilterInfo() { caption = "物品大类", fieldname = "ITEMTYPENAME", fieldtype = "String", islike = true });
        }

        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "工艺":
                    this.GY();
                    break;
            }
            base.ToolButtonClick(name);
        }
        private void GY()
        {
            SM_ITEMTYPE itemtype = this.gGrid1.GetCurSelect<SM_ITEMTYPE>();
            if (itemtype != null)
            {
                SM_PROCESSFLOWEDIT planform = new SM_PROCESSFLOWEDIT();
                planform.SetPara(itemtype);
                planform.ShowDialog();
            }
        }
    }
}