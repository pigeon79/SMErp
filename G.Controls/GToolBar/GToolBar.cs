using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace G.Controls.GToolBar
{
    public partial class GToolBar : UserControl
    {
        public GToolBar()
        {
            InitializeComponent();
            c1CommandHolder1.CommandClick += c1CommandHolder1_CommandClick;
            this.Height = this.c1ToolBar1.Height;
            this.Dock = System.Windows.Forms.DockStyle.Top;
        }
        public delegate void FunButtonClick(string caption);
        public FunButtonClick ButtonClick;
        void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {
            this.ButtonClick(e.Command.Text);
        }
        public void AddButton(string caption)
        {
            this.AddButton(caption, "");
        }
        Dictionary<string, int> toolList = new Dictionary<string, int>();
        public void AddButton(string caption,string imgpath)
        {
            this.AddButton(caption, imgpath, true);
        }
        public void AddButton(string caption, string imgpath,bool enabled)
        {
            C1.Win.C1Command.C1Command command = new C1.Win.C1Command.C1Command();
            command.Enabled = enabled;
            command.Text = caption;
            c1CommandHolder1.Commands.Add(command);
            C1.Win.C1Command.C1CommandLink link = new C1.Win.C1Command.C1CommandLink();
            link.Text = caption;
            if (imgpath == "")
            {
                imgpath = DefaultImagePath(caption);
            }
            if (imgpath != "")
            {
                command.Image = System.Drawing.Image.FromFile(imgpath);
                link.ButtonLook = ButtonLookFlags.TextAndImage;
            }
            else
            {
                link.ButtonLook = ButtonLookFlags.Text;
            }
            link.Command = command;
            c1ToolBar1.CommandLinks.Add(link);
        }
        public void ClearButton() {
            c1ToolBar1.CommandLinks.Clear();
            c1CommandHolder1.Commands.Clear();
        }
        public C1CommandLink GetToolBar(string name) {
            C1CommandLink link = null;
            foreach (C1CommandLink l in c1ToolBar1.CommandLinks) {
                if (l.Command.Text == name) {
                    link = l;
                }
            }
            return link;
        }
        public void SetToolBarUse(string name,bool enable)
        {
            foreach (C1CommandLink l in c1ToolBar1.CommandLinks)
            {
                if (l.Command.Text == name)
                {
                    l.Command.Enabled = enable;
                }
            }
        }
        private string DefaultImagePath(string caption) {
            string path = "";
            switch (caption) {
                case "导出":
                    path = Application.StartupPath + @"\Images\ToolBar\rptexcel.ico";
                    break;
                case "打印":
                    path = Application.StartupPath + @"\Images\ToolBar\print.ico";
                    break;
                case "过滤":
                    path = Application.StartupPath + @"\Images\ToolBar\query.ico";
                    break;
                case "新增":
                    path = Application.StartupPath + @"\Images\ToolBar\new.ico";
                    break;
                case "刷新":
                    path = Application.StartupPath + @"\Images\ToolBar\refresh.ico";
                    break;
                case "保存":
                    path = Application.StartupPath + @"\Images\ToolBar\save.ico";
                    break;
                case "删除":
                    path = Application.StartupPath + @"\Images\ToolBar\del.ico";
                    break;
                case "修改":
                    path = Application.StartupPath + @"\Images\ToolBar\modify.ico";
                    break;
                case "增行":
                    path = Application.StartupPath + @"\Images\ToolBar\AddRow.ico";
                    break;
                case "插行":
                    path = Application.StartupPath + @"\Images\ToolBar\InsertRow.ico";
                    break;
                case "删行":
                    path = Application.StartupPath + @"\Images\ToolBar\DelRow.ico";
                    break;
                case "退出":
                    path = Application.StartupPath + @"\Images\ToolBar\exit.ico";
                    break;
            }
            return path;
        }
        private void GToolBar_Resize(object sender, EventArgs e)
        {
            this.Height = this.c1ToolBar1.Height;
        }
    }
}
