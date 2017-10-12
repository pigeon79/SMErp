using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Entity.ERP;
using C1.Win.C1Input;
using G.Controls.Base;

namespace G.ERP.BaseData
{
    public partial class InvClassEDIT : BasicForm
    {
        public InvClassEDIT()
        {
            InitializeComponent();
        }

        private void EDIT_Load(object sender, EventArgs e)
        {
            this.Text = "仓库";
            this.lab_title.Text = "仓库";
            InitToolBar();
            //this.drop_ORGID.Logic = new G.BLL.Sys.ND_ORGINAZITIONLogic();
            LoadData();
        }
        EditorAdapter<DM_INVCLASS, object> eadapter = new EditorAdapter<DM_INVCLASS, object>();
        public override bool LoadForm()
        {
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "仓库代码", FieldName = "InvClass", Editor = this.txt_INVCLASS });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "仓库名称", FieldName = "InvDesc", Editor = this.txt_INVDESC });
            return true;
        }
        public void SetData(DM_INVCLASS data)
        {
            editData = data;
            LoadData();
        }
        private void InitToolBar()
        {
            this.gToolBar1.AddButton("新增");
            this.gToolBar1.AddButton("保存");
            this.gToolBar1.AddButton("退出");
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "新增":
                        this.New();
                        break;
                    case "保存":
                        this.Save();
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
                    default:
                        break;
                }
            });
        }
        DM_INVCLASS editData = new DM_INVCLASS();
        private void LoadData()
        {
            eadapter.SetData(editData);           
        }
        private void New() {
            editData = new DM_INVCLASS();
            this.LoadData();
        }
        private void Save() {
            try
            {
                editData = eadapter.GetData();
                G.BLL.ERP.BaseData.DM_INVCLASSLogic logic = new BLL.ERP.BaseData.DM_INVCLASSLogic();
                logic.ExecuteUpdate(editData);
                MessageBox.Show("保存成功！");
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
