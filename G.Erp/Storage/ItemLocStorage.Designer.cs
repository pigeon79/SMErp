namespace G.Erp.BaseData
{
    partial class ItemLocStorage
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
            this.txt_ATTRIBUTEA = new G.Controls.GText();
            this.check_ozero = new G.Controls.Input.GCheckBox();
            this.drop_wrhs = new G.Controls.GDropDown();
            this.drop_loc = new G.Controls.GDropDown();
            this.txt_ITEMDESC = new G.Controls.GText();
            this.txt_ITEMCODE = new G.Controls.GText();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            this.drop_attributeb = new G.Controls.GDropDown();
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
            this.splitContainer1.Panel1.Controls.Add(this.drop_attributeb);
            this.splitContainer1.Panel1.Controls.Add(this.txt_ATTRIBUTEA);
            this.splitContainer1.Panel1.Controls.Add(this.check_ozero);
            this.splitContainer1.Panel1.Controls.Add(this.drop_wrhs);
            this.splitContainer1.Panel1.Controls.Add(this.drop_loc);
            this.splitContainer1.Panel1.Controls.Add(this.txt_ITEMDESC);
            this.splitContainer1.Panel1.Controls.Add(this.txt_ITEMCODE);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(749, 519);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_ATTRIBUTEA
            // 
            this.txt_ATTRIBUTEA.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ATTRIBUTEA.Caption = "色号";
            this.txt_ATTRIBUTEA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ATTRIBUTEA.Location = new System.Drawing.Point(334, 89);
            this.txt_ATTRIBUTEA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ATTRIBUTEA.Multiline = false;
            this.txt_ATTRIBUTEA.Name = "txt_ATTRIBUTEA";
            this.txt_ATTRIBUTEA.ReadOnly = false;
            this.txt_ATTRIBUTEA.Size = new System.Drawing.Size(188, 21);
            this.txt_ATTRIBUTEA.TabIndex = 9;
            this.txt_ATTRIBUTEA.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // check_ozero
            // 
            this.check_ozero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_ozero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_ozero.Caption = "库存数大于0";
            this.check_ozero.Checked = true;
            this.check_ozero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_ozero.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_ozero.ForeColor = System.Drawing.Color.Black;
            this.check_ozero.Location = new System.Drawing.Point(599, 89);
            this.check_ozero.Name = "check_ozero";
            this.check_ozero.Padding = new System.Windows.Forms.Padding(1);
            this.check_ozero.ReadOnly = false;
            this.check_ozero.Size = new System.Drawing.Size(126, 24);
            this.check_ozero.TabIndex = 8;
            this.check_ozero.Text = "库存数大于0";
            this.check_ozero.UseVisualStyleBackColor = false;
            this.check_ozero.Value = true;
            // 
            // drop_wrhs
            // 
            this.drop_wrhs.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_wrhs.Caption = "仓    库";
            this.drop_wrhs.CustomerDropDownForm = null;
            this.drop_wrhs.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_wrhs.IsText = false;
            this.drop_wrhs.Location = new System.Drawing.Point(35, 23);
            this.drop_wrhs.Logic = null;
            this.drop_wrhs.Name = "drop_wrhs";
            this.drop_wrhs.ReadOnly = false;
            this.drop_wrhs.Size = new System.Drawing.Size(251, 21);
            this.drop_wrhs.TabIndex = 7;
            this.drop_wrhs.TextField = "InvDesc";
            this.drop_wrhs.Value = "0";
            this.drop_wrhs.ValueField = "ID";
            this.drop_wrhs.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // drop_loc
            // 
            this.drop_loc.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_loc.Caption = "库位";
            this.drop_loc.CustomerDropDownForm = null;
            this.drop_loc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_loc.IsText = false;
            this.drop_loc.Location = new System.Drawing.Point(334, 25);
            this.drop_loc.Logic = null;
            this.drop_loc.Name = "drop_loc";
            this.drop_loc.ReadOnly = false;
            this.drop_loc.Size = new System.Drawing.Size(188, 21);
            this.drop_loc.TabIndex = 7;
            this.drop_loc.TextField = "InvDesc";
            this.drop_loc.Value = "0";
            this.drop_loc.ValueField = "ID";
            this.drop_loc.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMDESC
            // 
            this.txt_ITEMDESC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMDESC.Caption = "物品名称";
            this.txt_ITEMDESC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMDESC.Location = new System.Drawing.Point(35, 89);
            this.txt_ITEMDESC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ITEMDESC.Multiline = false;
            this.txt_ITEMDESC.Name = "txt_ITEMDESC";
            this.txt_ITEMDESC.ReadOnly = false;
            this.txt_ITEMDESC.Size = new System.Drawing.Size(251, 21);
            this.txt_ITEMDESC.TabIndex = 5;
            this.txt_ITEMDESC.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMCODE
            // 
            this.txt_ITEMCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMCODE.Caption = "物品代码";
            this.txt_ITEMCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMCODE.Location = new System.Drawing.Point(35, 57);
            this.txt_ITEMCODE.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ITEMCODE.Multiline = false;
            this.txt_ITEMCODE.Name = "txt_ITEMCODE";
            this.txt_ITEMCODE.ReadOnly = false;
            this.txt_ITEMCODE.Size = new System.Drawing.Size(251, 21);
            this.txt_ITEMCODE.TabIndex = 4;
            this.txt_ITEMCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
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
            this.btn_cancel.Location = new System.Drawing.Point(650, 55);
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
            this.gGrid1.Size = new System.Drawing.Size(749, 384);
            this.gGrid1.TabIndex = 0;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.DoubleClick += new System.EventHandler(this.gGrid1_DoubleClick);
            // 
            // drop_attributeb
            // 
            this.drop_attributeb.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_attributeb.Caption = "花模";
            this.drop_attributeb.CustomerDropDownForm = null;
            this.drop_attributeb.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_attributeb.IsText = false;
            this.drop_attributeb.Location = new System.Drawing.Point(334, 55);
            this.drop_attributeb.Logic = null;
            this.drop_attributeb.Name = "drop_attributeb";
            this.drop_attributeb.ReadOnly = false;
            this.drop_attributeb.Size = new System.Drawing.Size(188, 21);
            this.drop_attributeb.TabIndex = 10;
            this.drop_attributeb.TextField = "MDNAME";
            this.drop_attributeb.Value = "0";
            this.drop_attributeb.ValueField = "MDCODE";
            this.drop_attributeb.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // ItemLocStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 519);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemLocStorage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存查询";
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
        private Controls.GText txt_ITEMCODE;
        private Controls.GText txt_ITEMDESC;
        private Controls.GDropDown drop_loc;
        private Controls.Input.GCheckBox check_ozero;
        private Controls.GDropDown drop_wrhs;
        private Controls.GText txt_ATTRIBUTEA;
        private Controls.GDropDown drop_attributeb;
    }
}