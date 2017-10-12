namespace G.Erp.BaseData
{
    partial class DM_AREAEDIT
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
            this.TXT_DQNAME = new G.Controls.GText();
            this.TXT_DQDM = new G.Controls.GText();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.c1SplitterPanel1.Controls.Add(this.TXT_DQNAME);
            this.c1SplitterPanel1.Controls.Add(this.TXT_DQDM);
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(563, 24);
            // 
            // TXT_DQNAME
            // 
            this.TXT_DQNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_DQNAME.Caption = "地区名称";
            this.TXT_DQNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_DQNAME.Location = new System.Drawing.Point(91, 61);
            this.TXT_DQNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_DQNAME.Multiline = false;
            this.TXT_DQNAME.Name = "TXT_DQNAME";
            this.TXT_DQNAME.ReadOnly = false;
            this.TXT_DQNAME.Size = new System.Drawing.Size(203, 24);
            this.TXT_DQNAME.TabIndex = 7;
            this.TXT_DQNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_DQDM
            // 
            this.TXT_DQDM.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_DQDM.Caption = "地区代码";
            this.TXT_DQDM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_DQDM.Location = new System.Drawing.Point(91, 28);
            this.TXT_DQDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_DQDM.Multiline = false;
            this.TXT_DQDM.Name = "TXT_DQDM";
            this.TXT_DQDM.ReadOnly = false;
            this.TXT_DQDM.Size = new System.Drawing.Size(203, 24);
            this.TXT_DQDM.TabIndex = 6;
            this.TXT_DQDM.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DM_AREAEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 283);
            this.Name = "DM_AREAEDIT";
            this.Text = "DM_AREAEDIT";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_DQNAME;
        private Controls.GText TXT_DQDM;
    }
}