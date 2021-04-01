namespace Oracle_Test
{
    partial class txsur_role_Option
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
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.them_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sua_btn
            // 
            this.sua_btn.BackColor = System.Drawing.Color.Snow;
            this.sua_btn.Location = new System.Drawing.Point(1086, 91);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(390, 191);
            this.sua_btn.TabIndex = 8;
            this.sua_btn.Text = "SỬA";
            this.sua_btn.UseVisualStyleBackColor = false;
            // 
            // xoa_btn
            // 
            this.xoa_btn.BackColor = System.Drawing.Color.Snow;
            this.xoa_btn.Location = new System.Drawing.Point(621, 91);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(390, 191);
            this.xoa_btn.TabIndex = 7;
            this.xoa_btn.Text = "XÓA";
            this.xoa_btn.UseVisualStyleBackColor = false;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // them_btn
            // 
            this.them_btn.BackColor = System.Drawing.Color.Snow;
            this.them_btn.Location = new System.Drawing.Point(155, 91);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(390, 191);
            this.them_btn.TabIndex = 6;
            this.them_btn.Text = "THÊM";
            this.them_btn.UseVisualStyleBackColor = false;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(0, 339);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // txsur_role_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 418);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.them_btn);
            this.Name = "txsur_role_Option";
            this.Text = "txsur_role_Option";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.Button back_btn;
    }
}