namespace Oracle_Test
{
    partial class capRoleUserPolicyScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cq_btn = new System.Windows.Forms.Button();
            this.role_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "ROLE";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(302, 83);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(603, 44);
            this.username_text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 77);
            this.button1.TabIndex = 15;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cq_btn
            // 
            this.cq_btn.Location = new System.Drawing.Point(674, 276);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(231, 88);
            this.cq_btn.TabIndex = 16;
            this.cq_btn.Text = "CẤP ROLE";
            this.cq_btn.UseVisualStyleBackColor = true;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // role_combo
            // 
            this.role_combo.FormattingEnabled = true;
            this.role_combo.Location = new System.Drawing.Point(302, 174);
            this.role_combo.Name = "role_combo";
            this.role_combo.Size = new System.Drawing.Size(603, 45);
            this.role_combo.TabIndex = 17;
            this.role_combo.SelectedIndexChanged += new System.EventHandler(this.role_combo_SelectedIndexChanged);
            // 
            // capRoleUserPolicyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(977, 508);
            this.Controls.Add(this.role_combo);
            this.Controls.Add(this.cq_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label1);
            this.Name = "capRoleUserPolicyScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤP ROLE";
            this.Load += new System.EventHandler(this.capRoleUserPolicyScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cq_btn;
        private System.Windows.Forms.ComboBox role_combo;
    }
}