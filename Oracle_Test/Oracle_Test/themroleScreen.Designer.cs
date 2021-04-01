namespace Oracle_Test
{
    partial class themroleScreen
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
            this.them_btn = new System.Windows.Forms.Button();
            this.role_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // them_btn
            // 
            this.them_btn.Location = new System.Drawing.Point(856, 270);
            this.them_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(247, 108);
            this.them_btn.TabIndex = 9;
            this.them_btn.Text = "TẠO ROLE";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // role_text
            // 
            this.role_text.Location = new System.Drawing.Point(400, 82);
            this.role_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.role_text.Name = "role_text";
            this.role_text.Size = new System.Drawing.Size(694, 44);
            this.role_text.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "ROLE";
            // 
            // themroleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 438);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.role_text);
            this.Controls.Add(this.label1);
            this.Name = "themroleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themroleScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.TextBox role_text;
        private System.Windows.Forms.Label label1;
    }
}