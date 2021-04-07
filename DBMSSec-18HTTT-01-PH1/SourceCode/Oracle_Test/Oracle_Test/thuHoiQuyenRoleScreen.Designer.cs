namespace Oracle_Test
{
    partial class thuHoiQuyenRoleScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xem_btn = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.Label();
            this.role_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rolename_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.object_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.select_radio = new System.Windows.Forms.RadioButton();
            this.update_radio = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1498, 347);
            this.dataGridView1.TabIndex = 7;
            // 
            // xem_btn
            // 
            this.xem_btn.Location = new System.Drawing.Point(1403, 71);
            this.xem_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.xem_btn.Name = "xem_btn";
            this.xem_btn.Size = new System.Drawing.Size(200, 60);
            this.xem_btn.TabIndex = 12;
            this.xem_btn.Text = "Xem";
            this.xem_btn.UseVisualStyleBackColor = true;
            this.xem_btn.Click += new System.EventHandler(this.xem_btn_Click);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(98, 77);
            this.Role.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(103, 37);
            this.Role.TabIndex = 11;
            this.Role.Text = "ROLE";
            // 
            // role_text
            // 
            this.role_text.Location = new System.Drawing.Point(222, 71);
            this.role_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.role_text.Name = "role_text";
            this.role_text.Size = new System.Drawing.Size(1135, 44);
            this.role_text.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1818, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "TÊN ROLE";
            // 
            // rolename_text
            // 
            this.rolename_text.Location = new System.Drawing.Point(2065, 171);
            this.rolename_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.rolename_text.Name = "rolename_text";
            this.rolename_text.Size = new System.Drawing.Size(508, 44);
            this.rolename_text.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1818, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "QUYỀN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1818, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "TABLE/VIEW";
            // 
            // object_text
            // 
            this.object_text.Location = new System.Drawing.Point(2065, 330);
            this.object_text.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.object_text.Name = "object_text";
            this.object_text.Size = new System.Drawing.Size(508, 44);
            this.object_text.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2372, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thu hồi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_radio
            // 
            this.select_radio.AutoSize = true;
            this.select_radio.Location = new System.Drawing.Point(2065, 253);
            this.select_radio.Name = "select_radio";
            this.select_radio.Size = new System.Drawing.Size(185, 41);
            this.select_radio.TabIndex = 20;
            this.select_radio.TabStop = true;
            this.select_radio.Text = "SELECT";
            this.select_radio.UseVisualStyleBackColor = true;
            // 
            // update_radio
            // 
            this.update_radio.AutoSize = true;
            this.update_radio.Location = new System.Drawing.Point(2328, 253);
            this.update_radio.Name = "update_radio";
            this.update_radio.Size = new System.Drawing.Size(191, 41);
            this.update_radio.TabIndex = 21;
            this.update_radio.TabStop = true;
            this.update_radio.Text = "UPDATE";
            this.update_radio.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 652);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 77);
            this.button3.TabIndex = 22;
            this.button3.Text = "⬅";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // thuHoiQuyenRoleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(2685, 731);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.update_radio);
            this.Controls.Add(this.select_radio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.object_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolename_text);
            this.Controls.Add(this.xem_btn);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.role_text);
            this.Controls.Add(this.dataGridView1);
            this.Name = "thuHoiQuyenRoleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THU HỒI QUYỀN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button xem_btn;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.TextBox role_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rolename_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox object_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton select_radio;
        private System.Windows.Forms.RadioButton update_radio;
        private System.Windows.Forms.Button button3;
    }
}