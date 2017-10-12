namespace G.Erp.BaseData
{
    partial class DM_WHBLBEDIT
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
            this.TXT_WHBLBNAME = new G.Controls.GText();
            this.TXT_WHBLDM = new G.Controls.GText();
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
            this.c1SplitterPanel1.Controls.Add(this.TXT_WHBLBNAME);
            this.c1SplitterPanel1.Controls.Add(this.TXT_WHBLDM);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(563, 238);
            // 
            // TXT_WHBLBNAME
            // 
            this.TXT_WHBLBNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_WHBLBNAME.Caption = "辅助资料类别名称";
            this.TXT_WHBLBNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_WHBLBNAME.Location = new System.Drawing.Point(91, 61);
            this.TXT_WHBLBNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_WHBLBNAME.Multiline = false;
            this.TXT_WHBLBNAME.Name = "TXT_WHBLBNAME";
            this.TXT_WHBLBNAME.ReadOnly = false;
            this.TXT_WHBLBNAME.Size = new System.Drawing.Size(248, 24);
            this.TXT_WHBLBNAME.TabIndex = 7;
            this.TXT_WHBLBNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_WHBLDM
            // 
            this.TXT_WHBLDM.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_WHBLDM.Caption = "辅助资料类别代码";
            this.TXT_WHBLDM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_WHBLDM.Location = new System.Drawing.Point(91, 28);
            this.TXT_WHBLDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_WHBLDM.Multiline = false;
            this.TXT_WHBLDM.Name = "TXT_WHBLDM";
            this.TXT_WHBLDM.ReadOnly = false;
            this.TXT_WHBLDM.Size = new System.Drawing.Size(248, 24);
            this.TXT_WHBLDM.TabIndex = 6;
            this.TXT_WHBLDM.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DM_WHBLBEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 283);
            this.Name = "DM_WHBLBEDIT";
            this.Text = "DM_AREAEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_WHBLBNAME;
        private Controls.GText TXT_WHBLDM;
    }
}