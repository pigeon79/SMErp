namespace G.Erp.Purchase
{
    partial class SM_SHIPVOUCHEREDIT
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
            this.TXT_SHIPVID = new G.Controls.GText();
            this.TXT_STATUS = new G.Controls.GText();
            this.DROP_SUPCODE = new G.Controls.GDropDown();
            this.DROP_OPERATOR = new G.Controls.GDropDown();
            this.DROP_AUDITOR = new G.Controls.GDropDown();
            this.DATE_AUDITDATE = new G.Controls.GDate();
            this.DATE_OPERDATE = new G.Controls.GDate();
            this.TXT_TAXRATE = new G.Controls.GText();
            this.DROP_POID = new G.Controls.GDropDown();
            this.DATE_SHIPDATE = new G.Controls.GDate();
            this.DROP_SHIPUSER = new G.Controls.GDropDown();
            this.CHECK_ISPRICEDIFF = new G.Controls.Input.GCheckBox();
            this.TXT_DELIVERCODE = new G.Controls.GText();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGrid1
            // 
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(881, 439);
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
            this.c1SplitterPanel1.Controls.Add(this.TXT_DELIVERCODE);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ISPRICEDIFF);
            this.c1SplitterPanel1.Controls.Add(this.DROP_SHIPUSER);
            this.c1SplitterPanel1.Controls.Add(this.DATE_SHIPDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_POID);
            this.c1SplitterPanel1.Controls.Add(this.TXT_TAXRATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_OPERDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_AUDITDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AUDITOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_OPERATOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_SUPCODE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SHIPVID);
            this.c1SplitterPanel1.Height = 127;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(881, 106);
            this.c1SplitterPanel1.SizeRatio = 22.438D;
            // 
            // TXT_SHIPVID
            // 
            this.TXT_SHIPVID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SHIPVID.Caption = "收货单号";
            this.TXT_SHIPVID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SHIPVID.Location = new System.Drawing.Point(492, 44);
            this.TXT_SHIPVID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SHIPVID.Multiline = false;
            this.TXT_SHIPVID.Name = "TXT_SHIPVID";
            this.TXT_SHIPVID.ReadOnly = true;
            this.TXT_SHIPVID.Size = new System.Drawing.Size(163, 21);
            this.TXT_SHIPVID.TabIndex = 22;
            this.TXT_SHIPVID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(550, 16);
            this.TXT_STATUS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STATUS.Multiline = false;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.ReadOnly = true;
            this.TXT_STATUS.Size = new System.Drawing.Size(104, 21);
            this.TXT_STATUS.TabIndex = 23;
            this.TXT_STATUS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_SUPCODE
            // 
            this.DROP_SUPCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SUPCODE.Caption = "供应商";
            this.DROP_SUPCODE.CustomerDropDownForm = null;
            this.DROP_SUPCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SUPCODE.Location = new System.Drawing.Point(256, 16);
            this.DROP_SUPCODE.Logic = null;
            this.DROP_SUPCODE.Name = "DROP_SUPCODE";
            this.DROP_SUPCODE.ReadOnly = false;
            this.DROP_SUPCODE.Size = new System.Drawing.Size(271, 21);
            this.DROP_SUPCODE.TabIndex = 25;
            this.DROP_SUPCODE.TextField = "";
            this.DROP_SUPCODE.Value = "0";
            this.DROP_SUPCODE.ValueField = "";
            this.DROP_SUPCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_OPERATOR
            // 
            this.DROP_OPERATOR.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_OPERATOR.Caption = "制单人";
            this.DROP_OPERATOR.CustomerDropDownForm = null;
            this.DROP_OPERATOR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_OPERATOR.Location = new System.Drawing.Point(678, 17);
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
            this.DROP_AUDITOR.Location = new System.Drawing.Point(492, 72);
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
            this.DATE_AUDITDATE.Location = new System.Drawing.Point(676, 72);
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
            this.DATE_OPERDATE.Location = new System.Drawing.Point(678, 44);
            this.DATE_OPERDATE.Name = "DATE_OPERDATE";
            this.DATE_OPERDATE.ReadOnly = true;
            this.DATE_OPERDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_OPERDATE.TabIndex = 29;
            this.DATE_OPERDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_TAXRATE
            // 
            this.TXT_TAXRATE.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_TAXRATE.Caption = "税率";
            this.TXT_TAXRATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_TAXRATE.Location = new System.Drawing.Point(254, 72);
            this.TXT_TAXRATE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_TAXRATE.Multiline = false;
            this.TXT_TAXRATE.Name = "TXT_TAXRATE";
            this.TXT_TAXRATE.ReadOnly = false;
            this.TXT_TAXRATE.Size = new System.Drawing.Size(80, 21);
            this.TXT_TAXRATE.TabIndex = 30;
            this.TXT_TAXRATE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_POID
            // 
            this.DROP_POID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_POID.Caption = "采购订单号";
            this.DROP_POID.CustomerDropDownForm = null;
            this.DROP_POID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_POID.Location = new System.Drawing.Point(40, 16);
            this.DROP_POID.Logic = null;
            this.DROP_POID.Name = "DROP_POID";
            this.DROP_POID.ReadOnly = false;
            this.DROP_POID.Size = new System.Drawing.Size(193, 21);
            this.DROP_POID.TabIndex = 32;
            this.DROP_POID.TextField = "";
            this.DROP_POID.Value = "0";
            this.DROP_POID.ValueField = "";
            this.DROP_POID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.DROP_POID.RowSelect += new System.EventHandler<G.Interface.Event.DataRowEvent>(this.DROP_POID_RowSelect);
            // 
            // DATE_SHIPDATE
            // 
            this.DATE_SHIPDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_SHIPDATE.Caption = "收货日期";
            this.DATE_SHIPDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_SHIPDATE.Location = new System.Drawing.Point(266, 45);
            this.DATE_SHIPDATE.Name = "DATE_SHIPDATE";
            this.DATE_SHIPDATE.ReadOnly = false;
            this.DATE_SHIPDATE.Size = new System.Drawing.Size(193, 21);
            this.DATE_SHIPDATE.TabIndex = 33;
            this.DATE_SHIPDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_SHIPUSER
            // 
            this.DROP_SHIPUSER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SHIPUSER.Caption = "收货员";
            this.DROP_SHIPUSER.CustomerDropDownForm = null;
            this.DROP_SHIPUSER.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SHIPUSER.Location = new System.Drawing.Point(40, 45);
            this.DROP_SHIPUSER.Logic = null;
            this.DROP_SHIPUSER.Name = "DROP_SHIPUSER";
            this.DROP_SHIPUSER.ReadOnly = false;
            this.DROP_SHIPUSER.Size = new System.Drawing.Size(193, 21);
            this.DROP_SHIPUSER.TabIndex = 34;
            this.DROP_SHIPUSER.TextField = "USERNAME";
            this.DROP_SHIPUSER.Value = "0";
            this.DROP_SHIPUSER.ValueField = "USERDM";
            this.DROP_SHIPUSER.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // CHECK_ISPRICEDIFF
            // 
            this.CHECK_ISPRICEDIFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ISPRICEDIFF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ISPRICEDIFF.Caption = "是否补差价单";
            this.CHECK_ISPRICEDIFF.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ISPRICEDIFF.Location = new System.Drawing.Point(355, 72);
            this.CHECK_ISPRICEDIFF.Name = "CHECK_ISPRICEDIFF";
            this.CHECK_ISPRICEDIFF.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ISPRICEDIFF.ReadOnly = false;
            this.CHECK_ISPRICEDIFF.Size = new System.Drawing.Size(116, 24);
            this.CHECK_ISPRICEDIFF.TabIndex = 35;
            this.CHECK_ISPRICEDIFF.Text = "是否补差价单";
            this.CHECK_ISPRICEDIFF.UseVisualStyleBackColor = false;
            this.CHECK_ISPRICEDIFF.Value = null;
            this.CHECK_ISPRICEDIFF.CheckStateChanged += new System.EventHandler(this.CHECK_ISPRICEDIFF_CheckStateChanged);
            // 
            // TXT_DELIVERCODE
            // 
            this.TXT_DELIVERCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_DELIVERCODE.Caption = "送货单号";
            this.TXT_DELIVERCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_DELIVERCODE.Location = new System.Drawing.Point(40, 72);
            this.TXT_DELIVERCODE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_DELIVERCODE.Multiline = false;
            this.TXT_DELIVERCODE.Name = "TXT_DELIVERCODE";
            this.TXT_DELIVERCODE.ReadOnly = false;
            this.TXT_DELIVERCODE.Size = new System.Drawing.Size(193, 21);
            this.TXT_DELIVERCODE.TabIndex = 36;
            this.TXT_DELIVERCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // SM_SHIPVOUCHEREDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 594);
            this.Name = "SM_SHIPVOUCHEREDIT";
            this.Text = "SM_PORDEREDIT";
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_SHIPVID;
        private Controls.GText TXT_STATUS;
        private Controls.GDropDown DROP_SUPCODE;
        private Controls.GDropDown DROP_OPERATOR;
        private Controls.GDropDown DROP_AUDITOR;
        private Controls.GDate DATE_OPERDATE;
        private Controls.GDate DATE_AUDITDATE;
        private Controls.GText TXT_TAXRATE;
        private Controls.GDropDown DROP_SHIPUSER;
        private Controls.GDate DATE_SHIPDATE;
        private Controls.GDropDown DROP_POID;
        private Controls.Input.GCheckBox CHECK_ISPRICEDIFF;
        private Controls.GText TXT_DELIVERCODE;
    }
}