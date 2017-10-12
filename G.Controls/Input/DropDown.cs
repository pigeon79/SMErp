using System;
using System.Collections.Generic;
using System.Text;
using C1.Win.C1Input;
using System.Threading;
using System.Windows.Forms;
using G.Data.Definition;
using G.Data;
using G.Interface.BLL;
using G.Interface.Event;
using System.Data;
using G.Controls.GGrid;

namespace G.Controls.Input
{
    public class DropDown : C1DropDownControl, G.Interface.CLIENT.IControl
    {
        private Input.DefaultDropDownList dDF;

        public event EventHandler<DataRowEvent> RowSelected;
        public DropDown()
        {
            this.TextDetached = true;
            this.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.DropDownForm = new Input.DefaultDropDownList();
            dDF = (Input.DefaultDropDownList)this.DropDownForm;

            //dDF.EventRowSelected += dropDownForm_RowSelected;
            dDF.EventRequestClose += dropDownForm_RequestClose;
        }
        private ISearch _logic;
        /// <summary>
        /// 业务逻辑获取数据的接口
        /// </summary>
        public ISearch Logic
        {
            set { _logic = value; }
            get { return _logic; }
        }
        private bool _isText=false;
        /// <summary>
        /// 是否返回输入数据
        /// </summary>
        public bool IsText { get { return _isText; } set { _isText = value; } }
        public Condition DefaultCondition { get; set; }
        /// <summary>
        /// 显示值字段
        /// </summary>
        public string TextField { get; set; }
        /// <summary>
        /// 保存值字段
        /// </summary>
        public string ValueField { get; set; }
        private BaseSearchForm OpenForm = null;
        //点按钮打开列表
        public BaseSearchForm CustomerDropDownForm
        {
            set { this.OpenForm = value; if (OpenForm != null) { this.OpenForm.EventRowSelected += dropDownForm_RowSelected; } }
            get { return this.OpenForm; }
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (dDF != null)
            {
                //dDF.EventRowSelected -= dropDownForm_RowSelected;
                dDF.EventRequestClose -= dropDownForm_RequestClose;
            }
            if (OpenForm != null)
            {
                this.OpenForm.EventRowSelected -= dropDownForm_RowSelected;
            }
        }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, int new_FieldWidth)
        {
            dDF.AddGridColumn(new_FieldName, new_FieldCaption, new_DataType, new_FieldWidth);
        }
        public bool InitGridEnd = false;
        public void GridEndInit() {

            if (!InitGridEnd)
            {
                dDF.InitColumns();
                InitGridEnd = true;
            }
        
        }

        private bool isEnter = false;
        //回车打开
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                isEnter = true;
                if (!this.DroppedDown)
                {
                    searchText = this.Text;
                    SearchDataTable = SearchData();
                    if (SearchDataTable.Rows.Count == 1)
                    {
                        this.dropDownForm_RowSelected(null, new DataRowEvent { DataRow = SearchDataTable.Rows[0] });
                    }
                    else
                    {
                        this.OpenDropDown();
                    }
                }
                else
                {
                    this.CloseDropDown();
                }
                isEnter = false;

            }
            else
            {
                base.OnKeyDown(e);
            }

            //}
        }
        DataTable SearchDataTable = new DataTable();
        bool isOpenForm = false;
        //打开数据列表
        public override void OpenDropDown()
        {
            if (OpenForm != null && !isEnter)
            {
                isOpenForm = true;
                this.OpenForm.ChangeStatus();
                this.OpenForm.ShowDialog();
            }
            else
            {
                if (!isEnter)
                {
                    SearchDataTable = SearchData();
                }
                dDF.SetData(SearchDataTable);
                base.OpenDropDown();
            }
        }
        public override void CloseDropDown(bool doPost)
        {
            base.CloseDropDown(doPost);
            if (doPost)
            {
                if (OpenForm == null || !isOpenForm)
                {
                    DataRow dr = this.dDF.SelectRow;
                    this.dropDownForm_RowSelected(null, new DataRowEvent { DataRow = dr });
                }
                
            }
            isOpenForm = false;
        }
        private string searchText = "";
        private DataTable SearchData()
        {
            DataTable list = new DataTable();
            try
            {

                if (_logic != null)
                {
                    list = _logic.SearchValue(this.DefaultCondition, searchText, "", "");

                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return list;
        }
        private void dropDownForm_RowSelected(object sender, DataRowEvent e)
        {
            this.SetData(e.DataRow);
            if (RowSelected != null && this.Tag != null)
            {
                DataRowEvent de = new DataRowEvent() { DataRow = this.Tag as DataRow };
                RowSelected(this, de);
            }
        }
        private void SetData(DataRow dr) {
            if (dr != null)
            {
                this.Tag = dr;
                this.Value = dr[this.ValueField];
                this.Text = dr[this.TextField].ToString();
            }
            else
            {
                this.Tag = null;
                this.Value = "";
                this.Text = "";
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Text == "") { this.ClearValue(); }
        }
        private void dropDownForm_RequestClose(object sender, EventArgs e)
        {
            this.CloseDropDown(true);
        }

        public object GetValue()
        {
            if (IsText) { return this.Text; }
            else
            {
                return this.Value;
            }
        }
        public void ClearValue()
        {
            this.Value = "";
            this.Text = "";
            this.Tag = null;
        }
        public void SetValue(object value)
        {
            if (IsText) { this.Text = value.ToString(); this.Value = value.ToString(); }
            else
            {
                if (_logic != null)
                {
                    if (value == null) value = "";
                    if (G.Core.GConvert.ToString(value) != "")
                    {
                        //string field=this.
                        DataTable list = _logic.SearchValue(this.DefaultCondition, value.ToString(), "", this.ValueField);
                        if (list.Rows.Count == 1)
                        {
                            SetData(list.Rows[0]);
                        }
                        else
                        {
                            SetData(null);
                        }
                    }
                    else {
                        SetData(null);
                    }
                }
            }
        }



        public void NotNullFormat()
        {
            throw new NotImplementedException();
        }
    }
}
