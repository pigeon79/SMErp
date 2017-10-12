namespace G.Erp.BaseData
{
    partial class WHB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WHB));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView_menu = new System.Windows.Forms.TreeView();
            this.CMS_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStrip_New = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Prv = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Next = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Last = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_DelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            this.gToolBar1 = new G.Controls.GToolBar.GToolBar();
            this.ToolStrip_Modify = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CMS_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_menu);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gGrid1);
            this.splitContainer1.Panel2.Controls.Add(this.gToolBar1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(797, 495);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView_menu
            // 
            this.treeView_menu.AllowDrop = true;
            this.treeView_menu.ContextMenuStrip = this.CMS_Menu;
            this.treeView_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_menu.Location = new System.Drawing.Point(0, 0);
            this.treeView_menu.Name = "treeView_menu";
            this.treeView_menu.Size = new System.Drawing.Size(205, 495);
            this.treeView_menu.TabIndex = 0;
            this.treeView_menu.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_menu_ItemDrag);
            this.treeView_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_menu_AfterSelect);
            this.treeView_menu.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_menu_DragDrop);
            this.treeView_menu.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_menu_DragEnter);
            // 
            // CMS_Menu
            // 
            this.CMS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_New,
            this.ToolStrip_Modify,
            this.ToolStrip_Delete,
            this.ToolStrip_Top,
            this.ToolStrip_Prv,
            this.ToolStrip_Next,
            this.ToolStrip_Last,
            this.ToolStrip_DelAll,
            this.ToolStrip_Refresh});
            this.CMS_Menu.Name = "CMS_Menu";
            this.CMS_Menu.Size = new System.Drawing.Size(131, 202);
            this.CMS_Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMS_Menu_ItemClicked);
            // 
            // ToolStrip_New
            // 
            this.ToolStrip_New.Name = "ToolStrip_New";
            this.ToolStrip_New.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_New.Text = "新增";
            // 
            // ToolStrip_Delete
            // 
            this.ToolStrip_Delete.Name = "ToolStrip_Delete";
            this.ToolStrip_Delete.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_Delete.Text = "删除";
            // 
            // ToolStrip_Top
            // 
            this.ToolStrip_Top.Name = "ToolStrip_Top";
            this.ToolStrip_Top.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_Top.Text = "最上";
            // 
            // ToolStrip_Prv
            // 
            this.ToolStrip_Prv.Name = "ToolStrip_Prv";
            this.ToolStrip_Prv.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_Prv.Text = "上移";
            // 
            // ToolStrip_Next
            // 
            this.ToolStrip_Next.Name = "ToolStrip_Next";
            this.ToolStrip_Next.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_Next.Text = "下移";
            // 
            // ToolStrip_Last
            // 
            this.ToolStrip_Last.Name = "ToolStrip_Last";
            this.ToolStrip_Last.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_Last.Text = "最下";
            // 
            // ToolStrip_DelAll
            // 
            this.ToolStrip_DelAll.Name = "ToolStrip_DelAll";
            this.ToolStrip_DelAll.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_DelAll.Text = "删除子菜单";
            // 
            // ToolStrip_Refresh
            // 
            this.ToolStrip_Refresh.Name = "ToolStrip_Refresh";
            this.ToolStrip_Refresh.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_Refresh.Text = "刷新";
            // 
            // gGrid1
            // 
            this.gGrid1.AllowEditing = false;
            this.gGrid1.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.gGrid1.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGrid1.FrozenCell = 0;
            this.gGrid1.Location = new System.Drawing.Point(0, 24);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.Rows.DefaultSize = 20;
            this.gGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.gGrid1.Size = new System.Drawing.Size(588, 471);
            this.gGrid1.StyleInfo = resources.GetString("gGrid1.StyleInfo");
            this.gGrid1.TabIndex = 1;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.DoubleClick += new System.EventHandler(this.gGrid1_DoubleClick);
            // 
            // gToolBar1
            // 
            this.gToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gToolBar1.Location = new System.Drawing.Point(0, 0);
            this.gToolBar1.Name = "gToolBar1";
            this.gToolBar1.Size = new System.Drawing.Size(588, 24);
            this.gToolBar1.TabIndex = 2;
            // 
            // ToolStrip_Modify
            // 
            this.ToolStrip_Modify.Name = "ToolStrip_Modify";
            this.ToolStrip_Modify.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip_Modify.Text = "修改";
            // 
            // WHB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WHB";
            this.Text = "辅助资料";
            this.Load += new System.EventHandler(this.Menus_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CMS_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView_menu;
        private System.Windows.Forms.ContextMenuStrip CMS_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_New;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Delete;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Prv;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Next;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Last;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_DelAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Refresh;
        private Controls.GGrid.GGrid gGrid1;
        private Controls.GToolBar.GToolBar gToolBar1;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Modify;
    }
}