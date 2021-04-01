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
            this.tablename_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.RadioButton();
            this.update_btn = new System.Windows.Forms.RadioButton();
            this.cq_btn = new System.Windows.Forms.Button();
            this.cot_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.withgrantoption = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 74);
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
            // tablename_text
            // 
            this.tablename_text.Location = new System.Drawing.Point(399, 188);
            this.tablename_text.Name = "tablename_text";
            this.tablename_text.Size = new System.Drawing.Size(656, 44);
            this.tablename_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "TABLE NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUYỀN";
            // 
            // select_btn
            // 
            this.select_btn.AutoSize = true;
            this.select_btn.Location = new System.Drawing.Point(399, 397);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(185, 41);
            this.select_btn.TabIndex = 5;
            this.select_btn.TabStop = true;
            this.select_btn.Text = "SELECT";
            this.select_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.AutoSize = true;
            this.update_btn.Location = new System.Drawing.Point(811, 397);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(191, 41);
            this.update_btn.TabIndex = 6;
            this.update_btn.TabStop = true;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // cq_btn
            // 
            this.cq_btn.Location = new System.Drawing.Point(779, 608);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(276, 91);
            this.cq_btn.TabIndex = 7;
            this.cq_btn.Text = "CẤP QUYỀN";
            this.cq_btn.UseVisualStyleBackColor = true;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // cot_text
            // 
            this.cot_text.Location = new System.Drawing.Point(400, 291);
            this.cot_text.Name = "cot_text";
            this.cot_text.Size = new System.Drawing.Size(656, 44);
            this.cot_text.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "CỘT";
            // 
            // withgrantoption
            // 
            this.withgrantoption.AutoSize = true;
            this.withgrantoption.Location = new System.Drawing.Point(399, 505);
            this.withgrantoption.Name = "withgrantoption";
            this.withgrantoption.Size = new System.Drawing.Size(397, 41);
            this.withgrantoption.TabIndex = 10;
            this.withgrantoption.TabStop = true;
            this.withgrantoption.Text = "WITH GRANT OPTION";
            this.withgrantoption.UseVisualStyleBackColor = true;
            // 
            // cqcuo_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 795);
            this.Controls.Add(this.withgrantoption);
            this.Controls.Add(this.cot_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cq_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablename_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label1);
            this.Name = "cqcuo_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cqcuo_Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox tablename_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton select_btn;
        private System.Windows.Forms.RadioButton update_btn;
        private System.Windows.Forms.Button cq_btn;
        private System.Windows.Forms.TextBox cot_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton withgrantoption;
    }
}