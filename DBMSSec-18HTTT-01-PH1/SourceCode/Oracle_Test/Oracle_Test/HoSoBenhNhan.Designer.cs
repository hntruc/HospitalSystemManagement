namespace Oracle_Test
{
    partial class HoSoBenhNhan
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
            this.dsDT = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsHSBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDT)).BeginInit();
            this.SuspendLayout();
            // 
            // dsHSBN
            // 
            this.dsHSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHSBN.Location = new System.Drawing.Point(72, 132);
            this.dsHSBN.Name = "dsHSBN";
            this.dsHSBN.RowHeadersWidth = 123;
            this.dsHSBN.RowTemplate.Height = 46;
            this.dsHSBN.Size = new System.Drawing.Size(2321, 470);
            this.dsHSBN.TabIndex = 0;
            this.dsHSBN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsHSBN_CellDoubleClick);
            // 
            // dsDT
            // 
            this.dsDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDT.Location = new System.Drawing.Point(72, 719);
            this.dsDT.Name = "dsDT";
            this.dsDT.RowHeadersWidth = 123;
            this.dsDT.RowTemplate.Height = 46;
            this.dsDT.Size = new System.Drawing.Size(2321, 470);
            this.dsDT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(1077, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "HỒ SƠ BỆNH NHÂN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(1077, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐƠN THUỐC";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(2, 0);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 37;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // HoSoBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2464, 1345);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dsDT);
            this.Controls.Add(this.dsHSBN);
            this.Name = "HoSoBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐIỀU TRỊ KHÁM BỆNH";
            this.Load += new System.EventHandler(this.HoSoBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHSBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsHSBN;
        private System.Windows.Forms.DataGridView dsDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_btn;
    }
}