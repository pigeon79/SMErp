namespace G.Controls.GGrid
{
    partial class CutPager
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
            this.BTN_FIRST = new C1.Win.C1Input.C1Button();
            this.BTN_PRV = new C1.Win.C1Input.C1Button();
            this.NUM_PAGE = new C1.Win.C1Input.C1NumericEdit();
            this.BTN_NEXT = new C1.Win.C1Input.C1Button();
            this.BTN_LAST = new C1.Win.C1Input.C1Button();
            this.LAB_PAGEINFO = new C1.Win.C1Input.C1Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LAB_PageRowsInfo = new C1.Win.C1Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_PAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_PAGEINFO)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_PageRowsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_FIRST
            // 
            this.BTN_FIRST.Location = new System.Drawing.Point(-3, 0);
            this.BTN_FIRST.Name = "BTN_FIRST";
            this.BTN_FIRST.Size = new System.Drawing.Size(25, 25);
            this.BTN_FIRST.TabIndex = 0;
            this.BTN_FIRST.Text = "<<";
            this.BTN_FIRST.UseVisualStyleBackColor = true;
            this.BTN_FIRST.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.BTN_FIRST.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.BTN_FIRST.Click += new System.EventHandler(this.BTN_FIRST_Click);
            // 
            // BTN_PRV
            // 
            this.BTN_PRV.Location = new System.Drawing.Point(26, 0);
            this.BTN_PRV.Name = "BTN_PRV";
            this.BTN_PRV.Size = new System.Drawing.Size(25, 25);
            this.BTN_PRV.TabIndex = 0;
            this.BTN_PRV.Text = "<";
            this.BTN_PRV.UseVisualStyleBackColor = true;
            this.BTN_PRV.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.BTN_PRV.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.BTN_PRV.Click += new System.EventHandler(this.BTN_PRV_Click);
            // 
            // NUM_PAGE
            // 
            this.NUM_PAGE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.NUM_PAGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.NUM_PAGE.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.NUM_PAGE.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.NUM_PAGE.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.NUM_PAGE.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.NUM_PAGE.DisplayFormat.NullText = "1";
            this.NUM_PAGE.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.NUM_PAGE.EditFormat.NullText = "1";
            this.NUM_PAGE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_PAGE.Location = new System.Drawing.Point(58, 2);
            this.NUM_PAGE.MaxLength = 100;
            this.NUM_PAGE.Name = "NUM_PAGE";
            this.NUM_PAGE.NullText = "1";
            this.NUM_PAGE.ParseInfo.FormatType = C1.Win.C1Input.FormatTypeEnum.Integer;
            this.NUM_PAGE.ParseInfo.Inherit = ((C1.Win.C1Input.ParseInfoInheritFlags)(((((((C1.Win.C1Input.ParseInfoInheritFlags.CaseSensitive | C1.Win.C1Input.ParseInfoInheritFlags.CustomFormat) 
            | C1.Win.C1Input.ParseInfoInheritFlags.NullText) 
            | C1.Win.C1Input.ParseInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.ParseInfoInheritFlags.ErrorMessage) 
            | C1.Win.C1Input.ParseInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.ParseInfoInheritFlags.TrimEnd)));
            this.NUM_PAGE.Size = new System.Drawing.Size(56, 21);
            this.NUM_PAGE.TabIndex = 1;
            this.NUM_PAGE.Tag = null;
            this.NUM_PAGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_PAGE.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            this.NUM_PAGE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.NUM_PAGE.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.NUM_PAGE.Formatting += new C1.Win.C1Input.FormatEventHandler(this.NUM_PAGE_Formatting);
            this.NUM_PAGE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NUM_PAGE_KeyDown);
            // 
            // BTN_NEXT
            // 
            this.BTN_NEXT.Location = new System.Drawing.Point(149, 1);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(25, 25);
            this.BTN_NEXT.TabIndex = 0;
            this.BTN_NEXT.Text = ">";
            this.BTN_NEXT.UseVisualStyleBackColor = true;
            this.BTN_NEXT.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.BTN_NEXT.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.BTN_NEXT.Click += new System.EventHandler(this.BTN_NEXT_Click);
            // 
            // BTN_LAST
            // 
            this.BTN_LAST.Location = new System.Drawing.Point(178, 1);
            this.BTN_LAST.Name = "BTN_LAST";
            this.BTN_LAST.Size = new System.Drawing.Size(25, 25);
            this.BTN_LAST.TabIndex = 0;
            this.BTN_LAST.Text = ">>";
            this.BTN_LAST.UseVisualStyleBackColor = true;
            this.BTN_LAST.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.BTN_LAST.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.BTN_LAST.Click += new System.EventHandler(this.BTN_LAST_Click);
            // 
            // LAB_PAGEINFO
            // 
            this.LAB_PAGEINFO.AutoSize = true;
            this.LAB_PAGEINFO.BackColor = System.Drawing.Color.Transparent;
            this.LAB_PAGEINFO.BorderColor = System.Drawing.Color.Empty;
            this.LAB_PAGEINFO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LAB_PAGEINFO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LAB_PAGEINFO.ForeColor = System.Drawing.Color.Black;
            this.LAB_PAGEINFO.Location = new System.Drawing.Point(116, 6);
            this.LAB_PAGEINFO.Margin = new System.Windows.Forms.Padding(3);
            this.LAB_PAGEINFO.Name = "LAB_PAGEINFO";
            this.LAB_PAGEINFO.Size = new System.Drawing.Size(21, 14);
            this.LAB_PAGEINFO.TabIndex = 2;
            this.LAB_PAGEINFO.Tag = null;
            this.LAB_PAGEINFO.Text = "页";
            this.LAB_PAGEINFO.TextDetached = true;
            this.LAB_PAGEINFO.Value = "页";
            this.LAB_PAGEINFO.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LAB_PAGEINFO);
            this.panel1.Controls.Add(this.BTN_NEXT);
            this.panel1.Controls.Add(this.BTN_FIRST);
            this.panel1.Controls.Add(this.NUM_PAGE);
            this.panel1.Controls.Add(this.BTN_PRV);
            this.panel1.Controls.Add(this.BTN_LAST);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(438, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 27);
            this.panel1.TabIndex = 3;
            // 
            // LAB_PageRowsInfo
            // 
            this.LAB_PageRowsInfo.AutoSize = true;
            this.LAB_PageRowsInfo.BackColor = System.Drawing.Color.Transparent;
            this.LAB_PageRowsInfo.BorderColor = System.Drawing.Color.Empty;
            this.LAB_PageRowsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LAB_PageRowsInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LAB_PageRowsInfo.ForeColor = System.Drawing.Color.Black;
            this.LAB_PageRowsInfo.Location = new System.Drawing.Point(3, 4);
            this.LAB_PageRowsInfo.Margin = new System.Windows.Forms.Padding(3);
            this.LAB_PageRowsInfo.Name = "LAB_PageRowsInfo";
            this.LAB_PageRowsInfo.Size = new System.Drawing.Size(0, 14);
            this.LAB_PageRowsInfo.TabIndex = 4;
            this.LAB_PageRowsInfo.Tag = null;
            this.LAB_PageRowsInfo.TextDetached = true;
            this.LAB_PageRowsInfo.Value = "";
            this.LAB_PageRowsInfo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // CutPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.LAB_PageRowsInfo);
            this.Controls.Add(this.panel1);
            this.Name = "CutPager";
            this.Size = new System.Drawing.Size(669, 27);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_PAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_PAGEINFO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_PageRowsInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1Button BTN_FIRST;
        private C1.Win.C1Input.C1Button BTN_PRV;
        private C1.Win.C1Input.C1NumericEdit NUM_PAGE;
        private C1.Win.C1Input.C1Button BTN_NEXT;
        private C1.Win.C1Input.C1Button BTN_LAST;
        private C1.Win.C1Input.C1Label LAB_PAGEINFO;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1Label LAB_PageRowsInfo;


    }
}
