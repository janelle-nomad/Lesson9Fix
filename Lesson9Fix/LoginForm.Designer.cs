namespace Lesson9Fix
{
    partial class LoginForm
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
            this.UserTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.MessegeLbl = new System.Windows.Forms.Label();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // UserTb
            // 
            this.UserTb.Location = new System.Drawing.Point(70, 89);
            this.UserTb.Name = "UserTb";
            this.UserTb.Size = new System.Drawing.Size(223, 20);
            this.UserTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            this.PasswordTb.AutoSize = true;
            this.PasswordTb.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(68, 124);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(86, 18);
            this.PasswordTb.TabIndex = 2;
            this.PasswordTb.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Azure;
            this.LoginBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(220, 197);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(73, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // MessegeLbl
            // 
            this.MessegeLbl.AutoSize = true;
            this.MessegeLbl.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessegeLbl.Location = new System.Drawing.Point(68, 29);
            this.MessegeLbl.Name = "MessegeLbl";
            this.MessegeLbl.Size = new System.Drawing.Size(106, 17);
            this.MessegeLbl.TabIndex = 5;
            this.MessegeLbl.Text = "Please Log in";
            // 
            // PassTb
            // 
            this.PassTb.Location = new System.Drawing.Point(70, 152);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '*';
            this.PassTb.Size = new System.Drawing.Size(223, 20);
            this.PassTb.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(363, 340);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.MessegeLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.UserTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserTb;
        private System.Windows.Forms.Label PasswordTb;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label MessegeLbl;
        private System.Windows.Forms.TextBox PassTb;
    }
}

