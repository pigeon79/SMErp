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
    public partial class USEREDIT : BasicForm
    {
        public USEREDIT()
        {
            InitializeComponent();
            G.BLL.Sys.ND_ORGINAZITIONLogic orglogic = new G.BLL.Sys.ND_ORGINAZITIONLogic();
            Initialize.InitDropDown(DROP_ORGID, "ORG", orglogic, "ID", "ORGNAME");
        }

        private void EDIT_Load(object sender, EventArgs e)
        {
            InitToolBar();
            //this.drop_ORGID.Logic = new G.BLL.Sys.ND_ORGINAZITIONLogic();
            LoadData();
        }
        EditorAdapter<ND_USER, object> eadapter = new EditorAdapter<ND_USER, object>();
        public override bool LoadForm()
        {
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption="工号",FieldName="USERDM",Editor=this.txt_USERDM});
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "用户名", FieldName = "USERNAME", Editor = this.txt_USERNAME });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "用户类别", FieldName = "USERTYPE", Editor = this.comb_USERTYPE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "密码", FieldName = "PASSWORD", Editor = this.txt_PASSWORD });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "电话", FieldName = "TEL", Editor = this.TXT_TEL });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "部门", FieldName = "ORGID", Editor = this.DROP_ORGID });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "停用", FieldName = "NOTINUSE", Editor = this.checkbox_NOTINUSE });
            return true;
        }
        public void SetData(ND_USER data)
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
        ND_USER editData = new ND_USER();
        private void LoadData()
        {
            eadapter.SetData(editData);           
        }
        private void New() {
            editData = new ND_USER();
            this.LoadData();
        }
        private void Save() {
            try
            {
                editData = eadapter.GetData();
                G.BLL.Sys.ND_UserLogic logic = new BLL.Sys.ND_UserLogic();
                logic.ExecuteUpdate(editData);
                MessageBox.Show("保存成功！");
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
