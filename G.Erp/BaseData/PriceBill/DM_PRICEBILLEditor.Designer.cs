namespace G.Erp.BaseData.PriceBill
{
    partial class DM_PRICEBILLEditor
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
            this.check_USETAG = new G.Controls.Input.GCheckBox();
            this.TXT_REMARK = new G.Controls.GText();
            this.TXT_PBILLNAME = new G.Controls.GText();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGrid1
            // 
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(983, 337);
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(983, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(983, 478);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.check_USETAG);
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_PBILLNAME);
            this.c1SplitterPanel1.Height = 137;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(983, 116);
            this.c1SplitterPanel1.SizeRatio = 28.903D;
            // 
            // check_USETAG
            // 
            this.check_USETAG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_USETAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_USETAG.Caption = "启用";
            this.check_USETAG.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_USETAG.ForeColor = System.Drawing.Color.Black;
            this.check_USETAG.Location = new System.Drawing.Point(542, 12);
            this.check_USETAG.Name = "check_USETAG";
            this.check_USETAG.Padding = new System.Windows.Forms.Padding(1);
            this.check_USETAG.ReadOnly = false;
            this.check_USETAG.Size = new System.Drawing.Size(72, 24);
            this.check_USETAG.TabIndex = 20;
            this.check_USETAG.Text = "启用";
            this.check_USETAG.UseVisualStyleBackColor = false;
            this.check_USETAG.Value = null;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(69, 44);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(663, 51);
            this.TXT_REMARK.TabIndex = 21;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_PBILLNAME
            // 
            this.TXT_PBILLNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PBILLNAME.Caption = "价格簿名";
            this.TXT_PBILLNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_PBILLNAME.Location = new System.Drawing.Point(40, 15);
            this.TXT_PBILLNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PBILLNAME.Multiline = false;
            this.TXT_PBILLNAME.Name = "TXT_PBILLNAME";
            this.TXT_PBILLNAME.ReadOnly = false;
            this.TXT_PBILLNAME.Size = new System.Drawing.Size(319, 21);
            this.TXT_PBILLNAME.TabIndex = 22;
            this.TXT_PBILLNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DM_PRICEBILLEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 502);
            this.Name = "DM_PRICEBILLEditor";
            this.Text = "DM_PRICEBILLEditor";
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Input.GCheckBox check_USETAG;
        private Controls.GText TXT_REMARK;
        private Controls.GText TXT_PBILLNAME;
    }
}