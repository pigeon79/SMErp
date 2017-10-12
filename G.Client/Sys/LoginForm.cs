using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using G.BLL.Sys;
using G.Entity.SysEnt;

namespace G.Client.Sys
{
    public partial class LoginForm : C1.Win.C1Ribbon.C1RibbonForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.txt_password.TextBox.PasswordChar ='*';
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string logname = this.txt_logname.Text;
                string pwd = this.txt_password.Text;
                LoginLogic llogic = new LoginLogic();
                ND_USER user = llogic.CheckLogin(logname, pwd);
                if (user != null)
                {
                    this.SaveInfo(logname, pwd);
                    G.AppInfo.GGlobal.User = user;
                    G.AppInfo.SysInfo.logname = user.USERNAME;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void LoadInfo() {
            this.txt_logname.Text = ConfigurationManager.AppSettings["Logname"];
            this.txt_password.Text = ConfigurationManager.AppSettings["pwd"];
            this.check_rem.Checked = ConfigurationManager.AppSettings["remember"] == "1" ? true : false;
        }
        private void SaveInfo(string logname,string pwd) {
            Core.Config.UpdateAppConfig("Logname", logname);
            if (this.check_rem.Checked)
            {
                Core.Config.UpdateAppConfig("pwd", pwd);
                Core.Config.UpdateAppConfig("remember", "1");
            }
            else { 
                Core.Config.UpdateAppConfig("pwd", "");
                Core.Config.UpdateAppConfig("remember", "0");
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
