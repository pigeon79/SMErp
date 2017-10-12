namespace G.Controls
{
    partial class DefaultDropDownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultDropDownForm));
            this.messageLabel = new System.Windows.Forms.Label();
            this.innerList = new C1.Win.C1List.C1List();
            ((System.ComponentModel.ISupportInitialize)(this.innerList)).BeginInit();
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
            this.messageLabel.Text = "label1";
            // 
            // innerList
            // 
            this.innerList.AddItemSeparator = ';';
            this.innerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.innerList.Caption = "";
            this.innerList.CaptionHeight = 18;
            this.innerList.ColumnCaptionHeight = 18;
            this.innerList.ColumnFooterHeight = 18;
            this.innerList.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
            this.innerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerList.Images.Add(((System.Drawing.Image)(resources.GetObject("innerList.Images"))));
            this.innerList.ItemHeight = 16;
            this.innerList.Location = new System.Drawing.Point(0, 0);
            this.innerList.MatchEntryTimeout = ((long)(2000));
            this.innerList.Name = "innerList";
            this.innerList.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.innerList.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.innerList.PreviewInfo.ZoomFactor = 75D;
            this.innerList.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("innerList.PrintInfo.PageSettings")));
            this.innerList.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.innerList.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.innerList.ShowHeaderCheckBox = false;
            this.innerList.Size = new System.Drawing.Size(304, 269);
            this.innerList.TabIndex = 2;
            this.innerList.Text = "c1List1";
            this.innerList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.innerList_MouseClick);
            this.innerList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.innerList_MouseMove);
            this.innerList.PropBag = resources.GetString("innerList.PropBag");
            // 
            // DefaultDropDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.innerList);
            this.Controls.Add(this.messageLabel);
            this.Name = "DefaultDropDownForm";
            this.Options = ((C1.Win.C1Input.DropDownFormOptionsFlags)((C1.Win.C1Input.DropDownFormOptionsFlags.FixedWidth | C1.Win.C1Input.DropDownFormOptionsFlags.FixedHeight)));
            this.Text = "数据检索";
            ((System.ComponentModel.ISupportInitialize)(this.innerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private C1.Win.C1List.C1List innerList;

    }
}