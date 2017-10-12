namespace G.Controls.GToolBar
{
    partial class GToolBar
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
            this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
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
            this.c1ToolBar1.Size = new System.Drawing.Size(540, 24);
            this.c1ToolBar1.Text = "c1ToolBar1";
            this.c1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Owner = this;
            // 
            // GToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1ToolBar1);
            this.Name = "GToolBar";
            this.Size = new System.Drawing.Size(540, 43);
            this.Resize += new System.EventHandler(this.GToolBar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1ToolBar c1ToolBar1;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
    }
}
