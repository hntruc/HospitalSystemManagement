namespace Oracle_Test
{
    partial class cqcu_Option
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
            this.yobject_btn = new System.Windows.Forms.Button();
            this.nobject_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yobject_btn
            // 
            this.yobject_btn.Location = new System.Drawing.Point(70, 102);
            this.yobject_btn.Name = "yobject_btn";
            this.yobject_btn.Size = new System.Drawing.Size(323, 153);
            this.yobject_btn.TabIndex = 0;
            this.yobject_btn.Text = "SELECT, UPDATE";
            this.yobject_btn.UseVisualStyleBackColor = true;
            this.yobject_btn.Click += new System.EventHandler(this.yobject_btn_Click);
            // 
            // nobject_btn
            // 
            this.nobject_btn.Location = new System.Drawing.Point(507, 102);
            this.nobject_btn.Name = "nobject_btn";
            this.nobject_btn.Size = new System.Drawing.Size(323, 153);
            this.nobject_btn.TabIndex = 1;
            this.nobject_btn.Text = "CREATE SESSION, USER, ...";
            this.nobject_btn.UseVisualStyleBackColor = true;
            this.nobject_btn.Click += new System.EventHandler(this.nobject_btn_Click);
            // 
            // cqcu_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 362);
            this.Controls.Add(this.nobject_btn);
            this.Controls.Add(this.yobject_btn);
            this.Name = "cqcu_Option";
            this.Text = "cqcuo_Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yobject_btn;
        private System.Windows.Forms.Button nobject_btn;
    }
}