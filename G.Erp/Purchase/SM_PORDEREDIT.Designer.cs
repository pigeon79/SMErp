namespace G.Erp.Purchase
{
    partial class SM_PORDEREDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SM_PORDEREDIT));
            this.TXT_REMARK = new G.Controls.GText();
            this.TXT_POID = new G.Controls.GText();
            this.TXT_STATUS = new G.Controls.GText();
            this.COMB_POTYPE = new G.Controls.GCombo();
            this.DROP_SUPCODE = new G.Controls.GDropDown();
            this.DROP_OPERATOR = new G.Controls.GDropDown();
            this.DROP_AUDITOR = new G.Controls.GDropDown();
            this.DATE_AUDITDATE = new G.Controls.GDate();
            this.DATE_OPERDATE = new G.Controls.GDate();
            this.TXT_TAXRATE = new G.Controls.GText();
            this.TXT_TOTALAMT = new G.Controls.GText();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGrid1
            // 
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(881, 415);
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
            this.c1SplitterPanel1.Controls.Add(this.TXT_TOTALAMT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_TAXRATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_OPERDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_AUDITDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AUDITOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_OPERATOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_SUPCODE);
            this.c1SplitterPanel1.Controls.Add(this.COMB_POTYPE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_POID);
            this.c1SplitterPanel1.Height = 151;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(881, 130);
            this.c1SplitterPanel1.SizeRatio = 26.678D;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(40, 74);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(608, 45);
            this.TXT_REMARK.TabIndex = 21;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_POID
            // 
            this.TXT_POID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_POID.Caption = "采购订单号";
            this.TXT_POID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_POID.Location = new System.Drawing.Point(455, 16);
            this.TXT_POID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_POID.Multiline = false;
            this.TXT_POID.Name = "TXT_POID";
            this.TXT_POID.ReadOnly = true;
            this.TXT_POID.Size = new System.Drawing.Size(193, 21);
            this.TXT_POID.TabIndex = 22;
            this.TXT_POID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(553, 45);
            this.TXT_STATUS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STATUS.Multiline = false;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.ReadOnly = true;
            this.TXT_STATUS.Size = new System.Drawing.Size(95, 21);
            this.TXT_STATUS.TabIndex = 23;
            this.TXT_STATUS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // COMB_POTYPE
            // 
            this.COMB_POTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_POTYPE.Caption = "订单类型";
            this.COMB_POTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_POTYPE.Columns")));
            this.COMB_POTYPE.Data = "订单采购:1,存量采购:2";
            this.COMB_POTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_POTYPE.Location = new System.Drawing.Point(40, 44);
            this.COMB_POTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_POTYPE.Name = "COMB_POTYPE";
            this.COMB_POTYPE.ReadOnly = false;
            this.COMB_POTYPE.Size = new System.Drawing.Size(169, 22);
            this.COMB_POTYPE.TabIndex = 24;
            this.COMB_POTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // DROP_SUPCODE
            // 
            this.DROP_SUPCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SUPCODE.Caption = "供应商";
            this.DROP_SUPCODE.CustomerDropDownForm = null;
            this.DROP_SUPCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SUPCODE.Location = new System.Drawing.Point(40, 16);
            this.DROP_SUPCODE.Logic = null;
            this.DROP_SUPCODE.Name = "DROP_SUPCODE";
            this.DROP_SUPCODE.ReadOnly = false;
            this.DROP_SUPCODE.Size = new System.Drawing.Size(244, 21);
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
            this.DROP_OPERATOR.Location = new System.Drawing.Point(677, 16);
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
            this.DROP_AUDITOR.Location = new System.Drawing.Point(677, 71);
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
            this.DATE_AUDITDATE.Location = new System.Drawing.Point(677, 98);
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
            this.DATE_OPERDATE.Location = new System.Drawing.Point(677, 43);
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
            this.TXT_TAXRATE.Location = new System.Drawing.Point(306, 16);
            this.TXT_TAXRATE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_TAXRATE.Multiline = false;
            this.TXT_TAXRATE.Name = "TXT_TAXRATE";
            this.TXT_TAXRATE.ReadOnly = false;
            this.TXT_TAXRATE.Size = new System.Drawing.Size(125, 21);
            this.TXT_TAXRATE.TabIndex = 30;
            this.TXT_TAXRATE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_TOTALAMT
            // 
            this.TXT_TOTALAMT.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_TOTALAMT.Caption = "合计金额";
            this.TXT_TOTALAMT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_TOTALAMT.Location = new System.Drawing.Point(306, 45);
            this.TXT_TOTALAMT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_TOTALAMT.Multiline = false;
            this.TXT_TOTALAMT.Name = "TXT_TOTALAMT";
            this.TXT_TOTALAMT.ReadOnly = true;
            this.TXT_TOTALAMT.Size = new System.Drawing.Size(198, 21);
            this.TXT_TOTALAMT.TabIndex = 31;
            this.TXT_TOTALAMT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_PORDEREDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 594);
            this.Name = "SM_PORDEREDIT";
            this.Text = "SM_PORDEREDIT";
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_REMARK;
        private Controls.GText TXT_POID;
        private Controls.GText TXT_STATUS;
        private Controls.GCombo COMB_POTYPE;
        private Controls.GDropDown DROP_SUPCODE;
        private Controls.GDropDown DROP_OPERATOR;
        private Controls.GDropDown DROP_AUDITOR;
        private Controls.GDate DATE_OPERDATE;
        private Controls.GDate DATE_AUDITDATE;
        private Controls.GText TXT_TOTALAMT;
        private Controls.GText TXT_TAXRATE;
    }
}