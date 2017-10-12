namespace G.Controls
{
    partial class GCombo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCombo));
            this.label1 = new System.Windows.Forms.Label();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.AutoCompletion = true;
            this.c1Combo1.AutoDropDown = true;
            this.c1Combo1.AutoSelect = true;
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 18;
            this.c1Combo1.ColumnFooterHeight = 18;
            this.c1Combo1.ContentHeight = 16;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 16;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(36, 0);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(108, 22);
            this.c1Combo1.TabIndex = 3;
            this.c1Combo1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.c1Combo1.TextChanged += new System.EventHandler(this.c1Combo1_TextChanged);
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // GCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Combo1);
            this.Controls.Add(this.label1);
            this.Name = "GCombo";
            this.Size = new System.Drawing.Size(144, 23);
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private C1.Win.C1List.C1Combo c1Combo1;
    }
}
