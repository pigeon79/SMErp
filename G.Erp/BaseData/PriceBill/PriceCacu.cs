using G.Data;
using G.Entity.ERP;
using G.Interface.CLIENT;
using G.Interface.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Erp.BaseData
{
    public partial class PriceCacu : C1.Win.C1Input.DropDownForm
    {
        public PriceCacu()
        {
            InitializeComponent();
        }

        G.BLL.ERP.BaseData.SM_PRICEPARALogic priceparalogic = new BLL.ERP.BaseData.SM_PRICEPARALogic();

        private void btn_OK_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void PriceCacu_PostChanges(object sender, EventArgs e)
        {
            decimal value = cacuprice();
            if (DialogResult == DialogResult.OK)
            { 
                OwnerControl.Value = value; 
            }
        }
        private decimal cacuprice() {
            decimal weight=(decimal)this.TXT_WEIGHT.GetValue();
            string type = this.comb_Type.GetValue().ToString();
            decimal value = 0;
            var pl = from p in list
                     where weight >= p.SWEIGHT && weight < p.EWEIGHT && type==p.TYPECODE
                     select p.PRICE;
            if (pl.ToArray().Count() > 0)
            {
                value = G.Core.GConvert.ToDecimal(pl.ToArray()[0],2) * weight;
            }
            return value;
        }
        List<SM_PRICEPARA> list = new List<SM_PRICEPARA>();
        private void PriceCacu_Load(object sender, EventArgs e)
        {
            list= priceparalogic.ExecuteSelect(Condition.Empty, OrderBy.Parse("SWEIGHT"), 0, 0);
        }

        private void TXT_WEIGHT_ValueChanged(object sender, EventArgs e)
        {
            var v = cacuprice();
            this.label1.Text = string.Format("价格：{0}", v);
        }
    }
}
