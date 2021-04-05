namespace Oracle_Test
{
    partial class Login
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
            this.dangnhap_btn = new System.Windows.Forms.Button();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.thoat_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dangnhap_btn
            // 
            this.dangnhap_btn.Location = new System.Drawing.Point(748, 387);
            this.dangnhap_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dangnhap_btn.Name = "dangnhap_btn";
            this.dangnhap_btn.Size = new System.Drawing.Size(307, 108);
            this.dangnhap_btn.TabIndex = 12;
            this.dangnhap_btn.Text = "ĐĂNG NHẬP";
            this.dangnhap_btn.UseVisualStyleBackColor = true;
            this.dangnhap_btn.Click += new System.EventHandler(this.dangnhap_btn_Click);
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(361, 108);
            this.username_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(694, 44);
            this.username_text.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "USERNAME";
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(361, 250);
            this.password_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(694, 44);
            this.password_text.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "PASSWORD";
            // 
            // thoat_btn
            // 
            this.thoat_btn.Location = new System.Drawing.Point(95, 387);
            this.thoat_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.thoat_btn.Name = "thoat_btn";
            this.thoat_btn.Size = new System.Drawing.Size(307, 108);
            this.thoat_btn.TabIndex = 15;
            this.thoat_btn.Text = "THOÁT";
            this.thoat_btn.UseVisualStyleBackColor = true;
            this.thoat_btn.Click += new System.EventHandler(this.thoat_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1153, 572);
            this.Controls.Add(this.thoat_btn);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dangnhap_btn);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dangnhap_btn;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button thoat_btn;
    }
}