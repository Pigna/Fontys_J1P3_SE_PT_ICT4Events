namespace ICT4Events_Group1
{
    partial class Reactie
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 12);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(129, 20);
            this.tbTitle.TabIndex = 17;
            this.tbTitle.Text = "Title";
            this.tbTitle.Enter += new System.EventHandler(this.tbTitle_Enter);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(219, 74);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 16;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(138, 74);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "Upload file";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 38);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(286, 69);
            this.tbMessage.TabIndex = 14;
            this.tbMessage.Text = "New Message\r\n";
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            this.tbMessage.Enter += new System.EventHandler(this.tbMessage_Enter);
            // 
            // Reactie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 122);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbMessage);
            this.Name = "Reactie";
            this.Text = "Reactie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbMessage;
    }
}