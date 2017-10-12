namespace G.Erp.Shop
{
    partial class SM_SHOPINEDIT
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
            this.TXT_SHOPINID = new G.Controls.GText();
            this.TXT_INVUNIT = new G.Controls.GText();
            this.TXT_REMARK = new G.Controls.GText();
            this.DROP_ITEMCODE = new G.Controls.GDropDown();
            this.TXT_STATUS = new G.Controls.GText();
            this.NUM_ATTRIBUTEC = new G.Controls.GNumText();
            this.DROP_ATTRIBUTEA = new G.Controls.GDropDown();
            this.DROP_ATTRIBUTEB = new G.Controls.GDropDown();
            this.DROP_AUDITOR = new G.Controls.GDropDown();
            this.DATE_AUDITDATE = new G.Controls.GDate();
            this.TXT_INQTY = new G.Controls.GText();
            this.TXT_RATE = new G.Controls.GText();
            this.TXT_WEIGHT = new G.Controls.GText();
            this.DROP_WORKSHOP = new G.Controls.GDropDown();
            this.DROP_WRHSCODE = new G.Controls.GDropDown();
            this.DROP_LOCCODE = new G.Controls.GDropDown();
            this.DATE_FINISHDATE = new G.Controls.GDate();
            this.TXT_SHOPORDERID = new G.Controls.GText();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(737, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(737, 439);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.TXT_SHOPORDERID);
            this.c1SplitterPanel1.Controls.Add(this.DATE_FINISHDATE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_LOCCODE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_WRHSCODE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_WORKSHOP);
            this.c1SplitterPanel1.Controls.Add(this.TXT_WEIGHT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_RATE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_INQTY);
            this.c1SplitterPanel1.Controls.Add(this.NUM_ATTRIBUTEC);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AUDITOR);
            this.c1SplitterPanel1.Controls.Add(this.DATE_AUDITDATE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_SHOPINID);
            this.c1SplitterPanel1.Controls.Add(this.TXT_INVUNIT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ATTRIBUTEB);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ATTRIBUTEA);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ITEMCODE);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(737, 418);
            // 
            // TXT_SHOPINID
            // 
            this.TXT_SHOPINID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SHOPINID.Caption = "完工入库单号";
            this.TXT_SHOPINID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SHOPINID.Location = new System.Drawing.Point(380, 20);
            this.TXT_SHOPINID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SHOPINID.Multiline = false;
            this.TXT_SHOPINID.Name = "TXT_SHOPINID";
            this.TXT_SHOPINID.ReadOnly = true;
            this.TXT_SHOPINID.Size = new System.Drawing.Size(200, 21);
            this.TXT_SHOPINID.TabIndex = 16;
            this.TXT_SHOPINID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_INVUNIT
            // 
            this.TXT_INVUNIT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_INVUNIT.Caption = "单位";
            this.TXT_INVUNIT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_INVUNIT.Location = new System.Drawing.Point(268, 20);
            this.TXT_INVUNIT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_INVUNIT.Multiline = false;
            this.TXT_INVUNIT.Name = "TXT_INVUNIT";
            this.TXT_INVUNIT.ReadOnly = true;
            this.TXT_INVUNIT.Size = new System.Drawing.Size(80, 21);
            this.TXT_INVUNIT.TabIndex = 18;
            this.TXT_INVUNIT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(38, 232);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(657, 92);
            this.TXT_REMARK.TabIndex = 19;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_ITEMCODE
            // 
            this.DROP_ITEMCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ITEMCODE.Caption = "物品";
            this.DROP_ITEMCODE.CustomerDropDownForm = null;
            this.DROP_ITEMCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ITEMCODE.IsText = false;
            this.DROP_ITEMCODE.Location = new System.Drawing.Point(38, 20);
            this.DROP_ITEMCODE.Logic = null;
            this.DROP_ITEMCODE.Name = "DROP_ITEMCODE";
            this.DROP_ITEMCODE.ReadOnly = false;
            this.DROP_ITEMCODE.Size = new System.Drawing.Size(198, 21);
            this.DROP_ITEMCODE.TabIndex = 14;
            this.DROP_ITEMCODE.TextField = "";
            this.DROP_ITEMCODE.Value = "0";
            this.DROP_ITEMCODE.ValueField = "";
            this.DROP_ITEMCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
           // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(612, 20);
            this.TXT_STATUS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STATUS.Multiline = false;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.ReadOnly = true;
            this.TXT_STATUS.Size = new System.Drawing.Size(80, 21);
            this.TXT_STATUS.TabIndex = 20;
            this.TXT_STATUS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_ATTRIBUTEC
            // 
            this.NUM_ATTRIBUTEC.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_ATTRIBUTEC.Caption = "尺寸";
            this.NUM_ATTRIBUTEC.DataType = "Decimal";
            this.NUM_ATTRIBUTEC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_ATTRIBUTEC.Location = new System.Drawing.Point(38, 152);
            this.NUM_ATTRIBUTEC.Name = "NUM_ATTRIBUTEC";
            this.NUM_ATTRIBUTEC.ReadOnly = false;
            this.NUM_ATTRIBUTEC.Size = new System.Drawing.Size(115, 21);
            this.NUM_ATTRIBUTEC.TabIndex = 24;
            this.NUM_ATTRIBUTEC.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_ATTRIBUTEA
            // 
            this.DROP_ATTRIBUTEA.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ATTRIBUTEA.Caption = "色号";
            this.DROP_ATTRIBUTEA.CustomerDropDownForm = null;
            this.DROP_ATTRIBUTEA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ATTRIBUTEA.IsText = false;
            this.DROP_ATTRIBUTEA.Location = new System.Drawing.Point(38, 64);
            this.DROP_ATTRIBUTEA.Logic = null;
            this.DROP_ATTRIBUTEA.Name = "DROP_ATTRIBUTEA";
            this.DROP_ATTRIBUTEA.ReadOnly = false;
            this.DROP_ATTRIBUTEA.Size = new System.Drawing.Size(198, 21);
            this.DROP_ATTRIBUTEA.TabIndex = 14;
            this.DROP_ATTRIBUTEA.TextField = "";
            this.DROP_ATTRIBUTEA.Value = "0";
            this.DROP_ATTRIBUTEA.ValueField = "";
            this.DROP_ATTRIBUTEA.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_ATTRIBUTEB
            // 
            this.DROP_ATTRIBUTEB.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ATTRIBUTEB.Caption = "花模";
            this.DROP_ATTRIBUTEB.CustomerDropDownForm = null;
            this.DROP_ATTRIBUTEB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ATTRIBUTEB.IsText = false;
            this.DROP_ATTRIBUTEB.Location = new System.Drawing.Point(38, 108);
            this.DROP_ATTRIBUTEB.Logic = null;
            this.DROP_ATTRIBUTEB.Name = "DROP_ATTRIBUTEB";
            this.DROP_ATTRIBUTEB.ReadOnly = false;
            this.DROP_ATTRIBUTEB.Size = new System.Drawing.Size(198, 21);
            this.DROP_ATTRIBUTEB.TabIndex = 14;
            this.DROP_ATTRIBUTEB.TextField = "";
            this.DROP_ATTRIBUTEB.Value = "0";
            this.DROP_ATTRIBUTEB.ValueField = "";
            this.DROP_ATTRIBUTEB.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_AUDITOR
            // 
            this.DROP_AUDITOR.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_AUDITOR.Caption = "审核人";
            this.DROP_AUDITOR.CustomerDropDownForm = null;
            this.DROP_AUDITOR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_AUDITOR.IsText = false;
            this.DROP_AUDITOR.Location = new System.Drawing.Point(295, 346);
            this.DROP_AUDITOR.Logic = null;
            this.DROP_AUDITOR.Name = "DROP_AUDITOR";
            this.DROP_AUDITOR.ReadOnly = true;
            this.DROP_AUDITOR.Size = new System.Drawing.Size(138, 21);
            this.DROP_AUDITOR.TabIndex = 23;
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
            this.DATE_AUDITDATE.Location = new System.Drawing.Point(531, 346);
            this.DATE_AUDITDATE.Name = "DATE_AUDITDATE";
            this.DATE_AUDITDATE.ReadOnly = true;
            this.DATE_AUDITDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_AUDITDATE.TabIndex = 22;
            this.DATE_AUDITDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_INQTY
            // 
            this.TXT_INQTY.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_INQTY.Caption = "入库数量";
            this.TXT_INQTY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_INQTY.Location = new System.Drawing.Point(38, 193);
            this.TXT_INQTY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_INQTY.Multiline = false;
            this.TXT_INQTY.Name = "TXT_INQTY";
            this.TXT_INQTY.ReadOnly = false;
            this.TXT_INQTY.Size = new System.Drawing.Size(139, 21);
            this.TXT_INQTY.TabIndex = 26;
            this.TXT_INQTY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_RATE
            // 
            this.TXT_RATE.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_RATE.Caption = "折率";
            this.TXT_RATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_RATE.Location = new System.Drawing.Point(430, 193);
            this.TXT_RATE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_RATE.Multiline = false;
            this.TXT_RATE.Name = "TXT_RATE";
            this.TXT_RATE.ReadOnly = false;
            this.TXT_RATE.Size = new System.Drawing.Size(80, 21);
            this.TXT_RATE.TabIndex = 27;
            this.TXT_RATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_WEIGHT
            // 
            this.TXT_WEIGHT.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_WEIGHT.Caption = "公斤数";
            this.TXT_WEIGHT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_WEIGHT.Location = new System.Drawing.Point(243, 193);
            this.TXT_WEIGHT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_WEIGHT.Multiline = false;
            this.TXT_WEIGHT.Name = "TXT_WEIGHT";
            this.TXT_WEIGHT.ReadOnly = false;
            this.TXT_WEIGHT.Size = new System.Drawing.Size(121, 21);
            this.TXT_WEIGHT.TabIndex = 28;
            this.TXT_WEIGHT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_WORKSHOP
            // 
            this.DROP_WORKSHOP.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_WORKSHOP.Caption = "车间";
            this.DROP_WORKSHOP.CustomerDropDownForm = null;
            this.DROP_WORKSHOP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_WORKSHOP.IsText = false;
            this.DROP_WORKSHOP.Location = new System.Drawing.Point(284, 64);
            this.DROP_WORKSHOP.Logic = null;
            this.DROP_WORKSHOP.Name = "DROP_WORKSHOP";
            this.DROP_WORKSHOP.ReadOnly = false;
            this.DROP_WORKSHOP.Size = new System.Drawing.Size(180, 21);
            this.DROP_WORKSHOP.TabIndex = 29;
            this.DROP_WORKSHOP.TextField = "";
            this.DROP_WORKSHOP.Value = "0";
            this.DROP_WORKSHOP.ValueField = "";
            this.DROP_WORKSHOP.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_WRHSCODE
            // 
            this.DROP_WRHSCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_WRHSCODE.Caption = "仓库";
            this.DROP_WRHSCODE.CustomerDropDownForm = null;
            this.DROP_WRHSCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_WRHSCODE.IsText = false;
            this.DROP_WRHSCODE.Location = new System.Drawing.Point(284, 108);
            this.DROP_WRHSCODE.Logic = null;
            this.DROP_WRHSCODE.Name = "DROP_WRHSCODE";
            this.DROP_WRHSCODE.ReadOnly = false;
            this.DROP_WRHSCODE.Size = new System.Drawing.Size(180, 21);
            this.DROP_WRHSCODE.TabIndex = 30;
            this.DROP_WRHSCODE.TextField = "";
            this.DROP_WRHSCODE.Value = "0";
            this.DROP_WRHSCODE.ValueField = "";
            this.DROP_WRHSCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.DROP_WRHSCODE.ValueChanged += new System.EventHandler(this.DROP_WRHSCODE_ValueChanged);
            // 
            // DROP_LOCCODE
            // 
            this.DROP_LOCCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_LOCCODE.Caption = "库位";
            this.DROP_LOCCODE.CustomerDropDownForm = null;
            this.DROP_LOCCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_LOCCODE.IsText = false;
            this.DROP_LOCCODE.Location = new System.Drawing.Point(284, 152);
            this.DROP_LOCCODE.Logic = null;
            this.DROP_LOCCODE.Name = "DROP_LOCCODE";
            this.DROP_LOCCODE.ReadOnly = false;
            this.DROP_LOCCODE.Size = new System.Drawing.Size(180, 21);
            this.DROP_LOCCODE.TabIndex = 31;
            this.DROP_LOCCODE.TextField = "";
            this.DROP_LOCCODE.Value = "0";
            this.DROP_LOCCODE.ValueField = "";
            this.DROP_LOCCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DATE_FINISHDATE
            // 
            this.DATE_FINISHDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_FINISHDATE.Caption = "完工日期";
            this.DATE_FINISHDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_FINISHDATE.Location = new System.Drawing.Point(529, 108);
            this.DATE_FINISHDATE.Name = "DATE_FINISHDATE";
            this.DATE_FINISHDATE.ReadOnly = true;
            this.DATE_FINISHDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_FINISHDATE.TabIndex = 32;
            this.DATE_FINISHDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SHOPORDERID
            // 
            this.TXT_SHOPORDERID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SHOPORDERID.Caption = "车间订单号";
            this.TXT_SHOPORDERID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SHOPORDERID.Location = new System.Drawing.Point(510, 64);
            this.TXT_SHOPORDERID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SHOPORDERID.Multiline = false;
            this.TXT_SHOPORDERID.Name = "TXT_SHOPORDERID";
            this.TXT_SHOPORDERID.ReadOnly = false;
            this.TXT_SHOPORDERID.Size = new System.Drawing.Size(182, 21);
            this.TXT_SHOPORDERID.TabIndex = 33;
            this.TXT_SHOPORDERID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_SHOPINEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 463);
            this.Name = "SM_SHOPINEDIT";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_SHOPINID;
        private Controls.GText TXT_INVUNIT;
        private Controls.GText TXT_REMARK;
        private Controls.GDropDown DROP_ITEMCODE;
        private Controls.GText TXT_STATUS;
        private Controls.GNumText NUM_ATTRIBUTEC;
        private Controls.GDropDown DROP_ATTRIBUTEB;
        private Controls.GDropDown DROP_ATTRIBUTEA;
        private Controls.GDropDown DROP_AUDITOR;
        private Controls.GDate DATE_AUDITDATE;
        private Controls.GDate DATE_FINISHDATE;
        private Controls.GDropDown DROP_LOCCODE;
        private Controls.GDropDown DROP_WRHSCODE;
        private Controls.GDropDown DROP_WORKSHOP;
        private Controls.GText TXT_WEIGHT;
        private Controls.GText TXT_RATE;
        private Controls.GText TXT_INQTY;
        private Controls.GText TXT_SHOPORDERID;

    }
}