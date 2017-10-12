namespace G.Client.Sys
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_login = new C1.Win.C1Input.C1Button();
            this.btn_cancel = new C1.Win.C1Input.C1Button();
            this.c1PictureBox1 = new C1.Win.C1Input.C1PictureBox();
            this.check_rem = new C1.Win.C1Input.C1CheckBox();
            this.txt_password = new G.Controls.GText();
            this.txt_logname = new G.Controls.GText();
            this.comb_zt = new G.Controls.GCombo();
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(207, 153);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.btn_login.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(319, 153);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "退出";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.btn_cancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // c1PictureBox1
            // 
            this.c1PictureBox1.Location = new System.Drawing.Point(13, 13);
            this.c1PictureBox1.Name = "c1PictureBox1";
            this.c1PictureBox1.Size = new System.Drawing.Size(166, 163);
            this.c1PictureBox1.TabIndex = 3;
            this.c1PictureBox1.TabStop = false;
            // 
            // check_rem
            // 
            this.check_rem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.check_rem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_rem.ForeColor = System.Drawing.Color.Black;
            this.check_rem.Location = new System.Drawing.Point(250, 116);
            this.check_rem.Name = "check_rem";
            this.check_rem.Padding = new System.Windows.Forms.Padding(1);
            this.check_rem.Size = new System.Drawing.Size(104, 24);
            this.check_rem.TabIndex = 6;
            this.check_rem.Text = "记住密码";
            this.check_rem.UseVisualStyleBackColor = false;
            this.check_rem.Value = null;
            // 
            // txt_password
            // 
            this.txt_password.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.Caption = "密  码：";
            this.txt_password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.Location = new System.Drawing.Point(185, 82);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.ReadOnly = false;
            this.txt_password.Size = new System.Drawing.Size(240, 21);
            this.txt_password.TabIndex = 3;
            this.txt_password.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // txt_logname
            // 
            this.txt_logname.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_logname.Caption = "登录名：";
            this.txt_logname.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_logname.Location = new System.Drawing.Point(185, 49);
            this.txt_logname.Multiline = false;
            this.txt_logname.Name = "txt_logname";
            this.txt_logname.ReadOnly = false;
            this.txt_logname.Size = new System.Drawing.Size(240, 21);
            this.txt_logname.TabIndex = 2;
            this.txt_logname.VisualStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // comb_zt
            // 
            this.comb_zt.Align = System.Windows.Forms.HorizontalAlignment.Left;
            this.comb_zt.Caption = "账  套：";
            this.comb_zt.Columns = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("comb_zt.Columns")));
            this.comb_zt.Data = "";
            this.comb_zt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_zt.Location = new System.Drawing.Point(185, 13);
            this.comb_zt.Name = "comb_zt";
            this.comb_zt.ReadOnly = false;
            this.comb_zt.Size = new System.Drawing.Size(240, 22);
            this.comb_zt.TabIndex = 1;
            this.comb_zt.VisualStyle = C1.Win.C1List.VisualStyle.Custom;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 192);
            this.Controls.Add(this.check_rem);
            this.Controls.Add(this.c1PictureBox1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_logname);
            this.Controls.Add(this.comb_zt);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1Button btn_login;
        private C1.Win.C1Input.C1Button btn_cancel;
        private Controls.GCombo comb_zt;
        private Controls.GText txt_logname;
        private Controls.GText txt_password;
        private C1.Win.C1Input.C1PictureBox c1PictureBox1;
        private C1.Win.C1Input.C1CheckBox check_rem;
    }
}