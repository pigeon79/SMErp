namespace G.Erp.Sale.Order
{
    partial class SM_SALEORDERDELETED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SM_SALEORDERDELETED));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NTXT_OTHAMOUNT = new G.Controls.GNumText();
            this.COMB_CLOTHTYPE = new G.Controls.GCombo();
            this.NTXT_THICK = new G.Controls.GNumText();
            this.DROP_INOFC = new G.Controls.GDropDown();
            this.DROP_SALESREP = new G.Controls.GDropDown();
            this.DROP_SALESMAN = new G.Controls.GDropDown();
            this.DROP_INVCUSTID = new G.Controls.GDropDown();
            this.DROP_CUSTID = new G.Controls.GDropDown();
            this.CHECK_SUPPTAG = new G.Controls.Input.GCheckBox();
            this.CHECK_PROTAG = new G.Controls.Input.GCheckBox();
            this.CHECK_INVTAG = new G.Controls.Input.GCheckBox();
            this.TXT_REMARK = new G.Controls.GText();
            this.TXT_RECADDRESS = new G.Controls.GText();
            this.TXT_CUSTLEV = new G.Controls.GText();
            this.TXT_CUSTORDNB = new G.Controls.GText();
            this.CHECK_FTTAG = new G.Controls.Input.GCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.COMB_ORDERTYPE = new G.Controls.GCombo();
            this.DATE_ORDERDATE = new G.Controls.GDate();
            this.TXT_ORDDISCOUNT = new G.Controls.GText();
            this.TXT_STATUS = new G.Controls.GText();
            this.TXT_ORDAMOUNT = new G.Controls.GText();
            this.TXT_ORDQTY = new G.Controls.GText();
            this.TXT_ORDERID = new G.Controls.GText();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(984, 617);
            this.splitContainer2.SplitterDistance = 206;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 177);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.tabPage1.Controls.Add(this.NTXT_OTHAMOUNT);
            this.tabPage1.Controls.Add(this.COMB_CLOTHTYPE);
            this.tabPage1.Controls.Add(this.NTXT_THICK);
            this.tabPage1.Controls.Add(this.DROP_INOFC);
            this.tabPage1.Controls.Add(this.DROP_SALESREP);
            this.tabPage1.Controls.Add(this.DROP_SALESMAN);
            this.tabPage1.Controls.Add(this.DROP_INVCUSTID);
            this.tabPage1.Controls.Add(this.DROP_CUSTID);
            this.tabPage1.Controls.Add(this.CHECK_SUPPTAG);
            this.tabPage1.Controls.Add(this.CHECK_PROTAG);
            this.tabPage1.Controls.Add(this.CHECK_INVTAG);
            this.tabPage1.Controls.Add(this.TXT_REMARK);
            this.tabPage1.Controls.Add(this.TXT_RECADDRESS);
            this.tabPage1.Controls.Add(this.TXT_CUSTLEV);
            this.tabPage1.Controls.Add(this.TXT_CUSTORDNB);
            this.tabPage1.Controls.Add(this.CHECK_FTTAG);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "订单信息";
            // 
            // NTXT_OTHAMOUNT
            // 
            this.NTXT_OTHAMOUNT.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NTXT_OTHAMOUNT.Caption = "其他费用";
            this.NTXT_OTHAMOUNT.DataType = "Decimal";
            this.NTXT_OTHAMOUNT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NTXT_OTHAMOUNT.Location = new System.Drawing.Point(477, 38);
            this.NTXT_OTHAMOUNT.Name = "NTXT_OTHAMOUNT";
            this.NTXT_OTHAMOUNT.ReadOnly = false;
            this.NTXT_OTHAMOUNT.Size = new System.Drawing.Size(143, 21);
            this.NTXT_OTHAMOUNT.TabIndex = 26;
            this.NTXT_OTHAMOUNT.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // COMB_CLOTHTYPE
            // 
            this.COMB_CLOTHTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_CLOTHTYPE.Caption = "服装类型";
            this.COMB_CLOTHTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_CLOTHTYPE.Columns")));
            this.COMB_CLOTHTYPE.Data = "牛仔:牛仔,西服:西服";
            this.COMB_CLOTHTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_CLOTHTYPE.Location = new System.Drawing.Point(756, 11);
            this.COMB_CLOTHTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_CLOTHTYPE.Name = "COMB_CLOTHTYPE";
            this.COMB_CLOTHTYPE.ReadOnly = false;
            this.COMB_CLOTHTYPE.Size = new System.Drawing.Size(136, 22);
            this.COMB_CLOTHTYPE.TabIndex = 22;
            this.COMB_CLOTHTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // NTXT_THICK
            // 
            this.NTXT_THICK.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NTXT_THICK.Caption = "布样层数";
            this.NTXT_THICK.DataType = "Int32";
            this.NTXT_THICK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NTXT_THICK.Location = new System.Drawing.Point(351, 38);
            this.NTXT_THICK.Name = "NTXT_THICK";
            this.NTXT_THICK.ReadOnly = false;
            this.NTXT_THICK.Size = new System.Drawing.Size(120, 21);
            this.NTXT_THICK.TabIndex = 25;
            this.NTXT_THICK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_INOFC
            // 
            this.DROP_INOFC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_INOFC.Caption = "内勤";
            this.DROP_INOFC.CustomerDropDownForm = null;
            this.DROP_INOFC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_INOFC.IsText = false;
            this.DROP_INOFC.Location = new System.Drawing.Point(626, 11);
            this.DROP_INOFC.Logic = null;
            this.DROP_INOFC.Name = "DROP_INOFC";
            this.DROP_INOFC.ReadOnly = true;
            this.DROP_INOFC.Size = new System.Drawing.Size(110, 21);
            this.DROP_INOFC.TabIndex = 21;
            this.DROP_INOFC.TextField = "USERNAME";
            this.DROP_INOFC.Value = "0";
            this.DROP_INOFC.ValueField = "USERDM";
            this.DROP_INOFC.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_SALESREP
            // 
            this.DROP_SALESREP.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SALESREP.Caption = "销售代表";
            this.DROP_SALESREP.CustomerDropDownForm = null;
            this.DROP_SALESREP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SALESREP.IsText = false;
            this.DROP_SALESREP.Location = new System.Drawing.Point(477, 11);
            this.DROP_SALESREP.Logic = null;
            this.DROP_SALESREP.Name = "DROP_SALESREP";
            this.DROP_SALESREP.ReadOnly = true;
            this.DROP_SALESREP.Size = new System.Drawing.Size(143, 21);
            this.DROP_SALESREP.TabIndex = 23;
            this.DROP_SALESREP.TextField = "USERNAME";
            this.DROP_SALESREP.Value = "0";
            this.DROP_SALESREP.ValueField = "USERDM";
            this.DROP_SALESREP.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_SALESMAN
            // 
            this.DROP_SALESMAN.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SALESMAN.Caption = "销售员";
            this.DROP_SALESMAN.CustomerDropDownForm = null;
            this.DROP_SALESMAN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SALESMAN.IsText = false;
            this.DROP_SALESMAN.Location = new System.Drawing.Point(351, 11);
            this.DROP_SALESMAN.Logic = null;
            this.DROP_SALESMAN.Name = "DROP_SALESMAN";
            this.DROP_SALESMAN.ReadOnly = true;
            this.DROP_SALESMAN.Size = new System.Drawing.Size(120, 21);
            this.DROP_SALESMAN.TabIndex = 24;
            this.DROP_SALESMAN.TextField = "USERNAME";
            this.DROP_SALESMAN.Value = "0";
            this.DROP_SALESMAN.ValueField = "USERDM";
            this.DROP_SALESMAN.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_INVCUSTID
            // 
            this.DROP_INVCUSTID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_INVCUSTID.Caption = "开票客户";
            this.DROP_INVCUSTID.CustomerDropDownForm = null;
            this.DROP_INVCUSTID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_INVCUSTID.IsText = false;
            this.DROP_INVCUSTID.Location = new System.Drawing.Point(10, 38);
            this.DROP_INVCUSTID.Logic = null;
            this.DROP_INVCUSTID.Name = "DROP_INVCUSTID";
            this.DROP_INVCUSTID.ReadOnly = true;
            this.DROP_INVCUSTID.Size = new System.Drawing.Size(321, 21);
            this.DROP_INVCUSTID.TabIndex = 13;
            this.DROP_INVCUSTID.TextField = "CUSTNAME";
            this.DROP_INVCUSTID.Value = "0";
            this.DROP_INVCUSTID.ValueField = "ID";
            this.DROP_INVCUSTID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_CUSTID
            // 
            this.DROP_CUSTID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_CUSTID.Caption = "下单客户";
            this.DROP_CUSTID.CustomerDropDownForm = null;
            this.DROP_CUSTID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_CUSTID.IsText = false;
            this.DROP_CUSTID.Location = new System.Drawing.Point(10, 11);
            this.DROP_CUSTID.Logic = null;
            this.DROP_CUSTID.Name = "DROP_CUSTID";
            this.DROP_CUSTID.ReadOnly = true;
            this.DROP_CUSTID.Size = new System.Drawing.Size(321, 21);
            this.DROP_CUSTID.TabIndex = 14;
            this.DROP_CUSTID.TextField = "CUSTNAME";
            this.DROP_CUSTID.Value = "0";
            this.DROP_CUSTID.ValueField = "ID";
            this.DROP_CUSTID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // CHECK_SUPPTAG
            // 
            this.CHECK_SUPPTAG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_SUPPTAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_SUPPTAG.Caption = "检针";
            this.CHECK_SUPPTAG.Enabled = false;
            this.CHECK_SUPPTAG.ForeColor = System.Drawing.Color.Black;
            this.CHECK_SUPPTAG.Location = new System.Drawing.Point(274, 120);
            this.CHECK_SUPPTAG.Name = "CHECK_SUPPTAG";
            this.CHECK_SUPPTAG.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_SUPPTAG.ReadOnly = false;
            this.CHECK_SUPPTAG.Size = new System.Drawing.Size(56, 24);
            this.CHECK_SUPPTAG.TabIndex = 8;
            this.CHECK_SUPPTAG.Text = "检针";
            this.CHECK_SUPPTAG.UseVisualStyleBackColor = false;
            this.CHECK_SUPPTAG.Value = null;
            // 
            // CHECK_PROTAG
            // 
            this.CHECK_PROTAG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_PROTAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_PROTAG.Caption = "环保";
            this.CHECK_PROTAG.Enabled = false;
            this.CHECK_PROTAG.ForeColor = System.Drawing.Color.Black;
            this.CHECK_PROTAG.Location = new System.Drawing.Point(194, 120);
            this.CHECK_PROTAG.Name = "CHECK_PROTAG";
            this.CHECK_PROTAG.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_PROTAG.ReadOnly = false;
            this.CHECK_PROTAG.Size = new System.Drawing.Size(56, 24);
            this.CHECK_PROTAG.TabIndex = 8;
            this.CHECK_PROTAG.Text = "环保";
            this.CHECK_PROTAG.UseVisualStyleBackColor = false;
            this.CHECK_PROTAG.Value = null;
            // 
            // CHECK_INVTAG
            // 
            this.CHECK_INVTAG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_INVTAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_INVTAG.Caption = "不开票";
            this.CHECK_INVTAG.Enabled = false;
            this.CHECK_INVTAG.ForeColor = System.Drawing.Color.Black;
            this.CHECK_INVTAG.Location = new System.Drawing.Point(97, 120);
            this.CHECK_INVTAG.Name = "CHECK_INVTAG";
            this.CHECK_INVTAG.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_INVTAG.ReadOnly = false;
            this.CHECK_INVTAG.Size = new System.Drawing.Size(71, 24);
            this.CHECK_INVTAG.TabIndex = 8;
            this.CHECK_INVTAG.Text = "不开票";
            this.CHECK_INVTAG.UseVisualStyleBackColor = false;
            this.CHECK_INVTAG.Value = null;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(350, 66);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = true;
            this.TXT_REMARK.Size = new System.Drawing.Size(619, 78);
            this.TXT_REMARK.TabIndex = 15;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_RECADDRESS
            // 
            this.TXT_RECADDRESS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_RECADDRESS.Caption = "收货单位";
            this.TXT_RECADDRESS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_RECADDRESS.Location = new System.Drawing.Point(10, 66);
            this.TXT_RECADDRESS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_RECADDRESS.Multiline = false;
            this.TXT_RECADDRESS.Name = "TXT_RECADDRESS";
            this.TXT_RECADDRESS.ReadOnly = true;
            this.TXT_RECADDRESS.Size = new System.Drawing.Size(321, 21);
            this.TXT_RECADDRESS.TabIndex = 16;
            this.TXT_RECADDRESS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CUSTLEV
            // 
            this.TXT_CUSTLEV.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTLEV.Caption = "客户等级";
            this.TXT_CUSTLEV.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTLEV.Location = new System.Drawing.Point(191, 92);
            this.TXT_CUSTLEV.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CUSTLEV.Multiline = false;
            this.TXT_CUSTLEV.Name = "TXT_CUSTLEV";
            this.TXT_CUSTLEV.ReadOnly = true;
            this.TXT_CUSTLEV.Size = new System.Drawing.Size(140, 21);
            this.TXT_CUSTLEV.TabIndex = 17;
            this.TXT_CUSTLEV.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CUSTORDNB
            // 
            this.TXT_CUSTORDNB.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTORDNB.Caption = "合同号";
            this.TXT_CUSTORDNB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTORDNB.Location = new System.Drawing.Point(23, 92);
            this.TXT_CUSTORDNB.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CUSTORDNB.Multiline = false;
            this.TXT_CUSTORDNB.Name = "TXT_CUSTORDNB";
            this.TXT_CUSTORDNB.ReadOnly = true;
            this.TXT_CUSTORDNB.Size = new System.Drawing.Size(140, 21);
            this.TXT_CUSTORDNB.TabIndex = 18;
            this.TXT_CUSTORDNB.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // CHECK_FTTAG
            // 
            this.CHECK_FTTAG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_FTTAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_FTTAG.Caption = "外贸";
            this.CHECK_FTTAG.Enabled = false;
            this.CHECK_FTTAG.ForeColor = System.Drawing.Color.Black;
            this.CHECK_FTTAG.Location = new System.Drawing.Point(18, 120);
            this.CHECK_FTTAG.Name = "CHECK_FTTAG";
            this.CHECK_FTTAG.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_FTTAG.ReadOnly = false;
            this.CHECK_FTTAG.Size = new System.Drawing.Size(58, 24);
            this.CHECK_FTTAG.TabIndex = 9;
            this.CHECK_FTTAG.Text = "外贸";
            this.CHECK_FTTAG.UseVisualStyleBackColor = false;
            this.CHECK_FTTAG.Value = null;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "其他信息";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.COMB_ORDERTYPE);
            this.panel1.Controls.Add(this.DATE_ORDERDATE);
            this.panel1.Controls.Add(this.TXT_ORDDISCOUNT);
            this.panel1.Controls.Add(this.TXT_STATUS);
            this.panel1.Controls.Add(this.TXT_ORDAMOUNT);
            this.panel1.Controls.Add(this.TXT_ORDQTY);
            this.panel1.Controls.Add(this.TXT_ORDERID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 29);
            this.panel1.TabIndex = 0;
            // 
            // COMB_ORDERTYPE
            // 
            this.COMB_ORDERTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_ORDERTYPE.Caption = "订单类型";
            this.COMB_ORDERTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_ORDERTYPE.Columns")));
            this.COMB_ORDERTYPE.Data = "销售订单:1,打样订单:2,备料订单:3";
            this.COMB_ORDERTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_ORDERTYPE.Location = new System.Drawing.Point(354, 3);
            this.COMB_ORDERTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_ORDERTYPE.Name = "COMB_ORDERTYPE";
            this.COMB_ORDERTYPE.ReadOnly = true;
            this.COMB_ORDERTYPE.Size = new System.Drawing.Size(136, 22);
            this.COMB_ORDERTYPE.TabIndex = 11;
            this.COMB_ORDERTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // DATE_ORDERDATE
            // 
            this.DATE_ORDERDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_ORDERDATE.Caption = "订单日期";
            this.DATE_ORDERDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_ORDERDATE.Location = new System.Drawing.Point(174, 4);
            this.DATE_ORDERDATE.Name = "DATE_ORDERDATE";
            this.DATE_ORDERDATE.ReadOnly = true;
            this.DATE_ORDERDATE.Size = new System.Drawing.Size(173, 21);
            this.DATE_ORDERDATE.TabIndex = 8;
            this.DATE_ORDERDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDDISCOUNT
            // 
            this.TXT_ORDDISCOUNT.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_ORDDISCOUNT.Caption = "折扣";
            this.TXT_ORDDISCOUNT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDDISCOUNT.Location = new System.Drawing.Point(750, 3);
            this.TXT_ORDDISCOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDDISCOUNT.Multiline = false;
            this.TXT_ORDDISCOUNT.Name = "TXT_ORDDISCOUNT";
            this.TXT_ORDDISCOUNT.ReadOnly = true;
            this.TXT_ORDDISCOUNT.Size = new System.Drawing.Size(90, 21);
            this.TXT_ORDDISCOUNT.TabIndex = 7;
            this.TXT_ORDDISCOUNT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(857, 4);
            this.TXT_STATUS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STATUS.Multiline = false;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.ReadOnly = true;
            this.TXT_STATUS.Size = new System.Drawing.Size(67, 21);
            this.TXT_STATUS.TabIndex = 7;
            this.TXT_STATUS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDAMOUNT
            // 
            this.TXT_ORDAMOUNT.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_ORDAMOUNT.Caption = "总金额";
            this.TXT_ORDAMOUNT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDAMOUNT.Location = new System.Drawing.Point(624, 4);
            this.TXT_ORDAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDAMOUNT.Multiline = false;
            this.TXT_ORDAMOUNT.Name = "TXT_ORDAMOUNT";
            this.TXT_ORDAMOUNT.ReadOnly = true;
            this.TXT_ORDAMOUNT.Size = new System.Drawing.Size(118, 21);
            this.TXT_ORDAMOUNT.TabIndex = 7;
            this.TXT_ORDAMOUNT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDQTY
            // 
            this.TXT_ORDQTY.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_ORDQTY.Caption = "总数量";
            this.TXT_ORDQTY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDQTY.Location = new System.Drawing.Point(498, 4);
            this.TXT_ORDQTY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDQTY.Multiline = false;
            this.TXT_ORDQTY.Name = "TXT_ORDQTY";
            this.TXT_ORDQTY.ReadOnly = true;
            this.TXT_ORDQTY.Size = new System.Drawing.Size(118, 21);
            this.TXT_ORDQTY.TabIndex = 7;
            this.TXT_ORDQTY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERID
            // 
            this.TXT_ORDERID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERID.Caption = "销售订单号";
            this.TXT_ORDERID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERID.Location = new System.Drawing.Point(4, 4);
            this.TXT_ORDERID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERID.Multiline = false;
            this.TXT_ORDERID.Name = "TXT_ORDERID";
            this.TXT_ORDERID.ReadOnly = true;
            this.TXT_ORDERID.Size = new System.Drawing.Size(162, 21);
            this.TXT_ORDERID.TabIndex = 7;
            this.TXT_ORDERID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // gGrid1
            // 
            this.gGrid1.ColumnInfo = "10,0,0,0,0,110,Columns:";
            this.gGrid1.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGrid1.FrozenCell = 0;
            this.gGrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.gGrid1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.gGrid1.Location = new System.Drawing.Point(0, 0);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.ReadOnly = false;
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(984, 407);
            this.gGrid1.StyleInfo = resources.GetString("gGrid1.StyleInfo");
            this.gGrid1.TabIndex = 0;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // SM_SALEORDERDELETED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Name = "SM_SALEORDERDELETED";
            this.Text = "SM_SALEORDERDELETED";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private Controls.GGrid.GGrid gGrid1;
        private Controls.GText TXT_ORDERID;
        private Controls.GDate DATE_ORDERDATE;
        private Controls.GCombo COMB_ORDERTYPE;
        private Controls.GText TXT_ORDQTY;
        private Controls.GText TXT_ORDDISCOUNT;
        private Controls.GText TXT_ORDAMOUNT;
        private Controls.GText TXT_STATUS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Controls.GDropDown DROP_INVCUSTID;
        private Controls.GDropDown DROP_CUSTID;
        private Controls.Input.GCheckBox CHECK_INVTAG;
        private Controls.GText TXT_REMARK;
        private Controls.GText TXT_RECADDRESS;
        private Controls.GText TXT_CUSTLEV;
        private Controls.GText TXT_CUSTORDNB;
        private Controls.Input.GCheckBox CHECK_FTTAG;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.Input.GCheckBox CHECK_PROTAG;
        private Controls.Input.GCheckBox CHECK_SUPPTAG;
        private Controls.GNumText NTXT_OTHAMOUNT;
        private Controls.GCombo COMB_CLOTHTYPE;
        private Controls.GNumText NTXT_THICK;
        private Controls.GDropDown DROP_INOFC;
        private Controls.GDropDown DROP_SALESREP;
        private Controls.GDropDown DROP_SALESMAN;
    }
}