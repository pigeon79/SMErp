namespace G.Controls
{
    partial class GDate
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1DateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1DateEdit1.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateEdit1.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1DateEdit1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1DateEdit1.CustomFormat = "yyyy-MM-dd";
            this.c1DateEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1DateEdit1.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.c1DateEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1DateEdit1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1DateEdit1.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.c1DateEdit1.EmptyAsNull = true;
            this.c1DateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1DateEdit1.Label = this.label1;
            this.c1DateEdit1.Location = new System.Drawing.Point(45, 0);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(99, 19);
            this.c1DateEdit1.TabIndex = 3;
            this.c1DateEdit1.Tag = null;
            this.c1DateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.c1DateEdit1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1DateEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1DateEdit1.TextChanged += new System.EventHandler(this.c1DateEdit1_TextChanged);
            // 
            // GDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1DateEdit1);
            this.Controls.Add(this.label1);
            this.Name = "GDate";
            this.Size = new System.Drawing.Size(144, 23);
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
    }
}
