namespace G.ERP.BaseData
{
    partial class InvClassEDIT
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
            this.txt_INVDESC = new G.Controls.GText();
            this.txt_INVCLASS = new G.Controls.GText();
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
            this.splitContainer1.Panel2.Controls.Add(this.txt_INVDESC);
            this.splitContainer1.Panel2.Controls.Add(this.txt_INVCLASS);
            this.splitContainer1.Size = new System.Drawing.Size(630, 357);
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
            // txt_INVDESC
            // 
            this.txt_INVDESC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_INVDESC.Caption = "库存类别名称 ";
            this.txt_INVDESC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_INVDESC.Location = new System.Drawing.Point(187, 77);
            this.txt_INVDESC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_INVDESC.Multiline = false;
            this.txt_INVDESC.Name = "txt_INVDESC";
            this.txt_INVDESC.ReadOnly = false;
            this.txt_INVDESC.Size = new System.Drawing.Size(254, 24);
            this.txt_INVDESC.TabIndex = 1;
            this.txt_INVDESC.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // txt_INVCLASS
            // 
            this.txt_INVCLASS.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_INVCLASS.Caption = "库存类别代码 ";
            this.txt_INVCLASS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_INVCLASS.Location = new System.Drawing.Point(187, 44);
            this.txt_INVCLASS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_INVCLASS.Multiline = false;
            this.txt_INVCLASS.Name = "txt_INVCLASS";
            this.txt_INVCLASS.ReadOnly = false;
            this.txt_INVCLASS.Size = new System.Drawing.Size(254, 24);
            this.txt_INVCLASS.TabIndex = 1;
            this.txt_INVCLASS.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // gToolBar1
            // 
            this.gToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gToolBar1.Location = new System.Drawing.Point(0, 0);
            this.gToolBar1.Name = "gToolBar1";
            this.gToolBar1.Size = new System.Drawing.Size(630, 24);
            this.gToolBar1.TabIndex = 0;
            // 
            // InvClassEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 381);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gToolBar1);
            this.Name = "InvClassEDIT";
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
        private Controls.GText txt_INVCLASS;
        private Controls.GText txt_INVDESC;

    }
}