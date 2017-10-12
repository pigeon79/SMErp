namespace G.Erp.BaseData
{
    partial class SM_BOMEDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SM_BOMEDIT));
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DROP_FITEM = new G.Controls.GDropDown();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(984, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(984, 638);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.gGrid1);
            this.c1SplitterPanel1.Controls.Add(this.panel1);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(984, 617);
            // 
            // gGrid1
            // 
            this.gGrid1.ColumnInfo = "10,0,0,0,0,110,Columns:";
            this.gGrid1.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGrid1.FrozenCell = 0;
            this.gGrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.gGrid1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.gGrid1.Location = new System.Drawing.Point(0, 29);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(984, 588);
            this.gGrid1.StyleInfo = resources.GetString("gGrid1.StyleInfo");
            this.gGrid1.TabIndex = 3;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DROP_FITEM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 29);
            this.panel1.TabIndex = 2;
            // 
            // DROP_FITEM
            // 
            this.DROP_FITEM.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_FITEM.Caption = "物品";
            this.DROP_FITEM.CustomerDropDownForm = null;
            this.DROP_FITEM.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_FITEM.Location = new System.Drawing.Point(12, 3);
            this.DROP_FITEM.Logic = null;
            this.DROP_FITEM.Name = "DROP_FITEM";
            this.DROP_FITEM.ReadOnly = false;
            this.DROP_FITEM.Size = new System.Drawing.Size(302, 21);
            this.DROP_FITEM.TabIndex = 15;
            this.DROP_FITEM.TextField = "CUSTNAME";
            this.DROP_FITEM.Value = "0";
            this.DROP_FITEM.ValueField = "ID";
            this.DROP_FITEM.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // SM_BOMEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Name = "SM_BOMEDIT";
            this.Text = "SM_SALEORDEREDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GGrid.GGrid gGrid1;
        private System.Windows.Forms.Panel panel1;
        private Controls.GDropDown DROP_FITEM;

    }
}