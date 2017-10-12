using System;
using System.Collections.Generic;
using System.Text;
using C1.Win.C1Input;
using System.Threading;
using System.Windows.Forms;
using G.Data.Definition;
using G.Data;
using G.Interface.BLL;
using G.Interface.Event;
using System.Data;
using G.Controls.GGrid;

namespace G.Controls.Input
{
    public class GCheckBox : C1CheckBox, G.Interface.CLIENT.IControl
    {
        public GCheckBox()
        {
        }
        public string Caption
        {
            get { return this.Text;}
            set { this.Text = value;}
        }
        public object GetValue()
        {
            return this.Checked;
        }

        public void SetValue(object value)
        {
            this.Checked = G.Core.GConvert.ToBool(value);
        }


        public bool ReadOnly
        {
            get
            {
                return !this.Enabled;
            }
            set
            {
                this.Enabled = !value;
            }
        }


        public void NotNullFormat()
        {
            this.ForeColor = System.Drawing.Color.Red;
        }
    }
}
