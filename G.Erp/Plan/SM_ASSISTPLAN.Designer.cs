namespace G.Erp.Plan
{
    partial class SM_ASSISTPLAN
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
            this.DATE_PLANDATE = new G.Controls.GDate();
            this.TXT_ORDERTYPE = new G.Controls.GText();
            this.TXT_CUSTNAME = new G.Controls.GText();
            this.TXT_ORDERID = new G.Controls.GText();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
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
            this.c1SplitterPanel1.Controls.Add(this.splitContainer2);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(984, 617);
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
            this.splitContainer2.Panel1.Controls.Add(this.DATE_PLANDATE);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_ORDERTYPE);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_CUSTNAME);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_ORDERID);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(984, 617);
            this.splitContainer2.SplitterDistance = 69;
            this.splitContainer2.TabIndex = 0;
            // 
            // DATE_PLANDATE
            // 
            this.DATE_PLANDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_PLANDATE.Caption = "交    期";
            this.DATE_PLANDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_PLANDATE.Location = new System.Drawing.Point(735, 10);
            this.DATE_PLANDATE.Name = "DATE_PLANDATE";
            this.DATE_PLANDATE.ReadOnly = false;
            this.DATE_PLANDATE.Size = new System.Drawing.Size(186, 21);
            this.DATE_PLANDATE.TabIndex = 21;
            this.DATE_PLANDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERTYPE
            // 
            this.TXT_ORDERTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERTYPE.Caption = "订单类型";
            this.TXT_ORDERTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERTYPE.Location = new System.Drawing.Point(228, 10);
            this.TXT_ORDERTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERTYPE.Multiline = false;
            this.TXT_ORDERTYPE.Name = "TXT_ORDERTYPE";
            this.TXT_ORDERTYPE.ReadOnly = true;
            this.TXT_ORDERTYPE.Size = new System.Drawing.Size(157, 21);
            this.TXT_ORDERTYPE.TabIndex = 20;
            this.TXT_ORDERTYPE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CUSTNAME
            // 
            this.TXT_CUSTNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTNAME.Caption = "客户名称";
            this.TXT_CUSTNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTNAME.Location = new System.Drawing.Point(393, 10);
            this.TXT_CUSTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CUSTNAME.Multiline = false;
            this.TXT_CUSTNAME.Name = "TXT_CUSTNAME";
            this.TXT_CUSTNAME.ReadOnly = true;
            this.TXT_CUSTNAME.Size = new System.Drawing.Size(320, 21);
            this.TXT_CUSTNAME.TabIndex = 18;
            this.TXT_CUSTNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERID
            // 
            this.TXT_ORDERID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERID.Caption = "销售订单号";
            this.TXT_ORDERID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERID.Location = new System.Drawing.Point(24, 10);
            this.TXT_ORDERID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERID.Multiline = false;
            this.TXT_ORDERID.Name = "TXT_ORDERID";
            this.TXT_ORDERID.ReadOnly = true;
            this.TXT_ORDERID.Size = new System.Drawing.Size(196, 21);
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
            this.tabControl1.Size = new System.Drawing.Size(984, 544);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.tabPage1.Controls.Add(this.gGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "成品";
            // 
            // gGrid1
            // 
            this.gGrid1.ColumnInfo = "10,0,0,0,0,110,Columns:";
            this.gGrid1.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGrid1.FrozenCell = 0;
            this.gGrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.gGrid1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.gGrid1.Location = new System.Drawing.Point(3, 3);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.ReadOnly = false;
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(970, 510);
            this.gGrid1.StyleInfo = resources.GetString("gGrid1.StyleInfo");
            this.gGrid1.TabIndex = 1;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "成品子件";
            // 
            // SM_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Name = "SM_PLAN";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SM_SALEORDERPRINT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.GText TXT_ORDERTYPE;
        private Controls.GText TXT_CUSTNAME;
        private Controls.GText TXT_ORDERID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Controls.GGrid.GGrid gGrid1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.GDate DATE_PLANDATE;

    }
}