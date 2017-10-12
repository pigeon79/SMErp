namespace G.Client.Sys
{
    partial class USEREDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USEREDIT));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.DROP_ORGID = new G.Controls.GDropDown();
            this.checkbox_NOTINUSE = new G.Controls.Input.GCheckBox();
            this.comb_USERTYPE = new G.Controls.GCombo();
            this.txt_PASSWORD = new G.Controls.GText();
            this.txt_USERNAME = new G.Controls.GText();
            this.txt_USERDM = new G.Controls.GText();
            this.gToolBar1 = new G.Controls.GToolBar.GToolBar();
            this.TXT_TEL = new G.Controls.GText();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.splitContainer1.Panel2.Controls.Add(this.TXT_TEL);
            this.splitContainer1.Panel2.Controls.Add(this.DROP_ORGID);
            this.splitContainer1.Panel2.Controls.Add(this.checkbox_NOTINUSE);
            this.splitContainer1.Panel2.Controls.Add(this.comb_USERTYPE);
            this.splitContainer1.Panel2.Controls.Add(this.txt_PASSWORD);
            this.splitContainer1.Panel2.Controls.Add(this.txt_USERNAME);
            this.splitContainer1.Panel2.Controls.Add(this.txt_USERDM);
            this.splitContainer1.Size = new System.Drawing.Size(630, 357);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(223, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "人员信息";
            // 
            // DROP_ORGID
            // 
            this.DROP_ORGID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ORGID.Caption = "部  门 ";
            this.DROP_ORGID.CustomerDropDownForm = null;
            this.DROP_ORGID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ORGID.IsText = false;
            this.DROP_ORGID.Location = new System.Drawing.Point(187, 149);
            this.DROP_ORGID.Logic = null;
            this.DROP_ORGID.Name = "DROP_ORGID";
            this.DROP_ORGID.ReadOnly = false;
            this.DROP_ORGID.Size = new System.Drawing.Size(232, 24);
            this.DROP_ORGID.TabIndex = 4;
            this.DROP_ORGID.TextField = "";
            this.DROP_ORGID.Value = "0";
            this.DROP_ORGID.ValueField = "";
            this.DROP_ORGID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // checkbox_NOTINUSE
            // 
            this.checkbox_NOTINUSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.checkbox_NOTINUSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkbox_NOTINUSE.Caption = "停用";
            this.checkbox_NOTINUSE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkbox_NOTINUSE.ForeColor = System.Drawing.Color.Black;
            this.checkbox_NOTINUSE.Location = new System.Drawing.Point(254, 252);
            this.checkbox_NOTINUSE.Name = "checkbox_NOTINUSE";
            this.checkbox_NOTINUSE.Padding = new System.Windows.Forms.Padding(1);
            this.checkbox_NOTINUSE.ReadOnly = false;
            this.checkbox_NOTINUSE.Size = new System.Drawing.Size(104, 24);
            this.checkbox_NOTINUSE.TabIndex = 6;
            this.checkbox_NOTINUSE.Text = "停用";
            this.checkbox_NOTINUSE.UseVisualStyleBackColor = false;
            this.checkbox_NOTINUSE.Value = null;
            // 
            // comb_USERTYPE
            // 
            this.comb_USERTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.comb_USERTYPE.Caption = "人员类别";
            this.comb_USERTYPE.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("comb_USERTYPE.Columns")));
            this.comb_USERTYPE.Data = "工人:1,软件操作员:2,两者都是:0";
            this.comb_USERTYPE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_USERTYPE.Location = new System.Drawing.Point(187, 219);
            this.comb_USERTYPE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comb_USERTYPE.Name = "comb_USERTYPE";
            this.comb_USERTYPE.ReadOnly = false;
            this.comb_USERTYPE.Size = new System.Drawing.Size(232, 22);
            this.comb_USERTYPE.TabIndex = 5;
            this.comb_USERTYPE.VisualStyle = C1.Win.C1List.VisualStyle.Custom;
            // 
            // txt_PASSWORD
            // 
            this.txt_PASSWORD.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_PASSWORD.Caption = "密  码 ";
            this.txt_PASSWORD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_PASSWORD.Location = new System.Drawing.Point(187, 114);
            this.txt_PASSWORD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PASSWORD.Multiline = false;
            this.txt_PASSWORD.Name = "txt_PASSWORD";
            this.txt_PASSWORD.ReadOnly = false;
            this.txt_PASSWORD.Size = new System.Drawing.Size(232, 24);
            this.txt_PASSWORD.TabIndex = 3;
            this.txt_PASSWORD.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // txt_USERNAME
            // 
            this.txt_USERNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_USERNAME.Caption = "姓  名 ";
            this.txt_USERNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_USERNAME.Location = new System.Drawing.Point(187, 79);
            this.txt_USERNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_USERNAME.Multiline = false;
            this.txt_USERNAME.Name = "txt_USERNAME";
            this.txt_USERNAME.ReadOnly = false;
            this.txt_USERNAME.Size = new System.Drawing.Size(232, 24);
            this.txt_USERNAME.TabIndex = 2;
            this.txt_USERNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // txt_USERDM
            // 
            this.txt_USERDM.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_USERDM.Caption = "工  号 ";
            this.txt_USERDM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_USERDM.Location = new System.Drawing.Point(187, 44);
            this.txt_USERDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_USERDM.Multiline = false;
            this.txt_USERDM.Name = "txt_USERDM";
            this.txt_USERDM.ReadOnly = false;
            this.txt_USERDM.Size = new System.Drawing.Size(232, 24);
            this.txt_USERDM.TabIndex = 1;
            this.txt_USERDM.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // gToolBar1
            // 
            this.gToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gToolBar1.Location = new System.Drawing.Point(0, 0);
            this.gToolBar1.Name = "gToolBar1";
            this.gToolBar1.Size = new System.Drawing.Size(630, 24);
            this.gToolBar1.TabIndex = 0;
            // 
            // TXT_TEL
            // 
            this.TXT_TEL.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_TEL.Caption = "电  话 ";
            this.TXT_TEL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_TEL.Location = new System.Drawing.Point(187, 184);
            this.TXT_TEL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_TEL.Multiline = false;
            this.TXT_TEL.Name = "TXT_TEL";
            this.TXT_TEL.ReadOnly = false;
            this.TXT_TEL.Size = new System.Drawing.Size(232, 24);
            this.TXT_TEL.TabIndex = 7;
            this.TXT_TEL.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // USEREDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 381);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gToolBar1);
            this.Name = "USEREDIT";
            this.Text = "人员信息";
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
        private System.Windows.Forms.Label label1;
        private Controls.GText txt_USERDM;
        private Controls.GText txt_USERNAME;
        private Controls.GCombo comb_USERTYPE;
        private Controls.GText txt_PASSWORD;
        private Controls.Input.GCheckBox checkbox_NOTINUSE;
        private Controls.GDropDown DROP_ORGID;
        private Controls.GText TXT_TEL;

    }
}