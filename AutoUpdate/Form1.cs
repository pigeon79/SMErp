using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace AutoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateFile() {
            try
            {
                string DownloadUri = ConfigurationManager.AppSettings["filepath"];
                string path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "UpdateFile.zip");
                var c = new WebClient();
                c.DownloadFile(DownloadUri, path);
                //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh-CN");
                C1.C1Zip.C1ZipFile zipfile = new C1.C1Zip.C1ZipFile();
                
                zipfile.Open(path);
                zipfile.Entries.ExtractFolder(System.Windows.Forms.Application.StartupPath);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
