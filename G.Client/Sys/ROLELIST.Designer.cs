namespace G.Client.Sys
{
    partial class ROLELIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROLELIST));
            this.gToolBar1 = new G.Controls.GToolBar.GToolBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_Caption = new System.Windows.Forms.Label();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gToolBar1.Location = new System.Drawing.Point(0, 0);
            this.gToolBar1.Name = "gToolBar1";
            this.gToolBar1.Size = new System.Drawing.Size(728, 24);
            this.gToolBar1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.splitContainer1.Panel1.Controls.Add(this.label_Caption);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(728, 418);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 1;
            // 
            // label_Caption
            // 
            this.label_Caption.AutoSize = true;
            this.label_Caption.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Caption.Location = new System.Drawing.Point(268, 3);
            this.label_Caption.Name = "label_Caption";
            this.label_Caption.Size = new System.Drawing.Size(56, 16);
            this.label_Caption.TabIndex = 0;
            this.label_Caption.Text = "label1";
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
            this.gGrid1.Location = new System.Drawing.Point(0, 0);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.ReadOnly = false;
            this.gGrid1.Rows.DefaultSize = 20;
            this.gGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gGrid1.Size = new System.Drawing.Size(728, 376);
            this.gGrid1.StyleInfo = resources.GetString("gGrid1.StyleInfo");
            this.gGrid1.TabIndex = 0;
            this.gGrid1.DoubleClick += new System.EventHandler(this.gGrid1_DoubleClick);
            // 
            // ROLELIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(728, 442);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gToolBar1);
            this.Name = "ROLELIST";
            this.Text = "人员信息";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GToolBar.GToolBar gToolBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.GGrid.GGrid gGrid1;
        private System.Windows.Forms.Label label_Caption;


    }
}