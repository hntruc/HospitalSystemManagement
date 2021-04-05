namespace Oracle_Test
{
    partial class capRoleUserScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.role_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cq_btn = new System.Windows.Forms.Button();
            this.y_radio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(260, 80);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(603, 44);
            this.username_text.TabIndex = 1;
            // 
            // role_text
            // 
            this.role_text.Location = new System.Drawing.Point(260, 171);
            this.role_text.Name = "role_text";
            this.role_text.Size = new System.Drawing.Size(603, 44);
            this.role_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "ROLE";
            // 
            // cq_btn
            // 
            this.cq_btn.Location = new System.Drawing.Point(630, 376);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(231, 88);
            this.cq_btn.TabIndex = 4;
            this.cq_btn.Text = "CẤP ROLE";
            this.cq_btn.UseVisualStyleBackColor = true;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // y_radio
            // 
            this.y_radio.AutoSize = true;
            this.y_radio.Location = new System.Drawing.Point(260, 270);
            this.y_radio.Name = "y_radio";
            this.y_radio.Size = new System.Drawing.Size(397, 41);
            this.y_radio.TabIndex = 5;
            this.y_radio.TabStop = true;
            this.y_radio.Text = "WITH GRANT OPTION";
            this.y_radio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 487);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 77);
            this.button1.TabIndex = 14;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // capRoleUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1115, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.y_radio);
            this.Controls.Add(this.cq_btn);
            this.Controls.Add(this.role_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label1);
            this.Name = "capRoleUserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤP ROLE CHO USER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox role_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cq_btn;
        private System.Windows.Forms.RadioButton y_radio;
        private System.Windows.Forms.Button button1;
    }
}