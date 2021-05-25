namespace Oracle_Test
{
    partial class doiTuongHienCoOption
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
            this.dsObject = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.role_radio = new System.Windows.Forms.RadioButton();
            this.table_radio = new System.Windows.Forms.RadioButton();
            this.view_radio = new System.Windows.Forms.RadioButton();
            this.xem_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsObject)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, 674);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 77);
            this.button1.TabIndex = 17;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsObject
            // 
            this.dsObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsObject.Location = new System.Drawing.Point(98, 138);
            this.dsObject.Name = "dsObject";
            this.dsObject.ReadOnly = true;
            this.dsObject.RowHeadersWidth = 123;
            this.dsObject.RowTemplate.Height = 46;
            this.dsObject.Size = new System.Drawing.Size(1559, 480);
            this.dsObject.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(91, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "CHỌN LOẠI ĐỐI TƯỢNG";
            // 
            // role_radio
            // 
            this.role_radio.AutoSize = true;
            this.role_radio.Location = new System.Drawing.Point(596, 52);
            this.role_radio.Name = "role_radio";
            this.role_radio.Size = new System.Drawing.Size(147, 41);
            this.role_radio.TabIndex = 21;
            this.role_radio.TabStop = true;
            this.role_radio.Text = "ROLE";
            this.role_radio.UseVisualStyleBackColor = true;
            // 
            // table_radio
            // 
            this.table_radio.AutoSize = true;
            this.table_radio.Location = new System.Drawing.Point(848, 51);
            this.table_radio.Name = "table_radio";
            this.table_radio.Size = new System.Drawing.Size(163, 41);
            this.table_radio.TabIndex = 22;
            this.table_radio.TabStop = true;
            this.table_radio.Text = "TABLE";
            this.table_radio.UseVisualStyleBackColor = true;
            // 
            // view_radio
            // 
            this.view_radio.AutoSize = true;
            this.view_radio.Location = new System.Drawing.Point(1099, 48);
            this.view_radio.Name = "view_radio";
            this.view_radio.Size = new System.Drawing.Size(143, 41);
            this.view_radio.TabIndex = 23;
            this.view_radio.TabStop = true;
            this.view_radio.Text = "VIEW";
            this.view_radio.UseVisualStyleBackColor = true;
            // 
            // xem_btn
            // 
            this.xem_btn.Location = new System.Drawing.Point(1433, 33);
            this.xem_btn.Name = "xem_btn";
            this.xem_btn.Size = new System.Drawing.Size(224, 71);
            this.xem_btn.TabIndex = 24;
            this.xem_btn.Text = "XEM";
            this.xem_btn.UseVisualStyleBackColor = true;
            this.xem_btn.Click += new System.EventHandler(this.xem_btn_Click);
            // 
            // doiTuongHienCoOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1760, 745);
            this.Controls.Add(this.xem_btn);
            this.Controls.Add(this.view_radio);
            this.Controls.Add(this.table_radio);
            this.Controls.Add(this.role_radio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dsObject);
            this.Controls.Add(this.button1);
            this.Name = "doiTuongHienCoOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEM USER, ROLE, TABLE, VIEW HIỆN CÓ TRONG CƠ SỞ DỮ LIỆU";
            ((System.ComponentModel.ISupportInitialize)(this.dsObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dsObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton role_radio;
        private System.Windows.Forms.RadioButton table_radio;
        private System.Windows.Forms.RadioButton view_radio;
        private System.Windows.Forms.Button xem_btn;
    }
}