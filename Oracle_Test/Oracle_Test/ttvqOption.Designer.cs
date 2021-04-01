namespace Oracle_Test
{
    partial class ttvqOption
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
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_btn
            // 
            this.user_btn.BackColor = System.Drawing.Color.Snow;
            this.user_btn.Location = new System.Drawing.Point(98, 74);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(390, 191);
            this.user_btn.TabIndex = 1;
            this.user_btn.Text = "USER";
            this.user_btn.UseVisualStyleBackColor = false;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // role_btn
            // 
            this.role_btn.BackColor = System.Drawing.Color.Snow;
            this.role_btn.Location = new System.Drawing.Point(564, 74);
            this.role_btn.Name = "role_btn";
            this.role_btn.Size = new System.Drawing.Size(390, 191);
            this.role_btn.TabIndex = 2;
            this.role_btn.Text = "ROLE";
            this.role_btn.UseVisualStyleBackColor = false;
            this.role_btn.Click += new System.EventHandler(this.role_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(0, 333);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ttvqOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1115, 407);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.role_btn);
            this.Controls.Add(this.user_btn);
            this.Name = "ttvqOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ttvqOption";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Button role_btn;
        private System.Windows.Forms.Button back_btn;
    }
}