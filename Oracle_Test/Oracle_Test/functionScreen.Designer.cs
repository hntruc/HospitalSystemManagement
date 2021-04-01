namespace Oracle_Test
{
    partial class functionScreen
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
            this.xdsnd_btn = new System.Windows.Forms.Button();
            this.ttvq_btn = new System.Windows.Forms.Button();
            this.txsur_btn = new System.Windows.Forms.Button();
            this.csqur_btn = new System.Windows.Forms.Button();
            this.cq_btn = new System.Windows.Forms.Button();
            this.thq_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xdsnd_btn
            // 
            this.xdsnd_btn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.xdsnd_btn.Location = new System.Drawing.Point(114, 88);
            this.xdsnd_btn.Name = "xdsnd_btn";
            this.xdsnd_btn.Size = new System.Drawing.Size(481, 171);
            this.xdsnd_btn.TabIndex = 1;
            this.xdsnd_btn.Text = "XEM DANH SÁCH NGƯỜI DÙNG";
            this.xdsnd_btn.UseVisualStyleBackColor = false;
            this.xdsnd_btn.Click += new System.EventHandler(this.xdsnd_btn_Click);
            // 
            // ttvq_btn
            // 
            this.ttvq_btn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ttvq_btn.Location = new System.Drawing.Point(114, 336);
            this.ttvq_btn.Name = "ttvq_btn";
            this.ttvq_btn.Size = new System.Drawing.Size(481, 171);
            this.ttvq_btn.TabIndex = 2;
            this.ttvq_btn.Text = "THÔNG TIN VỀ QUYỀN";
            this.ttvq_btn.UseVisualStyleBackColor = false;
            this.ttvq_btn.Click += new System.EventHandler(this.ttvq_btn_Click);
            // 
            // txsur_btn
            // 
            this.txsur_btn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txsur_btn.Location = new System.Drawing.Point(756, 88);
            this.txsur_btn.Name = "txsur_btn";
            this.txsur_btn.Size = new System.Drawing.Size(481, 171);
            this.txsur_btn.TabIndex = 4;
            this.txsur_btn.Text = "TẠO, XÓA, SỬA USER/ROLE";
            this.txsur_btn.UseVisualStyleBackColor = false;
            this.txsur_btn.Click += new System.EventHandler(this.txsur_btn_Click);
            // 
            // csqur_btn
            // 
            this.csqur_btn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.csqur_btn.Location = new System.Drawing.Point(756, 573);
            this.csqur_btn.Name = "csqur_btn";
            this.csqur_btn.Size = new System.Drawing.Size(481, 171);
            this.csqur_btn.TabIndex = 5;
            this.csqur_btn.Text = "CHỈNH SỬA QUYỀN USER/ROLE";
            this.csqur_btn.UseVisualStyleBackColor = false;
            this.csqur_btn.Click += new System.EventHandler(this.csqur_btn_Click);
            // 
            // cq_btn
            // 
            this.cq_btn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cq_btn.Location = new System.Drawing.Point(114, 573);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(481, 171);
            this.cq_btn.TabIndex = 6;
            this.cq_btn.Text = "CẤP QUYỀN";
            this.cq_btn.UseVisualStyleBackColor = false;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // thq_btn
            // 
            this.thq_btn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.thq_btn.Location = new System.Drawing.Point(756, 336);
            this.thq_btn.Name = "thq_btn";
            this.thq_btn.Size = new System.Drawing.Size(481, 171);
            this.thq_btn.TabIndex = 7;
            this.thq_btn.Text = "THU HỒI QUYỀN";
            this.thq_btn.UseVisualStyleBackColor = false;
            this.thq_btn.Click += new System.EventHandler(this.thq_btn_Click);
            // 
            // functionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1360, 852);
            this.Controls.Add(this.thq_btn);
            this.Controls.Add(this.cq_btn);
            this.Controls.Add(this.csqur_btn);
            this.Controls.Add(this.txsur_btn);
            this.Controls.Add(this.ttvq_btn);
            this.Controls.Add(this.xdsnd_btn);
            this.Name = "functionScreen";
            this.Text = "functionScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xdsnd_btn;
        private System.Windows.Forms.Button ttvq_btn;
        private System.Windows.Forms.Button txsur_btn;
        private System.Windows.Forms.Button csqur_btn;
        private System.Windows.Forms.Button cq_btn;
        private System.Windows.Forms.Button thq_btn;
    }
}