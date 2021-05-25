namespace Oracle_Test
{
    partial class XemDSDichVu
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
            this.dsDV = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsDV)).BeginInit();
            this.SuspendLayout();
            // 
            // dsDV
            // 
            this.dsDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDV.Location = new System.Drawing.Point(71, 161);
            this.dsDV.Name = "dsDV";
            this.dsDV.ReadOnly = true;
            this.dsDV.RowHeadersWidth = 123;
            this.dsDV.RowTemplate.Height = 46;
            this.dsDV.Size = new System.Drawing.Size(1574, 645);
            this.dsDV.TabIndex = 1;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(3, -1);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 38;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(532, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 64);
            this.label2.TabIndex = 39;
            this.label2.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // XemDSDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1714, 902);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dsDV);
            this.Name = "XemDSDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEM DANH SÁCH DỊCH VỤ";
            this.Load += new System.EventHandler(this.XemDSDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsDV;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
    }
}