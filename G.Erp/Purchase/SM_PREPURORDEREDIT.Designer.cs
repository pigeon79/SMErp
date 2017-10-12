namespace G.Erp.Purchase
{
    partial class SM_PREPURORDEREDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SM_PREPURORDEREDIT));
            this.TXT_PREPURORDID = new G.Controls.GText();
            this.TXT_INVUNIT = new G.Controls.GText();
            this.TXT_REMARK = new G.Controls.GText();
            this.TXT_ORDERID = new G.Controls.GText();
            this.DROP_SUPCODE = new G.Controls.GDropDown();
            this.DROP_ITEMCODE = new G.Controls.GDropDown();
            this.DATE_APPLYDATE = new G.Controls.GDate();
            this.DROP_APPLYUSER = new G.Controls.GDropDown();
            this.TXT_STATUS = new G.Controls.GText();
            this.NUM_ORDLNNO = new G.Controls.GNumText();
            this.DROP_DEPCODE = new G.Controls.GDropDown();
            this.DATE_DEMANDDATE = new G.Controls.GDate();
            this.NUM_PREPURQTY = new G.Controls.GNumText();
            this.DROP_PURUSER = new G.Controls.GDropDown();
            this.COMB_PURTYPE = new G.Controls.GCombo();
            this.NUM_ATTRIBUTEC = new G.Controls.GNumText();
            this.DROP_ATTRIBUTEA = new G.Controls.GDropDown();
            this.DROP_ATTRIBUTEB = new G.Controls.GDropDown();
            this.DROP_OPERATOR = new G.Controls.GDropDown();
            this.DROP_AUDITOR = new G.Controls.GDropDown();
            this.DATE_AUDITDATE = new G.Controls.GDate();
            this.NUM_SUPPRICE = new G.Controls.GNumText();
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
            this.c1SplitterPanel1.Controls.Add(this.NUM_SUPPRICE);
            this.c1SplitterPanel1.Controls.Add(this.COMB_PURTYPE);
            this.c1SplitterPanel1.Controls.Add(this.NUM_ATTRIBUTEC);
            this.c1SplitterPanel1.Controls.Add(this.NUM_PREPURQTY);
            this.c1SplitterPanel1.Controls.Add(this.NUM_ORDLNNO);
            this.c1SplitterPanel1.Controls.Add(this.DROP_PURUSER);
            this.c1SplitterPanel1.Controls.Add(this.DROP_AUDITOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_OPERATOR);
            this.c1SplitterPanel1.Controls.Add(this.DROP_APPLYUSER);
            this.c1SplitterPanel1.Controls.Add(this.DATE_DEMANDDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_AUDITDATE);
            this.c1SplitterPanel1.Controls.Add(this.DATE_APPLYDATE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_PREPURORDID);
            this.c1SplitterPanel1.Controls.Add(this.TXT_INVUNIT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_REMARK);
            this.c1SplitterPanel1.Controls.Add(this.TXT_STATUS);
            this.c1SplitterPanel1.Controls.Add(this.TXT_ORDERID);
            this.c1SplitterPanel1.Controls.Add(this.DROP_SUPCODE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_DEPCODE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ATTRIBUTEB);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ATTRIBUTEA);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ITEMCODE);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(737, 418);
            // 
            // TXT_PREPURORDID
            // 
            this.TXT_PREPURORDID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PREPURORDID.Caption = "请购单号";
            this.TXT_PREPURORDID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_PREPURORDID.Location = new System.Drawing.Point(38, 13);
            this.TXT_PREPURORDID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PREPURORDID.Multiline = false;
            this.TXT_PREPURORDID.Name = "TXT_PREPURORDID";
            this.TXT_PREPURORDID.ReadOnly = true;
            this.TXT_PREPURORDID.Size = new System.Drawing.Size(183, 21);
            this.TXT_PREPURORDID.TabIndex = 16;
            this.TXT_PREPURORDID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_INVUNIT
            // 
            this.TXT_INVUNIT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_INVUNIT.Caption = "单位";
            this.TXT_INVUNIT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_INVUNIT.Location = new System.Drawing.Point(245, 81);
            this.TXT_INVUNIT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_INVUNIT.Multiline = false;
            this.TXT_INVUNIT.Name = "TXT_INVUNIT";
            this.TXT_INVUNIT.ReadOnly = true;
            this.TXT_INVUNIT.Size = new System.Drawing.Size(75, 21);
            this.TXT_INVUNIT.TabIndex = 18;
            this.TXT_INVUNIT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_REMARK
            // 
            this.TXT_REMARK.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_REMARK.Caption = "备注";
            this.TXT_REMARK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_REMARK.Location = new System.Drawing.Point(37, 190);
            this.TXT_REMARK.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REMARK.Multiline = true;
            this.TXT_REMARK.Name = "TXT_REMARK";
            this.TXT_REMARK.ReadOnly = false;
            this.TXT_REMARK.Size = new System.Drawing.Size(657, 92);
            this.TXT_REMARK.TabIndex = 19;
            this.TXT_REMARK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_ORDERID
            // 
            this.TXT_ORDERID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERID.Caption = "销售订单号";
            this.TXT_ORDERID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERID.Location = new System.Drawing.Point(23, 48);
            this.TXT_ORDERID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERID.Multiline = false;
            this.TXT_ORDERID.Name = "TXT_ORDERID";
            this.TXT_ORDERID.ReadOnly = false;
            this.TXT_ORDERID.Size = new System.Drawing.Size(198, 21);
            this.TXT_ORDERID.TabIndex = 20;
            this.TXT_ORDERID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_SUPCODE
            // 
            this.DROP_SUPCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SUPCODE.Caption = "供应商";
            this.DROP_SUPCODE.CustomerDropDownForm = null;
            this.DROP_SUPCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SUPCODE.Location = new System.Drawing.Point(23, 118);
            this.DROP_SUPCODE.Logic = null;
            this.DROP_SUPCODE.Name = "DROP_SUPCODE";
            this.DROP_SUPCODE.ReadOnly = true;
            this.DROP_SUPCODE.Size = new System.Drawing.Size(198, 21);
            this.DROP_SUPCODE.TabIndex = 11;
            this.DROP_SUPCODE.TextField = "";
            this.DROP_SUPCODE.Value = "0";
            this.DROP_SUPCODE.ValueField = "";
            this.DROP_SUPCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_ITEMCODE
            // 
            this.DROP_ITEMCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ITEMCODE.Caption = "物品";
            this.DROP_ITEMCODE.CustomerDropDownForm = null;
            this.DROP_ITEMCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ITEMCODE.Location = new System.Drawing.Point(23, 81);
            this.DROP_ITEMCODE.Logic = null;
            this.DROP_ITEMCODE.Name = "DROP_ITEMCODE";
            this.DROP_ITEMCODE.ReadOnly = false;
            this.DROP_ITEMCODE.Size = new System.Drawing.Size(198, 21);
            this.DROP_ITEMCODE.TabIndex = 14;
            this.DROP_ITEMCODE.TextField = "";
            this.DROP_ITEMCODE.Value = "0";
            this.DROP_ITEMCODE.ValueField = "";
            this.DROP_ITEMCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.DROP_ITEMCODE.RowSelect += new System.EventHandler<G.Interface.Event.DataRowEvent>(this.DROP_ITEMCODE_RowSelect);
            // 
            // DATE_APPLYDATE
            // 
            this.DATE_APPLYDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_APPLYDATE.Caption = "申请日期";
            this.DATE_APPLYDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_APPLYDATE.Location = new System.Drawing.Point(245, 13);
            this.DATE_APPLYDATE.Name = "DATE_APPLYDATE";
            this.DATE_APPLYDATE.ReadOnly = true;
            this.DATE_APPLYDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_APPLYDATE.TabIndex = 22;
            this.DATE_APPLYDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_APPLYUSER
            // 
            this.DROP_APPLYUSER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_APPLYUSER.Caption = "申请人";
            this.DROP_APPLYUSER.CustomerDropDownForm = null;
            this.DROP_APPLYUSER.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_APPLYUSER.Location = new System.Drawing.Point(436, 13);
            this.DROP_APPLYUSER.Logic = null;
            this.DROP_APPLYUSER.Name = "DROP_APPLYUSER";
            this.DROP_APPLYUSER.ReadOnly = false;
            this.DROP_APPLYUSER.Size = new System.Drawing.Size(138, 21);
            this.DROP_APPLYUSER.TabIndex = 23;
            this.DROP_APPLYUSER.TextField = "USERNAME";
            this.DROP_APPLYUSER.Value = "0";
            this.DROP_APPLYUSER.ValueField = "USERDM";
            this.DROP_APPLYUSER.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_STATUS.Caption = "状态";
            this.TXT_STATUS.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_STATUS.Location = new System.Drawing.Point(614, 13);
            this.TXT_STATUS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STATUS.Multiline = false;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.ReadOnly = true;
            this.TXT_STATUS.Size = new System.Drawing.Size(80, 21);
            this.TXT_STATUS.TabIndex = 20;
            this.TXT_STATUS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_ORDLNNO
            // 
            this.NUM_ORDLNNO.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_ORDLNNO.Caption = "行号";
            this.NUM_ORDLNNO.DataType = "Int32";
            this.NUM_ORDLNNO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_ORDLNNO.Location = new System.Drawing.Point(245, 48);
            this.NUM_ORDLNNO.Name = "NUM_ORDLNNO";
            this.NUM_ORDLNNO.ReadOnly = false;
            this.NUM_ORDLNNO.Size = new System.Drawing.Size(75, 21);
            this.NUM_ORDLNNO.TabIndex = 24;
            this.NUM_ORDLNNO.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_DEPCODE
            // 
            this.DROP_DEPCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_DEPCODE.Caption = "需求部门";
            this.DROP_DEPCODE.CustomerDropDownForm = null;
            this.DROP_DEPCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_DEPCODE.Location = new System.Drawing.Point(326, 48);
            this.DROP_DEPCODE.Logic = null;
            this.DROP_DEPCODE.Name = "DROP_DEPCODE";
            this.DROP_DEPCODE.ReadOnly = false;
            this.DROP_DEPCODE.Size = new System.Drawing.Size(199, 21);
            this.DROP_DEPCODE.TabIndex = 14;
            this.DROP_DEPCODE.TextField = "";
            this.DROP_DEPCODE.Value = "0";
            this.DROP_DEPCODE.ValueField = "";
            this.DROP_DEPCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DATE_DEMANDDATE
            // 
            this.DATE_DEMANDDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DATE_DEMANDDATE.Caption = "需求日期";
            this.DATE_DEMANDDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DATE_DEMANDDATE.Location = new System.Drawing.Point(531, 48);
            this.DATE_DEMANDDATE.Name = "DATE_DEMANDDATE";
            this.DATE_DEMANDDATE.ReadOnly = false;
            this.DATE_DEMANDDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_DEMANDDATE.TabIndex = 22;
            this.DATE_DEMANDDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_PREPURQTY
            // 
            this.NUM_PREPURQTY.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_PREPURQTY.Caption = "请购数";
            this.NUM_PREPURQTY.DataType = "Decimal";
            this.NUM_PREPURQTY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_PREPURQTY.Location = new System.Drawing.Point(344, 81);
            this.NUM_PREPURQTY.Name = "NUM_PREPURQTY";
            this.NUM_PREPURQTY.ReadOnly = false;
            this.NUM_PREPURQTY.Size = new System.Drawing.Size(129, 21);
            this.NUM_PREPURQTY.TabIndex = 24;
            this.NUM_PREPURQTY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_PURUSER
            // 
            this.DROP_PURUSER.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_PURUSER.Caption = "采购员";
            this.DROP_PURUSER.CustomerDropDownForm = null;
            this.DROP_PURUSER.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_PURUSER.Location = new System.Drawing.Point(23, 154);
            this.DROP_PURUSER.Logic = null;
            this.DROP_PURUSER.Name = "DROP_PURUSER";
            this.DROP_PURUSER.ReadOnly = false;
            this.DROP_PURUSER.Size = new System.Drawing.Size(138, 21);
            this.DROP_PURUSER.TabIndex = 23;
            this.DROP_PURUSER.TextField = "USERNAME";
            this.DROP_PURUSER.Value = "0";
            this.DROP_PURUSER.ValueField = "USERDM";
            this.DROP_PURUSER.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // COMB_PURTYPE
            // 
            this.COMB_PURTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.COMB_PURTYPE.Caption = "采购类别";
            this.COMB_PURTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("COMB_PURTYPE.Columns")));
            this.COMB_PURTYPE.Data = "订单采购:1,存量采购:2";
            this.COMB_PURTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMB_PURTYPE.Location = new System.Drawing.Point(233, 154);
            this.COMB_PURTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_PURTYPE.Name = "COMB_PURTYPE";
            this.COMB_PURTYPE.ReadOnly = false;
            this.COMB_PURTYPE.Size = new System.Drawing.Size(136, 22);
            this.COMB_PURTYPE.TabIndex = 25;
            this.COMB_PURTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // NUM_ATTRIBUTEC
            // 
            this.NUM_ATTRIBUTEC.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_ATTRIBUTEC.Caption = "尺寸";
            this.NUM_ATTRIBUTEC.DataType = "Decimal";
            this.NUM_ATTRIBUTEC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_ATTRIBUTEC.Location = new System.Drawing.Point(496, 154);
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
            this.DROP_ATTRIBUTEA.Location = new System.Drawing.Point(496, 81);
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
            this.DROP_ATTRIBUTEB.Location = new System.Drawing.Point(496, 116);
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
            // DROP_OPERATOR
            // 
            this.DROP_OPERATOR.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_OPERATOR.Caption = "制单人";
            this.DROP_OPERATOR.CustomerDropDownForm = null;
            this.DROP_OPERATOR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_OPERATOR.Location = new System.Drawing.Point(38, 338);
            this.DROP_OPERATOR.Logic = null;
            this.DROP_OPERATOR.Name = "DROP_OPERATOR";
            this.DROP_OPERATOR.ReadOnly = true;
            this.DROP_OPERATOR.Size = new System.Drawing.Size(138, 21);
            this.DROP_OPERATOR.TabIndex = 23;
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
            this.DROP_AUDITOR.Location = new System.Drawing.Point(295, 338);
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
            this.DATE_AUDITDATE.Location = new System.Drawing.Point(531, 338);
            this.DATE_AUDITDATE.Name = "DATE_AUDITDATE";
            this.DATE_AUDITDATE.ReadOnly = true;
            this.DATE_AUDITDATE.Size = new System.Drawing.Size(163, 21);
            this.DATE_AUDITDATE.TabIndex = 22;
            this.DATE_AUDITDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_SUPPRICE
            // 
            this.NUM_SUPPRICE.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_SUPPRICE.Caption = "供应商单价";
            this.NUM_SUPPRICE.DataType = "Decimal";
            this.NUM_SUPPRICE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_SUPPRICE.Location = new System.Drawing.Point(245, 116);
            this.NUM_SUPPRICE.Name = "NUM_SUPPRICE";
            this.NUM_SUPPRICE.ReadOnly = true;
            this.NUM_SUPPRICE.Size = new System.Drawing.Size(188, 21);
            this.NUM_SUPPRICE.TabIndex = 26;
            this.NUM_SUPPRICE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_PREPURORDEREDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 463);
            this.Name = "SM_PREPURORDEREDIT";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_PREPURORDID;
        private Controls.GText TXT_INVUNIT;
        private Controls.GText TXT_REMARK;
        private Controls.GText TXT_ORDERID;
        private Controls.GDropDown DROP_SUPCODE;
        private Controls.GDropDown DROP_ITEMCODE;
        private Controls.GDate DATE_APPLYDATE;
        private Controls.GDropDown DROP_APPLYUSER;
        private Controls.GText TXT_STATUS;
        private Controls.GNumText NUM_ORDLNNO;
        private Controls.GDropDown DROP_DEPCODE;
        private Controls.GDate DATE_DEMANDDATE;
        private Controls.GNumText NUM_PREPURQTY;
        private Controls.GDropDown DROP_PURUSER;
        private Controls.GCombo COMB_PURTYPE;
        private Controls.GNumText NUM_ATTRIBUTEC;
        private Controls.GDropDown DROP_ATTRIBUTEB;
        private Controls.GDropDown DROP_ATTRIBUTEA;
        private Controls.GDropDown DROP_AUDITOR;
        private Controls.GDropDown DROP_OPERATOR;
        private Controls.GDate DATE_AUDITDATE;
        private Controls.GNumText NUM_SUPPRICE;

    }
}