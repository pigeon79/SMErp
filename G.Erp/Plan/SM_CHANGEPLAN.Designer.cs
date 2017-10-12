namespace G.Erp.Plan
{
    partial class SM_CHANGEPLAN
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
            this.btn_clearBom = new C1.Win.C1Input.C1Button();
            this.TXT_INOFC = new G.Controls.GText();
            this.TXT_ORDERTYPE = new G.Controls.GText();
            this.TXT_ORDERDATE = new G.Controls.GText();
            this.TXT_SALESREP = new G.Controls.GText();
            this.TXT_SALESMAN = new G.Controls.GText();
            this.TXT_ORDQTY = new G.Controls.GText();
            this.TXT_ORDERID = new G.Controls.GText();
            this.TXT_CUSTLEV = new G.Controls.GText();
            this.TXT_CUSTID = new G.Controls.GText();
            this.TXT_CUSTORDNB = new G.Controls.GText();
            this.SuspendLayout();
            // 
            // btn_clearBom
            // 
            this.btn_clearBom.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clearBom.Location = new System.Drawing.Point(22, 158);
            this.btn_clearBom.Name = "btn_clearBom";
            this.btn_clearBom.Size = new System.Drawing.Size(116, 49);
            this.btn_clearBom.TabIndex = 2;
            this.btn_clearBom.Text = "销售订单重置";
            this.btn_clearBom.UseVisualStyleBackColor = true;
            this.btn_clearBom.Click += new System.EventHandler(this.btn_clearBom_Click);
            // 
            // TXT_INOFC
            // 
            this.TXT_INOFC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_INOFC.Caption = "内勤";
            this.TXT_INOFC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_INOFC.Location = new System.Drawing.Point(674, 85);
            this.TXT_INOFC.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_INOFC.Multiline = false;
            this.TXT_INOFC.Name = "TXT_INOFC";
            this.TXT_INOFC.ReadOnly = true;
            this.TXT_INOFC.Size = new System.Drawing.Size(118, 21);
            this.TXT_INOFC.TabIndex = 35;
            this.TXT_INOFC.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERTYPE
            // 
            this.TXT_ORDERTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERTYPE.Caption = "订单类型";
            this.TXT_ORDERTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERTYPE.Location = new System.Drawing.Point(527, 56);
            this.TXT_ORDERTYPE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERTYPE.Multiline = false;
            this.TXT_ORDERTYPE.Name = "TXT_ORDERTYPE";
            this.TXT_ORDERTYPE.ReadOnly = true;
            this.TXT_ORDERTYPE.Size = new System.Drawing.Size(132, 21);
            this.TXT_ORDERTYPE.TabIndex = 35;
            this.TXT_ORDERTYPE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERDATE
            // 
            this.TXT_ORDERDATE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERDATE.Caption = "订单日期";
            this.TXT_ORDERDATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERDATE.Location = new System.Drawing.Point(370, 56);
            this.TXT_ORDERDATE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERDATE.Multiline = false;
            this.TXT_ORDERDATE.Name = "TXT_ORDERDATE";
            this.TXT_ORDERDATE.ReadOnly = true;
            this.TXT_ORDERDATE.Size = new System.Drawing.Size(149, 21);
            this.TXT_ORDERDATE.TabIndex = 35;
            this.TXT_ORDERDATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SALESREP
            // 
            this.TXT_SALESREP.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SALESREP.Caption = "销售代表";
            this.TXT_SALESREP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SALESREP.Location = new System.Drawing.Point(519, 85);
            this.TXT_SALESREP.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SALESREP.Multiline = false;
            this.TXT_SALESREP.Name = "TXT_SALESREP";
            this.TXT_SALESREP.ReadOnly = true;
            this.TXT_SALESREP.Size = new System.Drawing.Size(140, 21);
            this.TXT_SALESREP.TabIndex = 35;
            this.TXT_SALESREP.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SALESMAN
            // 
            this.TXT_SALESMAN.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SALESMAN.Caption = "销售员";
            this.TXT_SALESMAN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SALESMAN.Location = new System.Drawing.Point(360, 85);
            this.TXT_SALESMAN.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SALESMAN.Multiline = false;
            this.TXT_SALESMAN.Name = "TXT_SALESMAN";
            this.TXT_SALESMAN.ReadOnly = true;
            this.TXT_SALESMAN.Size = new System.Drawing.Size(140, 21);
            this.TXT_SALESMAN.TabIndex = 35;
            this.TXT_SALESMAN.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDQTY
            // 
            this.TXT_ORDQTY.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_ORDQTY.Caption = "总数量";
            this.TXT_ORDQTY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDQTY.Location = new System.Drawing.Point(674, 56);
            this.TXT_ORDQTY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDQTY.Multiline = false;
            this.TXT_ORDQTY.Name = "TXT_ORDQTY";
            this.TXT_ORDQTY.ReadOnly = true;
            this.TXT_ORDQTY.Size = new System.Drawing.Size(118, 21);
            this.TXT_ORDQTY.TabIndex = 25;
            this.TXT_ORDQTY.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORDERID
            // 
            this.TXT_ORDERID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORDERID.Caption = "销售订单号";
            this.TXT_ORDERID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORDERID.Location = new System.Drawing.Point(22, 13);
            this.TXT_ORDERID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ORDERID.Multiline = false;
            this.TXT_ORDERID.Name = "TXT_ORDERID";
            this.TXT_ORDERID.ReadOnly = false;
            this.TXT_ORDERID.Size = new System.Drawing.Size(180, 21);
            this.TXT_ORDERID.TabIndex = 26;
            this.TXT_ORDERID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.TXT_ORDERID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_ORDERID_KeyPress);
            // 
            // TXT_CUSTLEV
            // 
            this.TXT_CUSTLEV.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTLEV.Caption = "客户等级";
            this.TXT_CUSTLEV.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTLEV.Location = new System.Drawing.Point(183, 85);
            this.TXT_CUSTLEV.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CUSTLEV.Multiline = false;
            this.TXT_CUSTLEV.Name = "TXT_CUSTLEV";
            this.TXT_CUSTLEV.ReadOnly = true;
            this.TXT_CUSTLEV.Size = new System.Drawing.Size(110, 21);
            this.TXT_CUSTLEV.TabIndex = 30;
            this.TXT_CUSTLEV.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CUSTID
            // 
            this.TXT_CUSTID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTID.Caption = "下单客户";
            this.TXT_CUSTID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTID.Location = new System.Drawing.Point(22, 56);
            this.TXT_CUSTID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CUSTID.Multiline = false;
            this.TXT_CUSTID.Name = "TXT_CUSTID";
            this.TXT_CUSTID.ReadOnly = true;
            this.TXT_CUSTID.Size = new System.Drawing.Size(329, 21);
            this.TXT_CUSTID.TabIndex = 31;
            this.TXT_CUSTID.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_CUSTORDNB
            // 
            this.TXT_CUSTORDNB.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_CUSTORDNB.Caption = "合同号";
            this.TXT_CUSTORDNB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CUSTORDNB.Location = new System.Drawing.Point(22, 85);
            this.TXT_CUSTORDNB.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CUSTORDNB.Multiline = false;
            this.TXT_CUSTORDNB.Name = "TXT_CUSTORDNB";
            this.TXT_CUSTORDNB.ReadOnly = true;
            this.TXT_CUSTORDNB.Size = new System.Drawing.Size(140, 21);
            this.TXT_CUSTORDNB.TabIndex = 31;
            this.TXT_CUSTORDNB.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // SM_CHANGEPLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 453);
            this.Controls.Add(this.TXT_INOFC);
            this.Controls.Add(this.TXT_ORDERTYPE);
            this.Controls.Add(this.TXT_ORDERDATE);
            this.Controls.Add(this.TXT_SALESREP);
            this.Controls.Add(this.TXT_SALESMAN);
            this.Controls.Add(this.TXT_ORDQTY);
            this.Controls.Add(this.TXT_ORDERID);
            this.Controls.Add(this.TXT_CUSTLEV);
            this.Controls.Add(this.TXT_CUSTID);
            this.Controls.Add(this.TXT_CUSTORDNB);
            this.Controls.Add(this.btn_clearBom);
            this.Name = "SM_CHANGEPLAN";
            this.Text = "订单变更后计划处理";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1Button btn_clearBom;
        private Controls.GText TXT_ORDQTY;
        private Controls.GText TXT_ORDERID;
        private Controls.GText TXT_CUSTLEV;
        private Controls.GText TXT_CUSTORDNB;
        private Controls.GText TXT_CUSTID;
        private Controls.GText TXT_SALESMAN;
        private Controls.GText TXT_SALESREP;
        private Controls.GText TXT_INOFC;
        private Controls.GText TXT_ORDERDATE;
        private Controls.GText TXT_ORDERTYPE;
    }
}