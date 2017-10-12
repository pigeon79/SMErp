namespace G.Client
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new C1.Win.C1Command.C1MainMenu();
            this.commandHolder = new C1.Win.C1Command.C1CommandHolder();
            this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
            this.dockingTab_Menu = new C1.Win.C1Command.C1DockingTab();
            this.TabPage_Menu = new C1.Win.C1Command.C1DockingTabPage();
            this.TopicBar_Menu = new C1.Win.C1Command.C1TopicBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dockingTab_Main = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonButton1 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton2 = new C1.Win.C1Ribbon.RibbonButton();
            this.info_company = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton8 = new C1.Win.C1Ribbon.RibbonButton();
            this.info_version = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
            this.info_logname = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton5 = new C1.Win.C1Ribbon.RibbonButton();
            this.info_curdate = new C1.Win.C1Ribbon.RibbonButton();
            this.status_Info = new C1.Win.C1Ribbon.RibbonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.commandHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
            this.c1CommandDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab_Menu)).BeginInit();
            this.dockingTab_Menu.SuspendLayout();
            this.TabPage_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopicBar_Menu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab_Main)).BeginInit();
            this.dockingTab_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AccessibleName = "Menu Bar";
            this.mainMenu.CommandHolder = this.commandHolder;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(712, 23);
            this.mainMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            // 
            // commandHolder
            // 
            this.commandHolder.Owner = this;
            this.commandHolder.CommandClick += new C1.Win.C1Command.CommandClickEventHandler(this.commandHolder_CommandClick);
            // 
            // c1CommandDock1
            // 
            this.c1CommandDock1.Controls.Add(this.dockingTab_Menu);
            this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1CommandDock1.Id = 1;
            this.c1CommandDock1.Location = new System.Drawing.Point(0, 23);
            this.c1CommandDock1.Name = "c1CommandDock1";
            this.c1CommandDock1.Size = new System.Drawing.Size(213, 432);
            // 
            // dockingTab_Menu
            // 
            this.dockingTab_Menu.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.dockingTab_Menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingTab_Menu.CanAutoHide = true;
            this.dockingTab_Menu.Controls.Add(this.TabPage_Menu);
            this.dockingTab_Menu.Location = new System.Drawing.Point(0, 0);
            this.dockingTab_Menu.Name = "dockingTab_Menu";
            this.dockingTab_Menu.ShowCaption = true;
            this.dockingTab_Menu.ShowSingleTab = false;
            this.dockingTab_Menu.Size = new System.Drawing.Size(213, 432);
            this.dockingTab_Menu.TabIndex = 2;
            this.dockingTab_Menu.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
            this.dockingTab_Menu.TabsSpacing = 5;
            this.dockingTab_Menu.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
            this.dockingTab_Menu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            // 
            // TabPage_Menu
            // 
            this.TabPage_Menu.CaptionVisible = true;
            this.TabPage_Menu.Controls.Add(this.TopicBar_Menu);
            this.TabPage_Menu.Location = new System.Drawing.Point(0, 0);
            this.TabPage_Menu.Name = "TabPage_Menu";
            this.TabPage_Menu.Size = new System.Drawing.Size(210, 431);
            this.TabPage_Menu.TabIndex = 2;
            this.TabPage_Menu.Text = "菜单";
            // 
            // TopicBar_Menu
            // 
            this.TopicBar_Menu.AutoScrollMinSize = new System.Drawing.Size(0, 10);
            this.TopicBar_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicBar_Menu.ImageList = null;
            this.TopicBar_Menu.Location = new System.Drawing.Point(0, 19);
            this.TopicBar_Menu.Name = "TopicBar_Menu";
            this.TopicBar_Menu.Padding = new System.Windows.Forms.Padding(5);
            this.TopicBar_Menu.PagePadding = new System.Windows.Forms.Padding(10);
            this.TopicBar_Menu.Size = new System.Drawing.Size(210, 412);
            this.TopicBar_Menu.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.TopicBar_Menu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            this.TopicBar_Menu.LinkClick += new C1.Win.C1Command.C1TopicBarClickEventHandler(this.TopicBar_Menu_LinkClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dockingTab_Main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(213, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 432);
            this.panel1.TabIndex = 7;
            // 
            // dockingTab_Main
            // 
            this.dockingTab_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingTab_Main.CloseBox = C1.Win.C1Command.CloseBoxPositionEnum.ActivePage;
            this.dockingTab_Main.Controls.Add(this.c1DockingTabPage1);
            this.dockingTab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockingTab_Main.Location = new System.Drawing.Point(0, 0);
            this.dockingTab_Main.Name = "dockingTab_Main";
            this.dockingTab_Main.Size = new System.Drawing.Size(499, 432);
            this.dockingTab_Main.TabIndex = 3;
            this.dockingTab_Main.TabLook = C1.Win.C1Command.ButtonLookFlags.Text;
            this.dockingTab_Main.TabsSpacing = 5;
            this.dockingTab_Main.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
            this.dockingTab_Main.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            this.dockingTab_Main.SelectedIndexChanged += new System.EventHandler(this.dockingTab_Main_SelectedIndexChanged);
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.c1DockingTabPage1.Location = new System.Drawing.Point(0, 25);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(499, 407);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.TabStop = false;
            this.c1DockingTabPage1.Text = "首页";
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonButton1);
            this.c1StatusBar1.LeftPaneItems.Add(this.status_Info);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonButton2);
            this.c1StatusBar1.LeftPaneItems.Add(this.info_company);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonButton8);
            this.c1StatusBar1.LeftPaneItems.Add(this.info_version);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonLabel1);
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 455);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.RightPaneItems.Add(this.info_logname);
            this.c1StatusBar1.RightPaneItems.Add(this.ribbonButton5);
            this.c1StatusBar1.RightPaneItems.Add(this.info_curdate);
            this.c1StatusBar1.Size = new System.Drawing.Size(712, 23);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.Text = "就绪";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.Text = "|";
            // 
            // info_company
            // 
            this.info_company.Name = "info_company";
            this.info_company.Text = "公司";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.Text = "|";
            // 
            // info_version
            // 
            this.info_version.Name = "info_version";
            this.info_version.Text = "版本";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            // 
            // info_logname
            // 
            this.info_logname.Name = "info_logname";
            this.info_logname.Text = "操作员";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.Text = "|";
            // 
            // info_curdate
            // 
            this.info_curdate.Name = "info_curdate";
            this.info_curdate.Text = "日期";
            // 
            // status_Info
            // 
            this.status_Info.Name = "status_Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1CommandDock1);
            this.Controls.Add(this.c1StatusBar1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
            this.c1CommandDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab_Menu)).EndInit();
            this.dockingTab_Menu.ResumeLayout(false);
            this.TabPage_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopicBar_Menu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab_Main)).EndInit();
            this.dockingTab_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Command.C1MainMenu mainMenu;
        private C1.Win.C1Command.C1CommandHolder commandHolder;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Command.C1DockingTab dockingTab_Main;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.C1Command.C1CommandDock c1CommandDock1;
        private C1.Win.C1Command.C1DockingTab dockingTab_Menu;
        private C1.Win.C1Command.C1DockingTabPage TabPage_Menu;
        private C1.Win.C1Command.C1TopicBar TopicBar_Menu;
        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton2;
        private C1.Win.C1Ribbon.RibbonButton info_company;
        private C1.Win.C1Ribbon.RibbonButton info_logname;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton5;
        private C1.Win.C1Ribbon.RibbonButton info_curdate;
        private C1.Win.C1Ribbon.RibbonButton info_version;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton8;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.C1Ribbon.RibbonLabel status_Info;
    }
}