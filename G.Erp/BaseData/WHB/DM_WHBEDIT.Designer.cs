namespace G.Erp.BaseData
{
    partial class DM_WHBEDIT
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
            this.TXT_WHBNAME = new G.Controls.GText();
            this.TXT_WHBDM = new G.Controls.GText();
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
            this.c1SplitterPanel1.Controls.Add(this.TXT_WHBNAME);
            this.c1SplitterPanel1.Controls.Add(this.TXT_WHBDM);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(563, 238);
            // 
            // TXT_WHBNAME
            // 
            this.TXT_WHBNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_WHBNAME.Caption = "辅助资料名称";
            this.TXT_WHBNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_WHBNAME.Location = new System.Drawing.Point(158, 79);
            this.TXT_WHBNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_WHBNAME.Multiline = false;
            this.TXT_WHBNAME.Name = "TXT_WHBNAME";
            this.TXT_WHBNAME.ReadOnly = false;
            this.TXT_WHBNAME.Size = new System.Drawing.Size(225, 24);
            this.TXT_WHBNAME.TabIndex = 7;
            this.TXT_WHBNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_WHBDM
            // 
            this.TXT_WHBDM.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_WHBDM.Caption = "辅助资料代码";
            this.TXT_WHBDM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_WHBDM.Location = new System.Drawing.Point(158, 46);
            this.TXT_WHBDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_WHBDM.Multiline = false;
            this.TXT_WHBDM.Name = "TXT_WHBDM";
            this.TXT_WHBDM.ReadOnly = false;
            this.TXT_WHBDM.Size = new System.Drawing.Size(225, 24);
            this.TXT_WHBDM.TabIndex = 6;
            this.TXT_WHBDM.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DM_WHBEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 283);
            this.Name = "DM_WHBEDIT";
            this.Text = "DM_AREAEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_WHBNAME;
        private Controls.GText TXT_WHBDM;
    }
}