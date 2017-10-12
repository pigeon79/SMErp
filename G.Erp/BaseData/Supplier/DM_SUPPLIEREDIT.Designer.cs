namespace G.Erp.BaseData
{
    partial class DM_SUPPLIEREDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM_SUPPLIEREDIT));
            this.TXT_SUPPNAME = new G.Controls.GText();
            this.TXT_SUPPCODE = new G.Controls.GText();
            this.COMB_SUPPLEV = new G.Controls.GCombo();
            this.DATE_FOUNDDATE = new G.Controls.GDate();
            this.TXT_PY = new G.Controls.GText();
            this.TXT_SUPPOR = new G.Controls.GText();
            this.TXT_SUPPDESC = new G.Controls.GText();
            this.TXT_FAX = new G.Controls.GText();
            this.TXT_BOSS = new G.Controls.GText();
            this.TXT_CONTACTS = new G.Controls.GText();
            this.TXT_CONTEL = new G.Controls.GText();
            this.TXT_TEL = new G.Controls.GText();
            this.TXT_SUPPTEL = new G.Controls.GText();
            this.TXT_ADDRESS = new G.Controls.GText();
            this.TXT_PRDCOUNT = new G.Controls.GText();
            this.TXT_QS = new G.Controls.GText();
            this.TXT_SERVER = new G.Controls.GText();
            this.TXT_BANK = new G.Controls.GText();
            this.TXT_BANKCOUNT = new G.Controls.GText();
            this.TXT_REMARK = new G.Controls.GText();
            this.COMB_SUPPTYPE = new G.Controls.GCombo();
            this.DROP_AREA = new G.Controls.GDropDown();
            this.COMB_PAYTYPE = new G.Controls.GCombo();
            this.TXT_PAYTIME = new G.Controls.GText();
            this.CHECK_INVTAG = new G.Controls.Input.GCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(722, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(722, 540);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.CHECK_INVTAG);
            this.c1SplitterPanel1.Controls.Add(this.TXT_PAYTIME);
            this.c1SplitterPanel1.Controls.Add(this.COMB_PAYTYPE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AREA);
            this.c1SplitterPanel1.Controls.Add(this.COMB_SUPPTYPE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BANKCOUNT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BANK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SERVER);
            this.c1SplitterPanel1.Controls.Add(this.TXT_QS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_PRDCOUNT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUPPTEL);
            this.c1SplitterPanel1.Controls.Add(this.TXT_ADDRESS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_CONTEL);
            this.c1SplitterPanel1.Controls.Add(this.TXT_TEL);
            this.c1SplitterPanel1.Controls.Add(this.TXT_CONTACTS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BOSS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_FAX);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUPPDESC);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUPPOR);
            this.c1SplitterPanel1.Controls.Add(this.TXT_PY);
            this.c1SplitterPanel1.Controls.Add(this.DATE_FOUNDDATE);
            this.c1SplitterPanel1.Controls.Add(this.COMB_SUPPLEV);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUPPNAME);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUPPCODE);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(722, 519);
            // 
            // TXT_SUPPNAME
            // 
            this.TXT_SUPPNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUPPNAME.Caption = "供应商名称";
            this.TXT_SUPPNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUPPNAME.Location = new System.Drawing.Point(318, 24);
            this.TXT_SUPPNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUPPNAME.Multiline = false;
            this.TXT_SUPPNAME.Name = "TXT_SUPPNAME";
            this.TXT_SUPPNAME.ReadOnly = false;
            this.TXT_SUPPNAME.Size = new System.Drawing.Size(288, 21);
            this.TXT_SUPPNAME.TabIndex = 2;
            this.TXT_SUPPNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.TXT_SUPPNAME.Leave += new System.EventHandler(this.TXT_SUPPNAME_Leave);
            // 
            // TXT_SUPPCODE
            // 
            this.TXT_SUPPCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUPPCODE.Caption = "供应商代码";
            this.TXT_SUPPCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUPPCODE.Location = new System.Drawing.Point(80, 24);
            this.TXT_SUPPCODE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUPPCODE.Multiline = false;
            this.TXT_SUPPCODE.Name = "TXT_SUPPCODE";
            this.TXT_SUPPCODE.ReadOnly = false;
            this.TXT_SUPPCODE.Size = new System.Drawing.Size(210, 21);
            this.TXT_SUPPCODE.TabIndex = 1;
            this.TXT_SUPPCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // COMB_SUPPLEV
            // 
            this.COMB_SUPPLEV.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_SUPPLEV.Caption = "供应商等级";
            this.COMB_SUPPLEV.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_SUPPLEV.Columns")));
            this.COMB_SUPPLEV.Data = "A:A,B:B,C:C";
            this.COMB_SUPPLEV.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_SUPPLEV.Location = new System.Drawing.Point(80, 53);
            this.COMB_SUPPLEV.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_SUPPLEV.Name = "COMB_SUPPLEV";
            this.COMB_SUPPLEV.ReadOnly = false;
            this.COMB_SUPPLEV.Size = new System.Drawing.Size(210, 22);
            this.COMB_SUPPLEV.TabIndex = 3;
            this.COMB_SUPPLEV.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // DATE_FOUNDDATE
            // 
            this.DATE_FOUNDDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_FOUNDDATE.Caption = "建立日期";
            this.DATE_FOUNDDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_FOUNDDATE.Location = new System.Drawing.Point(80, 82);
            this.DATE_FOUNDDATE.Name = "DATE_FOUNDDATE";
            this.DATE_FOUNDDATE.ReadOnly = false;
            this.DATE_FOUNDDATE.Size = new System.Drawing.Size(173, 21);
            this.DATE_FOUNDDATE.TabIndex = 4;
            this.DATE_FOUNDDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_PY
            // 
            this.TXT_PY.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PY.Caption = "助记符";
            this.TXT_PY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_PY.Location = new System.Drawing.Point(318, 53);
            this.TXT_PY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PY.Multiline = false;
            this.TXT_PY.Name = "TXT_PY";
            this.TXT_PY.ReadOnly = false;
            this.TXT_PY.Size = new System.Drawing.Size(189, 21);
            this.TXT_PY.TabIndex = 24;
            this.TXT_PY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SUPPOR
            // 
            this.TXT_SUPPOR.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUPPOR.Caption = "供应商主业";
            this.TXT_SUPPOR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUPPOR.Location = new System.Drawing.Point(80, 110);
            this.TXT_SUPPOR.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUPPOR.Multiline = false;
            this.TXT_SUPPOR.Name = "TXT_SUPPOR";
            this.TXT_SUPPOR.ReadOnly = false;
            this.TXT_SUPPOR.Size = new System.Drawing.Size(210, 21);
            this.TXT_SUPPOR.TabIndex = 7;
            this.TXT_SUPPOR.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SUPPDESC
            // 
            this.TXT_SUPPDESC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUPPDESC.Caption = "主业描述";
            this.TXT_SUPPDESC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUPPDESC.Location = new System.Drawing.Point(318, 110);
            this.TXT_SUPPDESC.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUPPDESC.Multiline = false;
            this.TXT_SUPPDESC.Name = "TXT_SUPPDESC";
            this.TXT_SUPPDESC.ReadOnly = false;
            this.TXT_SUPPDESC.Size = new System.Drawing.Size(288, 21);
            this.TXT_SUPPDESC.TabIndex = 8;
            this.TXT_SUPPDESC.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_FAX
            // 
            this.TXT_FAX.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_FAX.Caption = "传真";
            this.TXT_FAX.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_FAX.Location = new System.Drawing.Point(80, 197);
            this.TXT_FAX.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_FAX.Multiline = false;
            this.TXT_FAX.Name = "TXT_FAX";
            this.TXT_FAX.ReadOnly = false;
            this.TXT_FAX.Size = new System.Drawing.Size(210, 21);
            this.TXT_FAX.TabIndex = 13;
            this.TXT_FAX.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_BOSS
            // 
            this.TXT_BOSS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BOSS.Caption = "法人代表";
            this.TXT_BOSS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BOSS.Location = new System.Drawing.Point(80, 139);
            this.TXT_BOSS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_BOSS.Multiline = false;
            this.TXT_BOSS.Name = "TXT_BOSS";
            this.TXT_BOSS.ReadOnly = false;
            this.TXT_BOSS.Size = new System.Drawing.Size(173, 21);
            this.TXT_BOSS.TabIndex = 9;
            this.TXT_BOSS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CONTACTS
            // 
            this.TXT_CONTACTS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CONTACTS.Caption = "联系人";
            this.TXT_CONTACTS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CONTACTS.Location = new System.Drawing.Point(80, 168);
            this.TXT_CONTACTS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CONTACTS.Multiline = false;
            this.TXT_CONTACTS.Name = "TXT_CONTACTS";
            this.TXT_CONTACTS.ReadOnly = false;
            this.TXT_CONTACTS.Size = new System.Drawing.Size(173, 21);
            this.TXT_CONTACTS.TabIndex = 11;
            this.TXT_CONTACTS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CONTEL
            // 
            this.TXT_CONTEL.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CONTEL.Caption = "联系电话";
            this.TXT_CONTEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CONTEL.Location = new System.Drawing.Point(318, 168);
            this.TXT_CONTEL.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CONTEL.Multiline = false;
            this.TXT_CONTEL.Name = "TXT_CONTEL";
            this.TXT_CONTEL.ReadOnly = false;
            this.TXT_CONTEL.Size = new System.Drawing.Size(189, 21);
            this.TXT_CONTEL.TabIndex = 12;
            this.TXT_CONTEL.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_TEL
            // 
            this.TXT_TEL.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_TEL.Caption = "法人电话";
            this.TXT_TEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_TEL.Location = new System.Drawing.Point(318, 139);
            this.TXT_TEL.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_TEL.Multiline = false;
            this.TXT_TEL.Name = "TXT_TEL";
            this.TXT_TEL.ReadOnly = false;
            this.TXT_TEL.Size = new System.Drawing.Size(189, 21);
            this.TXT_TEL.TabIndex = 10;
            this.TXT_TEL.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SUPPTEL
            // 
            this.TXT_SUPPTEL.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUPPTEL.Caption = "业务电话";
            this.TXT_SUPPTEL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUPPTEL.Location = new System.Drawing.Point(80, 226);
            this.TXT_SUPPTEL.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUPPTEL.Multiline = false;
            this.TXT_SUPPTEL.Name = "TXT_SUPPTEL";
            this.TXT_SUPPTEL.ReadOnly = false;
            this.TXT_SUPPTEL.Size = new System.Drawing.Size(210, 21);
            this.TXT_SUPPTEL.TabIndex = 15;
            this.TXT_SUPPTEL.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ADDRESS
            // 
            this.TXT_ADDRESS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ADDRESS.Caption = "地址";
            this.TXT_ADDRESS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ADDRESS.Location = new System.Drawing.Point(318, 197);
            this.TXT_ADDRESS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ADDRESS.Multiline = false;
            this.TXT_ADDRESS.Name = "TXT_ADDRESS";
            this.TXT_ADDRESS.ReadOnly = false;
            this.TXT_ADDRESS.Size = new System.Drawing.Size(288, 21);
            this.TXT_ADDRESS.TabIndex = 14;
            this.TXT_ADDRESS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_PRDCOUNT
            // 
            this.TXT_PRDCOUNT.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_PRDCOUNT.Caption = "产量";
            this.TXT_PRDCOUNT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_PRDCOUNT.Location = new System.Drawing.Point(318, 226);
            this.TXT_PRDCOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PRDCOUNT.Multiline = false;
            this.TXT_PRDCOUNT.Name = "TXT_PRDCOUNT";
            this.TXT_PRDCOUNT.ReadOnly = false;
            this.TXT_PRDCOUNT.Size = new System.Drawing.Size(126, 21);
            this.TXT_PRDCOUNT.TabIndex = 16;
            this.TXT_PRDCOUNT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_QS
            // 
            this.TXT_QS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_QS.Caption = "品质";
            this.TXT_QS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_QS.Location = new System.Drawing.Point(80, 255);
            this.TXT_QS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_QS.Multiline = false;
            this.TXT_QS.Name = "TXT_QS";
            this.TXT_QS.ReadOnly = false;
            this.TXT_QS.Size = new System.Drawing.Size(210, 21);
            this.TXT_QS.TabIndex = 17;
            this.TXT_QS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SERVER
            // 
            this.TXT_SERVER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SERVER.Caption = "服务";
            this.TXT_SERVER.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SERVER.Location = new System.Drawing.Point(318, 255);
            this.TXT_SERVER.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SERVER.Multiline = false;
            this.TXT_SERVER.Name = "TXT_SERVER";
            this.TXT_SERVER.ReadOnly = false;
            this.TXT_SERVER.Size = new System.Drawing.Size(210, 21);
            this.TXT_SERVER.TabIndex = 18;
            this.TXT_SERVER.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_BANK
            // 
            this.TXT_BANK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BANK.Caption = "开户银行";
            this.TXT_BANK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BANK.Location = new System.Drawing.Point(80, 343);
            this.TXT_BANK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_BANK.Multiline = false;
            this.TXT_BANK.Name = "TXT_BANK";
            this.TXT_BANK.ReadOnly = false;
            this.TXT_BANK.Size = new System.Drawing.Size(210, 21);
            this.TXT_BANK.TabIndex = 21;
            this.TXT_BANK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_BANKCOUNT
            // 
            this.TXT_BANKCOUNT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BANKCOUNT.Caption = "开户账号";
            this.TXT_BANKCOUNT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BANKCOUNT.Location = new System.Drawing.Point(318, 343);
            this.TXT_BANKCOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_BANKCOUNT.Multiline = false;
            this.TXT_BANKCOUNT.Name = "TXT_BANKCOUNT";
            this.TXT_BANKCOUNT.ReadOnly = false;
            this.TXT_BANKCOUNT.Size = new System.Drawing.Size(288, 21);
            this.TXT_BANKCOUNT.TabIndex = 22;
            this.TXT_BANKCOUNT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(80, 372);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(526, 88);
            this.TXT_REMARK.TabIndex = 23;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // COMB_SUPPTYPE
            // 
            this.COMB_SUPPTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_SUPPTYPE.Caption = "供应商类别";
            this.COMB_SUPPTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_SUPPTYPE.Columns")));
            this.COMB_SUPPTYPE.Data = "花模:花模,塑料:塑料,五金:五金";
            this.COMB_SUPPTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_SUPPTYPE.Location = new System.Drawing.Point(318, 82);
            this.COMB_SUPPTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_SUPPTYPE.Name = "COMB_SUPPTYPE";
            this.COMB_SUPPTYPE.ReadOnly = false;
            this.COMB_SUPPTYPE.Size = new System.Drawing.Size(210, 22);
            this.COMB_SUPPTYPE.TabIndex = 5;
            this.COMB_SUPPTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // DROP_AREA
            // 
            this.DROP_AREA.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_AREA.Caption = "区域";
            this.DROP_AREA.CustomerDropDownForm = null;
            this.DROP_AREA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_AREA.IsText = false;
            this.DROP_AREA.Location = new System.Drawing.Point(80, 315);
            this.DROP_AREA.Logic = null;
            this.DROP_AREA.Name = "DROP_AREA";
            this.DROP_AREA.ReadOnly = false;
            this.DROP_AREA.Size = new System.Drawing.Size(153, 21);
            this.DROP_AREA.TabIndex = 20;
            this.DROP_AREA.TextField = "";
            this.DROP_AREA.Value = "0";
            this.DROP_AREA.ValueField = "";
            this.DROP_AREA.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // COMB_PAYTYPE
            // 
            this.COMB_PAYTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_PAYTYPE.Caption = "付款方式";
            this.COMB_PAYTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_PAYTYPE.Columns")));
            this.COMB_PAYTYPE.Data = "月结:月结,现金:现金,货到付款:货到付款,款到发货:款到发货";
            this.COMB_PAYTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_PAYTYPE.Location = new System.Drawing.Point(80, 285);
            this.COMB_PAYTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_PAYTYPE.Name = "COMB_PAYTYPE";
            this.COMB_PAYTYPE.ReadOnly = false;
            this.COMB_PAYTYPE.Size = new System.Drawing.Size(173, 22);
            this.COMB_PAYTYPE.TabIndex = 25;
            this.COMB_PAYTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // TXT_PAYTIME
            // 
            this.TXT_PAYTIME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PAYTIME.Caption = "付款时间";
            this.TXT_PAYTIME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_PAYTIME.Location = new System.Drawing.Point(318, 284);
            this.TXT_PAYTIME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PAYTIME.Multiline = false;
            this.TXT_PAYTIME.Name = "TXT_PAYTIME";
            this.TXT_PAYTIME.ReadOnly = false;
            this.TXT_PAYTIME.Size = new System.Drawing.Size(210, 21);
            this.TXT_PAYTIME.TabIndex = 26;
            this.TXT_PAYTIME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // CHECK_INVTAG
            // 
            this.CHECK_INVTAG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_INVTAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_INVTAG.Caption = "是否开票";
            this.CHECK_INVTAG.ForeColor = System.Drawing.Color.Black;
            this.CHECK_INVTAG.Location = new System.Drawing.Point(318, 312);
            this.CHECK_INVTAG.Name = "CHECK_INVTAG";
            this.CHECK_INVTAG.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_INVTAG.ReadOnly = false;
            this.CHECK_INVTAG.Size = new System.Drawing.Size(85, 24);
            this.CHECK_INVTAG.TabIndex = 27;
            this.CHECK_INVTAG.Text = "是否开票";
            this.CHECK_INVTAG.UseVisualStyleBackColor = false;
            this.CHECK_INVTAG.Value = null;
            // 
            // DM_SUPPLIEREDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 564);
            this.Name = "DM_SUPPLIEREDIT";
            this.Text = "DM_AREAEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_SUPPNAME;
        private Controls.GText TXT_SUPPCODE;
        private Controls.GCombo COMB_SUPPLEV;
        private Controls.GText TXT_PY;
        private Controls.GDate DATE_FOUNDDATE;
        private Controls.GText TXT_CONTACTS;
        private Controls.GText TXT_BOSS;
        private Controls.GText TXT_FAX;
        private Controls.GText TXT_SUPPDESC;
        private Controls.GText TXT_SUPPOR;
        private Controls.GText TXT_SUPPTEL;
        private Controls.GText TXT_ADDRESS;
        private Controls.GText TXT_CONTEL;
        private Controls.GText TXT_TEL;
        private Controls.GText TXT_REMARK;
        private Controls.GText TXT_BANKCOUNT;
        private Controls.GText TXT_BANK;
        private Controls.GText TXT_SERVER;
        private Controls.GText TXT_QS;
        private Controls.GText TXT_PRDCOUNT;
        private Controls.GCombo COMB_SUPPTYPE;
        private Controls.GCombo COMB_PAYTYPE;
        private Controls.GDropDown DROP_AREA;
        private Controls.GText TXT_PAYTIME;
        private Controls.Input.GCheckBox CHECK_INVTAG;
    }
}