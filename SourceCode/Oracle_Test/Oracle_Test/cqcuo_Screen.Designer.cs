namespace Oracle_Test
{
    partial class cqcuo_Screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cq_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.withgrantoption = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tblname_combo = new System.Windows.Forms.ComboBox();
            this.cotname_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(399, 74);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(656, 44);
            this.username_text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "TABLE NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUYỀN";
            // 
            // cq_btn
            // 
            this.cq_btn.Location = new System.Drawing.Point(779, 609);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(276, 91);
            this.cq_btn.TabIndex = 7;
            this.cq_btn.Text = "CẤP QUYỀN";
            this.cq_btn.UseVisualStyleBackColor = true;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "CỘT";
            // 
            // withgrantoption
            // 
            this.withgrantoption.AutoSize = true;
            this.withgrantoption.Location = new System.Drawing.Point(399, 504);
            this.withgrantoption.Name = "withgrantoption";
            this.withgrantoption.Size = new System.Drawing.Size(397, 41);
            this.withgrantoption.TabIndex = 10;
            this.withgrantoption.TabStop = true;
            this.withgrantoption.Text = "WITH GRANT OPTION";
            this.withgrantoption.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-3, 717);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 77);
            this.button1.TabIndex = 14;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblname_combo
            // 
            this.tblname_combo.FormattingEnabled = true;
            this.tblname_combo.Location = new System.Drawing.Point(399, 188);
            this.tblname_combo.Name = "tblname_combo";
            this.tblname_combo.Size = new System.Drawing.Size(656, 45);
            this.tblname_combo.TabIndex = 15;
            this.tblname_combo.SelectedIndexChanged += new System.EventHandler(this.tblname_combo_SelectedIndexChanged);
            // 
            // cotname_combo
            // 
            this.cotname_combo.FormattingEnabled = true;
            this.cotname_combo.Location = new System.Drawing.Point(399, 282);
            this.cotname_combo.Name = "cotname_combo";
            this.cotname_combo.Size = new System.Drawing.Size(656, 45);
            this.cotname_combo.TabIndex = 16;
            this.cotname_combo.SelectedIndexChanged += new System.EventHandler(this.cotname_combo_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "SELECT";
            // 
            // cqcuo_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1115, 794);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cotname_combo);
            this.Controls.Add(this.tblname_combo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.withgrantoption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cq_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label1);
            this.Name = "cqcuo_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤP QUYỀN CHO USER";
            this.Load += new System.EventHandler(this.cqcuo_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cq_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton withgrantoption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tblname_combo;
        private System.Windows.Forms.ComboBox cotname_combo;
        private System.Windows.Forms.Label label5;
    }
}