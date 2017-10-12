using G.Controls.GGrid;
using G.Entity.ERP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Erp.BaseData.PriceBill
{
    public partial class DM_PRICEBILLList : G.APP.BaseForm.BaseList
    {
        public DM_PRICEBILLList()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单列表";
            this.listTool = new List<string>() { "导出", "打印", "新增", "修改", "删除", "刷新", "|", "退出" };
            this.EntityT = typeof(DM_PRICEBILL);
            this.EditorT = typeof(DM_PRICEBILLEditor);
            this.orderby = "ID";
            this.Logic = new G.BLL.ERP.BaseData.DM_PRICEBILLLogic();
            this.SetColumns(new List<ColumnInfo>(){
                new ColumnInfo("启用","USETAG","Boolean",80),
                new ColumnInfo("价格簿名称","PBILLNAME","String",80),
                new ColumnInfo("备注","REMARK","String",180)                
            });
            
        }
    }
}
