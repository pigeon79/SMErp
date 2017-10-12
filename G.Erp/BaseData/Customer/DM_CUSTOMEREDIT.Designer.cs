namespace G.Erp.BaseData
{
    partial class DM_CUSTOMEREDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM_CUSTOMEREDIT));
            this.DATE_FOUNDDATE = new G.Controls.GDate();
            this.TXT_CUSTNAME = new G.Controls.GText();
            this.TXT_PY = new G.Controls.GText();
            this.TXT_CUSTCODE = new G.Controls.GText();
            this.DROP_SALESMAN = new G.Controls.GDropDown();
            this.DROP_SALESREP = new G.Controls.GDropDown();
            this.DROP_INOFC = new G.Controls.GDropDown();
            this.TXT_BOSS = new G.Controls.GText();
            this.TXT_TEL = new G.Controls.GText();
            this.TXT_CONTACTS = new G.Controls.GText();
            this.TXT_CONTEL = new G.Controls.GText();
            this.TXT_ADDRESS = new G.Controls.GText();
            this.TXT_FAX = new G.Controls.GText();
            this.TXT_BUYTEL = new G.Controls.GText();
            this.COMB_JSFS = new G.Controls.GCombo();
            this.COMB_PAYTYPE = new G.Controls.GCombo();
            this.DROP_AREA = new G.Controls.GDropDown();
            this.TXT_DISCOUNT = new G.Controls.GNumText();
            this.TXT_BANK = new G.Controls.GText();
            this.TXT_BANKACCOUNT = new G.Controls.GText();
            this.TXT_REMARK = new G.Controls.GText();
            this.TXT_ORDERINFO = new G.Controls.GText();
            this.COMB_CUSTTYPE = new G.Controls.GCombo();
            this.TXT_TRADE = new G.Controls.GText();
            this.TXT_BUYER = new G.Controls.GText();
            this.COMB_CUSTLEV = new G.Controls.GCombo();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(848, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(848, 478);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.TXT_BUYER);
            this.c1SplitterPanel1.Controls.Add(this.TXT_TRADE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_DISCOUNT);
            this.c1SplitterPanel1.Controls.Add(this.COMB_PAYTYPE);
            this.c1SplitterPanel1.Controls.Add(this.COMB_CUSTTYPE);
            this.c1SplitterPanel1.Controls.Add(this.COMB_JSFS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_ORDERINFO);
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BANKACCOUNT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BANK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BUYTEL);
            this.c1SplitterPanel1.Controls.Add(this.TXT_CONTEL);
            this.c1SplitterPanel1.Controls.Add(this.TXT_CONTACTS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_ADDRESS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_FAX);
            this.c1SplitterPanel1.Controls.Add(this.TXT_TEL);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BOSS);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AREA);
            this.c1SplitterPanel1.Controls.Add(this.DROP_INOFC);
            this.c1SplitterPanel1.Controls.Add(this.DROP_SALESREP);
            this.c1SplitterPanel1.Controls.Add(this.DROP_SALESMAN);
            this.c1SplitterPanel1.Controls.Add(this.TXT_CUSTNAME);
            this.c1SplitterPanel1.Controls.Add(this.COMB_CUSTLEV);
            this.c1SplitterPanel1.Controls.Add(this.DATE_FOUNDDATE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_PY);
            this.c1SplitterPanel1.Controls.Add(this.TXT_CUSTCODE);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(848, 457);
            // 
            // DATE_FOUNDDATE
            // 
            this.DATE_FOUNDDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_FOUNDDATE.Caption = "建立日期";
            this.DATE_FOUNDDATE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_FOUNDDATE.Location = new System.Drawing.Point(555, 20);
            this.DATE_FOUNDDATE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DATE_FOUNDDATE.Name = "DATE_FOUNDDATE";
            this.DATE_FOUNDDATE.ReadOnly = false;
            this.DATE_FOUNDDATE.Size = new System.Drawing.Size(200, 24);
            this.DATE_FOUNDDATE.TabIndex = 4;
            this.DATE_FOUNDDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_CUSTNAME
            // 
            this.TXT_CUSTNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTNAME.Caption = "客户名称";
            this.TXT_CUSTNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTNAME.Location = new System.Drawing.Point(28, 53);
            this.TXT_CUSTNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CUSTNAME.Multiline = false;
            this.TXT_CUSTNAME.Name = "TXT_CUSTNAME";
            this.TXT_CUSTNAME.ReadOnly = false;
            this.TXT_CUSTNAME.Size = new System.Drawing.Size(397, 24);
            this.TXT_CUSTNAME.TabIndex = 5;
            this.TXT_CUSTNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.TXT_CUSTNAME.Leave += new System.EventHandler(this.TXT_CUSTNAME_Leave);
            // 
            // TXT_PY
            // 
            this.TXT_PY.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PY.Caption = "助记符";
            this.TXT_PY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_PY.Location = new System.Drawing.Point(368, 20);
            this.TXT_PY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_PY.Multiline = false;
            this.TXT_PY.Name = "TXT_PY";
            this.TXT_PY.ReadOnly = false;
            this.TXT_PY.Size = new System.Drawing.Size(179, 24);
            this.TXT_PY.TabIndex = 3;
            this.TXT_PY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CUSTCODE
            // 
            this.TXT_CUSTCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTCODE.Caption = "客户代码";
            this.TXT_CUSTCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTCODE.Location = new System.Drawing.Point(28, 20);
            this.TXT_CUSTCODE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CUSTCODE.Multiline = false;
            this.TXT_CUSTCODE.Name = "TXT_CUSTCODE";
            this.TXT_CUSTCODE.ReadOnly = true;
            this.TXT_CUSTCODE.Size = new System.Drawing.Size(203, 24);
            this.TXT_CUSTCODE.TabIndex = 1;
            this.TXT_CUSTCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_SALESMAN
            // 
            this.DROP_SALESMAN.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SALESMAN.Caption = "销售员";
            this.DROP_SALESMAN.CustomerDropDownForm = null;
            this.DROP_SALESMAN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SALESMAN.IsText = false;
            this.DROP_SALESMAN.Location = new System.Drawing.Point(28, 84);
            this.DROP_SALESMAN.Logic = null;
            this.DROP_SALESMAN.Name = "DROP_SALESMAN";
            this.DROP_SALESMAN.ReadOnly = false;
            this.DROP_SALESMAN.Size = new System.Drawing.Size(136, 24);
            this.DROP_SALESMAN.TabIndex = 7;
            this.DROP_SALESMAN.TextField = "USERNAME";
            this.DROP_SALESMAN.Value = "";
            this.DROP_SALESMAN.ValueField = "USERDM";
            this.DROP_SALESMAN.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_SALESREP
            // 
            this.DROP_SALESREP.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SALESREP.Caption = "销售代表";
            this.DROP_SALESREP.CustomerDropDownForm = null;
            this.DROP_SALESREP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SALESREP.IsText = false;
            this.DROP_SALESREP.Location = new System.Drawing.Point(170, 84);
            this.DROP_SALESREP.Logic = null;
            this.DROP_SALESREP.Name = "DROP_SALESREP";
            this.DROP_SALESREP.ReadOnly = false;
            this.DROP_SALESREP.Size = new System.Drawing.Size(151, 24);
            this.DROP_SALESREP.TabIndex = 8;
            this.DROP_SALESREP.TextField = "USERNAME";
            this.DROP_SALESREP.Value = "";
            this.DROP_SALESREP.ValueField = "USERDM";
            this.DROP_SALESREP.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_INOFC
            // 
            this.DROP_INOFC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_INOFC.Caption = "内勤";
            this.DROP_INOFC.CustomerDropDownForm = null;
            this.DROP_INOFC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_INOFC.IsText = false;
            this.DROP_INOFC.Location = new System.Drawing.Point(327, 84);
            this.DROP_INOFC.Logic = null;
            this.DROP_INOFC.Name = "DROP_INOFC";
            this.DROP_INOFC.ReadOnly = false;
            this.DROP_INOFC.Size = new System.Drawing.Size(128, 24);
            this.DROP_INOFC.TabIndex = 9;
            this.DROP_INOFC.TextField = "USERNAME";
            this.DROP_INOFC.Value = "";
            this.DROP_INOFC.ValueField = "USERDM";
            this.DROP_INOFC.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_BOSS
            // 
            this.TXT_BOSS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BOSS.Caption = "法人代表";
            this.TXT_BOSS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BOSS.Location = new System.Drawing.Point(28, 115);
            this.TXT_BOSS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_BOSS.Multiline = false;
            this.TXT_BOSS.Name = "TXT_BOSS";
            this.TXT_BOSS.ReadOnly = false;
            this.TXT_BOSS.Size = new System.Drawing.Size(155, 24);
            this.TXT_BOSS.TabIndex = 11;
            this.TXT_BOSS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_TEL
            // 
            this.TXT_TEL.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_TEL.Caption = "法人电话";
            this.TXT_TEL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_TEL.Location = new System.Drawing.Point(205, 115);
            this.TXT_TEL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_TEL.Multiline = false;
            this.TXT_TEL.Name = "TXT_TEL";
            this.TXT_TEL.ReadOnly = false;
            this.TXT_TEL.Size = new System.Drawing.Size(250, 24);
            this.TXT_TEL.TabIndex = 12;
            this.TXT_TEL.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CONTACTS
            // 
            this.TXT_CONTACTS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CONTACTS.Caption = "联系人";
            this.TXT_CONTACTS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CONTACTS.Location = new System.Drawing.Point(28, 147);
            this.TXT_CONTACTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CONTACTS.Multiline = false;
            this.TXT_CONTACTS.Name = "TXT_CONTACTS";
            this.TXT_CONTACTS.ReadOnly = false;
            this.TXT_CONTACTS.Size = new System.Drawing.Size(155, 24);
            this.TXT_CONTACTS.TabIndex = 14;
            this.TXT_CONTACTS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CONTEL
            // 
            this.TXT_CONTEL.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CONTEL.Caption = "联系电话";
            this.TXT_CONTEL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CONTEL.Location = new System.Drawing.Point(205, 147);
            this.TXT_CONTEL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CONTEL.Multiline = false;
            this.TXT_CONTEL.Name = "TXT_CONTEL";
            this.TXT_CONTEL.ReadOnly = false;
            this.TXT_CONTEL.Size = new System.Drawing.Size(250, 24);
            this.TXT_CONTEL.TabIndex = 15;
            this.TXT_CONTEL.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ADDRESS
            // 
            this.TXT_ADDRESS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ADDRESS.Caption = "地址";
            this.TXT_ADDRESS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ADDRESS.Location = new System.Drawing.Point(433, 52);
            this.TXT_ADDRESS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_ADDRESS.Multiline = false;
            this.TXT_ADDRESS.Name = "TXT_ADDRESS";
            this.TXT_ADDRESS.ReadOnly = false;
            this.TXT_ADDRESS.Size = new System.Drawing.Size(390, 24);
            this.TXT_ADDRESS.TabIndex = 6;
            this.TXT_ADDRESS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_FAX
            // 
            this.TXT_FAX.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_FAX.Caption = "传真";
            this.TXT_FAX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_FAX.Location = new System.Drawing.Point(476, 115);
            this.TXT_FAX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_FAX.Multiline = false;
            this.TXT_FAX.Name = "TXT_FAX";
            this.TXT_FAX.ReadOnly = false;
            this.TXT_FAX.Size = new System.Drawing.Size(250, 24);
            this.TXT_FAX.TabIndex = 13;
            this.TXT_FAX.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_BUYTEL
            // 
            this.TXT_BUYTEL.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BUYTEL.Caption = "采购员电话";
            this.TXT_BUYTEL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BUYTEL.Location = new System.Drawing.Point(205, 179);
            this.TXT_BUYTEL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_BUYTEL.Multiline = false;
            this.TXT_BUYTEL.Name = "TXT_BUYTEL";
            this.TXT_BUYTEL.ReadOnly = false;
            this.TXT_BUYTEL.Size = new System.Drawing.Size(250, 24);
            this.TXT_BUYTEL.TabIndex = 19;
            this.TXT_BUYTEL.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // COMB_JSFS
            // 
            this.COMB_JSFS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_JSFS.Caption = "结算方式";
            this.COMB_JSFS.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_JSFS.Columns")));
            this.COMB_JSFS.Data = "月结:月结,现金:现金,货到付款:货到付款,款到发货:款到发货";
            this.COMB_JSFS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_JSFS.Location = new System.Drawing.Point(290, 211);
            this.COMB_JSFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.COMB_JSFS.Name = "COMB_JSFS";
            this.COMB_JSFS.ReadOnly = false;
            this.COMB_JSFS.Size = new System.Drawing.Size(165, 22);
            this.COMB_JSFS.TabIndex = 22;
            this.COMB_JSFS.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // COMB_PAYTYPE
            // 
            this.COMB_PAYTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_PAYTYPE.Caption = "付款方式";
            this.COMB_PAYTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_PAYTYPE.Columns")));
            this.COMB_PAYTYPE.Data = "现金:现金,转账:转账,支票:支票";
            this.COMB_PAYTYPE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_PAYTYPE.Location = new System.Drawing.Point(290, 241);
            this.COMB_PAYTYPE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.COMB_PAYTYPE.Name = "COMB_PAYTYPE";
            this.COMB_PAYTYPE.ReadOnly = false;
            this.COMB_PAYTYPE.Size = new System.Drawing.Size(165, 22);
            this.COMB_PAYTYPE.TabIndex = 25;
            this.COMB_PAYTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // DROP_AREA
            // 
            this.DROP_AREA.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_AREA.Caption = "区域";
            this.DROP_AREA.CustomerDropDownForm = null;
            this.DROP_AREA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_AREA.IsText = false;
            this.DROP_AREA.Location = new System.Drawing.Point(476, 179);
            this.DROP_AREA.Logic = null;
            this.DROP_AREA.Name = "DROP_AREA";
            this.DROP_AREA.ReadOnly = false;
            this.DROP_AREA.Size = new System.Drawing.Size(138, 24);
            this.DROP_AREA.TabIndex = 20;
            this.DROP_AREA.TextField = "DQNAME";
            this.DROP_AREA.Value = "";
            this.DROP_AREA.ValueField = "DQDM";
            this.DROP_AREA.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_DISCOUNT
            // 
            this.TXT_DISCOUNT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_DISCOUNT.Caption = "折扣率";
            this.TXT_DISCOUNT.DataType = "Decimal";
            this.TXT_DISCOUNT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_DISCOUNT.Location = new System.Drawing.Point(476, 147);
            this.TXT_DISCOUNT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_DISCOUNT.Name = "TXT_DISCOUNT";
            this.TXT_DISCOUNT.ReadOnly = false;
            this.TXT_DISCOUNT.Size = new System.Drawing.Size(138, 24);
            this.TXT_DISCOUNT.TabIndex = 16;
            this.TXT_DISCOUNT.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_BANK
            // 
            this.TXT_BANK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BANK.Caption = "开户银行";
            this.TXT_BANK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BANK.Location = new System.Drawing.Point(28, 211);
            this.TXT_BANK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_BANK.Multiline = false;
            this.TXT_BANK.Name = "TXT_BANK";
            this.TXT_BANK.ReadOnly = false;
            this.TXT_BANK.Size = new System.Drawing.Size(254, 24);
            this.TXT_BANK.TabIndex = 21;
            this.TXT_BANK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_BANKACCOUNT
            // 
            this.TXT_BANKACCOUNT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BANKACCOUNT.Caption = "开户账号";
            this.TXT_BANKACCOUNT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BANKACCOUNT.Location = new System.Drawing.Point(28, 243);
            this.TXT_BANKACCOUNT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_BANKACCOUNT.Multiline = false;
            this.TXT_BANKACCOUNT.Name = "TXT_BANKACCOUNT";
            this.TXT_BANKACCOUNT.ReadOnly = false;
            this.TXT_BANKACCOUNT.Size = new System.Drawing.Size(254, 24);
            this.TXT_BANKACCOUNT.TabIndex = 24;
            this.TXT_BANKACCOUNT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(28, 275);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(427, 145);
            this.TXT_REMARK.TabIndex = 26;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERINFO
            // 
            this.TXT_ORDERINFO.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERINFO.Caption = "信息";
            this.TXT_ORDERINFO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERINFO.Location = new System.Drawing.Point(463, 275);
            this.TXT_ORDERINFO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_ORDERINFO.Multiline = true;
            this.TXT_ORDERINFO.Name = "TXT_ORDERINFO";
            this.TXT_ORDERINFO.ReadOnly = false;
            this.TXT_ORDERINFO.Size = new System.Drawing.Size(360, 145);
            this.TXT_ORDERINFO.TabIndex = 27;
            this.TXT_ORDERINFO.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // COMB_CUSTTYPE
            // 
            this.COMB_CUSTTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_CUSTTYPE.Caption = "客户类型";
            this.COMB_CUSTTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_CUSTTYPE.Columns")));
            this.COMB_CUSTTYPE.Data = "不限制:0,黑名单:1,款到发货:2";
            this.COMB_CUSTTYPE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_CUSTTYPE.Location = new System.Drawing.Point(638, 147);
            this.COMB_CUSTTYPE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.COMB_CUSTTYPE.Name = "COMB_CUSTTYPE";
            this.COMB_CUSTTYPE.ReadOnly = false;
            this.COMB_CUSTTYPE.Size = new System.Drawing.Size(185, 22);
            this.COMB_CUSTTYPE.TabIndex = 17;
            this.COMB_CUSTTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // TXT_TRADE
            // 
            this.TXT_TRADE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_TRADE.Caption = "行业";
            this.TXT_TRADE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_TRADE.Location = new System.Drawing.Point(476, 211);
            this.TXT_TRADE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_TRADE.Multiline = false;
            this.TXT_TRADE.Name = "TXT_TRADE";
            this.TXT_TRADE.ReadOnly = false;
            this.TXT_TRADE.Size = new System.Drawing.Size(138, 24);
            this.TXT_TRADE.TabIndex = 23;
            this.TXT_TRADE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_BUYER
            // 
            this.TXT_BUYER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BUYER.Caption = "采购员";
            this.TXT_BUYER.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BUYER.Location = new System.Drawing.Point(28, 180);
            this.TXT_BUYER.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_BUYER.Multiline = false;
            this.TXT_BUYER.Name = "TXT_BUYER";
            this.TXT_BUYER.ReadOnly = false;
            this.TXT_BUYER.Size = new System.Drawing.Size(155, 24);
            this.TXT_BUYER.TabIndex = 18;
            this.TXT_BUYER.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // COMB_CUSTLEV
            // 
            this.COMB_CUSTLEV.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_CUSTLEV.Caption = "客户等级";
            this.COMB_CUSTLEV.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_CUSTLEV.Columns")));
            this.COMB_CUSTLEV.Data = "A:A,B:B,C:C,D:D";
            this.COMB_CUSTLEV.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_CUSTLEV.Location = new System.Drawing.Point(239, 20);
            this.COMB_CUSTLEV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.COMB_CUSTLEV.Name = "COMB_CUSTLEV";
            this.COMB_CUSTLEV.ReadOnly = false;
            this.COMB_CUSTLEV.Size = new System.Drawing.Size(121, 22);
            this.COMB_CUSTLEV.TabIndex = 2;
            this.COMB_CUSTLEV.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // DM_CUSTOMEREDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 502);
            this.Name = "DM_CUSTOMEREDIT";
            this.Text = "DM_CUSTOMEREDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_CUSTNAME;
        private Controls.GText TXT_CUSTCODE;
        private Controls.GText TXT_PY;
        private Controls.GDate DATE_FOUNDDATE;
        private Controls.GDropDown DROP_INOFC;
        private Controls.GDropDown DROP_SALESREP;
        private Controls.GDropDown DROP_SALESMAN;
        private Controls.GText TXT_BOSS;
        private Controls.GText TXT_TEL;
        private Controls.GText TXT_CONTEL;
        private Controls.GText TXT_CONTACTS;
        private Controls.GText TXT_ADDRESS;
        private Controls.GText TXT_FAX;
        private Controls.GText TXT_BUYTEL;
        private Controls.GCombo COMB_PAYTYPE;
        private Controls.GCombo COMB_JSFS;
        private Controls.GDropDown DROP_AREA;
        private Controls.GNumText TXT_DISCOUNT;
        private Controls.GText TXT_BANKACCOUNT;
        private Controls.GText TXT_BANK;
        private Controls.GText TXT_REMARK;
        private Controls.GText TXT_ORDERINFO;
        private Controls.GCombo COMB_CUSTTYPE;
        private Controls.GText TXT_TRADE;
        private Controls.GText TXT_BUYER;
        private Controls.GCombo COMB_CUSTLEV;
    }
}