namespace G.Erp.BaseData
{
    partial class DM_GXEDIT
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
            this.TXT_GXNAME = new G.Controls.GText();
            this.TXT_GXDM = new G.Controls.GText();
            this.TXT_PY = new G.Controls.GText();
            this.CHECK_STOPTAG = new G.Controls.Input.GCheckBox();
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
            this.c1SplitterPanel1.Controls.Add(this.CHECK_STOPTAG);
            this.c1SplitterPanel1.Controls.Add(this.TXT_PY);
            this.c1SplitterPanel1.Controls.Add(this.TXT_GXNAME);
            this.c1SplitterPanel1.Controls.Add(this.TXT_GXDM);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(563, 238);
            // 
            // TXT_GXNAME
            // 
            this.TXT_GXNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_GXNAME.Caption = "工序名称";
            this.TXT_GXNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_GXNAME.Location = new System.Drawing.Point(91, 61);
            this.TXT_GXNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_GXNAME.Multiline = false;
            this.TXT_GXNAME.Name = "TXT_GXNAME";
            this.TXT_GXNAME.ReadOnly = false;
            this.TXT_GXNAME.Size = new System.Drawing.Size(203, 24);
            this.TXT_GXNAME.TabIndex = 2;
            this.TXT_GXNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.TXT_GXNAME.Leave += new System.EventHandler(this.TXT_GXNAME_Leave);
            // 
            // TXT_GXDM
            // 
            this.TXT_GXDM.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_GXDM.Caption = "工序代码";
            this.TXT_GXDM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_GXDM.Location = new System.Drawing.Point(91, 28);
            this.TXT_GXDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_GXDM.Multiline = false;
            this.TXT_GXDM.Name = "TXT_GXDM";
            this.TXT_GXDM.ReadOnly = false;
            this.TXT_GXDM.Size = new System.Drawing.Size(203, 24);
            this.TXT_GXDM.TabIndex = 1;
            this.TXT_GXDM.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_PY
            // 
            this.TXT_PY.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PY.Caption = "助记符";
            this.TXT_PY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_PY.Location = new System.Drawing.Point(91, 93);
            this.TXT_PY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_PY.Multiline = false;
            this.TXT_PY.Name = "TXT_PY";
            this.TXT_PY.ReadOnly = false;
            this.TXT_PY.Size = new System.Drawing.Size(134, 24);
            this.TXT_PY.TabIndex = 3;
            this.TXT_PY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // CHECK_STOPTAG
            // 
            this.CHECK_STOPTAG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_STOPTAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_STOPTAG.Caption = "是否停用";
            this.CHECK_STOPTAG.ForeColor = System.Drawing.Color.Black;
            this.CHECK_STOPTAG.Location = new System.Drawing.Point(91, 124);
            this.CHECK_STOPTAG.Name = "CHECK_STOPTAG";
            this.CHECK_STOPTAG.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_STOPTAG.ReadOnly = false;
            this.CHECK_STOPTAG.Size = new System.Drawing.Size(84, 24);
            this.CHECK_STOPTAG.TabIndex = 4;
            this.CHECK_STOPTAG.Text = "是否停用";
            this.CHECK_STOPTAG.UseVisualStyleBackColor = false;
            this.CHECK_STOPTAG.Value = null;
            // 
            // DM_GXEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 283);
            this.Name = "DM_GXEDIT";
            this.Text = "DM_GXEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_GXNAME;
        private Controls.GText TXT_GXDM;
        private Controls.GText TXT_PY;
        private Controls.Input.GCheckBox CHECK_STOPTAG;
    }
}