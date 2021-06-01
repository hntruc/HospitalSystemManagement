namespace Oracle_Test
{
    partial class cqcro_Screen
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
            this.label5 = new System.Windows.Forms.Label();
            this.cotname_combo = new System.Windows.Forms.ComboBox();
            this.tblname_combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cq_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rolename_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 37);
            this.label5.TabIndex = 28;
            this.label5.Text = "SELECT";
            // 
            // cotname_combo
            // 
            this.cotname_combo.FormattingEnabled = true;
            this.cotname_combo.Location = new System.Drawing.Point(400, 284);
            this.cotname_combo.Name = "cotname_combo";
            this.cotname_combo.Size = new System.Drawing.Size(656, 45);
            this.cotname_combo.TabIndex = 27;
            this.cotname_combo.SelectedIndexChanged += new System.EventHandler(this.cotname_combo_SelectedIndexChanged);
            // 
            // tblname_combo
            // 
            this.tblname_combo.FormattingEnabled = true;
            this.tblname_combo.Location = new System.Drawing.Point(400, 190);
            this.tblname_combo.Name = "tblname_combo";
            this.tblname_combo.Size = new System.Drawing.Size(656, 45);
            this.tblname_combo.TabIndex = 26;
            this.tblname_combo.SelectedIndexChanged += new System.EventHandler(this.tblname_combo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 623);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 77);
            this.button1.TabIndex = 25;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "CỘT";
            // 
            // cq_btn
            // 
            this.cq_btn.Location = new System.Drawing.Point(780, 512);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(276, 91);
            this.cq_btn.TabIndex = 22;
            this.cq_btn.Text = "CẤP QUYỀN";
            this.cq_btn.UseVisualStyleBackColor = true;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "QUYỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "TABLE NAME";
            // 
            // rolename_text
            // 
            this.rolename_text.Location = new System.Drawing.Point(400, 76);
            this.rolename_text.Name = "rolename_text";
            this.rolename_text.Size = new System.Drawing.Size(656, 44);
            this.rolename_text.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "ROLENAME";
            // 
            // cqcro_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1115, 700);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cotname_combo);
            this.Controls.Add(this.tblname_combo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cq_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rolename_text);
            this.Controls.Add(this.label1);
            this.Name = "cqcro_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤP QUYỀN CHO ROLE";
            this.Load += new System.EventHandler(this.cqcro_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cotname_combo;
        private System.Windows.Forms.ComboBox tblname_combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cq_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rolename_text;
        private System.Windows.Forms.Label label1;
    }
}