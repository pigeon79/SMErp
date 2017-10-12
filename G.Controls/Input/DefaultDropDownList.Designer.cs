namespace G.Controls.Input
{
    partial class DefaultDropDownList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultDropDownList));
            this.messageLabel = new System.Windows.Forms.Label();
            this.gGrid1 = new G.Controls.GGrid.GGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageLabel.Location = new System.Drawing.Point(0, 269);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(304, 12);
            this.messageLabel.TabIndex = 1;
            // 
            // gGrid1
            // 
            this.gGrid1.AllowEditing = false;
            this.gGrid1.AutoGenerateColumns = false;
            this.gGrid1.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.gGrid1.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.gGrid1.FrozenCell = 0;
            this.gGrid1.Location = new System.Drawing.Point(0, 0);
            this.gGrid1.Name = "gGrid1";
            this.gGrid1.NegativeRed = false;
            this.gGrid1.Rows.DefaultSize = 20;
            this.gGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.gGrid1.Size = new System.Drawing.Size(304, 269);
            this.gGrid1.StyleInfo = resources.GetString("gGrid1.StyleInfo");
            this.gGrid1.TabIndex = 2;
            this.gGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid1.SelChange += new System.EventHandler(this.gGrid1_SelChange);
            this.gGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gGrid1_MouseClick);
            // 
            // DefaultDropDownList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.gGrid1);
            this.Controls.Add(this.messageLabel);
            this.Name = "DefaultDropDownList";
            this.Text = "数据检索";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        public GGrid.GGrid gGrid1;

    }
}