namespace G.Client.Sys
{
    partial class Menus
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
            this.CMS_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除子菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TXT_DJLX = new G.Controls.GText();
            this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1Command1 = new C1.Win.C1Command.C1Command();
            this.CB_OUTLOOK = new C1.Win.C1Input.C1CheckBox();
            this.CB_ISVISIBLE = new C1.Win.C1Input.C1CheckBox();
            this.TXT_ACTIONTYPE = new G.Controls.GText();
            this.TXT_ASSEMBLYNAME = new G.Controls.GText();
            this.TXT_SYSTEMNAME = new G.Controls.GText();
            this.TXT_MENUCAPTION = new G.Controls.GText();
            this.txt_Target = new G.Controls.GText();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CMS_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.TXT_DJLX);
            this.splitContainer1.Panel2.Controls.Add(this.c1ToolBar1);
            this.splitContainer1.Panel2.Controls.Add(this.CB_OUTLOOK);
            this.splitContainer1.Panel2.Controls.Add(this.CB_ISVISIBLE);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Target);
            this.splitContainer1.Panel2.Controls.Add(this.TXT_ACTIONTYPE);
            this.splitContainer1.Panel2.Controls.Add(this.TXT_ASSEMBLYNAME);
            this.splitContainer1.Panel2.Controls.Add(this.TXT_SYSTEMNAME);
            this.splitContainer1.Panel2.Controls.Add(this.TXT_MENUCAPTION);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(797, 495);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView_menu
            // 
            this.treeView_menu.AllowDrop = true;
            this.treeView_menu.ContextMenuStrip = this.CMS_Menu;
            this.treeView_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_menu.Location = new System.Drawing.Point(0, 0);
            this.treeView_menu.Name = "treeView_menu";
            this.treeView_menu.Size = new System.Drawing.Size(341, 495);
            this.treeView_menu.TabIndex = 0;
            this.treeView_menu.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_menu_ItemDrag);
            this.treeView_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_menu_AfterSelect);
            this.treeView_menu.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_menu_DragDrop);
            this.treeView_menu.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_menu_DragEnter);
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
            this.CMS_Menu.Size = new System.Drawing.Size(131, 180);
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
            // TXT_DJLX
            // 
            this.TXT_DJLX.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_DJLX.Caption = "单据类型";
            this.TXT_DJLX.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_DJLX.Location = new System.Drawing.Point(25, 109);
            this.TXT_DJLX.Multiline = false;
            this.TXT_DJLX.Name = "TXT_DJLX";
            this.TXT_DJLX.ReadOnly = false;
            this.TXT_DJLX.Size = new System.Drawing.Size(379, 21);
            this.TXT_DJLX.TabIndex = 2;
            this.TXT_DJLX.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
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
            this.c1ToolBar1.Size = new System.Drawing.Size(452, 24);
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
            // CB_OUTLOOK
            // 
            this.CB_OUTLOOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CB_OUTLOOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CB_OUTLOOK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_OUTLOOK.ForeColor = System.Drawing.Color.Black;
            this.CB_OUTLOOK.Location = new System.Drawing.Point(85, 262);
            this.CB_OUTLOOK.Name = "CB_OUTLOOK";
            this.CB_OUTLOOK.Padding = new System.Windows.Forms.Padding(1);
            this.CB_OUTLOOK.Size = new System.Drawing.Size(166, 24);
            this.CB_OUTLOOK.TabIndex = 1;
            this.CB_OUTLOOK.Text = "outLook显示";
            this.CB_OUTLOOK.UseVisualStyleBackColor = false;
            this.CB_OUTLOOK.Value = null;
            // 
            // CB_ISVISIBLE
            // 
            this.CB_ISVISIBLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CB_ISVISIBLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CB_ISVISIBLE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_ISVISIBLE.ForeColor = System.Drawing.Color.Black;
            this.CB_ISVISIBLE.Location = new System.Drawing.Point(85, 232);
            this.CB_ISVISIBLE.Name = "CB_ISVISIBLE";
            this.CB_ISVISIBLE.Padding = new System.Windows.Forms.Padding(1);
            this.CB_ISVISIBLE.Size = new System.Drawing.Size(166, 24);
            this.CB_ISVISIBLE.TabIndex = 1;
            this.CB_ISVISIBLE.Text = "可见";
            this.CB_ISVISIBLE.UseVisualStyleBackColor = false;
            this.CB_ISVISIBLE.Value = null;
            // 
            // TXT_ACTIONTYPE
            // 
            this.TXT_ACTIONTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ACTIONTYPE.Caption = "链接类型";
            this.TXT_ACTIONTYPE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ACTIONTYPE.Location = new System.Drawing.Point(25, 163);
            this.TXT_ACTIONTYPE.Multiline = false;
            this.TXT_ACTIONTYPE.Name = "TXT_ACTIONTYPE";
            this.TXT_ACTIONTYPE.ReadOnly = false;
            this.TXT_ACTIONTYPE.Size = new System.Drawing.Size(379, 21);
            this.TXT_ACTIONTYPE.TabIndex = 0;
            this.TXT_ACTIONTYPE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_ASSEMBLYNAME
            // 
            this.TXT_ASSEMBLYNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_ASSEMBLYNAME.Caption = "自定义Form";
            this.TXT_ASSEMBLYNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_ASSEMBLYNAME.Location = new System.Drawing.Point(14, 136);
            this.TXT_ASSEMBLYNAME.Multiline = false;
            this.TXT_ASSEMBLYNAME.Name = "TXT_ASSEMBLYNAME";
            this.TXT_ASSEMBLYNAME.ReadOnly = false;
            this.TXT_ASSEMBLYNAME.Size = new System.Drawing.Size(390, 21);
            this.TXT_ASSEMBLYNAME.TabIndex = 0;
            this.TXT_ASSEMBLYNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_SYSTEMNAME
            // 
            this.TXT_SYSTEMNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SYSTEMNAME.Caption = "系统名称";
            this.TXT_SYSTEMNAME.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_SYSTEMNAME.Location = new System.Drawing.Point(25, 82);
            this.TXT_SYSTEMNAME.Multiline = false;
            this.TXT_SYSTEMNAME.Name = "TXT_SYSTEMNAME";
            this.TXT_SYSTEMNAME.ReadOnly = false;
            this.TXT_SYSTEMNAME.Size = new System.Drawing.Size(379, 21);
            this.TXT_SYSTEMNAME.TabIndex = 0;
            this.TXT_SYSTEMNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // TXT_MENUCAPTION
            // 
            this.TXT_MENUCAPTION.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_MENUCAPTION.Caption = "菜单名称";
            this.TXT_MENUCAPTION.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_MENUCAPTION.Location = new System.Drawing.Point(25, 54);
            this.TXT_MENUCAPTION.Multiline = false;
            this.TXT_MENUCAPTION.Name = "TXT_MENUCAPTION";
            this.TXT_MENUCAPTION.ReadOnly = false;
            this.TXT_MENUCAPTION.Size = new System.Drawing.Size(379, 21);
            this.TXT_MENUCAPTION.TabIndex = 0;
            this.TXT_MENUCAPTION.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // txt_Target
            // 
            this.txt_Target.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Target.Caption = "打开方向";
            this.txt_Target.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Target.Location = new System.Drawing.Point(25, 190);
            this.txt_Target.Multiline = false;
            this.txt_Target.Name = "txt_Target";
            this.txt_Target.ReadOnly = false;
            this.txt_Target.Size = new System.Drawing.Size(379, 21);
            this.txt_Target.TabIndex = 0;
            this.txt_Target.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Menus";
            this.Text = "菜单";
            this.Load += new System.EventHandler(this.Menus_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CMS_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView_menu;
        private Controls.GText TXT_MENUCAPTION;
        private Controls.GText TXT_ASSEMBLYNAME;
        private Controls.GText TXT_SYSTEMNAME;
        private C1.Win.C1Input.C1CheckBox CB_ISVISIBLE;
        private Controls.GText TXT_ACTIONTYPE;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1ToolBar c1ToolBar1;
        private C1.Win.C1Command.C1Command c1Command1;
        private Controls.GText TXT_DJLX;
        private C1.Win.C1Input.C1CheckBox CB_OUTLOOK;
        private System.Windows.Forms.ContextMenuStrip CMS_Menu;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除子菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private Controls.GText txt_Target;
    }
}