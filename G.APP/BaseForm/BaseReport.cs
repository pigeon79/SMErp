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
    public partial class BaseReport : BasicForm
    {
        public BaseReport()
        {
            InitializeComponent();
        }
        public virtual string listCaption {
            set {
                this.Text = value;
                this.c1SplitterPanel1.Text = value;
            }
        }
        public void IsChecked() {
            this.gGrid1.AllowEditing = true;
            this.gGrid1.SelectionMode = SelectionModeEnum.Default;
            this.gGrid1.FocusRect = FocusRectEnum.Light;
        }
        public int PageIndex = 0;
        public int AllCount = 0;
        public int PageSize = 200;
        List<string> _listTool = new List<string>();

        public Type EntityT { get; set; }
        //public Type EditorT { get; set; }
        public List<string> listTool { get { return _listTool; } set { _listTool = value; } }
        public string orderby { get; set; }
        IBaseBLL _Logic = null;
        public IBaseBLL Logic { set { _Logic = value; } get { return _Logic; } }

        public void SetColumns(List<ColumnInfo> columns) { gGrid1.SetColumns(columns); }

        public override bool LoadForm()
        {
            InitToolBar();
            InitForm();
            this.cutPager1.PageSize = PageSize;
            this.cutPager1.EventPaging += cutPager1_EventPaging;
            InitFilter();
            return Filter();
            //LoadData(0);
            
        }

        void cutPager1_EventPaging(EventPagingArg e)
        {
            LoadData(e.PageIndex);
        }
        public virtual void InitToolBar()
        {

            foreach (string s in listTool) { 
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
                case "刷新":
                    RefreshData();
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
        private Data.Condition CurCondition = Data.Condition.Empty;
        public List<FilterInfo> FilterInfos = new List<FilterInfo>();
        public BaseFilter fform = null;
        public virtual void InitFilter() { 
            
        }
        private bool Filter()
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
                return true;
            }
            else { return false; }
            
        }
        public virtual void Export() {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel2003 (*.xls)|*.xls |Excel 2007 (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.gGrid1.SaveExcel(sfd.FileName,FileFlags.IncludeFixedCells);
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        public virtual void Print() {
            gGrid1.PrintGrid(this.Text,PrintGridFlags.ShowPrintDialog);
           
        }
        public virtual void InitForm()
        {
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();

        }
        public IEnumerable<IDbObject> DataSource = null;
        public virtual void LoadData(int index)
        {
            try
            {
                if (_Logic != null)
                {
                    this.PageIndex = index;
                    var EditData = _Logic.IExecuteSelect(G.AppInfo.GGlobal.User, CurCondition, OrderBy.Parse(orderby), PageSize, PageIndex, ref AllCount);
                    this.DataSource = EditData as IEnumerable<IDbObject>;
                    gGrid1.DataBind(EditData);
                    this.cutPager1.AllCount = AllCount;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public virtual void RefreshData()
        {
            LoadData(this.PageIndex);
        }
    }
}
