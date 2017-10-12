using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Client.SysSet
{
    public partial class SysSetForm : G.Controls.Base.BasicForm
    {
        public SysSetForm()
        {
            InitializeComponent();
        }


        private void c1Button1_Click(object sender, EventArgs e)
        {
            string fkey = this.gText1.Text;
            string fvalue = this.gText2.Text;
            BaseExtends.SetSysSetting(fkey, fvalue);
        }

        private void c1Button2_Click(object sender, EventArgs e)
        {
            string fkey = this.gText1.Text;
            this.gText2.Text = BaseExtends.GetSysSetting(fkey);
        }
    }
}
