namespace G.Controls
{
    partial class GNumText
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
            this.c1NumericEdit1 = new C1.Win.C1Input.C1NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
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
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1NumericEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1NumericEdit1.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.c1NumericEdit1.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit1.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1NumericEdit1.Label = this.label1;
            this.c1NumericEdit1.Location = new System.Drawing.Point(44, 0);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Size = new System.Drawing.Size(100, 19);
            this.c1NumericEdit1.TabIndex = 3;
            this.c1NumericEdit1.Tag = null;
            this.c1NumericEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.c1NumericEdit1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // GNumText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1NumericEdit1);
            this.Controls.Add(this.label1);
            this.Name = "GNumText";
            this.Size = new System.Drawing.Size(144, 23);
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit1;
    }
}
