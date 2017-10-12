namespace G.Erp.BaseData
{
    partial class SM_ITEMWASTINGEDIT
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
            this.NUM_FQTY = new G.Controls.GNumText();
            this.NUM_TQTY = new G.Controls.GNumText();
            this.NUM_WASTING = new G.Controls.GNumText();
            this.DROP_ITEMTYPEID = new G.Controls.GDropDown();
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
            this.c1SplitContainer1.Size = new System.Drawing.Size(563, 285);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.DROP_ITEMTYPEID);
            this.c1SplitterPanel1.Controls.Add(this.NUM_WASTING);
            this.c1SplitterPanel1.Controls.Add(this.NUM_TQTY);
            this.c1SplitterPanel1.Controls.Add(this.NUM_FQTY);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(563, 264);
            // 
            // NUM_FQTY
            // 
            this.NUM_FQTY.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_FQTY.Caption = "起始值";
            this.NUM_FQTY.DataType = "Decimal";
            this.NUM_FQTY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_FQTY.Location = new System.Drawing.Point(247, 28);
            this.NUM_FQTY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_FQTY.Name = "NUM_FQTY";
            this.NUM_FQTY.ReadOnly = false;
            this.NUM_FQTY.Size = new System.Drawing.Size(191, 24);
            this.NUM_FQTY.TabIndex = 8;
            this.NUM_FQTY.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_TQTY
            // 
            this.NUM_TQTY.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_TQTY.Caption = "终止值";
            this.NUM_TQTY.DataType = "Decimal";
            this.NUM_TQTY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_TQTY.Location = new System.Drawing.Point(247, 60);
            this.NUM_TQTY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_TQTY.Name = "NUM_TQTY";
            this.NUM_TQTY.ReadOnly = false;
            this.NUM_TQTY.Size = new System.Drawing.Size(191, 24);
            this.NUM_TQTY.TabIndex = 8;
            this.NUM_TQTY.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_WASTING
            // 
            this.NUM_WASTING.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_WASTING.Caption = "损耗量";
            this.NUM_WASTING.DataType = "Decimal";
            this.NUM_WASTING.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_WASTING.Location = new System.Drawing.Point(247, 92);
            this.NUM_WASTING.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_WASTING.Name = "NUM_WASTING";
            this.NUM_WASTING.ReadOnly = false;
            this.NUM_WASTING.Size = new System.Drawing.Size(191, 24);
            this.NUM_WASTING.TabIndex = 8;
            this.NUM_WASTING.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_ITEMTYPEID
            // 
            this.DROP_ITEMTYPEID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ITEMTYPEID.Caption = "物品类型";
            this.DROP_ITEMTYPEID.CustomerDropDownForm = null;
            this.DROP_ITEMTYPEID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ITEMTYPEID.Location = new System.Drawing.Point(51, 31);
            this.DROP_ITEMTYPEID.Logic = null;
            this.DROP_ITEMTYPEID.Name = "DROP_ITEMTYPEID";
            this.DROP_ITEMTYPEID.ReadOnly = false;
            this.DROP_ITEMTYPEID.Size = new System.Drawing.Size(175, 21);
            this.DROP_ITEMTYPEID.TabIndex = 21;
            this.DROP_ITEMTYPEID.TextField = "ITEMTYPENAME";
            this.DROP_ITEMTYPEID.Value = "0";
            this.DROP_ITEMTYPEID.ValueField = "Id";
            this.DROP_ITEMTYPEID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_ITEMWASTINGEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 309);
            this.Name = "SM_ITEMWASTINGEDIT";
            this.Text = "SM_ITEMWASTINGEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GNumText NUM_WASTING;
        private Controls.GNumText NUM_TQTY;
        private Controls.GNumText NUM_FQTY;
        private Controls.GDropDown DROP_ITEMTYPEID;

    }
}