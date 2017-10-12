namespace G.Erp.BaseData
{
    partial class DM_MOULDEDIT
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
            this.TXT_DQNAME = new G.Controls.GText();
            this.TXT_MDCODE = new G.Controls.GText();
            this.NUM_ADDPRICE = new G.Controls.GNumText();
            this.NUM_BASICPRICE = new G.Controls.GNumText();
            this.NUM_WASTING2 = new G.Controls.GNumText();
            this.NUM_WASTING1 = new G.Controls.GNumText();
            this.NUM_WASTING3 = new G.Controls.GNumText();
            this.NUM_WEIGHT = new G.Controls.GNumText();
            this.TXT_BASICCODE = new G.Controls.GText();
            this.NUM_ISIZE = new G.Controls.GNumText();
            this.NUM_MCOUNT = new G.Controls.GNumText();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gToolBar1
            // 
            this.gToolBar1.Size = new System.Drawing.Size(613, 24);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Size = new System.Drawing.Size(613, 259);
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.NUM_MCOUNT);
            this.c1SplitterPanel1.Controls.Add(this.NUM_ISIZE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_BASICCODE);
            this.c1SplitterPanel1.Controls.Add(this.NUM_WASTING3);
            this.c1SplitterPanel1.Controls.Add(this.NUM_WEIGHT);
            this.c1SplitterPanel1.Controls.Add(this.NUM_WASTING2);
            this.c1SplitterPanel1.Controls.Add(this.NUM_WASTING1);
            this.c1SplitterPanel1.Controls.Add(this.NUM_ADDPRICE);
            this.c1SplitterPanel1.Controls.Add(this.NUM_BASICPRICE);
            this.c1SplitterPanel1.Controls.Add(this.TXT_DQNAME);
            this.c1SplitterPanel1.Controls.Add(this.TXT_MDCODE);
            this.c1SplitterPanel1.Size = new System.Drawing.Size(613, 238);
            // 
            // TXT_DQNAME
            // 
            this.TXT_DQNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_DQNAME.Caption = "花模名称";
            this.TXT_DQNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_DQNAME.Location = new System.Drawing.Point(90, 93);
            this.TXT_DQNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_DQNAME.Multiline = false;
            this.TXT_DQNAME.Name = "TXT_DQNAME";
            this.TXT_DQNAME.ReadOnly = false;
            this.TXT_DQNAME.Size = new System.Drawing.Size(203, 24);
            this.TXT_DQNAME.TabIndex = 7;
            this.TXT_DQNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_MDCODE
            // 
            this.TXT_MDCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_MDCODE.Caption = "花模代码";
            this.TXT_MDCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_MDCODE.Location = new System.Drawing.Point(90, 60);
            this.TXT_MDCODE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_MDCODE.Multiline = false;
            this.TXT_MDCODE.Name = "TXT_MDCODE";
            this.TXT_MDCODE.ReadOnly = false;
            this.TXT_MDCODE.Size = new System.Drawing.Size(203, 24);
            this.TXT_MDCODE.TabIndex = 6;
            this.TXT_MDCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_ADDPRICE
            // 
            this.NUM_ADDPRICE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_ADDPRICE.Caption = "其他加价";
            this.NUM_ADDPRICE.DataType = "Decimal";
            this.NUM_ADDPRICE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_ADDPRICE.Location = new System.Drawing.Point(382, 60);
            this.NUM_ADDPRICE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_ADDPRICE.Name = "NUM_ADDPRICE";
            this.NUM_ADDPRICE.ReadOnly = false;
            this.NUM_ADDPRICE.Size = new System.Drawing.Size(149, 24);
            this.NUM_ADDPRICE.TabIndex = 9;
            this.NUM_ADDPRICE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_BASICPRICE
            // 
            this.NUM_BASICPRICE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_BASICPRICE.Caption = "基本价";
            this.NUM_BASICPRICE.DataType = "Decimal";
            this.NUM_BASICPRICE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_BASICPRICE.Location = new System.Drawing.Point(382, 28);
            this.NUM_BASICPRICE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_BASICPRICE.Name = "NUM_BASICPRICE";
            this.NUM_BASICPRICE.ReadOnly = false;
            this.NUM_BASICPRICE.Size = new System.Drawing.Size(149, 24);
            this.NUM_BASICPRICE.TabIndex = 10;
            this.NUM_BASICPRICE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_WASTING2
            // 
            this.NUM_WASTING2.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_WASTING2.Caption = "颜色损耗";
            this.NUM_WASTING2.DataType = "Decimal";
            this.NUM_WASTING2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_WASTING2.Location = new System.Drawing.Point(382, 124);
            this.NUM_WASTING2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_WASTING2.Name = "NUM_WASTING2";
            this.NUM_WASTING2.ReadOnly = false;
            this.NUM_WASTING2.Size = new System.Drawing.Size(149, 24);
            this.NUM_WASTING2.TabIndex = 11;
            this.NUM_WASTING2.Visible = false;
            this.NUM_WASTING2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_WASTING1
            // 
            this.NUM_WASTING1.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_WASTING1.Caption = "全新损耗";
            this.NUM_WASTING1.DataType = "Decimal";
            this.NUM_WASTING1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_WASTING1.Location = new System.Drawing.Point(382, 92);
            this.NUM_WASTING1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_WASTING1.Name = "NUM_WASTING1";
            this.NUM_WASTING1.ReadOnly = false;
            this.NUM_WASTING1.Size = new System.Drawing.Size(149, 24);
            this.NUM_WASTING1.TabIndex = 12;
            this.NUM_WASTING1.Visible = false;
            this.NUM_WASTING1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_WASTING3
            // 
            this.NUM_WASTING3.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_WASTING3.Caption = "黑色损耗";
            this.NUM_WASTING3.DataType = "Decimal";
            this.NUM_WASTING3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_WASTING3.Location = new System.Drawing.Point(382, 156);
            this.NUM_WASTING3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_WASTING3.Name = "NUM_WASTING3";
            this.NUM_WASTING3.ReadOnly = false;
            this.NUM_WASTING3.Size = new System.Drawing.Size(149, 24);
            this.NUM_WASTING3.TabIndex = 13;
            this.NUM_WASTING3.Visible = false;
            this.NUM_WASTING3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_WEIGHT
            // 
            this.NUM_WEIGHT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_WEIGHT.Caption = "克重";
            this.NUM_WEIGHT.DataType = "Decimal";
            this.NUM_WEIGHT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_WEIGHT.Location = new System.Drawing.Point(120, 125);
            this.NUM_WEIGHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_WEIGHT.Name = "NUM_WEIGHT";
            this.NUM_WEIGHT.ReadOnly = false;
            this.NUM_WEIGHT.Size = new System.Drawing.Size(150, 24);
            this.NUM_WEIGHT.TabIndex = 14;
            this.NUM_WEIGHT.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // TXT_BASICCODE
            // 
            this.TXT_BASICCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_BASICCODE.Caption = "基础模代码";
            this.TXT_BASICCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_BASICCODE.Location = new System.Drawing.Point(76, 28);
            this.TXT_BASICCODE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_BASICCODE.Multiline = false;
            this.TXT_BASICCODE.Name = "TXT_BASICCODE";
            this.TXT_BASICCODE.ReadOnly = false;
            this.TXT_BASICCODE.Size = new System.Drawing.Size(226, 24);
            this.TXT_BASICCODE.TabIndex = 15;
            this.TXT_BASICCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_ISIZE
            // 
            this.NUM_ISIZE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_ISIZE.Caption = "规格";
            this.NUM_ISIZE.DataType = "Decimal";
            this.NUM_ISIZE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_ISIZE.Location = new System.Drawing.Point(120, 156);
            this.NUM_ISIZE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_ISIZE.Name = "NUM_ISIZE";
            this.NUM_ISIZE.ReadOnly = false;
            this.NUM_ISIZE.Size = new System.Drawing.Size(150, 24);
            this.NUM_ISIZE.TabIndex = 16;
            this.NUM_ISIZE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_MCOUNT
            // 
            this.NUM_MCOUNT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.NUM_MCOUNT.Caption = "模数";
            this.NUM_MCOUNT.DataType = "Decimal";
            this.NUM_MCOUNT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_MCOUNT.Location = new System.Drawing.Point(120, 188);
            this.NUM_MCOUNT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUM_MCOUNT.Name = "NUM_MCOUNT";
            this.NUM_MCOUNT.ReadOnly = false;
            this.NUM_MCOUNT.Size = new System.Drawing.Size(150, 24);
            this.NUM_MCOUNT.TabIndex = 17;
            this.NUM_MCOUNT.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DM_MOULDEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 283);
            this.Name = "DM_MOULDEDIT";
            this.Text = "DM_AREAEDIT";
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GText TXT_DQNAME;
        private Controls.GText TXT_MDCODE;
        private Controls.GNumText NUM_ADDPRICE;
        private Controls.GNumText NUM_BASICPRICE;
        private Controls.GNumText NUM_WASTING3;
        private Controls.GNumText NUM_WEIGHT;
        private Controls.GNumText NUM_WASTING2;
        private Controls.GNumText NUM_WASTING1;
        private Controls.GNumText NUM_MCOUNT;
        private Controls.GNumText NUM_ISIZE;
        private Controls.GText TXT_BASICCODE;
    }
}