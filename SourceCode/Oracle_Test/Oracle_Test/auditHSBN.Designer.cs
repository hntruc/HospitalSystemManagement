namespace Oracle_Test
{
    partial class auditHSBN
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
            this.dsHSBN = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsHSBN)).BeginInit();
            this.SuspendLayout();
            // 
            // dsHSBN
            // 
            this.dsHSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHSBN.Location = new System.Drawing.Point(72, 88);
            this.dsHSBN.Name = "dsHSBN";
            this.dsHSBN.RowHeadersWidth = 123;
            this.dsHSBN.RowTemplate.Height = 46;
            this.dsHSBN.Size = new System.Drawing.Size(2362, 644);
            this.dsHSBN.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 77);
            this.button1.TabIndex = 19;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // auditHSBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2506, 820);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dsHSBN);
            this.Name = "auditHSBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audit của Hồ sơ bệnh nhân";
            this.Load += new System.EventHandler(this.auditHSBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHSBN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsHSBN;
        private System.Windows.Forms.Button button1;
    }
}