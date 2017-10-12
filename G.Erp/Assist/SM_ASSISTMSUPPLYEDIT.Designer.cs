namespace G.Erp.Assist
{
    partial class SM_ASSISTMSUPPLYEDIT
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
            this.DATE_ASSISTMSDATE = new G.Controls.GDate();
            this.TXT_ASSISTMSCODE = new G.Controls.GText();
            this.TXT_ORDERID = new G.Controls.GText();
            this.DROP_PURUSER = new G.Controls.GDropDown();
            this.DATE_ADELIVERYDATE = new G.Controls.GDate();
            this.TXT_SALESMANNAME = new G.Controls.GText();
            this.TXT_SALESREPNAME = new G.Controls.GText();
            this.TXT_MEMO = new G.Controls.GText();
            this.DROP_ASUPCODE = new G.Controls.GDropDown();
            this.DROP_ACUSTID = new G.Controls.GDropDown();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGrid1
            // 
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(881, 412);
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
            this.c1SplitterPanel1.Controls.Add(this.DROP_ACUSTID);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ASUPCODE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_MEMO);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SALESREPNAME);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SALESMANNAME);
            this.c1SplitterPanel1.Controls.Add(this.DATE_ADELIVERYDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_PURUSER);
            this.c1SplitterPanel1.Controls.Add(this.TXT_ORDERID);
            this.c1SplitterPanel1.Controls.Add(this.TXT_ASSISTMSCODE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_ASSISTMSDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_OPERDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_AUDITDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AUDITOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_OPERATOR);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Height = 154;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(881, 133);
            this.c1SplitterPanel1.SizeRatio = 27.208D;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(588, 16);
            this.TXT_STATUS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STATUS.Multiline = false;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.ReadOnly = true;
            this.TXT_STATUS.Size = new System.Drawing.Size(76, 21);
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
            this.DROP_OPERATOR.Location = new System.Drawing.Point(675, 16);
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
            this.DROP_AUDITOR.Location = new System.Drawing.Point(678, 71);
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
            this.DATE_AUDITDATE.Location = new System.Drawing.Point(678, 98);
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
            this.DATE_OPERDATE.Location = new System.Drawing.Point(678, 45);
            this.DATE_OPERDATE.Name = "DATE_OPERDATE";
            this.DATE_OPERDATE.ReadOnly = true;
            this.DATE_OPERDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_OPERDATE.TabIndex = 29;
            this.DATE_OPERDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DATE_ASSISTMSDATE
            // 
            this.DATE_ASSISTMSDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_ASSISTMSDATE.Caption = "领料日期";
            this.DATE_ASSISTMSDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_ASSISTMSDATE.Location = new System.Drawing.Point(416, 16);
            this.DATE_ASSISTMSDATE.Name = "DATE_ASSISTMSDATE";
            this.DATE_ASSISTMSDATE.ReadOnly = true;
            this.DATE_ASSISTMSDATE.Size = new System.Drawing.Size(161, 21);
            this.DATE_ASSISTMSDATE.TabIndex = 33;
            this.DATE_ASSISTMSDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ASSISTMSCODE
            // 
            this.TXT_ASSISTMSCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ASSISTMSCODE.Caption = "外协领料单号";
            this.TXT_ASSISTMSCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ASSISTMSCODE.Location = new System.Drawing.Point(40, 16);
            this.TXT_ASSISTMSCODE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ASSISTMSCODE.Multiline = false;
            this.TXT_ASSISTMSCODE.Name = "TXT_ASSISTMSCODE";
            this.TXT_ASSISTMSCODE.ReadOnly = true;
            this.TXT_ASSISTMSCODE.Size = new System.Drawing.Size(193, 21);
            this.TXT_ASSISTMSCODE.TabIndex = 37;
            this.TXT_ASSISTMSCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERID
            // 
            this.TXT_ORDERID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERID.Caption = "销售单号";
            this.TXT_ORDERID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERID.Location = new System.Drawing.Point(244, 16);
            this.TXT_ORDERID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERID.Multiline = false;
            this.TXT_ORDERID.Name = "TXT_ORDERID";
            this.TXT_ORDERID.ReadOnly = true;
            this.TXT_ORDERID.Size = new System.Drawing.Size(161, 21);
            this.TXT_ORDERID.TabIndex = 38;
            this.TXT_ORDERID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_PURUSER
            // 
            this.DROP_PURUSER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_PURUSER.Caption = "采购员";
            this.DROP_PURUSER.CustomerDropDownForm = null;
            this.DROP_PURUSER.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_PURUSER.IsText = false;
            this.DROP_PURUSER.Location = new System.Drawing.Point(360, 45);
            this.DROP_PURUSER.Logic = null;
            this.DROP_PURUSER.Name = "DROP_PURUSER";
            this.DROP_PURUSER.ReadOnly = false;
            this.DROP_PURUSER.Size = new System.Drawing.Size(145, 21);
            this.DROP_PURUSER.TabIndex = 39;
            this.DROP_PURUSER.TextField = "USERNAME";
            this.DROP_PURUSER.Value = "0";
            this.DROP_PURUSER.ValueField = "USERDM";
            this.DROP_PURUSER.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DATE_ADELIVERYDATE
            // 
            this.DATE_ADELIVERYDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_ADELIVERYDATE.Caption = "外协交期";
            this.DATE_ADELIVERYDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_ADELIVERYDATE.Location = new System.Drawing.Point(511, 45);
            this.DATE_ADELIVERYDATE.Name = "DATE_ADELIVERYDATE";
            this.DATE_ADELIVERYDATE.ReadOnly = false;
            this.DATE_ADELIVERYDATE.Size = new System.Drawing.Size(161, 21);
            this.DATE_ADELIVERYDATE.TabIndex = 40;
            this.DATE_ADELIVERYDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SALESMANNAME
            // 
            this.TXT_SALESMANNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SALESMANNAME.Caption = "销售员";
            this.TXT_SALESMANNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SALESMANNAME.Location = new System.Drawing.Point(361, 71);
            this.TXT_SALESMANNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SALESMANNAME.Multiline = false;
            this.TXT_SALESMANNAME.Name = "TXT_SALESMANNAME";
            this.TXT_SALESMANNAME.ReadOnly = true;
            this.TXT_SALESMANNAME.Size = new System.Drawing.Size(144, 21);
            this.TXT_SALESMANNAME.TabIndex = 42;
            this.TXT_SALESMANNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SALESREPNAME
            // 
            this.TXT_SALESREPNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SALESREPNAME.Caption = "销售代表";
            this.TXT_SALESREPNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SALESREPNAME.Location = new System.Drawing.Point(513, 71);
            this.TXT_SALESREPNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SALESREPNAME.Multiline = false;
            this.TXT_SALESREPNAME.Name = "TXT_SALESREPNAME";
            this.TXT_SALESREPNAME.ReadOnly = true;
            this.TXT_SALESREPNAME.Size = new System.Drawing.Size(159, 21);
            this.TXT_SALESREPNAME.TabIndex = 43;
            this.TXT_SALESREPNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_MEMO
            // 
            this.TXT_MEMO.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_MEMO.Caption = "备注";
            this.TXT_MEMO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_MEMO.Location = new System.Drawing.Point(40, 99);
            this.TXT_MEMO.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_MEMO.Multiline = false;
            this.TXT_MEMO.Name = "TXT_MEMO";
            this.TXT_MEMO.ReadOnly = false;
            this.TXT_MEMO.Size = new System.Drawing.Size(632, 21);
            this.TXT_MEMO.TabIndex = 44;
            this.TXT_MEMO.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_ASUPCODE
            // 
            this.DROP_ASUPCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ASUPCODE.Caption = "外协加工单位";
            this.DROP_ASUPCODE.CustomerDropDownForm = null;
            this.DROP_ASUPCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ASUPCODE.IsText = false;
            this.DROP_ASUPCODE.Location = new System.Drawing.Point(40, 44);
            this.DROP_ASUPCODE.Logic = null;
            this.DROP_ASUPCODE.Name = "DROP_ASUPCODE";
            this.DROP_ASUPCODE.ReadOnly = false;
            this.DROP_ASUPCODE.Size = new System.Drawing.Size(314, 21);
            this.DROP_ASUPCODE.TabIndex = 45;
            this.DROP_ASUPCODE.TextField = "";
            this.DROP_ASUPCODE.Value = "0";
            this.DROP_ASUPCODE.ValueField = "";
            this.DROP_ASUPCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_ACUSTID
            // 
            this.DROP_ACUSTID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ACUSTID.Caption = "客户单位";
            this.DROP_ACUSTID.CustomerDropDownForm = null;
            this.DROP_ACUSTID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ACUSTID.IsText = false;
            this.DROP_ACUSTID.Location = new System.Drawing.Point(40, 71);
            this.DROP_ACUSTID.Logic = null;
            this.DROP_ACUSTID.Name = "DROP_ACUSTID";
            this.DROP_ACUSTID.ReadOnly = false;
            this.DROP_ACUSTID.Size = new System.Drawing.Size(314, 21);
            this.DROP_ACUSTID.TabIndex = 46;
            this.DROP_ACUSTID.TextField = "";
            this.DROP_ACUSTID.Value = "0";
            this.DROP_ACUSTID.ValueField = "";
            this.DROP_ACUSTID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.DROP_ACUSTID.RowSelect += new System.EventHandler<G.Interface.Event.DataRowEvent>(this.DROP_ACUSTCODE_RowSelect);
            // 
            // SM_ASSISTMSUPPLYEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 594);
            this.Name = "SM_ASSISTMSUPPLYEDIT";
            this.Text = "SM_ASSISTMSUPPLYEDIT";
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
        private Controls.GDate DATE_ASSISTMSDATE;
        private Controls.GText TXT_ORDERID;
        private Controls.GText TXT_ASSISTMSCODE;
        private Controls.GDropDown DROP_PURUSER;
        private Controls.GDate DATE_ADELIVERYDATE;
        private Controls.GText TXT_SALESREPNAME;
        private Controls.GText TXT_SALESMANNAME;
        private Controls.GText TXT_MEMO;
        private Controls.GDropDown DROP_ACUSTID;
        private Controls.GDropDown DROP_ASUPCODE;
    }
}