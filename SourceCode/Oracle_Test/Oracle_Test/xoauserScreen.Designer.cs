namespace Oracle_Test
{
    partial class xoauserScreen
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
            this.xoa_btn = new System.Windows.Forms.Button();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xoa_btn
            // 
            this.xoa_btn.Location = new System.Drawing.Point(849, 171);
            this.xoa_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(247, 108);
            this.xoa_btn.TabIndex = 9;
            this.xoa_btn.Text = "XÓA USER";
            this.xoa_btn.UseVisualStyleBackColor = true;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(402, 74);
            this.username_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(694, 44);
            this.username_text.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 94);
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
            this.back_btn.Location = new System.Drawing.Point(-6, 279);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // xoauserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1169, 350);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label1);
            this.Name = "xoauserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XÓA USER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}