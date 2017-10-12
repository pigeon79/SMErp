namespace G.Erp.BaseData
{
    partial class SM_PRICEPARAEDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SM_PRICEPARAEDIT));
            this.TXT_SWEIGHT = new G.Controls.GNumText();
            this.TXT_EWEIGHT = new G.Controls.GNumText();
            this.TXT_PRICE = new G.Controls.GNumText();
            this.comb_Type = new G.Controls.GCombo();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.c1SplitterPanel1.Controls.Add(this.comb_Type);
            this.c1SplitterPanel1.Controls.Add(this.TXT_PRICE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_EWEIGHT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SWEIGHT);
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(563, 24);
            // 
            // TXT_SWEIGHT
            // 
            this.TXT_SWEIGHT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SWEIGHT.Caption = "起始值";
            this.TXT_SWEIGHT.DataType = "Decimal";
            this.TXT_SWEIGHT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SWEIGHT.Location = new System.Drawing.Point(247, 28);
            this.TXT_SWEIGHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_SWEIGHT.Name = "TXT_SWEIGHT";
            this.TXT_SWEIGHT.ReadOnly = false;
            this.TXT_SWEIGHT.Size = new System.Drawing.Size(191, 24);
            this.TXT_SWEIGHT.TabIndex = 8;
            this.TXT_SWEIGHT.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_EWEIGHT
            // 
            this.TXT_EWEIGHT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_EWEIGHT.Caption = "终止值";
            this.TXT_EWEIGHT.DataType = "Decimal";
            this.TXT_EWEIGHT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_EWEIGHT.Location = new System.Drawing.Point(247, 60);
            this.TXT_EWEIGHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_EWEIGHT.Name = "TXT_EWEIGHT";
            this.TXT_EWEIGHT.ReadOnly = false;
            this.TXT_EWEIGHT.Size = new System.Drawing.Size(191, 24);
            this.TXT_EWEIGHT.TabIndex = 8;
            this.TXT_EWEIGHT.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PRICE.Caption = "单价";
            this.TXT_PRICE.DataType = "Decimal";
            this.TXT_PRICE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_PRICE.Location = new System.Drawing.Point(247, 92);
            this.TXT_PRICE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.ReadOnly = false;
            this.TXT_PRICE.Size = new System.Drawing.Size(191, 24);
            this.TXT_PRICE.TabIndex = 8;
            this.TXT_PRICE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // comb_Type
            // 
            this.comb_Type.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.comb_Type.Caption = "类型";
            this.comb_Type.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("comb_Type.Columns")));
            this.comb_Type.Data = "五金:五金,橡胶:橡胶";
            this.comb_Type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_Type.Location = new System.Drawing.Point(44, 28);
            this.comb_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comb_Type.Name = "comb_Type";
            this.comb_Type.ReadOnly = false;
            this.comb_Type.Size = new System.Drawing.Size(156, 22);
            this.comb_Type.TabIndex = 11;
            this.comb_Type.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // SM_PRICEPARAEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 309);
            this.Name = "SM_PRICEPARAEDIT";
            this.Text = "DM_AREAEDIT";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GNumText TXT_PRICE;
        private Controls.GNumText TXT_EWEIGHT;
        private Controls.GNumText TXT_SWEIGHT;
        private Controls.GCombo comb_Type;

    }
}