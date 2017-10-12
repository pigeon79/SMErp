using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Entity.SysEnt;
using C1.Win.C1Input;
using G.Controls.Base;

namespace G.Client.Sys
{
    public partial class ROLEEDIT : BasicForm
    {
        public ROLEEDIT()
        {
            InitializeComponent();
        }

        private void EDIT_Load(object sender, EventArgs e)
        {
            InitToolBar();
            //this.drop_ORGID.Logic = new G.BLL.Sys.ND_ORGINAZITIONLogic();
            LoadData();
        }
        EditorAdapter<ND_ROLE, object> eadapter = new EditorAdapter<ND_ROLE, object>();
        public override bool LoadForm()
        {
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption="角色",FieldName="ROLENAME",Editor=this.txt_ROLENAME});
            //eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "用户名", FieldName = "USERNAME", Editor = this.txt_USERNAME });
            return true;
        }
        public void SetData(ND_ROLE data)
        {
            editData = data;
            LoadData();
        }
        private void InitToolBar()
        {
            this.gToolBar1.AddButton("新增");
            this.gToolBar1.AddButton("保存");
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
                    default:
                        break;
                }
            });
        }
        ND_ROLE editData = new ND_ROLE();
        private void LoadData()
        {
            eadapter.SetData(editData);           
        }
        private void New() {
            editData = new ND_ROLE();
            this.LoadData();
        }
        private void Save() {
            try
            {
                editData = eadapter.GetData();
                G.BLL.Sys.ND_ROLELogic logic = new BLL.Sys.ND_ROLELogic();
                logic.ExecuteUpdate(editData);
                MessageBox.Show("保存成功！");
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
