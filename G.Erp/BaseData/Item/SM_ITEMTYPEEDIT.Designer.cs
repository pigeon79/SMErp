namespace G.Erp.BaseData
{
    partial class SM_ITEMTYPEEDIT
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
            this.TXT_ITEMTYPENAME = new G.Controls.GText();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(416, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(416, 149);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.TXT_ITEMTYPENAME);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(416, 128);
            // 
            // TXT_ITEMTYPENAME
            // 
            this.TXT_ITEMTYPENAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ITEMTYPENAME.Caption = "物品大类";
            this.TXT_ITEMTYPENAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ITEMTYPENAME.Location = new System.Drawing.Point(57, 45);
            this.TXT_ITEMTYPENAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ITEMTYPENAME.Multiline = false;
            this.TXT_ITEMTYPENAME.Name = "TXT_ITEMTYPENAME";
            this.TXT_ITEMTYPENAME.ReadOnly = false;
            this.TXT_ITEMTYPENAME.Size = new System.Drawing.Size(279, 21);
            this.TXT_ITEMTYPENAME.TabIndex = 2;
            this.TXT_ITEMTYPENAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_ITEMTYPEEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 173);
            this.Name = "SM_ITEMTYPEEDIT";
            this.Text = "SM_ITEMTYPEEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_ITEMTYPENAME;
    }
}