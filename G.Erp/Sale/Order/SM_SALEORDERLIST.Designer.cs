﻿namespace G.Erp.Sale.Order
{
    partial class SM_SALEORDERLIST
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
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.SuspendLayout();
            // 
            // gGrid1
            // 
            this.gGrid1.AutoGenerateColumns = false;
            this.gGrid1.Rows.DefaultSize = 20;
            this.gGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            // 
            // SM_SALEORDERLIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 387);
            this.Name = "SM_SALEORDERLIST";
            this.Text = "SM_SALEORDERLIST";
            ((System.ComponentModel.ISupportInitialize)(this.gGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}