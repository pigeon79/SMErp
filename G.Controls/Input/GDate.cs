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
    public partial class GDate : UserControl,G.Interface.CLIENT.IControl
    {
        public GDate()
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
                return this.c1DateEdit1.Text;
            }
            set
            {
                this.c1DateEdit1.Text = value;
            }
        }
        public C1.Win.C1Input.C1DateEdit DateEdit { get { return this.c1DateEdit1; } }
        public bool ReadOnly { get { return this.c1DateEdit1.ReadOnly; } set { this.c1DateEdit1.ReadOnly = value; if (value) { c1DateEdit1.BackColor = Color.WhiteSmoke; } else { c1DateEdit1.BackColor = Color.White; } } }
        public bool Enabled { get { return this.c1DateEdit1.Enabled; } set { this.c1DateEdit1.Enabled = value; } }

        public HorizontalAlignment Align
        {
            get { return this.c1DateEdit1.TextAlign; }
            set { this.c1DateEdit1.TextAlign = value; }
        }
        public C1.Win.C1Input.VisualStyle VisualStyle
        {
            get { return this.c1DateEdit1.VisualStyle; }
            set
            {
                this.c1DateEdit1.VisualStyle = value;
            }
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.label1.Font = this.Font;
            this.c1DateEdit1.Font = this.Font;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Height = this.c1DateEdit1.Height;
            this.c1DateEdit1.Width = this.Width - this.label1.Width;
        }
        #endregion
        public delegate void TextEventHandler(object sender, EventArgs e);
        public event TextEventHandler ValueChanged;


        private void c1DateEdit1_TextChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                this.ValueChanged(sender, e);
            }
        }

        public object GetValue()
        {
            c1DateEdit1.ValidateText();
            object o = c1DateEdit1.Value;
            //if (o.ToString()=="") o = null;
            return o;
        }

        public void SetValue(object value)
        {
            c1DateEdit1.Value = value;
        }


        public void NotNullFormat()
        {
            //this.label1.Font = new Font(this.Font, FontStyle.Underline);
            this.label1.ForeColor = Color.Red;
        }
    }
}
