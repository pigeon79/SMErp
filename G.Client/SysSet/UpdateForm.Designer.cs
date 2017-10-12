namespace G.Client.SysSet
{
    partial class UpdateForm
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
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            this.SuspendLayout();
            // 
            // c1Button1
            // 
            this.c1Button1.Enabled = false;
            this.c1Button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c1Button1.Location = new System.Drawing.Point(87, 50);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(142, 69);
            this.c1Button1.TabIndex = 0;
            this.c1Button1.Text = "升级";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // c1Button2
            // 
            this.c1Button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c1Button2.Location = new System.Drawing.Point(109, 165);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(97, 29);
            this.c1Button2.TabIndex = 0;
            this.c1Button2.Text = "检测升级";
            this.c1Button2.UseVisualStyleBackColor = true;
            this.c1Button2.Click += new System.EventHandler(this.c1Button2_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 237);
            this.Controls.Add(this.c1Button2);
            this.Controls.Add(this.c1Button1);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "升级";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1Button c1Button1;
        private C1.Win.C1Input.C1Button c1Button2;
    }
}