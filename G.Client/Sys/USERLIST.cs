using G.Controls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.GGrid;
using G.Data;
using G.Entity.SysEnt;

namespace G.Client.Sys
{
    public partial class USERLIST : BasicForm
    {
        public USERLIST()
        {
            InitializeComponent();
        }
        public override bool LoadForm()
        {
            this.label_Caption.Text = "用户列表";
            InitToolBar();
            InitForm();
            LoadData();
            return true;
        }
        private void InitToolBar() {
            this.gToolBar1.AddButton("新增");
            this.gToolBar1.AddButton("修改");
            this.gToolBar1.AddButton("刷新");
            //this.gToolBar1.AddButton("退出");
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "新增":
                        AddNew();
                        break;
                    case "修改":
                        break;
                    case "刷新":
                        RefreshData();
                        break;
                    case "退出":
                        this.Close();
                        break;
                }
            });
        }
        List<ND_USER> EditData = new List<ND_USER>();
        private void InitForm() {
            gGrid1.AddGridColumn("USERDM", "工号", "String", 80);
            gGrid1.AddGridColumn("USERNAME", "用户名", "String", 80);
            gGrid1.AddGridColumn("USERTYPE", "用户类别", "String", 80);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
           
        }
        private void AddNew() {
            USEREDIT frm = new USEREDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void LoadData() {
            G.BLL.Sys.ND_UserLogic logic = new BLL.Sys.ND_UserLogic();
            int tcount = 0;
            EditData = logic.ExecuteSelect(Data.Condition.Empty, OrderBy.Parse("USERDM"), 0, 0, ref tcount);

            gGrid1.DataBind<ND_USER>(EditData);
        }
        private void RefreshData() {
            LoadData();
        }
        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            USEREDIT frm = new USEREDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.SetData(gGrid1.GetCurSelect<ND_USER>());
            frm.ShowDialog();

        }
    }
}
