namespace Oracle_Test
{
    partial class thqUserOption
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
            this.qtbpf_btn = new System.Windows.Forms.Button();
            this.r_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qtbpf_btn
            // 
            this.qtbpf_btn.Location = new System.Drawing.Point(767, 83);
            this.qtbpf_btn.Name = "qtbpf_btn";
            this.qtbpf_btn.Size = new System.Drawing.Size(571, 206);
            this.qtbpf_btn.TabIndex = 2;
            this.qtbpf_btn.Text = "QUYỀN TRÊN BẢNG/PROCEDURE/FUNCTION";
            this.qtbpf_btn.UseVisualStyleBackColor = true;
            this.qtbpf_btn.Click += new System.EventHandler(this.qtbpf_btn_Click);
            // 
            // r_btn
            // 
            this.r_btn.Location = new System.Drawing.Point(58, 83);
            this.r_btn.Name = "r_btn";
            this.r_btn.Size = new System.Drawing.Size(571, 206);
            this.r_btn.TabIndex = 4;
            this.r_btn.Text = "ROLE";
            this.r_btn.UseVisualStyleBackColor = true;
            this.r_btn.Click += new System.EventHandler(this.r_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(1, 360);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // thqUserOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1426, 440);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.r_btn);
            this.Controls.Add(this.qtbpf_btn);
            this.Name = "thqUserOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THU HỒI QUYỀN";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button qtbpf_btn;
        private System.Windows.Forms.Button r_btn;
        private System.Windows.Forms.Button back_btn;
    }
}