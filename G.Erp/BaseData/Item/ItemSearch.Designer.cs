namespace G.Erp.BaseData
{
    partial class ItemSearch
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.drop_InvClassID = new G.Controls.GDropDown();
            this.txt_HelpMarker = new G.Controls.GText();
            this.txt_ITEMDESC = new G.Controls.GText();
            this.txt_ITEMCODE = new G.Controls.GText();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            this.treeView_ItemType = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.splitContainer2.Panel1.Controls.Add(this.treeView_ItemType);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(749, 519);
            this.splitContainer2.SplitterDistance = 176;
            this.splitContainer2.TabIndex = 1;
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
            this.splitContainer1.Panel1.Controls.Add(this.drop_InvClassID);
            this.splitContainer1.Panel1.Controls.Add(this.txt_HelpMarker);
            this.splitContainer1.Panel1.Controls.Add(this.txt_ITEMDESC);
            this.splitContainer1.Panel1.Controls.Add(this.txt_ITEMCODE);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(569, 519);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 1;
            // 
            // drop_InvClassID
            // 
            this.drop_InvClassID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_InvClassID.Caption = "库存类别";
            this.drop_InvClassID.CustomerDropDownForm = null;
            this.drop_InvClassID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_InvClassID.IsText = false;
            this.drop_InvClassID.Location = new System.Drawing.Point(272, 25);
            this.drop_InvClassID.Logic = null;
            this.drop_InvClassID.Name = "drop_InvClassID";
            this.drop_InvClassID.ReadOnly = false;
            this.drop_InvClassID.Size = new System.Drawing.Size(175, 21);
            this.drop_InvClassID.TabIndex = 7;
            this.drop_InvClassID.TextField = "InvDesc";
            this.drop_InvClassID.Value = "0";
            this.drop_InvClassID.ValueField = "ID";
            this.drop_InvClassID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_HelpMarker
            // 
            this.txt_HelpMarker.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_HelpMarker.Caption = "辅 助 码";
            this.txt_HelpMarker.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_HelpMarker.Location = new System.Drawing.Point(272, 56);
            this.txt_HelpMarker.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HelpMarker.Multiline = false;
            this.txt_HelpMarker.Name = "txt_HelpMarker";
            this.txt_HelpMarker.ReadOnly = false;
            this.txt_HelpMarker.Size = new System.Drawing.Size(175, 21);
            this.txt_HelpMarker.TabIndex = 6;
            this.txt_HelpMarker.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMDESC
            // 
            this.txt_ITEMDESC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMDESC.Caption = "物品名称";
            this.txt_ITEMDESC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMDESC.Location = new System.Drawing.Point(35, 57);
            this.txt_ITEMDESC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ITEMDESC.Multiline = false;
            this.txt_ITEMDESC.Name = "txt_ITEMDESC";
            this.txt_ITEMDESC.ReadOnly = false;
            this.txt_ITEMDESC.Size = new System.Drawing.Size(210, 21);
            this.txt_ITEMDESC.TabIndex = 5;
            this.txt_ITEMDESC.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMCODE
            // 
            this.txt_ITEMCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMCODE.Caption = "物品代码";
            this.txt_ITEMCODE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMCODE.Location = new System.Drawing.Point(35, 25);
            this.txt_ITEMCODE.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ITEMCODE.Multiline = false;
            this.txt_ITEMCODE.Name = "txt_ITEMCODE";
            this.txt_ITEMCODE.ReadOnly = false;
            this.txt_ITEMCODE.Size = new System.Drawing.Size(210, 21);
            this.txt_ITEMCODE.TabIndex = 4;
            this.txt_ITEMCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_search.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(351, 95);
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
            this.btn_cancel.Location = new System.Drawing.Point(461, 95);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // gGrid1
            // 
            this.gGrid1.ColumnInfo = "5,1,0,0,0,100,Columns:";
            this.gGrid1.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGrid1.FrozenCell = 0;
            this.gGrid1.Location = new System.Drawing.Point(0, 0);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.ReadOnly = false;
            this.gGrid1.Rows.Count = 1;
            this.gGrid1.Rows.DefaultSize = 20;
            this.gGrid1.Size = new System.Drawing.Size(569, 385);
            this.gGrid1.TabIndex = 0;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.DoubleClick += new System.EventHandler(this.gGrid1_DoubleClick);
            // 
            // treeView_ItemType
            // 
            this.treeView_ItemType.AllowDrop = true;
            this.treeView_ItemType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_ItemType.Location = new System.Drawing.Point(0, 0);
            this.treeView_ItemType.Name = "treeView_ItemType";
            this.treeView_ItemType.Size = new System.Drawing.Size(176, 519);
            this.treeView_ItemType.TabIndex = 1;
            this.treeView_ItemType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_ItemType_AfterSelect);
            // 
            // ItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 519);
            this.Controls.Add(this.splitContainer2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物品查询";
            this.Load += new System.EventHandler(this.ItemSearch_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.GDropDown drop_InvClassID;
        private Controls.GText txt_HelpMarker;
        private Controls.GText txt_ITEMDESC;
        private Controls.GText txt_ITEMCODE;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cancel;
        private Controls.GGrid.GGrid gGrid1;
        private System.Windows.Forms.TreeView treeView_ItemType;

    }
}