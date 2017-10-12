using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace G.Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //CheckServer();
            try
            {
                G.AppInfo.SysInfo.sysname = "尚美纽扣信息系统";
                G.AppInfo.SysInfo.company = "宜兴尚美服饰辅料制造有限公司";
                G.AppInfo.SysInfo.version = Application.ProductVersion;
                if (StartLogin())
                {
                    MainForm mainform = new MainForm();                    
                    System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                    System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
                    if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                    {
                        Application.Run(mainform);
                    }
                    else
                    {
                        //创建启动对象
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.UseShellExecute = true;
                        startInfo.WorkingDirectory = Environment.CurrentDirectory;
                        startInfo.FileName = Application.ExecutablePath;
                        //设置启动动作,确保以管理员身份运行
                        startInfo.Verb = "runas";
                        try
                        {
                            System.Diagnostics.Process.Start(startInfo);
                        }
                        catch
                        {
                            return;
                        }
                        //退出
                        Application.Exit();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public static bool StartLogin()
        {
            bool ispass = false;
            Sys.LoginForm loginfrm = new Sys.LoginForm();
            DialogResult result = loginfrm.ShowDialog();
            if (result == DialogResult.OK) { 
                ispass = true;
                AutoUpdate();
            }
            return ispass;
        }
        public static bool CheckServer()
        {
            bool ispass = false;
            G.Core.Common.Usually.TestConnection("");
            ispass = true;
            return ispass;
        }
        private static void StartUpdate()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "AutoUpdate.exe");
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.Arguments = "G.Client.exe";
            Process.Start(psi);
        }
        private static bool CheckUpdate() {
            bool isupdate = false;
            string lastversion = BaseExtends.GetSysSetting("VERSION_ERP");
            if (new Version(lastversion) > new Version(G.AppInfo.SysInfo.version))
            {
                isupdate = true;
            }
            return isupdate;
        }
        private static void AutoUpdate()
        {
            if (CheckUpdate())
            {
                if (DialogResult.Yes == MessageBox.Show("已经有升级包，是否要升级!", "提示", MessageBoxButtons.YesNo))
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
            }
        }
    }
}
