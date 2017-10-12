namespace G.Erp.Sale.Order
{
    partial class Frm_SM_SALEORDERPRINT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SM_SALEORDERPRINT));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BTN_SALEORDERPRINT = new System.Windows.Forms.Button();
            this.TXT_ORDERTYPE = new G.Controls.GText();
            this.TXT_ORDERDATE = new G.Controls.GText();
            this.TXT_CUSTNAME = new G.Controls.GText();
            this.TXT_ORDERID = new G.Controls.GText();
            this.TXT_CUSTLEV = new G.Controls.GText();
            this.CHECK_ISYL = new G.Controls.Input.GCheckBox();
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
            this.splitContainer2.Panel1.Controls.Add(this.BTN_SALEORDERPRINT);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_ORDERTYPE);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_ORDERDATE);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_CUSTNAME);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_ORDERID);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_CUSTLEV);
            this.splitContainer2.Panel1.Controls.Add(this.CHECK_ISYL);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(984, 617);
            this.splitContainer2.SplitterDistance = 69;
            this.splitContainer2.TabIndex = 0;
            // 
            // BTN_SALEORDERPRINT
            // 
            this.BTN_SALEORDERPRINT.Location = new System.Drawing.Point(870, 10);
            this.BTN_SALEORDERPRINT.Name = "BTN_SALEORDERPRINT";
            this.BTN_SALEORDERPRINT.Size = new System.Drawing.Size(75, 23);
            this.BTN_SALEORDERPRINT.TabIndex = 21;
            this.BTN_SALEORDERPRINT.Text = "销售打印";
            this.BTN_SALEORDERPRINT.UseVisualStyleBackColor = true;
            this.BTN_SALEORDERPRINT.Click += new System.EventHandler(this.BTN_SALEORDERPRINT_Click);
            // 
            // TXT_ORDERTYPE
            // 
            this.TXT_ORDERTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERTYPE.Caption = "订单类型";
            this.TXT_ORDERTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERTYPE.Location = new System.Drawing.Point(435, 10);
            this.TXT_ORDERTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERTYPE.Multiline = false;
            this.TXT_ORDERTYPE.Name = "TXT_ORDERTYPE";
            this.TXT_ORDERTYPE.ReadOnly = true;
            this.TXT_ORDERTYPE.Size = new System.Drawing.Size(157, 21);
            this.TXT_ORDERTYPE.TabIndex = 20;
            this.TXT_ORDERTYPE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERDATE
            // 
            this.TXT_ORDERDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERDATE.Caption = "订单日期";
            this.TXT_ORDERDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERDATE.Location = new System.Drawing.Point(249, 10);
            this.TXT_ORDERDATE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERDATE.Multiline = false;
            this.TXT_ORDERDATE.Name = "TXT_ORDERDATE";
            this.TXT_ORDERDATE.ReadOnly = true;
            this.TXT_ORDERDATE.Size = new System.Drawing.Size(157, 21);
            this.TXT_ORDERDATE.TabIndex = 19;
            this.TXT_ORDERDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CUSTNAME
            // 
            this.TXT_CUSTNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTNAME.Caption = "客户名称";
            this.TXT_CUSTNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTNAME.Location = new System.Drawing.Point(24, 37);
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
            // TXT_CUSTLEV
            // 
            this.TXT_CUSTLEV.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTLEV.Caption = "客户等级";
            this.TXT_CUSTLEV.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTLEV.Location = new System.Drawing.Point(367, 37);
            this.TXT_CUSTLEV.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CUSTLEV.Multiline = false;
            this.TXT_CUSTLEV.Name = "TXT_CUSTLEV";
            this.TXT_CUSTLEV.ReadOnly = true;
            this.TXT_CUSTLEV.Size = new System.Drawing.Size(119, 21);
            this.TXT_CUSTLEV.TabIndex = 17;
            this.TXT_CUSTLEV.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // CHECK_ISYL
            // 
            this.CHECK_ISYL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ISYL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ISYL.Caption = "是否预览";
            this.CHECK_ISYL.Checked = true;
            this.CHECK_ISYL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHECK_ISYL.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ISYL.Location = new System.Drawing.Point(509, 37);
            this.CHECK_ISYL.Name = "CHECK_ISYL";
            this.CHECK_ISYL.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ISYL.ReadOnly = false;
            this.CHECK_ISYL.Size = new System.Drawing.Size(84, 24);
            this.CHECK_ISYL.TabIndex = 8;
            this.CHECK_ISYL.Text = "是否预览";
            this.CHECK_ISYL.UseVisualStyleBackColor = false;
            this.CHECK_ISYL.Value = true;
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
            this.tabPage1.Text = "订单信息";
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
            this.tabPage2.Text = "其他信息";
            // 
            // Frm_SM_SALEORDERPRINT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Name = "Frm_SM_SALEORDERPRINT";
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
        private System.Windows.Forms.Button BTN_SALEORDERPRINT;
        private Controls.GText TXT_ORDERTYPE;
        private Controls.GText TXT_ORDERDATE;
        private Controls.GText TXT_CUSTNAME;
        private Controls.GText TXT_ORDERID;
        private Controls.GText TXT_CUSTLEV;
        private Controls.Input.GCheckBox CHECK_ISYL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Controls.GGrid.GGrid gGrid1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}