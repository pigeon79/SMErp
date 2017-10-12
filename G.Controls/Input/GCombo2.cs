using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Controls
{
    public partial class GCombo2 : UserControl, G.Interface.CLIENT.IControl
    {
        public GCombo2()
        {
            InitializeComponent();
        }
        #region 外观
        public string Caption
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }
        public override string Text
        {
            get
            {
                return this.comboBox1.Text;
            }
            set
            {
                this.comboBox1.Text = value;
            }
        }
        public bool ReadOnly { set { comboBox1.Enabled = !value; } get { return !this.comboBox1.Enabled; } }
        public ComboBox Combo { get { return this.comboBox1; } }
        public HorizontalAlignment Align
        {
            get;
            set;
        }
        public C1.Win.C1List.VisualStyle VisualStyle
        {
            get;
            set;
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.label1.Font = this.Font;
            this.comboBox1.Font = this.Font;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Height = this.comboBox1.Height;
            this.comboBox1.Width = this.Width - this.label1.Width;
        }
        #endregion
        public delegate void TextEventHandler(object sender, EventArgs e);
        public event TextEventHandler ValueChanged;

        Dictionary<string, string> m_Columns = new Dictionary<string, string>();
        public Dictionary<string, string> Columns
        {
            get { return m_Columns; }
            set
            {
                m_Columns = value;
                //int i = 0;
                //this.comboBox1.Columns.Clear();
                //this.comboBox1.ExtendRightColumn = true;
                //foreach (string key in value.Keys)
                //{
                //    this.comboBox1.Columns.Add(new C1.Win.C1List.C1DataColumn());
                //    this.comboBox1.Splits[0, 0].DisplayColumns[i].DataColumn.Caption = value[key];
                //    this.comboBox1.Splits[0, 0].DisplayColumns[i].DataColumn.DataField = key;
                //    if (i == 1)
                //    {
                //        this.comboBox1.Splits[0, 0].DisplayColumns[i].Visible = false;
                //    }
                //    i++;
                //}
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                this.ValueChanged(sender, e);
            }
        }

        /// <summary>
        /// 数据格式 名称：值,名称：值
        /// </summary>
        public String Data
        {
            get { return m_Data; }
            set
            {
                if (!value.IsNullOrEmpty())
                {
                    m_Data = value;
                    foreach (string s in value.Split(','))
                    {
                        string n = "", v = "";
                        if (s.Contains(':'))
                        {
                            n = s.Split(':')[0];
                            v = s.Split(':')[1];
                        }
                        else { n = s; v = s; }
                        datalist.Add(new comboData(n, v));
                    }
                    this.Columns = new Dictionary<string, string>() { { "CName", "名称" }, { "CValue", "值" } };
             
                    
                    this.comboBox1.DisplayMember = "CName";
                    this.comboBox1.ValueMember = "CValue";
                    this.InitData<comboData>(datalist);
                }
            }
        }
        private String m_Data = "";
        private List<comboData> datalist = new List<comboData>() { };

        public void InitData<T>(List<T> list)
        {
            this.comboBox1.DataSource = list;

        }
        public object GetValue()
        {
            return comboBox1.SelectedValue;
        }

        public void SetValue(object value)
        {
            comboBox1.SelectedValue = value;
        }


        public void NotNullFormat()
        {
            //this.label1.Font = new Font(this.Font, FontStyle.Underline);
            this.label1.ForeColor = Color.Red;
        }
    }
}
