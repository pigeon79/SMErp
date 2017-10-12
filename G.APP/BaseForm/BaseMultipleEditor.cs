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
using G.Controls.Base;
using G.BLL.Base;
using G.Entity.ERP;
using G.Controls.Input;
using G.APP.BaseForm;


namespace G.APP.BaseForm
{
    public partial class BaseMultipleEditor : BaseEditor
    {
        public BaseMultipleEditor()
        {
            InitializeComponent();
        }
        
        private void InitInfo()
        {
            this.Edapter = initAdapter();
            InitDrop();
            InitGrid();
        }
        public virtual IEditorAdapter initAdapter()
        {
            return null;
        }
        public virtual void InitDrop()
        {
            
        }
        public virtual void InitGrid()
        {

        }

        public override bool LoadForm()
        {
            bool b= base.LoadForm();
            if (this.CurEditStatus == EditorStatus.New)
                AddRow();
            return b;
        }

        public override void InitToolBar()
        {
            this.gToolBar1.ClearButton();
            foreach (string s in listTool)
            {
                if (this.CurEditStatus == EditorStatus.Look && (s == "保存" || s == "审核" || s == "反审"))
                {
                    this.gToolBar1.AddButton(s, "", false);
                }
                else
                {
                    this.gToolBar1.AddButton(s);
                }
            }
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                this.ToolButtonClick(name);
            });
        }
        public override void ToolButtonClick(string name)
        {
            switch (name) {
                case "增行": 
                    if (this.CurEditStatus != EditorStatus.Look)
                    {
                        AddRow();
                    }
                    break;
                case "删行":
                    if (this.CurEditStatus != EditorStatus.Look)
                    {
                        DeleteRow();
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
            }
            base.ToolButtonClick(name);
        }
        public override void onBeforeSave()
        {
            base.onBeforeSave();
            this.gGrid1.FinishEditing();
        }
        public override void New()
        {
            base.New();
            AddRow();
        }
        public virtual void AddRow()
        {
        }
        public virtual void DeleteRow()
        {
        }
    }
}
