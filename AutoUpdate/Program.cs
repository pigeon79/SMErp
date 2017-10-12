using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace AutoUpdate
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.Sleep(2000);
            string gname = args.Length > 0 ? args[0]: "G.Client";
            //*关闭原有的应用程序 
            KillProcess(gname.Replace(".exe", ""));
            
            if (args.Length == 1)
            {
                try
                {
                    UpdateFile();
                    Process myprocess = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo(args[0]);
                    myprocess.StartInfo = startInfo;
                    myprocess.Start();
                    Application.Exit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            else
            {
                try
                {

                    UpdateFile();
                    MessageBox.Show("升级成功!");
                    Application.Exit();
                }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }
        private static void UpdateFile()
        {
            try
            {
                string DownloadUri = ConfigurationManager.AppSettings["filepath"];
                string path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "UpdateFile.zip");
                var c = new WebClient();
                c.DownloadFile(DownloadUri, path);

                C1.C1Zip.C1ZipFile zipfile = new C1.C1Zip.C1ZipFile();
                zipfile.Open(path);
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh-CN");
                zipfile.Entries.ExtractFolder(System.Windows.Forms.Application.StartupPath);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        /// <summary>
        /// 关闭进程
        /// </summary>
        /// <param name="processName">进程名</param>
        private static void KillProcess(string processName)
        {
            Process[] myproc = Process.GetProcesses();
            foreach (Process item in myproc)
            {
                if (item.ProcessName == processName)
                {
                    item.Kill();
                }
            }
            //System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(gname);
            //foreach (System.Diagnostics.Process pro in proc)
            //{
            //    pro.Kill();
            //}
        }

    }
}
