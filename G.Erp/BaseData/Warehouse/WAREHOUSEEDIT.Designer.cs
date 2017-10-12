namespace G.ERP.BaseData
{
    partial class WAREHOUSEEDIT
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
            this.txt_WRHSCODE = new G.Controls.GText();
            this.txt_WRHSNAME = new G.Controls.GText();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(563, 259);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.txt_WRHSCODE);
            this.c1SplitterPanel1.Controls.Add(this.txt_WRHSNAME);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(563, 238);
            // 
            // txt_WRHSCODE
            // 
            this.txt_WRHSCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_WRHSCODE.Caption = "仓库代码 ";
            this.txt_WRHSCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_WRHSCODE.Location = new System.Drawing.Point(187, 44);
            this.txt_WRHSCODE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_WRHSCODE.Multiline = false;
            this.txt_WRHSCODE.Name = "txt_WRHSCODE";
            this.txt_WRHSCODE.ReadOnly = false;
            this.txt_WRHSCODE.Size = new System.Drawing.Size(241, 24);
            this.txt_WRHSCODE.TabIndex = 1;
            this.txt_WRHSCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // txt_WRHSNAME
            // 
            this.txt_WRHSNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_WRHSNAME.Caption = "仓库名称 ";
            this.txt_WRHSNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_WRHSNAME.Location = new System.Drawing.Point(187, 77);
            this.txt_WRHSNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_WRHSNAME.Multiline = false;
            this.txt_WRHSNAME.Name = "txt_WRHSNAME";
            this.txt_WRHSNAME.ReadOnly = false;
            this.txt_WRHSNAME.Size = new System.Drawing.Size(241, 24);
            this.txt_WRHSNAME.TabIndex = 1;
            this.txt_WRHSNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // WAREHOUSEEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 381);
            this.Name = "WAREHOUSEEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText txt_WRHSCODE;
        private Controls.GText txt_WRHSNAME;

    }
}