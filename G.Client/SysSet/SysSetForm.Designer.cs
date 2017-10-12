namespace G.Client.SysSet
{
    partial class SysSetForm
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
            this.gText1 = new G.Controls.GText();
            this.gText2 = new G.Controls.GText();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            this.SuspendLayout();
            // 
            // c1Button1
            // 
            this.c1Button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c1Button1.Location = new System.Drawing.Point(419, 103);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(93, 29);
            this.c1Button1.TabIndex = 1;
            this.c1Button1.Text = "设置";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // gText1
            // 
            this.gText1.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.gText1.Caption = "参数名";
            this.gText1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gText1.Location = new System.Drawing.Point(104, 43);
            this.gText1.Multiline = false;
            this.gText1.Name = "gText1";
            this.gText1.ReadOnly = false;
            this.gText1.Size = new System.Drawing.Size(272, 21);
            this.gText1.TabIndex = 2;
            this.gText1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // gText2
            // 
            this.gText2.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.gText2.Caption = "参数值";
            this.gText2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gText2.Location = new System.Drawing.Point(104, 103);
            this.gText2.Multiline = false;
            this.gText2.Name = "gText2";
            this.gText2.ReadOnly = false;
            this.gText2.Size = new System.Drawing.Size(272, 21);
            this.gText2.TabIndex = 2;
            this.gText2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // c1Button2
            // 
            this.c1Button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c1Button2.Location = new System.Drawing.Point(419, 43);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(93, 29);
            this.c1Button2.TabIndex = 1;
            this.c1Button2.Text = "获取";
            this.c1Button2.UseVisualStyleBackColor = true;
            this.c1Button2.Click += new System.EventHandler(this.c1Button2_Click);
            // 
            // SysSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 305);
            this.Controls.Add(this.gText2);
            this.Controls.Add(this.gText1);
            this.Controls.Add(this.c1Button2);
            this.Controls.Add(this.c1Button1);
            this.Name = "SysSetForm";
            this.Text = "系统设置";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1Button c1Button1;
        private Controls.GText gText1;
        private Controls.GText gText2;
        private C1.Win.C1Input.C1Button c1Button2;

    }
}