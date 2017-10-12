namespace G.Client.Sys
{
    partial class Org
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView_menu = new System.Windows.Forms.TreeView();
            this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1Command1 = new C1.Win.C1Command.C1Command();
            this.TXT_ORGNAME = new G.Controls.GText();
            this.TXT_ORGDM = new G.Controls.GText();
            this.CMS_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除子菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.CMS_Menu.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.c1ToolBar1);
            this.splitContainer1.Panel2.Controls.Add(this.TXT_ORGNAME);
            this.splitContainer1.Panel2.Controls.Add(this.TXT_ORGDM);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(731, 495);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView_menu
            // 
            this.treeView_menu.AllowDrop = true;
            this.treeView_menu.ContextMenuStrip = this.CMS_Menu;
            this.treeView_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_menu.Location = new System.Drawing.Point(0, 0);
            this.treeView_menu.Name = "treeView_menu";
            this.treeView_menu.Size = new System.Drawing.Size(386, 495);
            this.treeView_menu.TabIndex = 0;
            this.treeView_menu.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_menu_ItemDrag);
            this.treeView_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_menu_AfterSelect);
            this.treeView_menu.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_menu_DragDrop);
            this.treeView_menu.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_menu_DragEnter);
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.AutoSize = false;
            this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
            this.c1ToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar1.Movable = false;
            this.c1ToolBar1.Name = "c1ToolBar1";
            this.c1ToolBar1.Size = new System.Drawing.Size(341, 24);
            this.c1ToolBar1.Text = "c1ToolBar1";
            this.c1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Owner = this;
            this.c1CommandHolder1.CommandClick += new C1.Win.C1Command.CommandClickEventHandler(this.c1CommandHolder1_CommandClick);
            // 
            // c1Command1
            // 
            this.c1Command1.Name = "c1Command1";
            this.c1Command1.ShortcutText = "";
            // 
            // TXT_ORGNAME
            // 
            this.TXT_ORGNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORGNAME.Caption = "部门名称";
            this.TXT_ORGNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORGNAME.Location = new System.Drawing.Point(39, 80);
            this.TXT_ORGNAME.Multiline = false;
            this.TXT_ORGNAME.Name = "TXT_ORGNAME";
            this.TXT_ORGNAME.ReadOnly = false;
            this.TXT_ORGNAME.Size = new System.Drawing.Size(242, 21);
            this.TXT_ORGNAME.TabIndex = 0;
            this.TXT_ORGNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ORGDM
            // 
            this.TXT_ORGDM.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ORGDM.Caption = "部门代码";
            this.TXT_ORGDM.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ORGDM.Location = new System.Drawing.Point(39, 52);
            this.TXT_ORGDM.Multiline = false;
            this.TXT_ORGDM.Name = "TXT_ORGDM";
            this.TXT_ORGDM.ReadOnly = false;
            this.TXT_ORGDM.Size = new System.Drawing.Size(242, 21);
            this.TXT_ORGDM.TabIndex = 0;
            this.TXT_ORGDM.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // CMS_Menu
            // 
            this.CMS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.最上ToolStripMenuItem,
            this.上移ToolStripMenuItem,
            this.下移ToolStripMenuItem,
            this.最下ToolStripMenuItem,
            this.删除子菜单ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.CMS_Menu.Name = "CMS_Menu";
            this.CMS_Menu.Size = new System.Drawing.Size(153, 202);
            this.CMS_Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMS_Menu_ItemClicked);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 最上ToolStripMenuItem
            // 
            this.最上ToolStripMenuItem.Name = "最上ToolStripMenuItem";
            this.最上ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.最上ToolStripMenuItem.Text = "最上";
            // 
            // 上移ToolStripMenuItem
            // 
            this.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem";
            this.上移ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.上移ToolStripMenuItem.Text = "上移";
            // 
            // 下移ToolStripMenuItem
            // 
            this.下移ToolStripMenuItem.Name = "下移ToolStripMenuItem";
            this.下移ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.下移ToolStripMenuItem.Text = "下移";
            // 
            // 最下ToolStripMenuItem
            // 
            this.最下ToolStripMenuItem.Name = "最下ToolStripMenuItem";
            this.最下ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.最下ToolStripMenuItem.Text = "最下";
            // 
            // 删除子菜单ToolStripMenuItem
            // 
            this.删除子菜单ToolStripMenuItem.Name = "删除子菜单ToolStripMenuItem";
            this.删除子菜单ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.删除子菜单ToolStripMenuItem.Text = "删除子菜单";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // Org
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Org";
            this.Text = "部门";
            this.Load += new System.EventHandler(this.Org_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.CMS_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView_menu;
        private Controls.GText TXT_ORGDM;
        private Controls.GText TXT_ORGNAME;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1ToolBar c1ToolBar1;
        private C1.Win.C1Command.C1Command c1Command1;
        private System.Windows.Forms.ContextMenuStrip CMS_Menu;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除子菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
    }
}