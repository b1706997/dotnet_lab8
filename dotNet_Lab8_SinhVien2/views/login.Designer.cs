
namespace Views
{
    partial class login
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
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(225, 115);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(374, 22);
            this.txt_uname.TabIndex = 0;
            // 
            // txt_psw
            // 
            this.txt_psw.Location = new System.Drawing.Point(225, 205);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.Size = new System.Drawing.Size(374, 22);
            this.txt_psw.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(225, 279);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(133, 31);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.txt_uname);
            this.Name = "login";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.Button btn_login;
    }
}

