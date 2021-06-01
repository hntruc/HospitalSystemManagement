namespace Oracle_Test
{
    partial class auditOption
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
            this.button3 = new System.Windows.Forms.Button();
            this.audit_dt = new System.Windows.Forms.Button();
            this.audit_lo = new System.Windows.Forms.Button();
            this.audit_hsbn = new System.Windows.Forms.Button();
            this.disable_btn = new System.Windows.Forms.Button();
            this.enable_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-7, 777);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 77);
            this.button3.TabIndex = 20;
            this.button3.Text = "⬅";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // audit_dt
            // 
            this.audit_dt.Location = new System.Drawing.Point(83, 289);
            this.audit_dt.Name = "audit_dt";
            this.audit_dt.Size = new System.Drawing.Size(450, 199);
            this.audit_dt.TabIndex = 22;
            this.audit_dt.Text = "ĐƠN THUỐC";
            this.audit_dt.UseVisualStyleBackColor = true;
            this.audit_dt.Click += new System.EventHandler(this.audit_dt_Click);
            // 
            // audit_lo
            // 
            this.audit_lo.Location = new System.Drawing.Point(83, 42);
            this.audit_lo.Name = "audit_lo";
            this.audit_lo.Size = new System.Drawing.Size(450, 199);
            this.audit_lo.TabIndex = 21;
            this.audit_lo.Text = "LOG ON";
            this.audit_lo.UseVisualStyleBackColor = true;
            this.audit_lo.Click += new System.EventHandler(this.audit_lo_Click);
            // 
            // audit_hsbn
            // 
            this.audit_hsbn.Location = new System.Drawing.Point(83, 535);
            this.audit_hsbn.Name = "audit_hsbn";
            this.audit_hsbn.Size = new System.Drawing.Size(450, 199);
            this.audit_hsbn.TabIndex = 23;
            this.audit_hsbn.Text = "HỒ SƠ BỆNH NHÂN";
            this.audit_hsbn.UseVisualStyleBackColor = true;
            this.audit_hsbn.Click += new System.EventHandler(this.audit_hsbn_Click);
            // 
            // disable_btn
            // 
            this.disable_btn.Location = new System.Drawing.Point(635, 42);
            this.disable_btn.Name = "disable_btn";
            this.disable_btn.Size = new System.Drawing.Size(450, 199);
            this.disable_btn.TabIndex = 24;
            this.disable_btn.Text = "DISABLE";
            this.disable_btn.UseVisualStyleBackColor = true;
            this.disable_btn.Click += new System.EventHandler(this.disable_btn_Click);
            // 
            // enable_btn
            // 
            this.enable_btn.Location = new System.Drawing.Point(635, 289);
            this.enable_btn.Name = "enable_btn";
            this.enable_btn.Size = new System.Drawing.Size(450, 199);
            this.enable_btn.TabIndex = 25;
            this.enable_btn.Text = "ENABLE";
            this.enable_btn.UseVisualStyleBackColor = true;
            this.enable_btn.Click += new System.EventHandler(this.enable_btn_Click);
            // 
            // auditOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1170, 853);
            this.Controls.Add(this.enable_btn);
            this.Controls.Add(this.disable_btn);
            this.Controls.Add(this.audit_hsbn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.audit_dt);
            this.Controls.Add(this.audit_lo);
            this.Name = "auditOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn loại audit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button audit_dt;
        private System.Windows.Forms.Button audit_lo;
        private System.Windows.Forms.Button audit_hsbn;
        private System.Windows.Forms.Button disable_btn;
        private System.Windows.Forms.Button enable_btn;
    }
}