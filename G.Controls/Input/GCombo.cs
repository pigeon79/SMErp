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
    public partial class GCombo : UserControl, G.Interface.CLIENT.IControl
    {
        public GCombo()
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
                return this.c1Combo1.Text;
            }
            set
            {
                this.c1Combo1.Text = value;
            }
        }
        public bool ReadOnly { set { c1Combo1.ReadOnly = value; if (value) { c1Combo1.BackColor = Color.WhiteSmoke; } else { c1Combo1.BackColor = Color.White; } } get { return this.c1Combo1.ReadOnly; } }
        public C1.Win.C1List.C1Combo Combo { get { return this.c1Combo1; } }
        public HorizontalAlignment Align
        {
            get { return this.c1Combo1.TextAlign; }
            set { this.c1Combo1.TextAlign = value; }
        }
        public C1.Win.C1List.VisualStyle VisualStyle
        {
            get { return this.c1Combo1.VisualStyle; }
            set
            {
                this.c1Combo1.VisualStyle = value;
            }
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.label1.Font = this.Font;
            this.c1Combo1.Font = this.Font;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Height = this.c1Combo1.Height;
            this.c1Combo1.Width = this.Width - this.label1.Width;
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
                int i = 0;
                this.c1Combo1.Columns.Clear();
                this.c1Combo1.ExtendRightColumn = true;
                foreach (string key in value.Keys)
                {
                    this.c1Combo1.Columns.Add(new C1.Win.C1List.C1DataColumn());
                    this.c1Combo1.Splits[0, 0].DisplayColumns[i].DataColumn.Caption = value[key];
                    this.c1Combo1.Splits[0, 0].DisplayColumns[i].DataColumn.DataField = key;
                    if (i == 1)
                    {
                        this.c1Combo1.Splits[0, 0].DisplayColumns[i].Visible = false;
                    }
                    i++;
                }
            }
        }

        private void c1Combo1_TextChanged(object sender, EventArgs e)
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
                    this.c1Combo1.HoldFields();
                    
                    this.c1Combo1.DisplayMember = "CName";
                    this.c1Combo1.ValueMember = "CValue";
                    this.InitData<comboData>(datalist);
                }
            }
        }
        private String m_Data = "";
        private List<comboData> datalist = new List<comboData>() { };

        public void InitData<T>(List<T> list)
        {
            this.c1Combo1.DataSource = list;

        }
        public object GetValue()
        {
            return c1Combo1.SelectedValue;
        }

        public void SetValue(object value)
        {
            c1Combo1.SelectedValue = value == null ? "" : value;
        }


        public void NotNullFormat()
        {
            //this.label1.Font = new Font(this.Font, FontStyle.Underline);
            this.label1.ForeColor = Color.Red;
        }
    }
    public class comboData
    {
        public comboData(string name, string value)
        {
            this.CValue = value;
            this.CName = name;
        }
        public String CValue { get; set; }
        public String CName { get; set; }
    }
}
