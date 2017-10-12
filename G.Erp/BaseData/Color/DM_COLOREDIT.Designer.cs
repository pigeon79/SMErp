namespace G.Erp.BaseData
{
    partial class DM_COLOREDIT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_CNAME = new G.Controls.GText();
            this.TXT_CCODE = new G.Controls.GText();
            this.NUM_ADDPRICE = new G.Controls.GNumText();
            this.CHECK_ISWX = new G.Controls.Input.GCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(563, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(563, 259);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ISWX);
            this.c1SplitterPanel1.Controls.Add(this.NUM_ADDPRICE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_CNAME);
            this.c1SplitterPanel1.Controls.Add(this.TXT_CCODE);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(563, 238);
            // 
            // TXT_CNAME
            // 
            this.TXT_CNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CNAME.Caption = "色号名称";
            this.TXT_CNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CNAME.Location = new System.Drawing.Point(91, 61);
            this.TXT_CNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CNAME.Multiline = false;
            this.TXT_CNAME.Name = "TXT_CNAME";
            this.TXT_CNAME.ReadOnly = false;
            this.TXT_CNAME.Size = new System.Drawing.Size(203, 24);
            this.TXT_CNAME.TabIndex = 7;
            this.TXT_CNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CCODE
            // 
            this.TXT_CCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CCODE.Caption = "色号代码";
            this.TXT_CCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CCODE.Location = new System.Drawing.Point(91, 28);
            this.TXT_CCODE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CCODE.Multiline = false;
            this.TXT_CCODE.Name = "TXT_CCODE";
            this.TXT_CCODE.ReadOnly = false;
            this.TXT_CCODE.Size = new System.Drawing.Size(203, 24);
            this.TXT_CCODE.TabIndex = 6;
            this.TXT_CCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_ADDPRICE
            // 
            this.NUM_ADDPRICE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_ADDPRICE.Caption = "加价";
            this.NUM_ADDPRICE.DataType = "Decimal";
            this.NUM_ADDPRICE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_ADDPRICE.Location = new System.Drawing.Point(91, 93);
            this.NUM_ADDPRICE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_ADDPRICE.Name = "NUM_ADDPRICE";
            this.NUM_ADDPRICE.ReadOnly = false;
            this.NUM_ADDPRICE.Size = new System.Drawing.Size(113, 24);
            this.NUM_ADDPRICE.TabIndex = 8;
            this.NUM_ADDPRICE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // CHECK_ISWX
            // 
            this.CHECK_ISWX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ISWX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ISWX.Caption = "外协";
            this.CHECK_ISWX.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ISWX.Location = new System.Drawing.Point(236, 93);
            this.CHECK_ISWX.Name = "CHECK_ISWX";
            this.CHECK_ISWX.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ISWX.ReadOnly = false;
            this.CHECK_ISWX.Size = new System.Drawing.Size(58, 24);
            this.CHECK_ISWX.TabIndex = 9;
            this.CHECK_ISWX.Text = "外协";
            this.CHECK_ISWX.UseVisualStyleBackColor = false;
            this.CHECK_ISWX.Value = null;
            // 
            // DM_COLOREDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 283);
            this.Name = "DM_COLOREDIT";
            this.Text = "DM_AREAEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_CNAME;
        private Controls.GText TXT_CCODE;
        private Controls.GNumText NUM_ADDPRICE;
        private Controls.Input.GCheckBox CHECK_ISWX;
    }
}