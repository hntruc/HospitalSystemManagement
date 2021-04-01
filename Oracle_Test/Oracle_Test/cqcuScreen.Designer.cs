namespace Oracle_Test
{
    partial class cqcuScreen
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
            this.cq_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tablename_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quyen_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cq_btn
            // 
            this.cq_btn.Location = new System.Drawing.Point(793, 400);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(276, 91);
            this.cq_btn.TabIndex = 15;
            this.cq_btn.Text = "CẤP QUYỀN";
            this.cq_btn.UseVisualStyleBackColor = true;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "QUYỀN";
            // 
            // tablename_text
            // 
            this.tablename_text.Location = new System.Drawing.Point(413, 198);
            this.tablename_text.Name = "tablename_text";
            this.tablename_text.Size = new System.Drawing.Size(656, 44);
            this.tablename_text.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "TABLE NAME";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(413, 84);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(656, 44);
            this.username_text.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "USERNAME";
            // 
            // quyen_text
            // 
            this.quyen_text.Location = new System.Drawing.Point(413, 316);
            this.quyen_text.Name = "quyen_text";
            this.quyen_text.Size = new System.Drawing.Size(656, 44);
            this.quyen_text.TabIndex = 16;
            // 
            // cqcuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 565);
            this.Controls.Add(this.quyen_text);
            this.Controls.Add(this.cq_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablename_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label1);
            this.Name = "cqcuScreen";
            this.Text = "cqcuScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cq_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tablename_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quyen_text;
    }
}