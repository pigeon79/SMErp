namespace G.Erp.BaseData
{
    partial class DM_ITEMESPLITDIT
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lab_title = new System.Windows.Forms.Label();
            this.check_IsD = new G.Controls.Input.GCheckBox();
            this.check_IsC = new G.Controls.Input.GCheckBox();
            this.check_Bmould = new G.Controls.Input.GCheckBox();
            this.check_IsB = new G.Controls.Input.GCheckBox();
            this.check_IsA = new G.Controls.Input.GCheckBox();
            this.txt_ItemCodeD = new G.Controls.GText();
            this.txt_ItemDescD = new G.Controls.GText();
            this.txt_ItemCodeC = new G.Controls.GText();
            this.txt_ItemDescC = new G.Controls.GText();
            this.txt_ItemCodeB = new G.Controls.GText();
            this.txt_ItemDescB = new G.Controls.GText();
            this.txt_ItemCodeA = new G.Controls.GText();
            this.txt_ItemDescA = new G.Controls.GText();
            this.txt_ITEMDESC = new G.Controls.GText();
            this.txt_ITEMCODE = new G.Controls.GText();
            this.gToolBar1 = new G.Controls.GToolBar.GToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.splitContainer1.Panel1.Controls.Add(this.lab_title);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.splitContainer1.Panel2.Controls.Add(this.check_IsD);
            this.splitContainer1.Panel2.Controls.Add(this.check_IsC);
            this.splitContainer1.Panel2.Controls.Add(this.check_Bmould);
            this.splitContainer1.Panel2.Controls.Add(this.check_IsB);
            this.splitContainer1.Panel2.Controls.Add(this.check_IsA);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ItemCodeD);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ItemDescD);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ItemCodeC);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ItemDescC);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ItemCodeB);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ItemDescB);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ItemCodeA);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ItemDescA);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ITEMDESC);
            this.splitContainer1.Panel2.Controls.Add(this.txt_ITEMCODE);
            this.splitContainer1.Size = new System.Drawing.Size(610, 381);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 1;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.Location = new System.Drawing.Point(223, 8);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(59, 20);
            this.lab_title.TabIndex = 2;
            this.lab_title.Text = "title";
            // 
            // check_IsD
            // 
            this.check_IsD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_IsD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_IsD.Caption = "D件";
            this.check_IsD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_IsD.ForeColor = System.Drawing.Color.Black;
            this.check_IsD.Location = new System.Drawing.Point(31, 151);
            this.check_IsD.Name = "check_IsD";
            this.check_IsD.Padding = new System.Windows.Forms.Padding(1);
            this.check_IsD.ReadOnly = false;
            this.check_IsD.Size = new System.Drawing.Size(54, 24);
            this.check_IsD.TabIndex = 7;
            this.check_IsD.Text = "D件";
            this.check_IsD.UseVisualStyleBackColor = false;
            this.check_IsD.Value = null;
            this.check_IsD.CheckedChanged += new System.EventHandler(this.check_IsD_CheckedChanged);
            // 
            // check_IsC
            // 
            this.check_IsC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_IsC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_IsC.Caption = "C件";
            this.check_IsC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_IsC.ForeColor = System.Drawing.Color.Black;
            this.check_IsC.Location = new System.Drawing.Point(31, 119);
            this.check_IsC.Name = "check_IsC";
            this.check_IsC.Padding = new System.Windows.Forms.Padding(1);
            this.check_IsC.ReadOnly = false;
            this.check_IsC.Size = new System.Drawing.Size(54, 24);
            this.check_IsC.TabIndex = 6;
            this.check_IsC.Text = "C件";
            this.check_IsC.UseVisualStyleBackColor = false;
            this.check_IsC.Value = null;
            this.check_IsC.CheckedChanged += new System.EventHandler(this.check_IsC_CheckedChanged);
            // 
            // check_Bmould
            // 
            this.check_Bmould.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_Bmould.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_Bmould.Caption = "B件有花模";
            this.check_Bmould.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_Bmould.ForeColor = System.Drawing.Color.Black;
            this.check_Bmould.Location = new System.Drawing.Point(483, 89);
            this.check_Bmould.Name = "check_Bmould";
            this.check_Bmould.Padding = new System.Windows.Forms.Padding(1);
            this.check_Bmould.ReadOnly = false;
            this.check_Bmould.Size = new System.Drawing.Size(105, 24);
            this.check_Bmould.TabIndex = 5;
            this.check_Bmould.Text = "B件有花模";
            this.check_Bmould.UseVisualStyleBackColor = false;
            this.check_Bmould.Value = null;
            // 
            // check_IsB
            // 
            this.check_IsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_IsB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_IsB.Caption = "B件";
            this.check_IsB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_IsB.ForeColor = System.Drawing.Color.Black;
            this.check_IsB.Location = new System.Drawing.Point(31, 89);
            this.check_IsB.Name = "check_IsB";
            this.check_IsB.Padding = new System.Windows.Forms.Padding(1);
            this.check_IsB.ReadOnly = false;
            this.check_IsB.Size = new System.Drawing.Size(54, 24);
            this.check_IsB.TabIndex = 5;
            this.check_IsB.Text = "B件";
            this.check_IsB.UseVisualStyleBackColor = false;
            this.check_IsB.Value = null;
            this.check_IsB.CheckedChanged += new System.EventHandler(this.check_IsB_CheckedChanged);
            // 
            // check_IsA
            // 
            this.check_IsA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_IsA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_IsA.Caption = "A件";
            this.check_IsA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_IsA.ForeColor = System.Drawing.Color.Black;
            this.check_IsA.Location = new System.Drawing.Point(31, 59);
            this.check_IsA.Name = "check_IsA";
            this.check_IsA.Padding = new System.Windows.Forms.Padding(1);
            this.check_IsA.ReadOnly = false;
            this.check_IsA.Size = new System.Drawing.Size(54, 24);
            this.check_IsA.TabIndex = 4;
            this.check_IsA.Text = "A件";
            this.check_IsA.UseVisualStyleBackColor = false;
            this.check_IsA.Value = null;
            this.check_IsA.CheckedChanged += new System.EventHandler(this.check_IsA_CheckedChanged);
            // 
            // txt_ItemCodeD
            // 
            this.txt_ItemCodeD.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ItemCodeD.Caption = "D件代码";
            this.txt_ItemCodeD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ItemCodeD.Location = new System.Drawing.Point(92, 153);
            this.txt_ItemCodeD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemCodeD.Multiline = false;
            this.txt_ItemCodeD.Name = "txt_ItemCodeD";
            this.txt_ItemCodeD.ReadOnly = true;
            this.txt_ItemCodeD.Size = new System.Drawing.Size(154, 24);
            this.txt_ItemCodeD.TabIndex = 3;
            this.txt_ItemCodeD.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ItemDescD
            // 
            this.txt_ItemDescD.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ItemDescD.Caption = "D件名称";
            this.txt_ItemDescD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ItemDescD.Location = new System.Drawing.Point(254, 150);
            this.txt_ItemDescD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemDescD.Multiline = false;
            this.txt_ItemDescD.Name = "txt_ItemDescD";
            this.txt_ItemDescD.ReadOnly = false;
            this.txt_ItemDescD.Size = new System.Drawing.Size(222, 24);
            this.txt_ItemDescD.TabIndex = 3;
            this.txt_ItemDescD.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ItemCodeC
            // 
            this.txt_ItemCodeC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ItemCodeC.Caption = "C件代码";
            this.txt_ItemCodeC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ItemCodeC.Location = new System.Drawing.Point(92, 121);
            this.txt_ItemCodeC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemCodeC.Multiline = false;
            this.txt_ItemCodeC.Name = "txt_ItemCodeC";
            this.txt_ItemCodeC.ReadOnly = true;
            this.txt_ItemCodeC.Size = new System.Drawing.Size(154, 24);
            this.txt_ItemCodeC.TabIndex = 3;
            this.txt_ItemCodeC.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ItemDescC
            // 
            this.txt_ItemDescC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ItemDescC.Caption = "C件名称";
            this.txt_ItemDescC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ItemDescC.Location = new System.Drawing.Point(254, 118);
            this.txt_ItemDescC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemDescC.Multiline = false;
            this.txt_ItemDescC.Name = "txt_ItemDescC";
            this.txt_ItemDescC.ReadOnly = false;
            this.txt_ItemDescC.Size = new System.Drawing.Size(222, 24);
            this.txt_ItemDescC.TabIndex = 3;
            this.txt_ItemDescC.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ItemCodeB
            // 
            this.txt_ItemCodeB.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ItemCodeB.Caption = "B件代码";
            this.txt_ItemCodeB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ItemCodeB.Location = new System.Drawing.Point(92, 89);
            this.txt_ItemCodeB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemCodeB.Multiline = false;
            this.txt_ItemCodeB.Name = "txt_ItemCodeB";
            this.txt_ItemCodeB.ReadOnly = false;
            this.txt_ItemCodeB.Size = new System.Drawing.Size(154, 24);
            this.txt_ItemCodeB.TabIndex = 3;
            this.txt_ItemCodeB.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.txt_ItemCodeB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ItemCodeB_KeyPress);
            // 
            // txt_ItemDescB
            // 
            this.txt_ItemDescB.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ItemDescB.Caption = "B件名称";
            this.txt_ItemDescB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ItemDescB.Location = new System.Drawing.Point(254, 86);
            this.txt_ItemDescB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemDescB.Multiline = false;
            this.txt_ItemDescB.Name = "txt_ItemDescB";
            this.txt_ItemDescB.ReadOnly = false;
            this.txt_ItemDescB.Size = new System.Drawing.Size(222, 24);
            this.txt_ItemDescB.TabIndex = 3;
            this.txt_ItemDescB.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ItemCodeA
            // 
            this.txt_ItemCodeA.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ItemCodeA.Caption = "A件代码";
            this.txt_ItemCodeA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ItemCodeA.Location = new System.Drawing.Point(92, 59);
            this.txt_ItemCodeA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemCodeA.Multiline = false;
            this.txt_ItemCodeA.Name = "txt_ItemCodeA";
            this.txt_ItemCodeA.ReadOnly = true;
            this.txt_ItemCodeA.Size = new System.Drawing.Size(154, 24);
            this.txt_ItemCodeA.TabIndex = 3;
            this.txt_ItemCodeA.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ItemDescA
            // 
            this.txt_ItemDescA.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ItemDescA.Caption = "A件名称";
            this.txt_ItemDescA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ItemDescA.Location = new System.Drawing.Point(254, 56);
            this.txt_ItemDescA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemDescA.Multiline = false;
            this.txt_ItemDescA.Name = "txt_ItemDescA";
            this.txt_ItemDescA.ReadOnly = false;
            this.txt_ItemDescA.Size = new System.Drawing.Size(222, 24);
            this.txt_ItemDescA.TabIndex = 3;
            this.txt_ItemDescA.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMDESC
            // 
            this.txt_ITEMDESC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMDESC.Caption = "套装名称";
            this.txt_ITEMDESC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMDESC.Location = new System.Drawing.Point(310, 24);
            this.txt_ITEMDESC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ITEMDESC.Multiline = false;
            this.txt_ITEMDESC.Name = "txt_ITEMDESC";
            this.txt_ITEMDESC.ReadOnly = true;
            this.txt_ITEMDESC.Size = new System.Drawing.Size(241, 24);
            this.txt_ITEMDESC.TabIndex = 3;
            this.txt_ITEMDESC.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMCODE
            // 
            this.txt_ITEMCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMCODE.Caption = "套装代码";
            this.txt_ITEMCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMCODE.Location = new System.Drawing.Point(31, 24);
            this.txt_ITEMCODE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ITEMCODE.Multiline = false;
            this.txt_ITEMCODE.Name = "txt_ITEMCODE";
            this.txt_ITEMCODE.ReadOnly = true;
            this.txt_ITEMCODE.Size = new System.Drawing.Size(241, 24);
            this.txt_ITEMCODE.TabIndex = 3;
            this.txt_ITEMCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // gToolBar1
            // 
            this.gToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gToolBar1.Location = new System.Drawing.Point(0, 0);
            this.gToolBar1.Name = "gToolBar1";
            this.gToolBar1.Size = new System.Drawing.Size(610, 24);
            this.gToolBar1.TabIndex = 0;
            // 
            // DM_ITEMESPLITDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 405);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gToolBar1);
            this.Name = "DM_ITEMESPLITDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "title";
            this.Load += new System.EventHandler(this.EDIT_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GToolBar.GToolBar gToolBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lab_title;
        private Controls.Input.GCheckBox check_IsA;
        private Controls.Input.GCheckBox check_IsB;
        private Controls.Input.GCheckBox check_IsC;
        private Controls.Input.GCheckBox check_IsD;
        private Controls.GText txt_ItemDescA;
        private Controls.GText txt_ITEMDESC;
        private Controls.GText txt_ITEMCODE;
        private Controls.GText txt_ItemDescD;
        private Controls.GText txt_ItemDescC;
        private Controls.GText txt_ItemDescB;
        private Controls.GText txt_ItemCodeD;
        private Controls.GText txt_ItemCodeC;
        private Controls.GText txt_ItemCodeB;
        private Controls.GText txt_ItemCodeA;
        private Controls.Input.GCheckBox check_Bmould;

    }
}