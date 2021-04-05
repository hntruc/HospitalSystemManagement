namespace Oracle_Test
{
    partial class thuHoiRoleScreen
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
            this.thuhoi_btn = new System.Windows.Forms.Button();
            this.role_text = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thuhoi_btn
            // 
            this.thuhoi_btn.Location = new System.Drawing.Point(834, 280);
            this.thuhoi_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.thuhoi_btn.Name = "thuhoi_btn";
            this.thuhoi_btn.Size = new System.Drawing.Size(247, 108);
            this.thuhoi_btn.TabIndex = 9;
            this.thuhoi_btn.Text = "THU HỒI";
            this.thuhoi_btn.UseVisualStyleBackColor = true;
            this.thuhoi_btn.Click += new System.EventHandler(this.thuhoi_btn_Click);
            // 
            // role_text
            // 
            this.role_text.Location = new System.Drawing.Point(378, 197);
            this.role_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.role_text.Name = "role_text";
            this.role_text.Size = new System.Drawing.Size(694, 44);
            this.role_text.TabIndex = 8;
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(378, 92);
            this.username_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(694, 44);
            this.username_text.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "ROLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "USERNAME";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(0, 409);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // thuHoiRoleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1147, 488);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.thuhoi_btn);
            this.Controls.Add(this.role_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "thuHoiRoleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THU HỒI ROLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thuhoi_btn;
        private System.Windows.Forms.TextBox role_text;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}