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
using G.Core.Common;

namespace G.APP.BaseForm
{
    public partial class DataBaseReport : BasicForm
    {
        public DataBaseReport()
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
        string _Csql = "";
        public string Csql { set { _Csql = value; } get { return _Csql; } }
        public CutPageType CutPageType { get; set; }
        public void SetColumns(List<ColumnInfo> columns) { gGrid1.SetColumns(columns); }
        private string m_DynamicRowColorFiled = "";
        public string DynamicRowColorFiled { set { DynamicRowColorFiled = value; } get { return DynamicRowColorFiled; } }
        private Color m_DynamicRowColorName = Color.Red;
        public Color DynamicRowColorName { set { m_DynamicRowColorName = value; } get { return m_DynamicRowColorName; } }
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
            CuterData(e.PageIndex);
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
                    Exit();
                    break;
            }
        }
        private void Exit() { 
            BasicForm f = this.ParentForm as BasicForm;
                    if (f != null)
                    {
                        this.Close();
                        f.DisplayOut((int)this.MenuId);
                    }
                    else { this.Close(); }
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
            else {
                return false;
            }
            
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
        public DataSet DataSource = null;
        public virtual void DynamicRowColor(int curRow,OwnerDrawCellEventArgs e) {
            //动态列背景色
            if (this.DynamicRowColorFiled != "")
            {
                if (G.Core.GConvert.ToBool(this.DataSource.Tables[0].Rows[curRow - this.gGrid1.Rows.Fixed][this.DynamicRowColorFiled]))
                {
                    for (int i = 0; i < this.gGrid1.Cols.Count; i++)
                    {
                        CellStyle s = this.gGrid1.Cols[curRow].Style;
                        CellStyle s1 = this.gGrid1.Styles[s.Name + "_DynaTrueColor"];
                        if (s1 == null)
                        {
                            s1 = this.gGrid1.Styles.Add(s.Name + "_DynaTrueColor", s1);
                            s1.ForeColor = this.DynamicRowColorName;
                        }
                        e.Style = s1;
                    }
                }
            }
        }
        //public DataSet AllData = null;
        /// <summary>
        /// 服务器获取数据
        /// </summary>
        /// <param name="index"></param>
        public virtual void LoadData(int index)
        {
            try
            {
                if (_Logic != null && _Csql!="")
                {
                    this.PageIndex = index;
                    var EditData = _Logic.IGetData(G.AppInfo.GGlobal.User, _Csql, CurCondition, OrderBy.Parse(orderby), PageSize, PageIndex, ref AllCount);
                    if (this.CutPageType == CutPageType.customer)//客户端分页
                    {
                        DataSource = EditData;
                        CuterData(index);
                    }
                    else
                    {
                        this.DataSource = EditData;
                        gGrid1.DataBind(DataSource.Tables[0]);
                        this.cutPager1.PageSize = AllCount;
                        this.cutPager1.AllCount = AllCount;
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="index"></param>
        public virtual void CuterData(int index) {
            if (this.CutPageType == CutPageType.customer)//客户端分页
            {
                this.PageIndex = index;
                var d = G.Core.Common.DataPage.DataSetPage(this.DataSource,index,PageSize);
                gGrid1.DataBind(d.Tables[0]);
                this.cutPager1.AllCount = this.DataSource.Tables[0].Rows.Count;
            }
            else { LoadData(index); }
        }
        public DataRow GetCurSelect() {
            DataRow r = null;
            int i = this.gGrid1.Row - this.gGrid1.Rows.Fixed;
            if (i >= 0)
            {
                try
                {
                    r = this.DataSource.Tables[0].Rows[i];
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return r;
        }
        public virtual void RefreshData()
        {
            LoadData(this.PageIndex);
        }
    }
}
