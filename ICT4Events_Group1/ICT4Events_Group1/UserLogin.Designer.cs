namespace ICT4Events_Group1
{
    partial class UserLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnEmpLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wachtwoord";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(131, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(139, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(15, 108);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(255, 28);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMsg.Size = new System.Drawing.Size(12, 17);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = " ";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEmpLogin
            // 
            this.btnEmpLogin.Location = new System.Drawing.Point(15, 142);
            this.btnEmpLogin.Name = "btnEmpLogin";
            this.btnEmpLogin.Size = new System.Drawing.Size(255, 28);
            this.btnEmpLogin.TabIndex = 6;
            this.btnEmpLogin.Text = "Beheer Login";
            this.btnEmpLogin.UseVisualStyleBackColor = true;
            this.btnEmpLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 181);
            this.Controls.Add(this.btnEmpLogin);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnEmpLogin;
    }
}