using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Entity.ERP;
using G.Controls.Base;
using G.Data;
using G.Data.Definition;
using G.BLL.Base;

namespace G.APP.BaseForm
{
    public partial class BaseEditor : BasicForm
    {
        public BaseEditor()
        {
            InitializeComponent();
        }
        public EditorStatus CurEditStatus { set; get; }
        public virtual string listCaption
        {
            set
            {
                this.Text = value;
                this.c1SplitterPanel1.Text = value;
            }
        }
        List<string> _listTool = new List<string>();
        public Type T { get; set; }
        public List<string> listTool { get { return _listTool; } set { _listTool = value; } }
        public string orderby { get; set; }
        IBaseBLL _Logic = null;
        public IBaseBLL Logic { set { _Logic = value; } get { return _Logic; } }

        IEditorAdapter eadapter = null;
        public IEditorAdapter Edapter { get { return eadapter; } set { eadapter = value; } }

        int _KeyId = 0;
        public int KeyId { get { return _KeyId; } set { _KeyId = value; } }

        public override bool LoadForm()
        {
            try
            {
                base.LoadForm();
                InitToolBar();
                LoadData();
                if (CurEditStatus == EditorStatus.Look || CurEditStatus == EditorStatus.Audit)
                {
                    SetReadOnly(true);
                }
                return true;
            }
            catch (Exception e) { MessageBox.Show("BaseEditor-LoadForm:" + e.Message); return false; }
        }
        public void SetReadOnly(bool isreadonly) {
            this.eadapter.SetReadOnly(isreadonly);            
        }
        public void SetData(IDbObject data)
        {
            editData = data;
        }
        
        public virtual void InitToolBar()
        {
            this.gToolBar1.ClearButton();
            foreach (string s in listTool)
            {
                if (this.CurEditStatus == EditorStatus.Look && (s == "保存" || s == "审核" || s == "反审"))
                {
                    this.gToolBar1.AddButton(s,"",false);
                }
                else
                {
                    this.gToolBar1.AddButton(s);
                }
            }
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                ToolButtonClick(name);
            });
        }
        public virtual void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "新增":
                    SetReadOnly(false);
                    this.New();
                    break;
                case "保存":
                    if (this.CurEditStatus != EditorStatus.Look)
                    {
                        this.Save();
                    }
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
        }
        public IDbObject editData = null;
        public virtual void LoadData()
        {
            if (KeyId > 0) {
                editData = this._Logic.IFindObject(G.AppInfo.GGlobal.User, KeyId);
                eadapter.SetData(editData);
            }
            else
            if (editData != null && eadapter != null)
            {
                eadapter.SetData(editData);
            }
            
        }
        public virtual void New()
        {
            editData = System.Activator.CreateInstance(T) as IDbObject;
            KeyId = 0;
            this.CurEditStatus = EditorStatus.New;
            this.gToolBar1.SetToolBarUse("保存", true);
            this.gToolBar1.SetToolBarUse("审核", true);
            this.gToolBar1.SetToolBarUse("反审", true);
            this.LoadData();

        }
        public virtual bool ValidSave()
        {
            bool ispass = true;
            return ispass;
        }
        public virtual void onBeforeSave() { 
        
        }
        public virtual bool Save()
        {
            bool ispass = false;
            try
            {
                if (ValidSave())
                {
                    onBeforeSave();
                    editData = eadapter.GetData();
                    _Logic.IExecuteUpdate(G.AppInfo.GGlobal.User, editData);
                    this.CurEditStatus = EditorStatus.Modify;
                    MessageBox.Show("保存成功！");
                    this.LoadData();
                    ispass= true;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message);}
            return ispass;
        }
        public virtual void EditorClosing() { this.editData = null; }
        private void BaseEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            EditorClosing();
        }

    }
    public enum EditorStatus
    {
        New,
        Modify,
        Look,
        Audit
    }
}
