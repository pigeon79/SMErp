namespace G.Erp.BaseData
{
    partial class PriceCacu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceCacu));
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.comb_Type = new G.Controls.GCombo();
            this.TXT_WEIGHT = new G.Controls.GNumText();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(248, 23);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(248, 69);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // comb_Type
            // 
            this.comb_Type.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.comb_Type.Caption = "类型";
            this.comb_Type.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("comb_Type.Columns")));
            this.comb_Type.Data = "五金:五金,橡胶:橡胶";
            this.comb_Type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_Type.Location = new System.Drawing.Point(44, 23);
            this.comb_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comb_Type.Name = "comb_Type";
            this.comb_Type.ReadOnly = false;
            this.comb_Type.Size = new System.Drawing.Size(156, 22);
            this.comb_Type.TabIndex = 15;
            this.comb_Type.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            // 
            // TXT_WEIGHT
            // 
            this.TXT_WEIGHT.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_WEIGHT.Caption = "重量";
            this.TXT_WEIGHT.DataType = "Decimal";
            this.TXT_WEIGHT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_WEIGHT.Location = new System.Drawing.Point(44, 54);
            this.TXT_WEIGHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_WEIGHT.Name = "TXT_WEIGHT";
            this.TXT_WEIGHT.ReadOnly = false;
            this.TXT_WEIGHT.Size = new System.Drawing.Size(156, 24);
            this.TXT_WEIGHT.TabIndex = 14;
            this.TXT_WEIGHT.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.TXT_WEIGHT.ValueChanged += new G.Controls.GNumText.TextEventHandler(this.TXT_WEIGHT_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 16;
            // 
            // PriceCacu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 134);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comb_Type);
            this.Controls.Add(this.TXT_WEIGHT);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "PriceCacu";
            this.ShowIcon = false;
            this.Text = "计算";
            this.PostChanges += new System.EventHandler(this.PriceCacu_PostChanges);
            this.Load += new System.EventHandler(this.PriceCacu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private Controls.GCombo comb_Type;
        private Controls.GNumText TXT_WEIGHT;
        private System.Windows.Forms.Label label1;

    }
}