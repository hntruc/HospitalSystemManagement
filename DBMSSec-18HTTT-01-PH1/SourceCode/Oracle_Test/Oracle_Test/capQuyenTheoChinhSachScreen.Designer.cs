namespace Oracle_Test
{
    partial class capQuyenTheoChinhSachScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.cq_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblquyen_combo = new System.Windows.Forms.ComboBox();
            this.tblrole_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 77);
            this.button1.TabIndex = 18;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cq_btn
            // 
            this.cq_btn.Location = new System.Drawing.Point(763, 282);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(276, 91);
            this.cq_btn.TabIndex = 17;
            this.cq_btn.Text = "CẤP QUYỀN";
            this.cq_btn.UseVisualStyleBackColor = true;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "TÊN ROLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "QUYỀN";
            // 
            // tblquyen_combo
            // 
            this.tblquyen_combo.FormattingEnabled = true;
            this.tblquyen_combo.Location = new System.Drawing.Point(383, 181);
            this.tblquyen_combo.Name = "tblquyen_combo";
            this.tblquyen_combo.Size = new System.Drawing.Size(656, 45);
            this.tblquyen_combo.TabIndex = 20;
            this.tblquyen_combo.SelectedIndexChanged += new System.EventHandler(this.tblquyen_combo_SelectedIndexChanged);
            // 
            // tblrole_combo
            // 
            this.tblrole_combo.FormattingEnabled = true;
            this.tblrole_combo.Location = new System.Drawing.Point(383, 54);
            this.tblrole_combo.Name = "tblrole_combo";
            this.tblrole_combo.Size = new System.Drawing.Size(656, 45);
            this.tblrole_combo.TabIndex = 21;
            this.tblrole_combo.SelectedIndexChanged += new System.EventHandler(this.tblrole_combo_SelectedIndexChanged);
            // 
            // capQuyenTheoChinhSachScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1134, 418);
            this.Controls.Add(this.tblrole_combo);
            this.Controls.Add(this.tblquyen_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cq_btn);
            this.Controls.Add(this.label1);
            this.Name = "capQuyenTheoChinhSachScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤP QUYỀN THEO CHÍNH SÁCH ";
            this.Load += new System.EventHandler(this.capQuyenTheoChinhSachScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cq_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tblquyen_combo;
        private System.Windows.Forms.ComboBox tblrole_combo;
    }
}