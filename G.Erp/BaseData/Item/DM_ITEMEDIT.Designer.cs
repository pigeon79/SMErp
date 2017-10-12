namespace G.Erp.BaseData
{
    partial class DM_ITEMEDIT
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
            this.txt_WorkOrdQty = new G.Controls.GNumText();
            this.txt_CertQty = new G.Controls.GNumText();
            this.txt_SafeStock = new G.Controls.GNumText();
            this.txt_MaxCap = new G.Controls.GNumText();
            this.txt_MaxStock = new G.Controls.GNumText();
            this.check_QltFlag = new G.Controls.Input.GCheckBox();
            this.check_IsAttributeC = new G.Controls.Input.GCheckBox();
            this.check_IsAttributeB = new G.Controls.Input.GCheckBox();
            this.check_IsAttributeA = new G.Controls.Input.GCheckBox();
            this.txt_BreakPer = new G.Controls.GText();
            this.txt_HelpMarker = new G.Controls.GText();
            this.txt_InvUnit = new G.Controls.GText();
            this.txt_ITEMNAME = new G.Controls.GText();
            this.txt_ITEMDESC = new G.Controls.GText();
            this.txt_Remark = new G.Controls.GText();
            this.txt_ITEMCODE = new G.Controls.GText();
            this.drop_LOCCODE = new G.Controls.GDropDown();
            this.drop_OrgDm = new G.Controls.GDropDown();
            this.drop_FinaClassID = new G.Controls.GDropDown();
            this.drop_InvClassID = new G.Controls.GDropDown();
            this.drop_WRHSCODE = new G.Controls.GDropDown();
            this.gToolBar1 = new G.Controls.GToolBar.GToolBar();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.NUM_SUPPRICE = new G.Controls.GNumText();
            this.DROP_SUPCODE = new G.Controls.GDropDown();
            this.DROP_ITEMTYPE = new G.Controls.GDropDown();
            this.CHECK_ISPUR = new G.Controls.Input.GCheckBox();
            this.TXT_METNAME = new G.Controls.GText();
            this.NUM_WEIGHT = new G.Controls.GNumText();
            this.NUM_ISIZE = new G.Controls.GNumText();
            this.NUM_SCRAPRATE = new G.Controls.GNumText();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_WorkOrdQty
            // 
            this.txt_WorkOrdQty.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_WorkOrdQty.Caption = "派工单批量";
            this.txt_WorkOrdQty.DataType = "Int32";
            this.txt_WorkOrdQty.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_WorkOrdQty.Location = new System.Drawing.Point(485, 396);
            this.txt_WorkOrdQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_WorkOrdQty.Name = "txt_WorkOrdQty";
            this.txt_WorkOrdQty.ReadOnly = false;
            this.txt_WorkOrdQty.Size = new System.Drawing.Size(204, 24);
            this.txt_WorkOrdQty.TabIndex = 11;
            this.txt_WorkOrdQty.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_CertQty
            // 
            this.txt_CertQty.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CertQty.Caption = "合格证批量";
            this.txt_CertQty.DataType = "Int32";
            this.txt_CertQty.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_CertQty.Location = new System.Drawing.Point(485, 364);
            this.txt_CertQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CertQty.Name = "txt_CertQty";
            this.txt_CertQty.ReadOnly = false;
            this.txt_CertQty.Size = new System.Drawing.Size(204, 24);
            this.txt_CertQty.TabIndex = 11;
            this.txt_CertQty.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_SafeStock
            // 
            this.txt_SafeStock.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SafeStock.Caption = "安全库存";
            this.txt_SafeStock.DataType = "Decimal";
            this.txt_SafeStock.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_SafeStock.Location = new System.Drawing.Point(485, 300);
            this.txt_SafeStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SafeStock.Name = "txt_SafeStock";
            this.txt_SafeStock.ReadOnly = false;
            this.txt_SafeStock.Size = new System.Drawing.Size(204, 24);
            this.txt_SafeStock.TabIndex = 11;
            this.txt_SafeStock.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_MaxCap
            // 
            this.txt_MaxCap.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_MaxCap.Caption = "最大产能";
            this.txt_MaxCap.DataType = "Decimal";
            this.txt_MaxCap.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_MaxCap.Location = new System.Drawing.Point(485, 332);
            this.txt_MaxCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaxCap.Name = "txt_MaxCap";
            this.txt_MaxCap.ReadOnly = false;
            this.txt_MaxCap.Size = new System.Drawing.Size(204, 24);
            this.txt_MaxCap.TabIndex = 11;
            this.txt_MaxCap.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_MaxStock
            // 
            this.txt_MaxStock.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_MaxStock.Caption = "最大库存";
            this.txt_MaxStock.DataType = "Decimal";
            this.txt_MaxStock.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_MaxStock.Location = new System.Drawing.Point(485, 268);
            this.txt_MaxStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaxStock.Name = "txt_MaxStock";
            this.txt_MaxStock.ReadOnly = false;
            this.txt_MaxStock.Size = new System.Drawing.Size(204, 24);
            this.txt_MaxStock.TabIndex = 11;
            this.txt_MaxStock.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // check_QltFlag
            // 
            this.check_QltFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_QltFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_QltFlag.Caption = "是否检验";
            this.check_QltFlag.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_QltFlag.ForeColor = System.Drawing.Color.Black;
            this.check_QltFlag.Location = new System.Drawing.Point(563, 98);
            this.check_QltFlag.Name = "check_QltFlag";
            this.check_QltFlag.Padding = new System.Windows.Forms.Padding(1);
            this.check_QltFlag.ReadOnly = false;
            this.check_QltFlag.Size = new System.Drawing.Size(104, 24);
            this.check_QltFlag.TabIndex = 7;
            this.check_QltFlag.Text = "是否检验";
            this.check_QltFlag.UseVisualStyleBackColor = false;
            this.check_QltFlag.Value = null;
            // 
            // check_IsAttributeC
            // 
            this.check_IsAttributeC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_IsAttributeC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_IsAttributeC.Caption = "是否尺寸";
            this.check_IsAttributeC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_IsAttributeC.ForeColor = System.Drawing.Color.Black;
            this.check_IsAttributeC.Location = new System.Drawing.Point(563, 66);
            this.check_IsAttributeC.Name = "check_IsAttributeC";
            this.check_IsAttributeC.Padding = new System.Windows.Forms.Padding(1);
            this.check_IsAttributeC.ReadOnly = false;
            this.check_IsAttributeC.Size = new System.Drawing.Size(104, 24);
            this.check_IsAttributeC.TabIndex = 6;
            this.check_IsAttributeC.Text = "是否尺寸";
            this.check_IsAttributeC.UseVisualStyleBackColor = false;
            this.check_IsAttributeC.Value = null;
            this.check_IsAttributeC.CheckedChanged += new System.EventHandler(this.check_IsAttributeC_CheckedChanged);
            // 
            // check_IsAttributeB
            // 
            this.check_IsAttributeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_IsAttributeB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_IsAttributeB.Caption = "是否花模";
            this.check_IsAttributeB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_IsAttributeB.ForeColor = System.Drawing.Color.Black;
            this.check_IsAttributeB.Location = new System.Drawing.Point(563, 36);
            this.check_IsAttributeB.Name = "check_IsAttributeB";
            this.check_IsAttributeB.Padding = new System.Windows.Forms.Padding(1);
            this.check_IsAttributeB.ReadOnly = false;
            this.check_IsAttributeB.Size = new System.Drawing.Size(104, 24);
            this.check_IsAttributeB.TabIndex = 5;
            this.check_IsAttributeB.Text = "是否花模";
            this.check_IsAttributeB.UseVisualStyleBackColor = false;
            this.check_IsAttributeB.Value = null;
            // 
            // check_IsAttributeA
            // 
            this.check_IsAttributeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_IsAttributeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_IsAttributeA.Caption = "是否色号";
            this.check_IsAttributeA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_IsAttributeA.ForeColor = System.Drawing.Color.Black;
            this.check_IsAttributeA.Location = new System.Drawing.Point(563, 6);
            this.check_IsAttributeA.Name = "check_IsAttributeA";
            this.check_IsAttributeA.Padding = new System.Windows.Forms.Padding(1);
            this.check_IsAttributeA.ReadOnly = false;
            this.check_IsAttributeA.Size = new System.Drawing.Size(104, 24);
            this.check_IsAttributeA.TabIndex = 4;
            this.check_IsAttributeA.Text = "是否色号";
            this.check_IsAttributeA.UseVisualStyleBackColor = false;
            this.check_IsAttributeA.Value = null;
            // 
            // txt_BreakPer
            // 
            this.txt_BreakPer.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_BreakPer.Caption = "折    率";
            this.txt_BreakPer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_BreakPer.Location = new System.Drawing.Point(485, 236);
            this.txt_BreakPer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BreakPer.Multiline = false;
            this.txt_BreakPer.Name = "txt_BreakPer";
            this.txt_BreakPer.ReadOnly = false;
            this.txt_BreakPer.Size = new System.Drawing.Size(204, 24);
            this.txt_BreakPer.TabIndex = 3;
            this.txt_BreakPer.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_HelpMarker
            // 
            this.txt_HelpMarker.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_HelpMarker.Caption = "辅 助 码";
            this.txt_HelpMarker.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_HelpMarker.Location = new System.Drawing.Point(293, 6);
            this.txt_HelpMarker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_HelpMarker.Multiline = false;
            this.txt_HelpMarker.Name = "txt_HelpMarker";
            this.txt_HelpMarker.ReadOnly = false;
            this.txt_HelpMarker.Size = new System.Drawing.Size(169, 24);
            this.txt_HelpMarker.TabIndex = 3;
            this.txt_HelpMarker.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_InvUnit
            // 
            this.txt_InvUnit.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_InvUnit.Caption = "计量单位";
            this.txt_InvUnit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_InvUnit.Location = new System.Drawing.Point(293, 36);
            this.txt_InvUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_InvUnit.Multiline = false;
            this.txt_InvUnit.Name = "txt_InvUnit";
            this.txt_InvUnit.ReadOnly = false;
            this.txt_InvUnit.Size = new System.Drawing.Size(169, 24);
            this.txt_InvUnit.TabIndex = 3;
            this.txt_InvUnit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMNAME
            // 
            this.txt_ITEMNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMNAME.Caption = "物品简称";
            this.txt_ITEMNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMNAME.Location = new System.Drawing.Point(28, 68);
            this.txt_ITEMNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ITEMNAME.Multiline = false;
            this.txt_ITEMNAME.Name = "txt_ITEMNAME";
            this.txt_ITEMNAME.ReadOnly = false;
            this.txt_ITEMNAME.Size = new System.Drawing.Size(241, 24);
            this.txt_ITEMNAME.TabIndex = 3;
            this.txt_ITEMNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMDESC
            // 
            this.txt_ITEMDESC.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMDESC.Caption = "物品名称";
            this.txt_ITEMDESC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMDESC.Location = new System.Drawing.Point(28, 36);
            this.txt_ITEMDESC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ITEMDESC.Multiline = false;
            this.txt_ITEMDESC.Name = "txt_ITEMDESC";
            this.txt_ITEMDESC.ReadOnly = false;
            this.txt_ITEMDESC.Size = new System.Drawing.Size(241, 24);
            this.txt_ITEMDESC.TabIndex = 3;
            this.txt_ITEMDESC.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.txt_ITEMDESC.ValueChanged += new G.Controls.GText.TextEventHandler(this.txt_ITEMDESC_ValueChanged);
            // 
            // txt_Remark
            // 
            this.txt_Remark.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Remark.Caption = "备注";
            this.txt_Remark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Remark.Location = new System.Drawing.Point(28, 268);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.ReadOnly = false;
            this.txt_Remark.Size = new System.Drawing.Size(434, 152);
            this.txt_Remark.TabIndex = 3;
            this.txt_Remark.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // txt_ITEMCODE
            // 
            this.txt_ITEMCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ITEMCODE.Caption = "物品代码";
            this.txt_ITEMCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ITEMCODE.Location = new System.Drawing.Point(28, 4);
            this.txt_ITEMCODE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ITEMCODE.Multiline = false;
            this.txt_ITEMCODE.Name = "txt_ITEMCODE";
            this.txt_ITEMCODE.ReadOnly = false;
            this.txt_ITEMCODE.Size = new System.Drawing.Size(241, 24);
            this.txt_ITEMCODE.TabIndex = 3;
            this.txt_ITEMCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // drop_LOCCODE
            // 
            this.drop_LOCCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_LOCCODE.Caption = "默认库位";
            this.drop_LOCCODE.CustomerDropDownForm = null;
            this.drop_LOCCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_LOCCODE.IsText = false;
            this.drop_LOCCODE.Location = new System.Drawing.Point(28, 129);
            this.drop_LOCCODE.Logic = null;
            this.drop_LOCCODE.Name = "drop_LOCCODE";
            this.drop_LOCCODE.ReadOnly = false;
            this.drop_LOCCODE.Size = new System.Drawing.Size(241, 24);
            this.drop_LOCCODE.TabIndex = 2;
            this.drop_LOCCODE.TextField = "LOCNAME";
            this.drop_LOCCODE.Value = "0";
            this.drop_LOCCODE.ValueField = "LOCCODE";
            this.drop_LOCCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // drop_OrgDm
            // 
            this.drop_OrgDm.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_OrgDm.Caption = "车    间";
            this.drop_OrgDm.CustomerDropDownForm = null;
            this.drop_OrgDm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_OrgDm.IsText = false;
            this.drop_OrgDm.Location = new System.Drawing.Point(485, 205);
            this.drop_OrgDm.Logic = null;
            this.drop_OrgDm.Name = "drop_OrgDm";
            this.drop_OrgDm.ReadOnly = false;
            this.drop_OrgDm.Size = new System.Drawing.Size(203, 24);
            this.drop_OrgDm.TabIndex = 2;
            this.drop_OrgDm.TextField = "WRHSNAME";
            this.drop_OrgDm.Value = "0";
            this.drop_OrgDm.ValueField = "WRHSCODE";
            this.drop_OrgDm.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // drop_FinaClassID
            // 
            this.drop_FinaClassID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_FinaClassID.Caption = "财务类别";
            this.drop_FinaClassID.CustomerDropDownForm = null;
            this.drop_FinaClassID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_FinaClassID.IsText = false;
            this.drop_FinaClassID.Location = new System.Drawing.Point(293, 100);
            this.drop_FinaClassID.Logic = null;
            this.drop_FinaClassID.Name = "drop_FinaClassID";
            this.drop_FinaClassID.ReadOnly = false;
            this.drop_FinaClassID.Size = new System.Drawing.Size(203, 24);
            this.drop_FinaClassID.TabIndex = 2;
            this.drop_FinaClassID.TextField = "FINADESC";
            this.drop_FinaClassID.Value = "0";
            this.drop_FinaClassID.ValueField = "ID";
            this.drop_FinaClassID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // drop_InvClassID
            // 
            this.drop_InvClassID.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_InvClassID.Caption = "库存类别";
            this.drop_InvClassID.CustomerDropDownForm = null;
            this.drop_InvClassID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_InvClassID.IsText = false;
            this.drop_InvClassID.Location = new System.Drawing.Point(293, 68);
            this.drop_InvClassID.Logic = null;
            this.drop_InvClassID.Name = "drop_InvClassID";
            this.drop_InvClassID.ReadOnly = false;
            this.drop_InvClassID.Size = new System.Drawing.Size(203, 24);
            this.drop_InvClassID.TabIndex = 2;
            this.drop_InvClassID.TextField = "InvDesc";
            this.drop_InvClassID.Value = "0";
            this.drop_InvClassID.ValueField = "ID";
            this.drop_InvClassID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // drop_WRHSCODE
            // 
            this.drop_WRHSCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.drop_WRHSCODE.Caption = "默认仓库";
            this.drop_WRHSCODE.CustomerDropDownForm = null;
            this.drop_WRHSCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drop_WRHSCODE.IsText = false;
            this.drop_WRHSCODE.Location = new System.Drawing.Point(28, 99);
            this.drop_WRHSCODE.Logic = null;
            this.drop_WRHSCODE.Name = "drop_WRHSCODE";
            this.drop_WRHSCODE.ReadOnly = false;
            this.drop_WRHSCODE.Size = new System.Drawing.Size(241, 24);
            this.drop_WRHSCODE.TabIndex = 2;
            this.drop_WRHSCODE.TextField = "WRHSNAME";
            this.drop_WRHSCODE.Value = "0";
            this.drop_WRHSCODE.ValueField = "WRHSCODE";
            this.drop_WRHSCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.drop_WRHSCODE.ValueChanged += new System.EventHandler(this.drop_WRHSCODE_ValueChanged);
            // 
            // gToolBar1
            // 
            this.gToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gToolBar1.Location = new System.Drawing.Point(0, 0);
            this.gToolBar1.Name = "gToolBar1";
            this.gToolBar1.Size = new System.Drawing.Size(747, 24);
            this.gToolBar1.TabIndex = 0;
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(185)))));
            this.c1SplitContainer1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(0, 24);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Size = new System.Drawing.Size(747, 454);
            this.c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(185)))));
            this.c1SplitContainer1.TabIndex = 2;
            this.c1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.NUM_SCRAPRATE);
            this.c1SplitterPanel1.Controls.Add(this.NUM_ISIZE);
            this.c1SplitterPanel1.Controls.Add(this.NUM_WEIGHT);
            this.c1SplitterPanel1.Controls.Add(this.TXT_METNAME);
            this.c1SplitterPanel1.Controls.Add(this.CHECK_ISPUR);
            this.c1SplitterPanel1.Controls.Add(this.NUM_SUPPRICE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_SUPCODE);
            this.c1SplitterPanel1.Controls.Add(this.DROP_ITEMTYPE);
            this.c1SplitterPanel1.Controls.Add(this.txt_WorkOrdQty);
            this.c1SplitterPanel1.Controls.Add(this.txt_ITEMCODE);
            this.c1SplitterPanel1.Controls.Add(this.txt_CertQty);
            this.c1SplitterPanel1.Controls.Add(this.drop_WRHSCODE);
            this.c1SplitterPanel1.Controls.Add(this.txt_SafeStock);
            this.c1SplitterPanel1.Controls.Add(this.drop_InvClassID);
            this.c1SplitterPanel1.Controls.Add(this.txt_MaxCap);
            this.c1SplitterPanel1.Controls.Add(this.drop_FinaClassID);
            this.c1SplitterPanel1.Controls.Add(this.txt_MaxStock);
            this.c1SplitterPanel1.Controls.Add(this.drop_OrgDm);
            this.c1SplitterPanel1.Controls.Add(this.drop_LOCCODE);
            this.c1SplitterPanel1.Controls.Add(this.check_QltFlag);
            this.c1SplitterPanel1.Controls.Add(this.txt_Remark);
            this.c1SplitterPanel1.Controls.Add(this.check_IsAttributeC);
            this.c1SplitterPanel1.Controls.Add(this.txt_ITEMDESC);
            this.c1SplitterPanel1.Controls.Add(this.check_IsAttributeB);
            this.c1SplitterPanel1.Controls.Add(this.txt_ITEMNAME);
            this.c1SplitterPanel1.Controls.Add(this.check_IsAttributeA);
            this.c1SplitterPanel1.Controls.Add(this.txt_InvUnit);
            this.c1SplitterPanel1.Controls.Add(this.txt_BreakPer);
            this.c1SplitterPanel1.Controls.Add(this.txt_HelpMarker);
            this.c1SplitterPanel1.HeaderTextAlign = C1.Win.C1SplitContainer.PanelTextAlign.Center;
            this.c1SplitterPanel1.Height = 100;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(747, 433);
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Text = "标题";
            // 
            // NUM_SUPPRICE
            // 
            this.NUM_SUPPRICE.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_SUPPRICE.Caption = "采购单价";
            this.NUM_SUPPRICE.DataType = "Decimal";
            this.NUM_SUPPRICE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_SUPPRICE.Location = new System.Drawing.Point(293, 159);
            this.NUM_SUPPRICE.Name = "NUM_SUPPRICE";
            this.NUM_SUPPRICE.ReadOnly = false;
            this.NUM_SUPPRICE.Size = new System.Drawing.Size(203, 21);
            this.NUM_SUPPRICE.TabIndex = 25;
            this.NUM_SUPPRICE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DROP_SUPCODE
            // 
            this.DROP_SUPCODE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_SUPCODE.Caption = "供应商";
            this.DROP_SUPCODE.CustomerDropDownForm = null;
            this.DROP_SUPCODE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_SUPCODE.IsText = false;
            this.DROP_SUPCODE.Location = new System.Drawing.Point(28, 159);
            this.DROP_SUPCODE.Logic = null;
            this.DROP_SUPCODE.Name = "DROP_SUPCODE";
            this.DROP_SUPCODE.ReadOnly = false;
            this.DROP_SUPCODE.Size = new System.Drawing.Size(241, 24);
            this.DROP_SUPCODE.TabIndex = 13;
            this.DROP_SUPCODE.TextField = "SUPPNAME";
            this.DROP_SUPCODE.Value = "0";
            this.DROP_SUPCODE.ValueField = "SUPPCODE";
            this.DROP_SUPCODE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // DROP_ITEMTYPE
            // 
            this.DROP_ITEMTYPE.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.DROP_ITEMTYPE.Caption = "物品类别";
            this.DROP_ITEMTYPE.CustomerDropDownForm = null;
            this.DROP_ITEMTYPE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DROP_ITEMTYPE.IsText = false;
            this.DROP_ITEMTYPE.Location = new System.Drawing.Point(293, 129);
            this.DROP_ITEMTYPE.Logic = null;
            this.DROP_ITEMTYPE.Name = "DROP_ITEMTYPE";
            this.DROP_ITEMTYPE.ReadOnly = false;
            this.DROP_ITEMTYPE.Size = new System.Drawing.Size(203, 24);
            this.DROP_ITEMTYPE.TabIndex = 12;
            this.DROP_ITEMTYPE.TextField = "ITEMTYPENAME";
            this.DROP_ITEMTYPE.Value = "0";
            this.DROP_ITEMTYPE.ValueField = "Id";
            this.DROP_ITEMTYPE.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // CHECK_ISPUR
            // 
            this.CHECK_ISPUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CHECK_ISPUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHECK_ISPUR.Caption = "是否采购";
            this.CHECK_ISPUR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHECK_ISPUR.ForeColor = System.Drawing.Color.Black;
            this.CHECK_ISPUR.Location = new System.Drawing.Point(563, 128);
            this.CHECK_ISPUR.Name = "CHECK_ISPUR";
            this.CHECK_ISPUR.Padding = new System.Windows.Forms.Padding(1);
            this.CHECK_ISPUR.ReadOnly = false;
            this.CHECK_ISPUR.Size = new System.Drawing.Size(104, 24);
            this.CHECK_ISPUR.TabIndex = 26;
            this.CHECK_ISPUR.Text = "是否采购";
            this.CHECK_ISPUR.UseVisualStyleBackColor = false;
            this.CHECK_ISPUR.Value = null;
            // 
            // TXT_METNAME
            // 
            this.TXT_METNAME.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_METNAME.Caption = "材料名称";
            this.TXT_METNAME.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_METNAME.Location = new System.Drawing.Point(28, 205);
            this.TXT_METNAME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_METNAME.Multiline = false;
            this.TXT_METNAME.Name = "TXT_METNAME";
            this.TXT_METNAME.ReadOnly = false;
            this.TXT_METNAME.Size = new System.Drawing.Size(241, 24);
            this.TXT_METNAME.TabIndex = 27;
            this.TXT_METNAME.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // NUM_WEIGHT
            // 
            this.NUM_WEIGHT.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_WEIGHT.Caption = "克重";
            this.NUM_WEIGHT.DataType = "Decimal";
            this.NUM_WEIGHT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_WEIGHT.Location = new System.Drawing.Point(293, 208);
            this.NUM_WEIGHT.Name = "NUM_WEIGHT";
            this.NUM_WEIGHT.ReadOnly = false;
            this.NUM_WEIGHT.Size = new System.Drawing.Size(169, 21);
            this.NUM_WEIGHT.TabIndex = 28;
            this.NUM_WEIGHT.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_ISIZE
            // 
            this.NUM_ISIZE.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_ISIZE.Caption = "规格";
            this.NUM_ISIZE.DataType = "Decimal";
            this.NUM_ISIZE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_ISIZE.Location = new System.Drawing.Point(28, 239);
            this.NUM_ISIZE.Name = "NUM_ISIZE";
            this.NUM_ISIZE.ReadOnly = false;
            this.NUM_ISIZE.Size = new System.Drawing.Size(181, 21);
            this.NUM_ISIZE.TabIndex = 29;
            this.NUM_ISIZE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // NUM_SCRAPRATE
            // 
            this.NUM_SCRAPRATE.Align = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_SCRAPRATE.Caption = "废料比列";
            this.NUM_SCRAPRATE.DataType = "Decimal";
            this.NUM_SCRAPRATE.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUM_SCRAPRATE.Location = new System.Drawing.Point(293, 240);
            this.NUM_SCRAPRATE.Name = "NUM_SCRAPRATE";
            this.NUM_SCRAPRATE.ReadOnly = false;
            this.NUM_SCRAPRATE.Size = new System.Drawing.Size(169, 21);
            this.NUM_SCRAPRATE.TabIndex = 30;
            this.NUM_SCRAPRATE.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // DM_ITEMEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 478);
            this.Controls.Add(this.c1SplitContainer1);
            this.Controls.Add(this.gToolBar1);
            this.Name = "DM_ITEMEDIT";
            this.Text = "title";
            this.Load += new System.EventHandler(this.EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GToolBar.GToolBar gToolBar1;
        private Controls.GDropDown drop_WRHSCODE;
        private Controls.GText txt_ITEMCODE;
        private Controls.GText txt_ITEMDESC;
        private Controls.GDropDown drop_LOCCODE;
        private Controls.GText txt_ITEMNAME;
        private Controls.GText txt_InvUnit;
        private Controls.GDropDown drop_FinaClassID;
        private Controls.GDropDown drop_InvClassID;
        private Controls.GDropDown drop_OrgDm;
        private Controls.GText txt_BreakPer;
        private Controls.Input.GCheckBox check_IsAttributeA;
        private Controls.Input.GCheckBox check_IsAttributeB;
        private Controls.Input.GCheckBox check_IsAttributeC;
        private Controls.Input.GCheckBox check_QltFlag;
        private Controls.GNumText txt_MaxStock;
        private Controls.GNumText txt_SafeStock;
        private Controls.GNumText txt_CertQty;
        private Controls.GNumText txt_MaxCap;
        private Controls.GNumText txt_WorkOrdQty;
        private Controls.GText txt_Remark;
        private Controls.GText txt_HelpMarker;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private Controls.GDropDown DROP_ITEMTYPE;
        private Controls.GDropDown DROP_SUPCODE;
        private Controls.GNumText NUM_SUPPRICE;
        private Controls.GNumText NUM_SCRAPRATE;
        private Controls.GNumText NUM_ISIZE;
        private Controls.GNumText NUM_WEIGHT;
        private Controls.GText TXT_METNAME;
        private Controls.Input.GCheckBox CHECK_ISPUR;

    }
}