namespace Oracle_Test
{
    partial class thqScreen
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
            this.cqk_btn = new System.Windows.Forms.Button();
            this.r_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qtbpf_btn
            // 
            this.qtbpf_btn.Location = new System.Drawing.Point(1416, 83);
            this.qtbpf_btn.Name = "qtbpf_btn";
            this.qtbpf_btn.Size = new System.Drawing.Size(571, 206);
            this.qtbpf_btn.TabIndex = 2;
            this.qtbpf_btn.Text = "QUYỀN TRÊN BẢNG/PROCEDURE/FUNCTION";
            this.qtbpf_btn.UseVisualStyleBackColor = true;
            // 
            // cqk_btn
            // 
            this.cqk_btn.Location = new System.Drawing.Point(729, 83);
            this.cqk_btn.Name = "cqk_btn";
            this.cqk_btn.Size = new System.Drawing.Size(571, 206);
            this.cqk_btn.TabIndex = 3;
            this.cqk_btn.Text = "CÁC QUYỀN KHÁC";
            this.cqk_btn.UseVisualStyleBackColor = true;
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
            // thqScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(2074, 391);
            this.Controls.Add(this.r_btn);
            this.Controls.Add(this.cqk_btn);
            this.Controls.Add(this.qtbpf_btn);
            this.Name = "thqScreen";
            this.Text = "thqScreen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button qtbpf_btn;
        private System.Windows.Forms.Button cqk_btn;
        private System.Windows.Forms.Button r_btn;
    }
}