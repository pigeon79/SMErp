using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using G.Controls.GGrid;
using G.Data;
using G.Data.Definition;
using G.Controls.Base;
using G.BLL.Base;
using C1.Win.C1FlexGrid;
using System.Drawing.Printing;
using C1.Win.C1Preview;

namespace G.APP.BaseForm
{
    public partial class BaseList : BasicForm
    {
        public BaseList()
        {
            InitializeComponent();
        }
        public virtual string listCaption
        {
            set
            {
                this.Text = value;
                this.c1SplitterPanel1.Text = value;
            }
        }
        List<string> _listTool = new List<string>();
        //DbObjectBase
        //Type t;
        public Type EntityT { get; set; }
        public Type EditorT { get; set; }
        public List<string> listTool { get { return _listTool; } set { _listTool = value; } }
        public string orderby { get; set; }
        IBaseBLL _Logic = null;
        public IBaseBLL Logic { set { _Logic = value; } get { return _Logic; } }
        public void SetColumns(List<ColumnInfo> columns) { gGrid1.SetColumns(columns); }
        public string AuditField = "STATUS";

        public override bool LoadForm()
        {
            InitToolBar();
            InitForm();
            InitFilter();
            LoadData();
            return true;
        }
        public virtual void InitToolBar()
        {
            foreach (string s in listTool)
            {
                this.gToolBar1.AddButton(s);
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
                case "导出":
                    Export();
                    break;
                case "打印":
                    Print();
                    break;
                case "过滤":
                    Filter();
                    break;
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
        }
        private Data.Condition _defaultCondition = Data.Condition.Empty;
        public Data.Condition DefaultCondition { set { _defaultCondition = value; this.CurCondition = value; } get { return _defaultCondition; } }
        public Data.Condition CurCondition = Data.Condition.Empty;
        public List<FilterInfo> FilterInfos = new List<FilterInfo>();
        public BaseFilter fform = null;
        public virtual void InitFilter()
        {

        }
        private void Filter()
        {
            try
            {
                if (fform == null)
                {
                    fform = new BaseFilter();
                }
                fform.FilterInfos = this.FilterInfos;
                fform.DefaultCondition = this.DefaultCondition;
                DialogResult rst = fform.ShowDialog(this); ;
                if (rst == DialogResult.OK)
                {
                    this.CurCondition = fform.GetCondition();
                    this.RefreshData();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public virtual void Export()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel2003 (*.xls)|*.xls |Excel 2007 (*.xlsx)|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    this.gGrid1.SaveExcel(sfd.FileName, FileFlags.IncludeFixedCells);
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public virtual void Print()
        {
            try
            {
                gGrid1.PrintGrid(this.Text, PrintGridFlags.ShowPrintDialog);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }


        }
        public virtual void Delete()
        {
            try
            {
                DialogResult dr = MessageBox.Show("是否删除单据!", "提示", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    _Logic.IExecuteDelete(G.AppInfo.GGlobal.User, gGrid1.GetCurSelect<IDbObject>());
                    this.RefreshData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public virtual void InitForm()
        {
            try
            {
                gGrid1.AutoGenerateColumns = false;
                gGrid1.InitGrid();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

        }
        protected virtual void AddNew()
        {
            try
            {
                if (this.EditorT != null)
                {
                    DateTime time1 = DateTime.Now;

                    BaseEditor editor = System.Activator.CreateInstance(this.EditorT) as BaseEditor;
                    editor.ShowInTaskbar = false;
                    editor.StartPosition = FormStartPosition.CenterScreen;
                    editor.SetData(System.Activator.CreateInstance(EntityT) as IDbObject);
                    editor.CurEditStatus = EditorStatus.New;
                    DateTime time2 = DateTime.Now;
                    G.AppInfo.GGlobal.SetInfo((time2 - time1).Milliseconds.ToString());
                    editor.ShowDialog();
                    RefreshData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public virtual void Modify()
        {
            try
            {
                if (this.EditorT != null)
                {
                    DateTime time1 = DateTime.Now;

                    BaseEditor editor = System.Activator.CreateInstance(this.EditorT) as BaseEditor;
                    DateTime time2 = DateTime.Now;
                    editor.ShowInTaskbar = false;
                    editor.StartPosition = FormStartPosition.CenterScreen;
                    IDbObject obj = gGrid1.GetCurSelect<IDbObject>();
                    editor.KeyId = G.Core.GConvert.ToInt(G.Core.ClassHelper.GetFieldValue(obj, "Id"));
                    
                    var audit = G.Core.ClassHelper.GetFieldValue(obj, AuditField) != null ? G.Core.ClassHelper.GetFieldValue(obj, AuditField).ToString() : "";
                    if (audit == "A") { editor.CurEditStatus = EditorStatus.Look; }
                    else
                    {
                        editor.CurEditStatus = EditorStatus.Modify;
                    }
                    string info = (time2 - time1).TotalSeconds.ToString();
                    G.AppInfo.GGlobal.SetInfo(info);
                    editor.ShowDialog();
                    RefreshData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public virtual void Look()
        {
            try
            {
                if (this.EditorT != null)
                {
                    DateTime time1 = DateTime.Now;

                    BaseEditor editor = System.Activator.CreateInstance(this.EditorT) as BaseEditor;
                    editor.ShowInTaskbar = false;
                    editor.StartPosition = FormStartPosition.CenterScreen;
                    IDbObject obj = gGrid1.GetCurSelect<IDbObject>();
                    editor.KeyId = G.Core.GConvert.ToInt(G.Core.ClassHelper.GetFieldValue(obj, "Id"));
                    
                    var audit = G.Core.ClassHelper.GetFieldValue(obj, AuditField) != null ? G.Core.ClassHelper.GetFieldValue(obj, AuditField).ToString() : "";
                    editor.CurEditStatus = EditorStatus.Look;
                    editor.listTool = new List<string>() { "退出" };

                    DateTime time2 = DateTime.Now;
                    G.AppInfo.GGlobal.SetInfo((time2 - time1).TotalSeconds.ToString());
                    editor.ShowDialog();
                    RefreshData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public virtual void Audit()
        {
            try
            {
                if (this.EditorT != null)
                {
                    DateTime time1 = DateTime.Now;
                    BaseEditor editor = System.Activator.CreateInstance(this.EditorT) as BaseEditor;
                    editor.ShowInTaskbar = false;
                    editor.StartPosition = FormStartPosition.CenterScreen;
                    IDbObject obj = gGrid1.GetCurSelect<IDbObject>();
                    editor.KeyId = G.Core.GConvert.ToInt(G.Core.ClassHelper.GetFieldValue(obj, "Id"));
                    var audit = G.Core.ClassHelper.GetFieldValue(obj, AuditField) != null ? G.Core.ClassHelper.GetFieldValue(obj, AuditField).ToString() : "";

                    editor.CurEditStatus = EditorStatus.Audit;
                    editor.listTool = new List<string>() { "预览", "打印", "|", "审核", "反审", "|", "退出" };

                    DateTime time2 = DateTime.Now;
                    G.AppInfo.GGlobal.SetInfo((time2 - time1).TotalSeconds.ToString());
                    editor.ShowDialog();
                    RefreshData();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public virtual void LoadData()
        {
            try
            {
                if (_Logic != null)
                {
                    int tcount = 0;
                    var EditData = _Logic.IExecuteSelect(G.AppInfo.GGlobal.User, CurCondition, OrderBy.Parse(orderby), 0, 0, ref tcount);
                    //var EditData = _Logic.IGetData(G.AppInfo.GGlobal.User, CurCondition, OrderBy.Parse(orderby), 0, 0, ref tcount);
                    gGrid1.DataBind(EditData);
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public virtual void RefreshData()
        {
            LoadData();
        }
        public virtual void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            Modify();
        }
    }
}
