namespace G.Erp.Assist
{
    partial class SM_ASSISTMENTRYEDIT
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
            this.DROP_CHECKEDPER = new G.Controls.GDropDown();
            this.DATE_ASSISTMEDATE = new G.Controls.GDate();
            this.TXT_MEMO = new G.Controls.GText();
            this.TXT_SUPPNAME = new G.Controls.GText();
            this.TXT_ASSISTMECODE = new G.Controls.GText();
            this.DROP_ASSISTMSCODE = new G.Controls.GDropDown();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGrid1
            // 
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(881, 417);
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
            this.c1SplitterPanel1.Controls.Add(this.DROP_ASSISTMSCODE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_ASSISTMECODE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_MEMO);
            this.c1SplitterPanel1.Controls.Add(this.DATE_ASSISTMEDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_CHECKEDPER);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SUPPNAME);
            this.c1SplitterPanel1.Controls.Add(this.DATE_OPERDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_AUDITDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AUDITOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_OPERATOR);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Height = 149;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(881, 128);
            this.c1SplitterPanel1.SizeRatio = 26.325D;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(585, 16);
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
            this.DROP_OPERATOR.Location = new System.Drawing.Point(678, 16);
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
            // DROP_CHECKEDPER
            // 
            this.DROP_CHECKEDPER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_CHECKEDPER.Caption = "验收员";
            this.DROP_CHECKEDPER.CustomerDropDownForm = null;
            this.DROP_CHECKEDPER.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_CHECKEDPER.IsText = false;
            this.DROP_CHECKEDPER.Location = new System.Drawing.Point(284, 45);
            this.DROP_CHECKEDPER.Logic = null;
            this.DROP_CHECKEDPER.Name = "DROP_CHECKEDPER";
            this.DROP_CHECKEDPER.ReadOnly = false;
            this.DROP_CHECKEDPER.Size = new System.Drawing.Size(145, 21);
            this.DROP_CHECKEDPER.TabIndex = 39;
            this.DROP_CHECKEDPER.TextField = "USERNAME";
            this.DROP_CHECKEDPER.Value = "0";
            this.DROP_CHECKEDPER.ValueField = "USERDM";
            this.DROP_CHECKEDPER.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DATE_ASSISTMEDATE
            // 
            this.DATE_ASSISTMEDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_ASSISTMEDATE.Caption = "外协入库日期";
            this.DATE_ASSISTMEDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_ASSISTMEDATE.Location = new System.Drawing.Point(40, 45);
            this.DATE_ASSISTMEDATE.Name = "DATE_ASSISTMEDATE";
            this.DATE_ASSISTMEDATE.ReadOnly = true;
            this.DATE_ASSISTMEDATE.Size = new System.Drawing.Size(193, 21);
            this.DATE_ASSISTMEDATE.TabIndex = 40;
            this.DATE_ASSISTMEDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_MEMO
            // 
            this.TXT_MEMO.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_MEMO.Caption = "备注";
            this.TXT_MEMO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_MEMO.Location = new System.Drawing.Point(40, 74);
            this.TXT_MEMO.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_MEMO.Multiline = true;
            this.TXT_MEMO.Name = "TXT_MEMO";
            this.TXT_MEMO.ReadOnly = false;
            this.TXT_MEMO.Size = new System.Drawing.Size(621, 45);
            this.TXT_MEMO.TabIndex = 44;
            this.TXT_MEMO.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SUPPNAME
            // 
            this.TXT_SUPPNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SUPPNAME.Caption = " 外协加工单位";
            this.TXT_SUPPNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SUPPNAME.Location = new System.Drawing.Point(248, 16);
            this.TXT_SUPPNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SUPPNAME.Multiline = false;
            this.TXT_SUPPNAME.Name = "TXT_SUPPNAME";
            this.TXT_SUPPNAME.ReadOnly = true;
            this.TXT_SUPPNAME.Size = new System.Drawing.Size(322, 21);
            this.TXT_SUPPNAME.TabIndex = 38;
            this.TXT_SUPPNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ASSISTMECODE
            // 
            this.TXT_ASSISTMECODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ASSISTMECODE.Caption = "外协入库单号";
            this.TXT_ASSISTMECODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ASSISTMECODE.Location = new System.Drawing.Point(468, 45);
            this.TXT_ASSISTMECODE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ASSISTMECODE.Multiline = false;
            this.TXT_ASSISTMECODE.Name = "TXT_ASSISTMECODE";
            this.TXT_ASSISTMECODE.ReadOnly = true;
            this.TXT_ASSISTMECODE.Size = new System.Drawing.Size(193, 21);
            this.TXT_ASSISTMECODE.TabIndex = 47;
            this.TXT_ASSISTMECODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_ASSISTMSCODE
            // 
            this.DROP_ASSISTMSCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ASSISTMSCODE.Caption = "外协领料单号";
            this.DROP_ASSISTMSCODE.CustomerDropDownForm = null;
            this.DROP_ASSISTMSCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ASSISTMSCODE.IsText = false;
            this.DROP_ASSISTMSCODE.Location = new System.Drawing.Point(40, 16);
            this.DROP_ASSISTMSCODE.Logic = null;
            this.DROP_ASSISTMSCODE.Name = "DROP_ASSISTMSCODE";
            this.DROP_ASSISTMSCODE.ReadOnly = false;
            this.DROP_ASSISTMSCODE.Size = new System.Drawing.Size(198, 21);
            this.DROP_ASSISTMSCODE.TabIndex = 48;
            this.DROP_ASSISTMSCODE.TextField = "USERNAME";
            this.DROP_ASSISTMSCODE.Value = "0";
            this.DROP_ASSISTMSCODE.ValueField = "USERDM";
            this.DROP_ASSISTMSCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.DROP_ASSISTMSCODE.RowSelect += new System.EventHandler<G.Interface.Event.DataRowEvent>(this.DROP_ASSISTMSCODE_RowSelect);
            // 
            // SM_ASSISTMENTRYEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 594);
            this.Name = "SM_ASSISTMENTRYEDIT";
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
        private Controls.GDropDown DROP_CHECKEDPER;
        private Controls.GDate DATE_ASSISTMEDATE;
        private Controls.GText TXT_MEMO;
        private Controls.GText TXT_SUPPNAME;
        private Controls.GText TXT_ASSISTMECODE;
        private Controls.GDropDown DROP_ASSISTMSCODE;
    }
}