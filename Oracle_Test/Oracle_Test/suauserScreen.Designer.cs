namespace Oracle_Test
{
    partial class suauserScreen
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
            this.thaydoi_btn = new System.Windows.Forms.Button();
            this.password_text = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thaydoi_btn
            // 
            this.thaydoi_btn.Location = new System.Drawing.Point(859, 267);
            this.thaydoi_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.thaydoi_btn.Name = "thaydoi_btn";
            this.thaydoi_btn.Size = new System.Drawing.Size(247, 108);
            this.thaydoi_btn.TabIndex = 9;
            this.thaydoi_btn.Text = "THAY ĐỔI ";
            this.thaydoi_btn.UseVisualStyleBackColor = true;
            this.thaydoi_btn.Click += new System.EventHandler(this.thaydoi_btn_Click);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(403, 184);
            this.password_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(694, 44);
            this.password_text.TabIndex = 8;
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(403, 79);
            this.username_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(694, 44);
            this.username_text.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "MẬT KHẨU MỚI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "USERNAME";
            // 
            // suauserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 446);
            this.Controls.Add(this.thaydoi_btn);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "suauserScreen";
            this.Text = "suauserScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thaydoi_btn;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}