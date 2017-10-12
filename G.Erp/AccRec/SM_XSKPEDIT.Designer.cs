namespace G.Erp.AccRec
{
    partial class SM_XSKPEDIT
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
            this.TXT_STATUS = new G.Controls.GText();
            this.DROP_OPERATOR = new G.Controls.GDropDown();
            this.DROP_AUDITOR = new G.Controls.GDropDown();
            this.DATE_AUDITDATE = new G.Controls.GDate();
            this.DATE_OPERDATE = new G.Controls.GDate();
            this.DROP_CUSTID = new G.Controls.GDropDown();
            this.TXT_FPNO = new G.Controls.GText();
            this.TXT_NO = new G.Controls.GText();
            this.DROP_INVCUSTID = new G.Controls.GDropDown();
            this.TXT_REMARK = new G.Controls.GText();
            this.TXT_SUMQTY = new G.Controls.GText();
            this.TXT_SUMVAT = new G.Controls.GText();
            this.TXT_SUMVOT = new G.Controls.GText();
            this.TXT_SKDAYS = new G.Controls.GText();
            this.DROP_SALEREP = new G.Controls.GDropDown();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGrid1
            // 
            this.gGrid1.Rows.Count = 1;
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(881, 416);
            this.gGrid1.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.gGrid1_AfterEdit);
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(881, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(881, 570);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.DROP_SALEREP);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SKDAYS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUMVOT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUMVAT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUMQTY);
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.DROP_INVCUSTID);
            this.c1SplitterPanel1.Controls.Add(this.TXT_NO);
            this.c1SplitterPanel1.Controls.Add(this.TXT_FPNO);
            this.c1SplitterPanel1.Controls.Add(this.DROP_CUSTID);
            this.c1SplitterPanel1.Controls.Add(this.DATE_OPERDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_AUDITDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AUDITOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_OPERATOR);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Height = 150;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(881, 129);
            this.c1SplitterPanel1.SizeRatio = 26.502D;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(456, 45);
            this.TXT_STATUS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STATUS.Multiline = false;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.ReadOnly = true;
            this.TXT_STATUS.Size = new System.Drawing.Size(77, 21);
            this.TXT_STATUS.TabIndex = 23;
            this.TXT_STATUS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_OPERATOR
            // 
            this.DROP_OPERATOR.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_OPERATOR.Caption = "制单人";
            this.DROP_OPERATOR.CustomerDropDownForm = null;
            this.DROP_OPERATOR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_OPERATOR.IsText = false;
            this.DROP_OPERATOR.Location = new System.Drawing.Point(540, 17);
            this.DROP_OPERATOR.Logic = null;
            this.DROP_OPERATOR.Name = "DROP_OPERATOR";
            this.DROP_OPERATOR.ReadOnly = true;
            this.DROP_OPERATOR.Size = new System.Drawing.Size(163, 21);
            this.DROP_OPERATOR.TabIndex = 26;
            this.DROP_OPERATOR.TextField = "USERNAME";
            this.DROP_OPERATOR.Value = "0";
            this.DROP_OPERATOR.ValueField = "USERDM";
            this.DROP_OPERATOR.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_AUDITOR
            // 
            this.DROP_AUDITOR.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_AUDITOR.Caption = "审核人";
            this.DROP_AUDITOR.CustomerDropDownForm = null;
            this.DROP_AUDITOR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_AUDITOR.IsText = false;
            this.DROP_AUDITOR.Location = new System.Drawing.Point(540, 43);
            this.DROP_AUDITOR.Logic = null;
            this.DROP_AUDITOR.Name = "DROP_AUDITOR";
            this.DROP_AUDITOR.ReadOnly = true;
            this.DROP_AUDITOR.Size = new System.Drawing.Size(163, 21);
            this.DROP_AUDITOR.TabIndex = 27;
            this.DROP_AUDITOR.TextField = "USERNAME";
            this.DROP_AUDITOR.Value = "0";
            this.DROP_AUDITOR.ValueField = "USERDM";
            this.DROP_AUDITOR.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DATE_AUDITDATE
            // 
            this.DATE_AUDITDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_AUDITDATE.Caption = "审核日期";
            this.DATE_AUDITDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_AUDITDATE.Location = new System.Drawing.Point(709, 43);
            this.DATE_AUDITDATE.Name = "DATE_AUDITDATE";
            this.DATE_AUDITDATE.ReadOnly = true;
            this.DATE_AUDITDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_AUDITDATE.TabIndex = 28;
            this.DATE_AUDITDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DATE_OPERDATE
            // 
            this.DATE_OPERDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_OPERDATE.Caption = "制单日期";
            this.DATE_OPERDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_OPERDATE.Location = new System.Drawing.Point(709, 17);
            this.DATE_OPERDATE.Name = "DATE_OPERDATE";
            this.DATE_OPERDATE.ReadOnly = true;
            this.DATE_OPERDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_OPERDATE.TabIndex = 29;
            this.DATE_OPERDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_CUSTID
            // 
            this.DROP_CUSTID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_CUSTID.Caption = "下单客户";
            this.DROP_CUSTID.CustomerDropDownForm = null;
            this.DROP_CUSTID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_CUSTID.IsText = false;
            this.DROP_CUSTID.Location = new System.Drawing.Point(40, 45);
            this.DROP_CUSTID.Logic = null;
            this.DROP_CUSTID.Name = "DROP_CUSTID";
            this.DROP_CUSTID.ReadOnly = false;
            this.DROP_CUSTID.Size = new System.Drawing.Size(270, 21);
            this.DROP_CUSTID.TabIndex = 34;
            this.DROP_CUSTID.TextField = "USERNAME";
            this.DROP_CUSTID.Value = "0";
            this.DROP_CUSTID.ValueField = "USERDM";
            this.DROP_CUSTID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.DROP_CUSTID.RowSelect += new System.EventHandler<G.Interface.Event.DataRowEvent>(this.DROP_CUSTID_RowSelect);
            // 
            // TXT_FPNO
            // 
            this.TXT_FPNO.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_FPNO.Caption = "金穗票号";
            this.TXT_FPNO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_FPNO.Location = new System.Drawing.Point(194, 17);
            this.TXT_FPNO.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_FPNO.Multiline = false;
            this.TXT_FPNO.Name = "TXT_FPNO";
            this.TXT_FPNO.ReadOnly = false;
            this.TXT_FPNO.Size = new System.Drawing.Size(339, 21);
            this.TXT_FPNO.TabIndex = 1;
            this.TXT_FPNO.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_NO
            // 
            this.TXT_NO.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_NO.Caption = "开票单号";
            this.TXT_NO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_NO.Location = new System.Drawing.Point(40, 17);
            this.TXT_NO.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NO.Multiline = false;
            this.TXT_NO.Name = "TXT_NO";
            this.TXT_NO.ReadOnly = true;
            this.TXT_NO.Size = new System.Drawing.Size(149, 21);
            this.TXT_NO.TabIndex = 37;
            this.TXT_NO.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_INVCUSTID
            // 
            this.DROP_INVCUSTID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_INVCUSTID.Caption = "开票客户";
            this.DROP_INVCUSTID.CustomerDropDownForm = null;
            this.DROP_INVCUSTID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_INVCUSTID.IsText = false;
            this.DROP_INVCUSTID.Location = new System.Drawing.Point(40, 72);
            this.DROP_INVCUSTID.Logic = null;
            this.DROP_INVCUSTID.Name = "DROP_INVCUSTID";
            this.DROP_INVCUSTID.ReadOnly = true;
            this.DROP_INVCUSTID.Size = new System.Drawing.Size(270, 21);
            this.DROP_INVCUSTID.TabIndex = 38;
            this.DROP_INVCUSTID.TextField = "USERNAME";
            this.DROP_INVCUSTID.Value = "0";
            this.DROP_INVCUSTID.ValueField = "USERDM";
            this.DROP_INVCUSTID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(40, 100);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = false;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(661, 21);
            this.TXT_REMARK.TabIndex = 39;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_SUMQTY
            // 
            this.TXT_SUMQTY.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUMQTY.Caption = "合计数量";
            this.TXT_SUMQTY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUMQTY.Location = new System.Drawing.Point(540, 71);
            this.TXT_SUMQTY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUMQTY.Multiline = false;
            this.TXT_SUMQTY.Name = "TXT_SUMQTY";
            this.TXT_SUMQTY.ReadOnly = true;
            this.TXT_SUMQTY.Size = new System.Drawing.Size(163, 21);
            this.TXT_SUMQTY.TabIndex = 40;
            this.TXT_SUMQTY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SUMVAT
            // 
            this.TXT_SUMVAT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUMVAT.Caption = "合计价税";
            this.TXT_SUMVAT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUMVAT.Location = new System.Drawing.Point(709, 100);
            this.TXT_SUMVAT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUMVAT.Multiline = false;
            this.TXT_SUMVAT.Name = "TXT_SUMVAT";
            this.TXT_SUMVAT.ReadOnly = true;
            this.TXT_SUMVAT.Size = new System.Drawing.Size(163, 21);
            this.TXT_SUMVAT.TabIndex = 41;
            this.TXT_SUMVAT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SUMVOT
            // 
            this.TXT_SUMVOT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUMVOT.Caption = "合计金额";
            this.TXT_SUMVOT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUMVOT.Location = new System.Drawing.Point(709, 71);
            this.TXT_SUMVOT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUMVOT.Multiline = false;
            this.TXT_SUMVOT.Name = "TXT_SUMVOT";
            this.TXT_SUMVOT.ReadOnly = true;
            this.TXT_SUMVOT.Size = new System.Drawing.Size(163, 21);
            this.TXT_SUMVOT.TabIndex = 43;
            this.TXT_SUMVOT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SKDAYS
            // 
            this.TXT_SKDAYS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SKDAYS.Caption = "收款期限";
            this.TXT_SKDAYS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SKDAYS.Location = new System.Drawing.Point(317, 71);
            this.TXT_SKDAYS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SKDAYS.Multiline = false;
            this.TXT_SKDAYS.Name = "TXT_SKDAYS";
            this.TXT_SKDAYS.ReadOnly = false;
            this.TXT_SKDAYS.Size = new System.Drawing.Size(137, 21);
            this.TXT_SKDAYS.TabIndex = 44;
            this.TXT_SKDAYS.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_SALEREP
            // 
            this.DROP_SALEREP.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SALEREP.Caption = "销售员";
            this.DROP_SALEREP.CustomerDropDownForm = null;
            this.DROP_SALEREP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SALEREP.IsText = false;
            this.DROP_SALEREP.Location = new System.Drawing.Point(317, 44);
            this.DROP_SALEREP.Logic = null;
            this.DROP_SALEREP.Name = "DROP_SALEREP";
            this.DROP_SALEREP.ReadOnly = true;
            this.DROP_SALEREP.Size = new System.Drawing.Size(137, 21);
            this.DROP_SALEREP.TabIndex = 45;
            this.DROP_SALEREP.TextField = "USERNAME";
            this.DROP_SALEREP.Value = "0";
            this.DROP_SALEREP.ValueField = "USERDM";
            this.DROP_SALEREP.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_XSKPEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 594);
            this.Name = "SM_XSKPEDIT";
            this.Text = "SM_XSKPEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_STATUS;
        private Controls.GDropDown DROP_OPERATOR;
        private Controls.GDropDown DROP_AUDITOR;
        private Controls.GDate DATE_OPERDATE;
        private Controls.GDate DATE_AUDITDATE;
        private Controls.GDropDown DROP_CUSTID;
        private Controls.GDropDown DROP_INVCUSTID;
        private Controls.GText TXT_NO;
        private Controls.GText TXT_FPNO;
        private Controls.GText TXT_REMARK;
        private Controls.GText TXT_SKDAYS;
        private Controls.GText TXT_SUMVOT;
        private Controls.GText TXT_SUMVAT;
        private Controls.GText TXT_SUMQTY;
        private Controls.GDropDown DROP_SALEREP;
    }
}