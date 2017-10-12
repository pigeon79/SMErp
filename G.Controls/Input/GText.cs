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
    public partial class GText : UserControl,G.Interface.CLIENT.IControl
    {
        public GText()
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
                return this.c1TextBox1.Text;
            }
            set
            {
                bool ro = this.c1TextBox1.ReadOnly;
                this.c1TextBox1.ReadOnly = false;
                this.c1TextBox1.Text = value;
                this.c1TextBox1.ReadOnly = ro;
            }
        }
        public bool ReadOnly {
            get { return this.c1TextBox1.ReadOnly; }
            set { this.c1TextBox1.ReadOnly = value; if (value) { c1TextBox1.BackColor = Color.WhiteSmoke; } else { c1TextBox1.BackColor = Color.White; } }
        }
        public C1.Win.C1Input.C1TextBox TextBox { get { return this.c1TextBox1; } }
        public HorizontalAlignment Align
        {
            get { return this.c1TextBox1.TextAlign; }
            set { this.c1TextBox1.TextAlign = value; }
        }
        public C1.Win.C1Input.VisualStyle VisualStyle
        {
            get { return this.c1TextBox1.VisualStyle; }
            set
            {
                this.c1TextBox1.VisualStyle = value;
            }
        }
        public bool Multiline
        {
            set { c1TextBox1.Multiline = value; }
            get { return this.c1TextBox1.Multiline; }
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.label1.Font = this.Font;
            this.c1TextBox1.Font = this.Font;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Height = this.c1TextBox1.Height;
            this.c1TextBox1.Width = this.Width - this.label1.Width;
        }
        #endregion
        public delegate void TextEventHandler(object sender, EventArgs e);
        public event TextEventHandler ValueChanged;

        private void c1TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                this.ValueChanged(sender, e);
            }
        }

        public object GetValue()
        {
            c1TextBox1.ValidateText();
            return c1TextBox1.Text;
        }

        public void SetValue(object value)
        {
            c1TextBox1.Value = G.Core.GConvert.ToString(value);
        }


        public void NotNullFormat()
        {
            //this.label1.Font = new Font(this.Font, FontStyle.Underline);
            this.label1.ForeColor = Color.Red;
        }

        private void c1TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }
        

    }
}
