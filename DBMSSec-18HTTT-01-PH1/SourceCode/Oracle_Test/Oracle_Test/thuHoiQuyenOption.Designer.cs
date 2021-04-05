namespace Oracle_Test
{
    partial class thuHoiQuyenOption
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
            this.user_btn = new System.Windows.Forms.Button();
            this.role_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_btn
            // 
            this.user_btn.Location = new System.Drawing.Point(155, 48);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(450, 199);
            this.user_btn.TabIndex = 15;
            this.user_btn.Text = "USER";
            this.user_btn.UseVisualStyleBackColor = true;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // role_btn
            // 
            this.role_btn.Location = new System.Drawing.Point(155, 308);
            this.role_btn.Name = "role_btn";
            this.role_btn.Size = new System.Drawing.Size(450, 199);
            this.role_btn.TabIndex = 16;
            this.role_btn.Text = "ROLE";
            this.role_btn.UseVisualStyleBackColor = true;
            this.role_btn.Click += new System.EventHandler(this.role_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(2, 516);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 77);
            this.button3.TabIndex = 15;
            this.button3.Text = "⬅";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // thuHoiQuyenOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(758, 596);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.role_btn);
            this.Controls.Add(this.user_btn);
            this.Name = "thuHoiQuyenOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỨC NĂNG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Button role_btn;
        private System.Windows.Forms.Button button3;
    }
}