namespace Oracle_Test
{
    partial class cqcro_Screen_Update
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
            this.label5.Location = new System.Drawing.Point(125, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "UPDATE";
            // 
            // cotname_combo
            // 
            this.cotname_combo.FormattingEnabled = true;
            this.cotname_combo.Location = new System.Drawing.Point(127, 96);
            this.cotname_combo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cotname_combo.Name = "cotname_combo";
            this.cotname_combo.Size = new System.Drawing.Size(210, 21);
            this.cotname_combo.TabIndex = 38;
            this.cotname_combo.SelectedIndexChanged += new System.EventHandler(this.cotname_combo_SelectedIndexChanged_1);
            // 
            // tblname_combo
            // 
            this.tblname_combo.FormattingEnabled = true;
            this.tblname_combo.Location = new System.Drawing.Point(127, 63);
            this.tblname_combo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tblname_combo.Name = "tblname_combo";
            this.tblname_combo.Size = new System.Drawing.Size(210, 21);
            this.tblname_combo.TabIndex = 37;
            this.tblname_combo.SelectedIndexChanged += new System.EventHandler(this.tblname_combo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 36;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "CỘT";
            // 
            // cq_btn
            // 
            this.cq_btn.Location = new System.Drawing.Point(247, 211);
            this.cq_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cq_btn.Name = "cq_btn";
            this.cq_btn.Size = new System.Drawing.Size(87, 32);
            this.cq_btn.TabIndex = 33;
            this.cq_btn.Text = "CẤP QUYỀN";
            this.cq_btn.UseVisualStyleBackColor = true;
            this.cq_btn.Click += new System.EventHandler(this.cq_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "QUYỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "TABLE NAME";
            // 
            // rolename_text
            // 
            this.rolename_text.Location = new System.Drawing.Point(127, 23);
            this.rolename_text.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rolename_text.Name = "rolename_text";
            this.rolename_text.Size = new System.Drawing.Size(210, 20);
            this.rolename_text.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "TÊN ROLE";
            // 
            // cqcro_Screen_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(352, 266);
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
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "cqcro_Screen_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤP QUYỀN";
            this.Load += new System.EventHandler(this.cqcro_Screen_Update_Load);
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