namespace G.Erp
{
    partial class Form2
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
            this.gGrid2 = new G.Controls.GGrid.GGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // gGrid2
            // 
            this.gGrid2.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.gGrid2.CurVisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.gGrid2.Location = new System.Drawing.Point(45, 58);
            this.gGrid2.Name = "gGrid2";
            this.gGrid2.NegativeRed = false;
            this.gGrid2.Rows.DefaultSize = 20;
            this.gGrid2.Size = new System.Drawing.Size(240, 150);
            this.gGrid2.TabIndex = 0;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gGrid2);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GGrid.GGrid gGrid2;
    }
}