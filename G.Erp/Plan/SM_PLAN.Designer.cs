namespace G.Erp.Plan
{
    partial class SM_PLAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SM_PLAN));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DROP_GX = new G.Controls.GDropDown();
            this.DATE_PLANDATE = new G.Controls.GDate();
            this.TXT_ORDERTYPE = new G.Controls.GText();
            this.TXT_CUSTNAME = new G.Controls.GText();
            this.TXT_ORDERID = new G.Controls.GText();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Grid_CP = new G.Controls.GGrid.GGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Grid_ZJ = new G.Controls.GGrid.GGrid();
            this.c1SplitterPanel2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.Grid_SHOP = new G.Controls.GGrid.GGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_CP)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ZJ)).BeginInit();
            this.c1SplitterPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SHOP)).BeginInit();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(984, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel2);
            this.c1SplitContainer1.Size = new System.Drawing.Size(984, 638);
            this.c1SplitContainer1.Controls.SetChildIndex(this.c1SplitterPanel2, 0);
            this.c1SplitContainer1.Controls.SetChildIndex(this.c1SplitterPanel1, 0);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.splitContainer2);
            this.c1SplitterPanel1.Height = 423;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(984, 402);
            this.c1SplitterPanel1.SizeRatio = 66.719D;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DROP_GX);
            this.splitContainer2.Panel1.Controls.Add(this.DATE_PLANDATE);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_ORDERTYPE);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_CUSTNAME);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_ORDERID);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(984, 402);
            this.splitContainer2.SplitterDistance = 39;
            this.splitContainer2.TabIndex = 0;
            // 
            // DROP_GX
            // 
            this.DROP_GX.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_GX.Caption = "工序";
            this.DROP_GX.CustomerDropDownForm = null;
            this.DROP_GX.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_GX.IsText = false;
            this.DROP_GX.Location = new System.Drawing.Point(50, 9);
            this.DROP_GX.Logic = null;
            this.DROP_GX.Name = "DROP_GX";
            this.DROP_GX.ReadOnly = false;
            this.DROP_GX.Size = new System.Drawing.Size(131, 21);
            this.DROP_GX.TabIndex = 22;
            this.DROP_GX.TextField = "GXNAME";
            this.DROP_GX.Value = "0";
            this.DROP_GX.ValueField = "ID";
            this.DROP_GX.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DATE_PLANDATE
            // 
            this.DATE_PLANDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_PLANDATE.Caption = "交期";
            this.DATE_PLANDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_PLANDATE.Location = new System.Drawing.Point(196, 9);
            this.DATE_PLANDATE.Name = "DATE_PLANDATE";
            this.DATE_PLANDATE.ReadOnly = false;
            this.DATE_PLANDATE.Size = new System.Drawing.Size(123, 21);
            this.DATE_PLANDATE.TabIndex = 21;
            this.DATE_PLANDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERTYPE
            // 
            this.TXT_ORDERTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERTYPE.Caption = "订单类型";
            this.TXT_ORDERTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERTYPE.Location = new System.Drawing.Point(529, 9);
            this.TXT_ORDERTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERTYPE.Multiline = false;
            this.TXT_ORDERTYPE.Name = "TXT_ORDERTYPE";
            this.TXT_ORDERTYPE.ReadOnly = true;
            this.TXT_ORDERTYPE.Size = new System.Drawing.Size(139, 21);
            this.TXT_ORDERTYPE.TabIndex = 20;
            this.TXT_ORDERTYPE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CUSTNAME
            // 
            this.TXT_CUSTNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTNAME.Caption = "客户名称";
            this.TXT_CUSTNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTNAME.Location = new System.Drawing.Point(676, 9);
            this.TXT_CUSTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CUSTNAME.Multiline = false;
            this.TXT_CUSTNAME.Name = "TXT_CUSTNAME";
            this.TXT_CUSTNAME.ReadOnly = true;
            this.TXT_CUSTNAME.Size = new System.Drawing.Size(301, 21);
            this.TXT_CUSTNAME.TabIndex = 18;
            this.TXT_CUSTNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERID
            // 
            this.TXT_ORDERID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERID.Caption = "销售订单号";
            this.TXT_ORDERID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERID.Location = new System.Drawing.Point(349, 9);
            this.TXT_ORDERID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERID.Multiline = false;
            this.TXT_ORDERID.Name = "TXT_ORDERID";
            this.TXT_ORDERID.ReadOnly = true;
            this.TXT_ORDERID.Size = new System.Drawing.Size(172, 21);
            this.TXT_ORDERID.TabIndex = 7;
            this.TXT_ORDERID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 359);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.tabPage1.Controls.Add(this.Grid_CP);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "成品";
            // 
            // Grid_CP
            // 
            this.Grid_CP.ColumnInfo = "10,0,0,0,0,110,Columns:";
            this.Grid_CP.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.Grid_CP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_CP.FrozenCell = 0;
            this.Grid_CP.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.Grid_CP.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.Grid_CP.Location = new System.Drawing.Point(3, 3);
            this.Grid_CP.Name = "Grid_CP";
            this.Grid_CP.NegativeRed = false;
            this.Grid_CP.ReadOnly = false;
            this.Grid_CP.Rows.DefaultSize = 22;
            this.Grid_CP.Size = new System.Drawing.Size(970, 325);
            this.Grid_CP.StyleInfo = resources.GetString("Grid_CP.StyleInfo");
            this.Grid_CP.TabIndex = 1;
            this.Grid_CP.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.tabPage2.Controls.Add(this.Grid_ZJ);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "子件";
            // 
            // Grid_ZJ
            // 
            this.Grid_ZJ.ColumnInfo = "10,0,0,0,0,110,Columns:";
            this.Grid_ZJ.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.Grid_ZJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_ZJ.FrozenCell = 0;
            this.Grid_ZJ.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.Grid_ZJ.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.Grid_ZJ.Location = new System.Drawing.Point(3, 3);
            this.Grid_ZJ.Name = "Grid_ZJ";
            this.Grid_ZJ.NegativeRed = false;
            this.Grid_ZJ.ReadOnly = false;
            this.Grid_ZJ.Rows.DefaultSize = 22;
            this.Grid_ZJ.Size = new System.Drawing.Size(970, 325);
            this.Grid_ZJ.StyleInfo = resources.GetString("Grid_ZJ.StyleInfo");
            this.Grid_ZJ.TabIndex = 2;
            this.Grid_ZJ.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // c1SplitterPanel2
            // 
            this.c1SplitterPanel2.Controls.Add(this.Grid_SHOP);
            this.c1SplitterPanel2.Height = 100;
            this.c1SplitterPanel2.Location = new System.Drawing.Point(0, 427);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Size = new System.Drawing.Size(984, 211);
            this.c1SplitterPanel2.TabIndex = 1;
            // 
            // Grid_SHOP
            // 
            this.Grid_SHOP.ColumnInfo = "10,0,0,0,0,110,Columns:";
            this.Grid_SHOP.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.Grid_SHOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_SHOP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Grid_SHOP.FrozenCell = 0;
            this.Grid_SHOP.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.Grid_SHOP.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.Grid_SHOP.Location = new System.Drawing.Point(0, 0);
            this.Grid_SHOP.Name = "Grid_SHOP";
            this.Grid_SHOP.NegativeRed = false;
            this.Grid_SHOP.ReadOnly = false;
            this.Grid_SHOP.Rows.DefaultSize = 22;
            this.Grid_SHOP.Size = new System.Drawing.Size(984, 211);
            this.Grid_SHOP.StyleInfo = resources.GetString("Grid_SHOP.StyleInfo");
            this.Grid_SHOP.TabIndex = 2;
            this.Grid_SHOP.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // SM_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Name = "SM_PLAN";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "车间计划";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_CP)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ZJ)).EndInit();
            this.c1SplitterPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SHOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.GText TXT_ORDERTYPE;
        private Controls.GText TXT_CUSTNAME;
        private Controls.GText TXT_ORDERID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Controls.GGrid.GGrid Grid_CP;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.GDate DATE_PLANDATE;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private Controls.GGrid.GGrid Grid_SHOP;
        private Controls.GGrid.GGrid Grid_ZJ;
        private Controls.GDropDown DROP_GX;

    }
}