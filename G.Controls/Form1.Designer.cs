namespace G.Controls
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.c1PreviewPane1 = new C1.Win.C1Preview.C1PreviewPane();
            this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
            this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            this.c1List1 = new C1.Win.C1List.C1List();
            this.c1DropDownControl1 = new C1.Win.C1Input.C1DropDownControl();
            this.gCombo21 = new G.Controls.GCombo2();
            this.gDate1 = new G.Controls.GDate();
            this.gCombo1 = new G.Controls.GCombo();
            this.cutPager1 = new G.Controls.GGrid.CutPager();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PreviewPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
            this.c1CommandDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c1InputPanel1.Location = new System.Drawing.Point(40, 33);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(240, 150);
            this.c1InputPanel1.TabIndex = 0;
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(915, 156);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Group";
            // 
            // c1PreviewPane1
            // 
            this.c1PreviewPane1.Location = new System.Drawing.Point(13, 201);
            this.c1PreviewPane1.Name = "c1PreviewPane1";
            this.c1PreviewPane1.Size = new System.Drawing.Size(197, 167);
            this.c1PreviewPane1.TabIndex = 2;
            // 
            // c1PdfDocument1
            // 
            this.c1PdfDocument1.RotateAngle = 0F;
            this.c1PdfDocument1.UseFileCaching = false;
            // 
            // c1CommandDock1
            // 
            this.c1CommandDock1.Controls.Add(this.cutPager1);
            this.c1CommandDock1.Id = 1;
            this.c1CommandDock1.Location = new System.Drawing.Point(0, 156);
            this.c1CommandDock1.Name = "c1CommandDock1";
            this.c1CommandDock1.Size = new System.Drawing.Size(915, 32);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.c1FlexGrid1.Location = new System.Drawing.Point(320, 260);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 20;
            this.c1FlexGrid1.Size = new System.Drawing.Size(240, 150);
            this.c1FlexGrid1.TabIndex = 4;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.Location = new System.Drawing.Point(279, 201);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(100, 21);
            this.c1TextBox1.TabIndex = 7;
            this.c1TextBox1.Tag = null;
            // 
            // c1DateEdit1
            // 
            // 
            // 
            // 
            this.c1DateEdit1.Calendar.DayNameLength = 1;
            this.c1DateEdit1.Location = new System.Drawing.Point(382, 194);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(200, 21);
            this.c1DateEdit1.TabIndex = 8;
            this.c1DateEdit1.Tag = null;
            this.c1DateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // c1List1
            // 
            this.c1List1.AddItemSeparator = ';';
            this.c1List1.CaptionHeight = 18;
            this.c1List1.ColumnCaptionHeight = 18;
            this.c1List1.ColumnFooterHeight = 18;
            this.c1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
            this.c1List1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1List1.Images"))));
            this.c1List1.ItemHeight = 16;
            this.c1List1.Location = new System.Drawing.Point(216, 228);
            this.c1List1.MatchEntryTimeout = ((long)(2000));
            this.c1List1.Name = "c1List1";
            this.c1List1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1List1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1List1.PreviewInfo.ZoomFactor = 75D;
            this.c1List1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1List1.PrintInfo.PageSettings")));
            this.c1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1List1.ShowHeaderCheckBox = false;
            this.c1List1.Size = new System.Drawing.Size(75, 124);
            this.c1List1.TabIndex = 11;
            this.c1List1.Text = "c1List1";
            this.c1List1.PropBag = resources.GetString("c1List1.PropBag");
            // 
            // c1DropDownControl1
            // 
            this.c1DropDownControl1.Location = new System.Drawing.Point(589, 320);
            this.c1DropDownControl1.Name = "c1DropDownControl1";
            this.c1DropDownControl1.Size = new System.Drawing.Size(200, 21);
            this.c1DropDownControl1.TabIndex = 20;
            this.c1DropDownControl1.Tag = null;
            // 
            // gCombo21
            // 
            this.gCombo21.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.gCombo21.Caption = "label1";
            this.gCombo21.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("gCombo21.Columns")));
            this.gCombo21.Data = "";
            this.gCombo21.Location = new System.Drawing.Point(65, 476);
            this.gCombo21.Name = "gCombo21";
            this.gCombo21.ReadOnly = false;
            this.gCombo21.Size = new System.Drawing.Size(145, 20);
            this.gCombo21.TabIndex = 23;
            this.gCombo21.VisualStyle = C1.Win.C1List.VisualStyle.Custom;
            // 
            // gDate1
            // 
            this.gDate1.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.gDate1.Caption = "label1";
            this.gDate1.Location = new System.Drawing.Point(618, 260);
            this.gDate1.Name = "gDate1";
            this.gDate1.ReadOnly = false;
            this.gDate1.Size = new System.Drawing.Size(144, 19);
            this.gDate1.TabIndex = 17;
            this.gDate1.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // gCombo1
            // 
            this.gCombo1.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.gCombo1.Caption = "label1";
            this.gCombo1.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("gCombo1.Columns")));
            this.gCombo1.Data = "";
            this.gCombo1.Location = new System.Drawing.Point(660, 201);
            this.gCombo1.Name = "gCombo1";
            this.gCombo1.ReadOnly = false;
            this.gCombo1.Size = new System.Drawing.Size(144, 22);
            this.gCombo1.TabIndex = 14;
            this.gCombo1.VisualStyle = C1.Win.C1List.VisualStyle.Custom;
            // 
            // cutPager1
            // 
            this.cutPager1.AllCount = 0;
            this.cutPager1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.cutPager1.Location = new System.Drawing.Point(77, 0);
            this.cutPager1.Name = "cutPager1";
            this.cutPager1.PageSize = 0;
            this.cutPager1.Size = new System.Drawing.Size(780, 27);
            this.cutPager1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 631);
            this.Controls.Add(this.gCombo21);
            this.Controls.Add(this.c1DropDownControl1);
            this.Controls.Add(this.gDate1);
            this.Controls.Add(this.gCombo1);
            this.Controls.Add(this.c1List1);
            this.Controls.Add(this.c1DateEdit1);
            this.Controls.Add(this.c1TextBox1);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1CommandDock1);
            this.Controls.Add(this.c1PreviewPane1);
            this.Controls.Add(this.c1Ribbon1);
            this.Controls.Add(this.c1InputPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PreviewPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
            this.c1CommandDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Preview.C1PreviewPane c1PreviewPane1;
        private C1.C1Pdf.C1PdfDocument c1PdfDocument1;
        private C1.Win.C1Command.C1CommandDock c1CommandDock1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
        private C1.Win.C1List.C1List c1List1;
        private GCombo gCombo1;
        private GDate gDate1;
        private C1.Win.C1Input.C1DropDownControl c1DropDownControl1;
        private GGrid.CutPager cutPager1;
        private GCombo2 gCombo21;
    }
}