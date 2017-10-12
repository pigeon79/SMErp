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
using G.Entity.ERP;

namespace G.ERP.BaseData
{
    public partial class InvClassLIST : BasicForm
    {
        public InvClassLIST()
        {
            InitializeComponent();
        }
        public override bool LoadForm()
        {
            this.Text = "库存类别列表";
            this.label_Caption.Text = "仓库列表";
            InitToolBar();
            InitForm();
            LoadData();
            return true;
        }
        private void InitToolBar() {
            this.gToolBar1.AddButton("新增");
            this.gToolBar1.AddButton("修改");
            this.gToolBar1.AddButton("刷新");
            this.gToolBar1.AddButton("删除");
            this.gToolBar1.AddButton("退出");
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "新增":
                        AddNew();
                        break;
                    case "修改":
                        Modify();
                        break;
                    case "刷新":
                        RefreshData();
                        break;
                    case "删除":
                        this.Delete();
                        break;
                    case "退出":
                        BasicForm f = this.ParentForm as BasicForm;
                        if (f != null)
                        {
                            this.Close();
                            f.DisplayOut((int)this.MenuId);
                        }
                        else { this.Close(); }
                        break;
                }
            });
        }
        private void Delete() {
            G.BLL.ERP.BaseData.DM_INVCLASSLogic logic = new BLL.ERP.BaseData.DM_INVCLASSLogic();
            logic.ExecuteDelete(gGrid1.GetCurSelect<DM_INVCLASS>());
        }
        List<DM_INVCLASS> EditData = new List<DM_INVCLASS>();
        private void InitForm() {
            gGrid1.AddGridColumn("InvClass", "库存类别代码", "String", 80);
            gGrid1.AddGridColumn("InvDesc", "库存类别名称", "String", 80);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
           
        }
        private void AddNew() {
            InvClassEDIT frm = new InvClassEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void Modify() { 
        InvClassEDIT frm = new InvClassEDIT();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.SetData(gGrid1.GetCurSelect<DM_INVCLASS>());
            frm.ShowDialog();
        }
        private void LoadData() {
            G.BLL.ERP.BaseData.DM_INVCLASSLogic logic = new BLL.ERP.BaseData.DM_INVCLASSLogic();
            int tcount = 0;
            EditData = logic.ExecuteSelect(Data.Condition.Empty, OrderBy.Parse("InvClass"), 0, 0, ref tcount);

            gGrid1.DataBind<DM_INVCLASS>(EditData);
        }
        private void RefreshData() {
            LoadData();
        }
        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            Modify();

        }
    }
}
