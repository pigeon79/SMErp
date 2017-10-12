namespace G.Erp.Sale.Pocket
{
    partial class SM_POCKETLOOK
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
            this.TXT_POCKID = new G.Controls.GText();
            this.TXT_STATUS = new G.Controls.GText();
            this.DROP_OPERATOR = new G.Controls.GDropDown();
            this.DATE_OPERDATE = new G.Controls.GDate();
            this.DROP_ORDERID = new G.Controls.GDropDown();
            this.DATE_POCKETDATE = new G.Controls.GDate();
            this.DROP_POCKETER = new G.Controls.GDropDown();
            this.TXT_TOTALQTY = new G.Controls.GText();
            this.TXT_BARCODE = new G.Controls.GText();
            this.TXT_REMARK = new G.Controls.GText();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGrid1
            // 
            this.gGrid1.Rows.DefaultSize = 22;
            this.gGrid1.Size = new System.Drawing.Size(881, 414);
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
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BARCODE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_TOTALQTY);
            this.c1SplitterPanel1.Controls.Add(this.DROP_POCKETER);
            this.c1SplitterPanel1.Controls.Add(this.DATE_POCKETDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ORDERID);
            this.c1SplitterPanel1.Controls.Add(this.DATE_OPERDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_OPERATOR);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_POCKID);
            this.c1SplitterPanel1.Height = 152;
            this.c1SplitterPanel1.Size = new System.Drawing.Size(881, 131);
            this.c1SplitterPanel1.SizeRatio = 26.855D;
            // 
            // TXT_POCKID
            // 
            this.TXT_POCKID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_POCKID.Caption = "装箱单号";
            this.TXT_POCKID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_POCKID.Location = new System.Drawing.Point(484, 46);
            this.TXT_POCKID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_POCKID.Multiline = false;
            this.TXT_POCKID.Name = "TXT_POCKID";
            this.TXT_POCKID.ReadOnly = true;
            this.TXT_POCKID.Size = new System.Drawing.Size(163, 21);
            this.TXT_POCKID.TabIndex = 22;
            this.TXT_POCKID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(555, 16);
            this.TXT_STATUS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STATUS.Multiline = false;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.ReadOnly = true;
            this.TXT_STATUS.Size = new System.Drawing.Size(104, 21);
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
            this.DROP_OPERATOR.Location = new System.Drawing.Point(676, 17);
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
            // DATE_OPERDATE
            // 
            this.DATE_OPERDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_OPERDATE.Caption = "制单日期";
            this.DATE_OPERDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_OPERDATE.Location = new System.Drawing.Point(676, 46);
            this.DATE_OPERDATE.Name = "DATE_OPERDATE";
            this.DATE_OPERDATE.ReadOnly = true;
            this.DATE_OPERDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_OPERDATE.TabIndex = 29;
            this.DATE_OPERDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_ORDERID
            // 
            this.DROP_ORDERID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ORDERID.Caption = "销售订单号";
            this.DROP_ORDERID.CustomerDropDownForm = null;
            this.DROP_ORDERID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ORDERID.IsText = false;
            this.DROP_ORDERID.Location = new System.Drawing.Point(40, 16);
            this.DROP_ORDERID.Logic = null;
            this.DROP_ORDERID.Name = "DROP_ORDERID";
            this.DROP_ORDERID.ReadOnly = false;
            this.DROP_ORDERID.Size = new System.Drawing.Size(193, 21);
            this.DROP_ORDERID.TabIndex = 1;
            this.DROP_ORDERID.TextField = "";
            this.DROP_ORDERID.Value = "0";
            this.DROP_ORDERID.ValueField = "";
            this.DROP_ORDERID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DATE_POCKETDATE
            // 
            this.DATE_POCKETDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_POCKETDATE.Caption = "装箱日期";
            this.DATE_POCKETDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_POCKETDATE.Location = new System.Drawing.Point(262, 45);
            this.DATE_POCKETDATE.Name = "DATE_POCKETDATE";
            this.DATE_POCKETDATE.ReadOnly = false;
            this.DATE_POCKETDATE.Size = new System.Drawing.Size(193, 21);
            this.DATE_POCKETDATE.TabIndex = 3;
            this.DATE_POCKETDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_POCKETER
            // 
            this.DROP_POCKETER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_POCKETER.Caption = "装箱人";
            this.DROP_POCKETER.CustomerDropDownForm = null;
            this.DROP_POCKETER.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_POCKETER.IsText = false;
            this.DROP_POCKETER.Location = new System.Drawing.Point(40, 46);
            this.DROP_POCKETER.Logic = null;
            this.DROP_POCKETER.Name = "DROP_POCKETER";
            this.DROP_POCKETER.ReadOnly = false;
            this.DROP_POCKETER.Size = new System.Drawing.Size(193, 21);
            this.DROP_POCKETER.TabIndex = 2;
            this.DROP_POCKETER.TextField = "USERNAME";
            this.DROP_POCKETER.Value = "0";
            this.DROP_POCKETER.ValueField = "USERDM";
            this.DROP_POCKETER.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_TOTALQTY
            // 
            this.TXT_TOTALQTY.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_TOTALQTY.Caption = "总数量";
            this.TXT_TOTALQTY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_TOTALQTY.Location = new System.Drawing.Point(424, 17);
            this.TXT_TOTALQTY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_TOTALQTY.Multiline = false;
            this.TXT_TOTALQTY.Name = "TXT_TOTALQTY";
            this.TXT_TOTALQTY.ReadOnly = true;
            this.TXT_TOTALQTY.Size = new System.Drawing.Size(114, 21);
            this.TXT_TOTALQTY.TabIndex = 35;
            this.TXT_TOTALQTY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_BARCODE
            // 
            this.TXT_BARCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BARCODE.Caption = "条形码";
            this.TXT_BARCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BARCODE.Location = new System.Drawing.Point(250, 16);
            this.TXT_BARCODE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_BARCODE.Multiline = false;
            this.TXT_BARCODE.Name = "TXT_BARCODE";
            this.TXT_BARCODE.ReadOnly = false;
            this.TXT_BARCODE.Size = new System.Drawing.Size(157, 21);
            this.TXT_BARCODE.TabIndex = 36;
            this.TXT_BARCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(40, 76);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(801, 45);
            this.TXT_REMARK.TabIndex = 37;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_POCKETLOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 594);
            this.Name = "SM_POCKETLOOK";
            this.Text = "SM_POCKETLOOK";
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_POCKID;
        private Controls.GText TXT_STATUS;
        private Controls.GDropDown DROP_OPERATOR;
        private Controls.GDate DATE_OPERDATE;
        private Controls.GDropDown DROP_POCKETER;
        private Controls.GDate DATE_POCKETDATE;
        private Controls.GDropDown DROP_ORDERID;
        private Controls.GText TXT_REMARK;
        private Controls.GText TXT_BARCODE;
        private Controls.GText TXT_TOTALQTY;
    }
}