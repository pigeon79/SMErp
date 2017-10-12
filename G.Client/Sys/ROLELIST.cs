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
    public partial class ROLELIST : BasicForm
    {
        public ROLELIST()
        {
            InitializeComponent();
        }
        public override bool LoadForm()
        {
            this.label_Caption.Text = "角色列表";
            InitToolBar();
            InitForm();
            LoadData();
            return true;
        }
        private void InitToolBar() {
            this.gToolBar1.AddButton("新增");
            this.gToolBar1.AddButton("修改");
            this.gToolBar1.AddButton("删除");
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
                    case "删除":
                        this.Delete();
                        break;
                }
            });
        }
        List<ND_ROLE> EditData = new List<ND_ROLE>();
        private void InitForm() {
            gGrid1.AddGridColumn("ROLENAME", "用户名", "String", 100);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
           
        }
        private void AddNew() {
            ROLEEDIT frm = new ROLEEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void Delete()
        {
            G.BLL.Sys.ND_ROLELogic logic = new BLL.Sys.ND_ROLELogic();
            logic.ExecuteDelete(gGrid1.GetCurSelect<ND_ROLE>());
            RefreshData();
        }
        private void LoadData() {
            G.BLL.Sys.ND_ROLELogic logic = new BLL.Sys.ND_ROLELogic();
            int tcount = 0;
            EditData = logic.ExecuteSelect(Data.Condition.Empty, OrderBy.Parse("ROLENAME"), 0, 0, ref tcount);

            gGrid1.DataBind<ND_ROLE>(EditData);
        }
        private void RefreshData() {
            LoadData();
        }
        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            ROLEEDIT frm = new ROLEEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.SetData(gGrid1.GetCurSelect<ND_ROLE>());
            frm.ShowDialog();

        }
    }
}
