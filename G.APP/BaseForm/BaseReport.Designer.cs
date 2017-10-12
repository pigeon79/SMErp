namespace G.APP.BaseForm
{
    public partial class BaseReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseReport));
            this.gToolBar1 = new G.Controls.GToolBar.GToolBar();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            this.cutPager1 = new G.Controls.GGrid.CutPager();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gToolBar1.Location = new System.Drawing.Point(0, 0);
            this.gToolBar1.Name = "gToolBar1";
            this.gToolBar1.Size = new System.Drawing.Size(837, 24);
            this.gToolBar1.TabIndex = 2;
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(185)))));
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(0, 24);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Size = new System.Drawing.Size(837, 566);
            this.c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(185)))));
            this.c1SplitContainer1.TabIndex = 3;
            this.c1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.gGrid1);
            this.c1SplitterPanel1.Controls.Add(this.cutPager1);
            this.c1SplitterPanel1.Controls.Add(this.c1InputPanel1);
            this.c1SplitterPanel1.HeaderTextAlign = C1.Win.C1SplitContainer.PanelTextAlign.Center;
            this.c1SplitterPanel1.Height = 74;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(837, 545);
            this.c1SplitterPanel1.SizeRatio = 20.613D;
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Text = "Panel 1";
            // 
            // gGrid1
            // 
            this.gGrid1.AllowEditing = false;
            this.gGrid1.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.gGrid1.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGrid1.ExtendLastCol = true;
            this.gGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.gGrid1.FrozenCell = 0;
            this.gGrid1.Location = new System.Drawing.Point(0, 59);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.ReadOnly = false;
            this.gGrid1.Rows.DefaultSize = 20;
            this.gGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.gGrid1.Size = new System.Drawing.Size(837, 486);
            this.gGrid1.StyleInfo = resources.GetString("gGrid1.StyleInfo");
            this.gGrid1.TabIndex = 3;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // cutPager1
            // 
            this.cutPager1.AllCount = 0;
            this.cutPager1.BackColor = System.Drawing.Color.Transparent;
            this.cutPager1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cutPager1.Location = new System.Drawing.Point(0, 32);
            this.cutPager1.Name = "cutPager1";
            this.cutPager1.PageSize = 0;
            this.cutPager1.Size = new System.Drawing.Size(837, 27);
            this.cutPager1.TabIndex = 5;
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1InputPanel1.Font = new System.Drawing.Font("宋体", 9F);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(837, 32);
            this.c1InputPanel1.TabIndex = 0;
            // 
            // BaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 590);
            this.Controls.Add(this.c1SplitContainer1);
            this.Controls.Add(this.gToolBar1);
            this.Name = "BaseReport";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.GToolBar.GToolBar gToolBar1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        public C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        public Controls.GGrid.GGrid gGrid1;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private Controls.GGrid.CutPager cutPager1;

    }
}