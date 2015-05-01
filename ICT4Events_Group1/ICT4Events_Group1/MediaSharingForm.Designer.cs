namespace ICT4Events_Group1
{
    partial class MediaSharingForm
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCategorie = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReact = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.lbComments = new System.Windows.Forms.ListBox();
            this.lbPosts = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.lblReactie = new System.Windows.Forms.Label();
            this.tbReactieMessage = new System.Windows.Forms.TextBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(6, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Search";
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(6, 16);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(64, 13);
            this.lblCategorie.TabIndex = 1;
            this.lblCategorie.Text = "Categorieën";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCategorie);
            this.groupBox1.Controls.Add(this.lblCategorie);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 398);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbCategorie
            // 
            this.lbCategorie.FormattingEnabled = true;
            this.lbCategorie.Location = new System.Drawing.Point(6, 58);
            this.lbCategorie.Name = "lbCategorie";
            this.lbCategorie.Size = new System.Drawing.Size(100, 290);
            this.lbCategorie.TabIndex = 4;
            this.lbCategorie.SelectedValueChanged += new System.EventHandler(this.lbCategorie_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReact);
            this.groupBox2.Controls.Add(this.btnImage);
            this.groupBox2.Controls.Add(this.lbComments);
            this.groupBox2.Controls.Add(this.lbPosts);
            this.groupBox2.Controls.Add(this.btnLike);
            this.groupBox2.Controls.Add(this.lblReactie);
            this.groupBox2.Controls.Add(this.tbReactieMessage);
            this.groupBox2.Controls.Add(this.panelPicture);
            this.groupBox2.Controls.Add(this.tbTitle);
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.btnUpload);
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Location = new System.Drawing.Point(247, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 398);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnReact
            // 
            this.btnReact.Location = new System.Drawing.Point(424, 107);
            this.btnReact.Name = "btnReact";
            this.btnReact.Size = new System.Drawing.Size(75, 23);
            this.btnReact.TabIndex = 23;
            this.btnReact.Text = "React";
            this.btnReact.UseVisualStyleBackColor = true;
            this.btnReact.Click += new System.EventHandler(this.btnReact_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(5, 350);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 15;
            this.btnImage.Text = "View image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lbComments
            // 
            this.lbComments.FormattingEnabled = true;
            this.lbComments.Location = new System.Drawing.Point(310, 134);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(189, 95);
            this.lbComments.TabIndex = 22;
            // 
            // lbPosts
            // 
            this.lbPosts.FormattingEnabled = true;
            this.lbPosts.Location = new System.Drawing.Point(6, 134);
            this.lbPosts.Name = "lbPosts";
            this.lbPosts.Size = new System.Drawing.Size(296, 212);
            this.lbPosts.TabIndex = 21;
            this.lbPosts.SelectedIndexChanged += new System.EventHandler(this.lbPosts_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 350);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.SystemColors.Control;
            this.btnLike.Location = new System.Drawing.Point(81, 350);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(44, 23);
            this.btnLike.TabIndex = 7;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // lblReactie
            // 
            this.lblReactie.AutoSize = true;
            this.lblReactie.Location = new System.Drawing.Point(307, 17);
            this.lblReactie.Name = "lblReactie";
            this.lblReactie.Size = new System.Drawing.Size(47, 13);
            this.lblReactie.TabIndex = 18;
            this.lblReactie.Text = "Reactie:";
            // 
            // tbReactieMessage
            // 
            this.tbReactieMessage.Location = new System.Drawing.Point(310, 36);
            this.tbReactieMessage.Multiline = true;
            this.tbReactieMessage.Name = "tbReactieMessage";
            this.tbReactieMessage.Size = new System.Drawing.Size(189, 67);
            this.tbReactieMessage.TabIndex = 17;
            // 
            // panelPicture
            // 
            this.panelPicture.Location = new System.Drawing.Point(310, 235);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(189, 111);
            this.panelPicture.TabIndex = 15;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(6, 10);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(139, 20);
            this.tbTitle.TabIndex = 13;
            this.tbTitle.Text = "Title";
            this.tbTitle.Enter += new System.EventHandler(this.tbTitle_Enter);
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(227, 107);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(151, 107);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload file";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(6, 36);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(296, 69);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.Text = "New Message\r\n";
            this.tbMessage.Enter += new System.EventHandler(this.tbMessage_Enter);
            this.tbMessage.Leave += new System.EventHandler(this.tbMessage_Leave);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(557, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // MediaSharingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 454);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MediaSharingForm";
            this.Text = "MediaSharingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListBox lbCategorie;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lblReactie;
        private System.Windows.Forms.TextBox tbReactieMessage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lbComments;
        private System.Windows.Forms.ListBox lbPosts;
        private System.Windows.Forms.Button btnReact;
        private System.Windows.Forms.Button btnLogout;
    }
}