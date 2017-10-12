namespace G.Erp.Storage
{
    partial class SM_SHOPSUPPLYEDIT
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
            this.TXT_SUPPLYID = new G.Controls.GText();
            this.TXT_STATUS = new G.Controls.GText();
            this.DROP_WORKSHOP = new G.Controls.GDropDown();
            this.DROP_OPERATOR = new G.Controls.GDropDown();
            this.DROP_AUDITOR = new G.Controls.GDropDown();
            this.DATE_AUDITDATE = new G.Controls.GDate();
            this.DATE_OPERDATE = new G.Controls.GDate();
            this.TXT_REMARK = new G.Controls.GText();
            this.DATE_APPLYDATE = new G.Controls.GDate();
            this.DROP_APPLYER = new G.Controls.GDropDown();
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
            this.c1SplitterPanel1.Controls.Add(this.DATE_APPLYDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_APPLYER);
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.DATE_OPERDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_AUDITDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AUDITOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_OPERATOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_WORKSHOP);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUPPLYID);
            this.c1SplitterPanel1.Height = 151;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(881, 130);
            this.c1SplitterPanel1.SizeRatio = 26.678D;
            // 
            // TXT_SUPPLYID
            // 
            this.TXT_SUPPLYID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUPPLYID.Caption = "领料单号";
            this.TXT_SUPPLYID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUPPLYID.Location = new System.Drawing.Point(492, 44);
            this.TXT_SUPPLYID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUPPLYID.Multiline = false;
            this.TXT_SUPPLYID.Name = "TXT_SUPPLYID";
            this.TXT_SUPPLYID.ReadOnly = true;
            this.TXT_SUPPLYID.Size = new System.Drawing.Size(163, 21);
            this.TXT_SUPPLYID.TabIndex = 22;
            this.TXT_SUPPLYID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
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
            // DROP_WORKSHOP
            // 
            this.DROP_WORKSHOP.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_WORKSHOP.Caption = "领料部门";
            this.DROP_WORKSHOP.CustomerDropDownForm = null;
            this.DROP_WORKSHOP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_WORKSHOP.Location = new System.Drawing.Point(237, 16);
            this.DROP_WORKSHOP.Logic = null;
            this.DROP_WORKSHOP.Name = "DROP_WORKSHOP";
            this.DROP_WORKSHOP.ReadOnly = false;
            this.DROP_WORKSHOP.Size = new System.Drawing.Size(193, 21);
            this.DROP_WORKSHOP.TabIndex = 3;
            this.DROP_WORKSHOP.TextField = "";
            this.DROP_WORKSHOP.Value = "0";
            this.DROP_WORKSHOP.ValueField = "";
            this.DROP_WORKSHOP.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
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
            this.DROP_AUDITOR.Location = new System.Drawing.Point(678, 72);
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
            this.DATE_AUDITDATE.Location = new System.Drawing.Point(678, 99);
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
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(40, 75);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(615, 45);
            this.TXT_REMARK.TabIndex = 4;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DATE_APPLYDATE
            // 
            this.DATE_APPLYDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_APPLYDATE.Caption = "申请日期";
            this.DATE_APPLYDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_APPLYDATE.Location = new System.Drawing.Point(40, 44);
            this.DATE_APPLYDATE.Name = "DATE_APPLYDATE";
            this.DATE_APPLYDATE.ReadOnly = false;
            this.DATE_APPLYDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_APPLYDATE.TabIndex = 2;
            this.DATE_APPLYDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_APPLYER
            // 
            this.DROP_APPLYER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_APPLYER.Caption = "申请人";
            this.DROP_APPLYER.CustomerDropDownForm = null;
            this.DROP_APPLYER.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_APPLYER.Location = new System.Drawing.Point(40, 17);
            this.DROP_APPLYER.Logic = null;
            this.DROP_APPLYER.Name = "DROP_APPLYER";
            this.DROP_APPLYER.ReadOnly = false;
            this.DROP_APPLYER.Size = new System.Drawing.Size(163, 21);
            this.DROP_APPLYER.TabIndex = 1;
            this.DROP_APPLYER.TextField = "USERNAME";
            this.DROP_APPLYER.Value = "0";
            this.DROP_APPLYER.ValueField = "USERDM";
            this.DROP_APPLYER.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_SHOPSUPPLYEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 594);
            this.Name = "SM_SHOPSUPPLYEDIT";
            this.Text = "SM_SHOPSUPPLYEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_SUPPLYID;
        private Controls.GText TXT_STATUS;
        private Controls.GDropDown DROP_WORKSHOP;
        private Controls.GDropDown DROP_OPERATOR;
        private Controls.GDropDown DROP_AUDITOR;
        private Controls.GDate DATE_OPERDATE;
        private Controls.GDate DATE_AUDITDATE;
        private Controls.GText TXT_REMARK;
        private Controls.GDate DATE_APPLYDATE;
        private Controls.GDropDown DROP_APPLYER;
    }
}