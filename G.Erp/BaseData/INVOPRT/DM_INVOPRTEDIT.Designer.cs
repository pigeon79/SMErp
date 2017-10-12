namespace G.Erp.BaseData
{
    partial class DM_INVOPRTEDIT
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
            this.TXT_INVTDESC = new G.Controls.GText();
            this.TXT_INVTRNCDE = new G.Controls.GText();
            this.CHECK_ONISSUE = new G.Controls.Input.GCheckBox();
            this.CHECK_ONREV = new G.Controls.Input.GCheckBox();
            this.CHECK_ONADJUST = new G.Controls.Input.GCheckBox();
            this.CHECK_ONSHOPA = new G.Controls.Input.GCheckBox();
            this.CHECK_ISPONO = new G.Controls.Input.GCheckBox();
            this.CHECK_ISORDERNO = new G.Controls.Input.GCheckBox();
            this.CHECK_ONSALEQTY = new G.Controls.Input.GCheckBox();
            this.CHECK_ONORDERA = new G.Controls.Input.GCheckBox();
            this.CHECK_ISHMERP = new G.Controls.Input.GCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(546, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(546, 417);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ISHMERP);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ISPONO);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ISORDERNO);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ONSALEQTY);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ONORDERA);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ONSHOPA);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ONADJUST);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ONREV);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ONISSUE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_INVTDESC);
            this.c1SplitterPanel1.Controls.Add(this.TXT_INVTRNCDE);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(546, 396);
            // 
            // TXT_INVTDESC
            // 
            this.TXT_INVTDESC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_INVTDESC.Caption = "库存事务名称";
            this.TXT_INVTDESC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_INVTDESC.Location = new System.Drawing.Point(91, 61);
            this.TXT_INVTDESC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_INVTDESC.Multiline = false;
            this.TXT_INVTDESC.Name = "TXT_INVTDESC";
            this.TXT_INVTDESC.ReadOnly = false;
            this.TXT_INVTDESC.Size = new System.Drawing.Size(245, 24);
            this.TXT_INVTDESC.TabIndex = 2;
            this.TXT_INVTDESC.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_INVTRNCDE
            // 
            this.TXT_INVTRNCDE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_INVTRNCDE.Caption = "库存事务代码";
            this.TXT_INVTRNCDE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_INVTRNCDE.Location = new System.Drawing.Point(91, 28);
            this.TXT_INVTRNCDE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_INVTRNCDE.Multiline = false;
            this.TXT_INVTRNCDE.Name = "TXT_INVTRNCDE";
            this.TXT_INVTRNCDE.ReadOnly = false;
            this.TXT_INVTRNCDE.Size = new System.Drawing.Size(245, 24);
            this.TXT_INVTRNCDE.TabIndex = 1;
            this.TXT_INVTRNCDE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // CHECK_ONISSUE
            // 
            this.CHECK_ONISSUE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ONISSUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ONISSUE.Caption = "是否影响发出";
            this.CHECK_ONISSUE.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ONISSUE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ONISSUE.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ONISSUE.Location = new System.Drawing.Point(91, 103);
            this.CHECK_ONISSUE.Name = "CHECK_ONISSUE";
            this.CHECK_ONISSUE.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ONISSUE.ReadOnly = false;
            this.CHECK_ONISSUE.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ONISSUE.TabIndex = 3;
            this.CHECK_ONISSUE.Text = "是否影响发出";
            this.CHECK_ONISSUE.UseVisualStyleBackColor = false;
            this.CHECK_ONISSUE.Value = null;
            // 
            // CHECK_ONREV
            // 
            this.CHECK_ONREV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ONREV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ONREV.Caption = "是否影响收入";
            this.CHECK_ONREV.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ONREV.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ONREV.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ONREV.Location = new System.Drawing.Point(91, 133);
            this.CHECK_ONREV.Name = "CHECK_ONREV";
            this.CHECK_ONREV.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ONREV.ReadOnly = false;
            this.CHECK_ONREV.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ONREV.TabIndex = 4;
            this.CHECK_ONREV.Text = "是否影响收入";
            this.CHECK_ONREV.UseVisualStyleBackColor = false;
            this.CHECK_ONREV.Value = null;
            // 
            // CHECK_ONADJUST
            // 
            this.CHECK_ONADJUST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ONADJUST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ONADJUST.Caption = "是否影响调整";
            this.CHECK_ONADJUST.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ONADJUST.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ONADJUST.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ONADJUST.Location = new System.Drawing.Point(91, 163);
            this.CHECK_ONADJUST.Name = "CHECK_ONADJUST";
            this.CHECK_ONADJUST.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ONADJUST.ReadOnly = false;
            this.CHECK_ONADJUST.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ONADJUST.TabIndex = 5;
            this.CHECK_ONADJUST.Text = "是否影响调整";
            this.CHECK_ONADJUST.UseVisualStyleBackColor = false;
            this.CHECK_ONADJUST.Value = null;
            // 
            // CHECK_ONSHOPA
            // 
            this.CHECK_ONSHOPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ONSHOPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ONSHOPA.Caption = "是否参与车间分配";
            this.CHECK_ONSHOPA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ONSHOPA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ONSHOPA.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ONSHOPA.Location = new System.Drawing.Point(91, 193);
            this.CHECK_ONSHOPA.Name = "CHECK_ONSHOPA";
            this.CHECK_ONSHOPA.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ONSHOPA.ReadOnly = false;
            this.CHECK_ONSHOPA.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ONSHOPA.TabIndex = 6;
            this.CHECK_ONSHOPA.Text = "是否参与车间分配";
            this.CHECK_ONSHOPA.UseVisualStyleBackColor = false;
            this.CHECK_ONSHOPA.Value = null;
            // 
            // CHECK_ISPONO
            // 
            this.CHECK_ISPONO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ISPONO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ISPONO.Caption = "是否记录采购订单号";
            this.CHECK_ISPONO.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ISPONO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ISPONO.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ISPONO.Location = new System.Drawing.Point(91, 313);
            this.CHECK_ISPONO.Name = "CHECK_ISPONO";
            this.CHECK_ISPONO.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ISPONO.ReadOnly = false;
            this.CHECK_ISPONO.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ISPONO.TabIndex = 10;
            this.CHECK_ISPONO.Text = "是否记录采购订单号";
            this.CHECK_ISPONO.UseVisualStyleBackColor = false;
            this.CHECK_ISPONO.Value = null;
            // 
            // CHECK_ISORDERNO
            // 
            this.CHECK_ISORDERNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ISORDERNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ISORDERNO.Caption = "是否记录订单号";
            this.CHECK_ISORDERNO.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ISORDERNO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ISORDERNO.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ISORDERNO.Location = new System.Drawing.Point(91, 283);
            this.CHECK_ISORDERNO.Name = "CHECK_ISORDERNO";
            this.CHECK_ISORDERNO.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ISORDERNO.ReadOnly = false;
            this.CHECK_ISORDERNO.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ISORDERNO.TabIndex = 9;
            this.CHECK_ISORDERNO.Text = "是否记录订单号";
            this.CHECK_ISORDERNO.UseVisualStyleBackColor = false;
            this.CHECK_ISORDERNO.Value = null;
            // 
            // CHECK_ONSALEQTY
            // 
            this.CHECK_ONSALEQTY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ONSALEQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ONSALEQTY.Caption = "是否计算销售量";
            this.CHECK_ONSALEQTY.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ONSALEQTY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ONSALEQTY.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ONSALEQTY.Location = new System.Drawing.Point(91, 253);
            this.CHECK_ONSALEQTY.Name = "CHECK_ONSALEQTY";
            this.CHECK_ONSALEQTY.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ONSALEQTY.ReadOnly = false;
            this.CHECK_ONSALEQTY.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ONSALEQTY.TabIndex = 8;
            this.CHECK_ONSALEQTY.Text = "是否计算销售量";
            this.CHECK_ONSALEQTY.UseVisualStyleBackColor = false;
            this.CHECK_ONSALEQTY.Value = null;
            // 
            // CHECK_ONORDERA
            // 
            this.CHECK_ONORDERA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ONORDERA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ONORDERA.Caption = "是否订单分配";
            this.CHECK_ONORDERA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ONORDERA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ONORDERA.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ONORDERA.Location = new System.Drawing.Point(91, 223);
            this.CHECK_ONORDERA.Name = "CHECK_ONORDERA";
            this.CHECK_ONORDERA.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ONORDERA.ReadOnly = false;
            this.CHECK_ONORDERA.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ONORDERA.TabIndex = 7;
            this.CHECK_ONORDERA.Text = "是否订单分配";
            this.CHECK_ONORDERA.UseVisualStyleBackColor = false;
            this.CHECK_ONORDERA.Value = null;
            // 
            // CHECK_ISHMERP
            // 
            this.CHECK_ISHMERP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ISHMERP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ISHMERP.Caption = "是否参与MRP运算";
            this.CHECK_ISHMERP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHECK_ISHMERP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ISHMERP.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ISHMERP.Location = new System.Drawing.Point(91, 343);
            this.CHECK_ISHMERP.Name = "CHECK_ISHMERP";
            this.CHECK_ISHMERP.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ISHMERP.ReadOnly = false;
            this.CHECK_ISHMERP.Size = new System.Drawing.Size(245, 24);
            this.CHECK_ISHMERP.TabIndex = 11;
            this.CHECK_ISHMERP.Text = "是否参与MRP运算";
            this.CHECK_ISHMERP.UseVisualStyleBackColor = false;
            this.CHECK_ISHMERP.Value = null;
            // 
            // DM_INVOPRTEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 441);
            this.Name = "DM_INVOPRTEDIT";
            this.Text = "DM_INVOPRTEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_INVTDESC;
        private Controls.GText TXT_INVTRNCDE;
        private Controls.Input.GCheckBox CHECK_ISHMERP;
        private Controls.Input.GCheckBox CHECK_ISPONO;
        private Controls.Input.GCheckBox CHECK_ISORDERNO;
        private Controls.Input.GCheckBox CHECK_ONSALEQTY;
        private Controls.Input.GCheckBox CHECK_ONORDERA;
        private Controls.Input.GCheckBox CHECK_ONSHOPA;
        private Controls.Input.GCheckBox CHECK_ONADJUST;
        private Controls.Input.GCheckBox CHECK_ONREV;
        private Controls.Input.GCheckBox CHECK_ONISSUE;
    }
}