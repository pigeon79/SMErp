namespace G.Client.Authority
{
    partial class MenuAuthority
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
            this.treeView_menu = new System.Windows.Forms.TreeView();
            this.drop_User = new G.Controls.GDropDown();
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
            this.splitContainer1.Panel2.Controls.Add(this.drop_User);
            this.splitContainer1.Panel2.Controls.Add(this.gToolBar1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(731, 495);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView_menu
            // 
            this.treeView_menu.AllowDrop = true;
            this.treeView_menu.CheckBoxes = true;
            this.treeView_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_menu.Location = new System.Drawing.Point(0, 0);
            this.treeView_menu.Name = "treeView_menu";
            this.treeView_menu.Size = new System.Drawing.Size(386, 495);
            this.treeView_menu.TabIndex = 0;
            this.treeView_menu.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_menu_AfterCheck);
            // 
            // drop_User
            // 
            this.drop_User.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_User.Caption = "用户:";
            this.drop_User.CustomerDropDownForm = null;
            this.drop_User.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_User.Location = new System.Drawing.Point(56, 85);
            this.drop_User.Name = "drop_User";
            this.drop_User.Size = new System.Drawing.Size(234, 21);
            this.drop_User.TabIndex = 1;
            this.drop_User.TextField = "USERNAME";
            this.drop_User.Value = "0";
            this.drop_User.ValueField = "USERID";
            this.drop_User.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.drop_User.ValueChanged += new System.EventHandler(this.drop_User_ValueChanged);
            // 
            // gToolBar1
            // 
            this.gToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gToolBar1.Location = new System.Drawing.Point(0, 0);
            this.gToolBar1.Name = "gToolBar1";
            this.gToolBar1.Size = new System.Drawing.Size(341, 24);
            this.gToolBar1.TabIndex = 0;
            // 
            // MenuAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MenuAuthority";
            this.Text = "菜单";
            this.Load += new System.EventHandler(this.Menus_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView_menu;
        private Controls.GToolBar.GToolBar gToolBar1;
        private Controls.GDropDown drop_User;
    }
}