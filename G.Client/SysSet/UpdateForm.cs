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
    public partial class UpdateForm : G.Controls.Base.BasicForm
    {
        public UpdateForm()
        {
            InitializeComponent();
            NeedUpdate();
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread thread = new System.Threading.Thread(StartUpdate);
                thread.Start();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            
        }
        private void StartUpdate() { 
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "AutoUpdate.exe");
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.Arguments="G.Client.exe";
            Process.Start(psi);
        }
        private void NeedUpdate() {
            bool need = false;
            string lastversion=BaseExtends.GetSysSetting("VERSION_ERP");
            if (new Version(lastversion) > new Version(G.AppInfo.SysInfo.version)) {
                need = true;
            }

            if (need) {
                c1Button1.Enabled = true;
            }
            else { c1Button1.Enabled = false; }
        }

        private void c1Button2_Click(object sender, EventArgs e)
        {
            NeedUpdate();
        }
    }
}
