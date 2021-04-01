namespace Oracle_Test
{
    partial class thqOption
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
            this.role_btn = new System.Windows.Forms.Button();
            this.user_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // role_btn
            // 
            this.role_btn.BackColor = System.Drawing.Color.Snow;
            this.role_btn.Location = new System.Drawing.Point(575, 83);
            this.role_btn.Name = "role_btn";
            this.role_btn.Size = new System.Drawing.Size(388, 191);
            this.role_btn.TabIndex = 4;
            this.role_btn.Text = "ROLE";
            this.role_btn.UseVisualStyleBackColor = false;
            this.role_btn.Click += new System.EventHandler(this.role_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.BackColor = System.Drawing.Color.Snow;
            this.user_btn.Location = new System.Drawing.Point(109, 83);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(388, 191);
            this.user_btn.TabIndex = 3;
            this.user_btn.Text = "USER";
            this.user_btn.UseVisualStyleBackColor = false;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // thqOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1069, 370);
            this.Controls.Add(this.role_btn);
            this.Controls.Add(this.user_btn);
            this.Name = "thqOption";
            this.Text = "thqOption";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button role_btn;
        private System.Windows.Forms.Button user_btn;
    }
}