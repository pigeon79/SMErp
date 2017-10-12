namespace G.Erp.BaseData
{
    partial class MouldSearch
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
            this.txt_MDNAME = new G.Controls.GText();
            this.txt_MDCODE = new G.Controls.GText();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.splitContainer1.Panel1.Controls.Add(this.txt_MDNAME);
            this.splitContainer1.Panel1.Controls.Add(this.txt_MDCODE);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(749, 519);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_MDNAME
            // 
            this.txt_MDNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_MDNAME.Caption = "花模名称";
            this.txt_MDNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_MDNAME.Location = new System.Drawing.Point(35, 57);
            this.txt_MDNAME.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MDNAME.Multiline = false;
            this.txt_MDNAME.Name = "txt_MDNAME";
            this.txt_MDNAME.ReadOnly = false;
            this.txt_MDNAME.Size = new System.Drawing.Size(251, 21);
            this.txt_MDNAME.TabIndex = 5;
            this.txt_MDNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_MDCODE
            // 
            this.txt_MDCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_MDCODE.Caption = "花模代码";
            this.txt_MDCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_MDCODE.Location = new System.Drawing.Point(35, 25);
            this.txt_MDCODE.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MDCODE.Multiline = false;
            this.txt_MDCODE.Name = "txt_MDCODE";
            this.txt_MDCODE.ReadOnly = false;
            this.txt_MDCODE.Size = new System.Drawing.Size(251, 21);
            this.txt_MDCODE.TabIndex = 4;
            this.txt_MDCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_search.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(650, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.Location = new System.Drawing.Point(650, 57);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // gGrid1
            // 
            this.gGrid1.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.gGrid1.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGrid1.FrozenCell = 0;
            this.gGrid1.Location = new System.Drawing.Point(0, 0);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.ReadOnly = false;
            this.gGrid1.Rows.DefaultSize = 20;
            this.gGrid1.Size = new System.Drawing.Size(749, 422);
            this.gGrid1.TabIndex = 0;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.DoubleClick += new System.EventHandler(this.gGrid1_DoubleClick);
            // 
            // MouldSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 519);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MouldSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "花模查询";
            this.Load += new System.EventHandler(this.ItemSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.GGrid.GGrid gGrid1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cancel;
        private Controls.GText txt_MDCODE;
        private Controls.GText txt_MDNAME;
    }
}