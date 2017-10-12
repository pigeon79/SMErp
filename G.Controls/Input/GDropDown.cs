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
using G.Controls.Input;
using System.Drawing;

namespace G.Controls
{
    public class GDropDown : UserControl, G.Interface.CLIENT.IControl
    {
        public GDropDown()
        {
            InitializeComponent();
            dropDown1.ValueChanged += dropDown1_ValueChanged;
            dropDown1.RowSelected += dropDown1_RowSelected;
        }
        public event EventHandler<DataRowEvent> RowSelect;
        void dropDown1_RowSelected(object sender, DataRowEvent e)
        {
            if (RowSelect != null)
            {
                RowSelect(sender, e);
            }
        }

        public event EventHandler ValueChanged;
        void dropDown1_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(sender, e);
            }
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
                return this.dropDown1.Text;
            }
            set
            {
                this.dropDown1.Text = value;
            }
        }
        public object Value
        {
            get
            {
                return this.dropDown1.Value;
            }
            set
            {
                this.dropDown1.Value = value;
            }
        }
        public bool ReadOnly { get { return this.dropDown1.ReadOnly; } set { this.dropDown1.ReadOnly = value; if (value) { dropDown1.BackColor = Color.WhiteSmoke; } else { dropDown1.BackColor = Color.White; } } }
        public bool Enabled { get { return this.dropDown1.Enabled; } set { this.dropDown1.Enabled = value; } }
        public G.Controls.Input.DropDown DropDown { get { return this.dropDown1; } }
        public HorizontalAlignment Align
        {
            get { return this.dropDown1.TextAlign; }
            set { this.dropDown1.TextAlign = value; }
        }
        public C1.Win.C1Input.VisualStyle VisualStyle
        {
            get { return this.dropDown1.VisualStyle; }
            set
            {
                this.dropDown1.VisualStyle = value;
            }
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.label1.Font = this.Font;
            this.dropDown1.Font = this.Font;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Height = this.dropDown1.Height;
            this.dropDown1.Width = this.Width - this.label1.Width;
        }
        #endregion
        private Label label1;
        private G.Controls.Input.DropDown dropDown1;
        /// <summary>
        /// 业务逻辑获取数据的接口
        /// </summary>
        public ISearch Logic
        {
            set { dropDown1.Logic = value; }
            get { return dropDown1.Logic; }
        }
        public bool IsText { get { return dropDown1.IsText; } set { dropDown1.IsText = value; } }
        public Condition DefaultCondition { set { dropDown1.DefaultCondition = value; } }
        /// <summary>
        /// 显示值字段
        /// </summary>
        public string TextField { get { return dropDown1.TextField; } set { dropDown1.TextField = value; } }
        /// <summary>
        /// 保存值字段
        /// </summary>
        public string ValueField { get { return dropDown1.ValueField; } set { dropDown1.ValueField = value; } }
        //点按钮打开列表
        public BaseSearchForm CustomerDropDownForm
        {
            set { dropDown1.CustomerDropDownForm = value; }
            get { return dropDown1.CustomerDropDownForm; }
        }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, int new_FieldWidth)
        {
            dropDown1.AddGridColumn(new_FieldName, new_FieldCaption, new_DataType, new_FieldWidth);
        }
        public void GridEndInit()
        {
            dropDown1.GridEndInit();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dropDown1 = new G.Controls.Input.DropDown();
            ((System.ComponentModel.ISupportInitialize)(this.dropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // dropDown1
            // 
            this.dropDown1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.dropDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropDown1.CustomerDropDownForm = null;
            this.dropDown1.DefaultCondition = null;
            this.dropDown1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropDown1.Location = new System.Drawing.Point(41, 0);
            this.dropDown1.Logic = null;
            this.dropDown1.Name = "dropDown1";
            this.dropDown1.Size = new System.Drawing.Size(171, 19);
            this.dropDown1.TabIndex = 4;
            this.dropDown1.Tag = null;
            this.dropDown1.TextDetached = true;
            this.dropDown1.TextField = null;
            this.dropDown1.Value = "";
            this.dropDown1.ValueField = null;
            this.dropDown1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dropDown1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dropDown1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // GDropDown
            // 
            this.Controls.Add(this.dropDown1);
            this.Controls.Add(this.label1);
            this.Name = "GDropDown";
            this.Size = new System.Drawing.Size(212, 23);
            ((System.ComponentModel.ISupportInitialize)(this.dropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        public object GetValue()
        {
            return this.dropDown1.GetValue();
        }
        public void ClearValue() { this.dropDown1.ClearValue(); }
        public void SetValue(object value)
        {
            this.dropDown1.SetValue(value);
        }


        public void NotNullFormat()
        {
            //this.label1.Font = new Font(this.Font, FontStyle.Underline);
            this.label1.ForeColor = Color.Red;
        }
    }
}
