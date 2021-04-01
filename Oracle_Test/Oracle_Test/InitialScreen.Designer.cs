namespace Oracle_Test
{
    partial class InitialScreen
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
            this.ttk_btn = new System.Windows.Forms.Button();
            this.dn_btn = new System.Windows.Forms.Button();
            this.cn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttk_btn
            // 
            this.ttk_btn.Location = new System.Drawing.Point(89, 75);
            this.ttk_btn.Name = "ttk_btn";
            this.ttk_btn.Size = new System.Drawing.Size(335, 187);
            this.ttk_btn.TabIndex = 0;
            this.ttk_btn.Text = "Tạo tài khoản";
            this.ttk_btn.UseVisualStyleBackColor = true;
            // 
            // dn_btn
            // 
            this.dn_btn.Location = new System.Drawing.Point(560, 75);
            this.dn_btn.Name = "dn_btn";
            this.dn_btn.Size = new System.Drawing.Size(335, 187);
            this.dn_btn.TabIndex = 1;
            this.dn_btn.Text = "Đăng nhập";
            this.dn_btn.UseVisualStyleBackColor = true;
            this.dn_btn.Click += new System.EventHandler(this.dn_btn_Click);
            // 
            // cn_btn
            // 
            this.cn_btn.Location = new System.Drawing.Point(1042, 75);
            this.cn_btn.Name = "cn_btn";
            this.cn_btn.Size = new System.Drawing.Size(335, 187);
            this.cn_btn.TabIndex = 2;
            this.cn_btn.Text = "Chức năng";
            this.cn_btn.UseVisualStyleBackColor = true;
            this.cn_btn.Click += new System.EventHandler(this.cn_btn_Click);
            // 
            // InitialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 468);
            this.Controls.Add(this.cn_btn);
            this.Controls.Add(this.dn_btn);
            this.Controls.Add(this.ttk_btn);
            this.Name = "InitialScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ttk_btn;
        private System.Windows.Forms.Button dn_btn;
        private System.Windows.Forms.Button cn_btn;
    }
}