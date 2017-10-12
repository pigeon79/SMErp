namespace G.ERP.BaseData
{
    partial class LOCATIONEDIT
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

            this.drop_WRHSCODE = new G.Controls.GDropDown();
            this.txt_LOCNAME = new G.Controls.GText();
            this.txt_LOCCODE = new G.Controls.GText();
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
            this.c1SplitterPanel1.Controls.Add(this.drop_WRHSCODE);
            this.c1SplitterPanel1.Controls.Add(this.txt_LOCNAME);
            this.c1SplitterPanel1.Controls.Add(this.txt_LOCCODE);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(563, 238);

            // 
            // drop_WRHSCODE
            // 
            this.drop_WRHSCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_WRHSCODE.Caption = "仓    库 ";
            this.drop_WRHSCODE.CustomerDropDownForm = null;
            this.drop_WRHSCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_WRHSCODE.Location = new System.Drawing.Point(185, 63);
            this.drop_WRHSCODE.Logic = null;
            this.drop_WRHSCODE.Name = "drop_WRHSCODE";
            this.drop_WRHSCODE.ReadOnly = false;
            this.drop_WRHSCODE.Size = new System.Drawing.Size(241, 24);
            this.drop_WRHSCODE.TabIndex = 2;
            this.drop_WRHSCODE.TextField = "WRHSNAME";
            this.drop_WRHSCODE.Value = "0";
            this.drop_WRHSCODE.ValueField = "WRHSCODE";
            this.drop_WRHSCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_LOCNAME
            // 
            this.txt_LOCNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_LOCNAME.Caption = "库位名称 ";
            this.txt_LOCNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LOCNAME.Location = new System.Drawing.Point(185, 132);
            this.txt_LOCNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_LOCNAME.Multiline = false;
            this.txt_LOCNAME.Name = "txt_LOCNAME";
            this.txt_LOCNAME.ReadOnly = false;
            this.txt_LOCNAME.Size = new System.Drawing.Size(241, 24);
            this.txt_LOCNAME.TabIndex = 1;
            this.txt_LOCNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // txt_LOCCODE
            // 
            this.txt_LOCCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_LOCCODE.Caption = "库位代码 ";
            this.txt_LOCCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LOCCODE.Location = new System.Drawing.Point(185, 99);
            this.txt_LOCCODE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_LOCCODE.Multiline = false;
            this.txt_LOCCODE.Name = "txt_LOCCODE";
            this.txt_LOCCODE.ReadOnly = false;
            this.txt_LOCCODE.Size = new System.Drawing.Size(241, 24);
            this.txt_LOCCODE.TabIndex = 1;
            this.txt_LOCCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;

            // 
            // LOCATIONEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 283);
            this.Name = "LOCATIONEDIT";
            this.Text = "LOCATIONEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText txt_LOCCODE;
        private Controls.GText txt_LOCNAME;
        private Controls.GDropDown drop_WRHSCODE;

    }
}