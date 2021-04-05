namespace Oracle_Test
{
    partial class ttvqOption01
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
            this.back_btn = new System.Windows.Forms.Button();
            this.ttvqcutcdtdl_btn = new System.Windows.Forms.Button();
            this.ttvqcu_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(1, 534);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ttvqcutcdtdl_btn
            // 
            this.ttvqcutcdtdl_btn.BackColor = System.Drawing.Color.Snow;
            this.ttvqcutcdtdl_btn.Location = new System.Drawing.Point(211, 68);
            this.ttvqcutcdtdl_btn.Name = "ttvqcutcdtdl_btn";
            this.ttvqcutcdtdl_btn.Size = new System.Drawing.Size(673, 191);
            this.ttvqcutcdtdl_btn.TabIndex = 13;
            this.ttvqcutcdtdl_btn.Text = "THÔNG TIN VỀ QUYỀN TRÊN ĐỐI TƯỢNG DỮ LIỆU CỦA USER/ROLE";
            this.ttvqcutcdtdl_btn.UseVisualStyleBackColor = false;
            this.ttvqcutcdtdl_btn.Click += new System.EventHandler(this.ttvqcutcdtdl_btn_Click);
            // 
            // ttvqcu_btn
            // 
            this.ttvqcu_btn.BackColor = System.Drawing.Color.Snow;
            this.ttvqcu_btn.Location = new System.Drawing.Point(211, 327);
            this.ttvqcu_btn.Name = "ttvqcu_btn";
            this.ttvqcu_btn.Size = new System.Drawing.Size(673, 191);
            this.ttvqcu_btn.TabIndex = 12;
            this.ttvqcu_btn.Text = "THÔNG TIN VỀ QUYỀN CỦA USER";
            this.ttvqcu_btn.UseVisualStyleBackColor = false;
            this.ttvqcu_btn.Click += new System.EventHandler(this.ttvqcu_btn_Click);
            // 
            // ttvqOption01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1082, 608);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.ttvqcutcdtdl_btn);
            this.Controls.Add(this.ttvqcu_btn);
            this.Name = "ttvqOption01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỨC NĂNG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button ttvqcutcdtdl_btn;
        private System.Windows.Forms.Button ttvqcu_btn;
    }
}