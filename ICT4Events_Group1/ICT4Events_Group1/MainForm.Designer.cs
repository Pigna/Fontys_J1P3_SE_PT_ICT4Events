namespace ICT4Events_Group1
{
    partial class MainForm
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
            this.btnVerhuur = new System.Windows.Forms.Button();
            this.btnBeheer = new System.Windows.Forms.Button();
            this.btnMediaShare = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Location = new System.Drawing.Point(64, 96);
            this.btnVerhuur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(188, 28);
            this.btnVerhuur.TabIndex = 0;
            this.btnVerhuur.Text = "Verhuur";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            this.btnVerhuur.Click += new System.EventHandler(this.btnVerhuur_Click);
            // 
            // btnBeheer
            // 
            this.btnBeheer.Location = new System.Drawing.Point(64, 132);
            this.btnBeheer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeheer.Name = "btnBeheer";
            this.btnBeheer.Size = new System.Drawing.Size(188, 28);
            this.btnBeheer.TabIndex = 1;
            this.btnBeheer.Text = "Beheer";
            this.btnBeheer.UseVisualStyleBackColor = true;
            this.btnBeheer.Click += new System.EventHandler(this.btnBeheer_Click);
            // 
            // btnMediaShare
            // 
            this.btnMediaShare.Location = new System.Drawing.Point(64, 167);
            this.btnMediaShare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMediaShare.Name = "btnMediaShare";
            this.btnMediaShare.Size = new System.Drawing.Size(188, 28);
            this.btnMediaShare.TabIndex = 2;
            this.btnMediaShare.Text = "Media Sharing";
            this.btnMediaShare.UseVisualStyleBackColor = true;
            this.btnMediaShare.Click += new System.EventHandler(this.btnMediaShare_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 203);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(460, 72);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(460, 101);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 22);
            this.txtPass.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCur
            // 
            this.lblCur.AutoSize = true;
            this.lblCur.Location = new System.Drawing.Point(460, 187);
            this.lblCur.Name = "lblCur";
            this.lblCur.Size = new System.Drawing.Size(0, 17);
            this.lblCur.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 495);
            this.Controls.Add(this.lblCur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMediaShare);
            this.Controls.Add(this.btnBeheer);
            this.Controls.Add(this.btnVerhuur);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerhuur;
        private System.Windows.Forms.Button btnBeheer;
        private System.Windows.Forms.Button btnMediaShare;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCur;
    }
}