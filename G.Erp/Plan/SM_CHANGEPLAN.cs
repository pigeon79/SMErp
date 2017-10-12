using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Data;
using G.Controls.Base;
using G.Entity.ERP;
using G.Controls.Input;
using G.BLL.ERP.Plan;
using G.Entity.SysEnt;

namespace G.Erp.Plan
{
    public partial class SM_CHANGEPLAN : G.Controls.Base.BasicForm
    {
        public SM_CHANGEPLAN()
        {
            InitializeComponent();
            
        }

        private void btn_clearBom_Click(object sender, EventArgs e)
        {
            G.BLL.ERP.Plan.SM_BOMTEMPLogic bomtemplogic = new SM_BOMTEMPLogic();
            string orderid = G.Core.Common.Usually.GetPadingNO("SO", this.TXT_ORDERID.Text, 10);
            bomtemplogic.ClearBomtemp(G.AppInfo.GGlobal.User, orderid);
            MessageBox.Show("已重置，请重新下达计划!");
        }
        private void FillSaleOrder(SM_SALEORDER order) {
            this.TXT_ORDERID.Text = order.ORDERID;
            this.TXT_CUSTID.Text = order.CUSTNAME;
            this.TXT_CUSTLEV.Text = order.CUSTLEV;
            this.TXT_ORDERDATE.Text = G.Core.GConvert.ToShortDateTime(order.ORDERDATE);
            this.TXT_SALESMAN.Text = order.SALESMANNAME;
            this.TXT_SALESREP.Text = order.SALESREPNAME;
            this.TXT_INOFC.Text = order.INOFCNAME;
            this.TXT_CUSTORDNB.Text = order.CUSTORDNB;
            this.TXT_ORDQTY.Text = G.Core.GConvert.ToInt(order.ORDQTY).ToString();

            
        }
        private void TXT_ORDERID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                G.BLL.ERP.Sale.SM_SALEORDERLogic salelogic = new G.BLL.ERP.Sale.SM_SALEORDERLogic();
                string orderid = G.Core.Common.Usually.GetPadingNO("SO", this.TXT_ORDERID.Text, 10);
                SM_SALEORDER order = salelogic.GetSaleOrder(G.AppInfo.GGlobal.User, orderid);
                FillSaleOrder(order);
            }
        }
    }
}
