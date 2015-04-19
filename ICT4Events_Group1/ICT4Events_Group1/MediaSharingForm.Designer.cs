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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaSharingForm));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCategorie = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblReactie = new System.Windows.Forms.Label();
            this.tbReactieMessage = new System.Windows.Forms.TextBox();
            this.tbReactieTitle = new System.Windows.Forms.TextBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.tbMessage1 = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lblLike = new System.Windows.Forms.Label();
            this.btnComment = new System.Windows.Forms.Button();
            this.lblPoster = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnReactieImage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
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
            this.lbCategorie.Size = new System.Drawing.Size(100, 329);
            this.lbCategorie.TabIndex = 4;
            this.lbCategorie.SelectedValueChanged += new System.EventHandler(this.lbCategorie_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReactieImage);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.lblReactie);
            this.groupBox2.Controls.Add(this.tbReactieMessage);
            this.groupBox2.Controls.Add(this.tbReactieTitle);
            this.groupBox2.Controls.Add(this.panelPicture);
            this.groupBox2.Controls.Add(this.btnHide);
            this.groupBox2.Controls.Add(this.tbTitle);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.btnUpload);
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Location = new System.Drawing.Point(247, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 398);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(314, 357);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblReactie
            // 
            this.lblReactie.AutoSize = true;
            this.lblReactie.Location = new System.Drawing.Point(116, 242);
            this.lblReactie.Name = "lblReactie";
            this.lblReactie.Size = new System.Drawing.Size(47, 13);
            this.lblReactie.TabIndex = 18;
            this.lblReactie.Text = "Reactie:";
            // 
            // tbReactieMessage
            // 
            this.tbReactieMessage.Location = new System.Drawing.Point(119, 284);
            this.tbReactieMessage.Multiline = true;
            this.tbReactieMessage.Name = "tbReactieMessage";
            this.tbReactieMessage.ReadOnly = true;
            this.tbReactieMessage.Size = new System.Drawing.Size(270, 67);
            this.tbReactieMessage.TabIndex = 17;
            // 
            // tbReactieTitle
            // 
            this.tbReactieTitle.Location = new System.Drawing.Point(119, 258);
            this.tbReactieTitle.Name = "tbReactieTitle";
            this.tbReactieTitle.ReadOnly = true;
            this.tbReactieTitle.Size = new System.Drawing.Size(125, 20);
            this.tbReactieTitle.TabIndex = 16;
            // 
            // panelPicture
            // 
            this.panelPicture.Location = new System.Drawing.Point(310, 9);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(79, 92);
            this.panelPicture.TabIndex = 15;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(357, 107);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(20, 20);
            this.btnHide.TabIndex = 14;
            this.btnHide.Text = "-";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(16, 6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(129, 20);
            this.tbTitle.TabIndex = 13;
            this.tbTitle.Text = "Title";
            this.tbTitle.Enter += new System.EventHandler(this.tbTitle_Enter);
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImage);
            this.groupBox3.Controls.Add(this.tbMessage1);
            this.groupBox3.Controls.Add(this.lblComment);
            this.groupBox3.Controls.Add(this.pbPhoto);
            this.groupBox3.Controls.Add(this.lblLike);
            this.groupBox3.Controls.Add(this.btnComment);
            this.groupBox3.Controls.Add(this.lblPoster);
            this.groupBox3.Controls.Add(this.btnLike);
            this.groupBox3.Location = new System.Drawing.Point(17, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 127);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(6, 97);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 15;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // tbMessage1
            // 
            this.tbMessage1.Location = new System.Drawing.Point(44, 24);
            this.tbMessage1.Multiline = true;
            this.tbMessage1.Name = "tbMessage1";
            this.tbMessage1.ReadOnly = true;
            this.tbMessage1.Size = new System.Drawing.Size(288, 69);
            this.tbMessage1.TabIndex = 14;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(290, 104);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comment";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbPhoto.Image")));
            this.pbPhoto.Location = new System.Drawing.Point(6, 8);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(30, 26);
            this.pbPhoto.TabIndex = 3;
            this.pbPhoto.TabStop = false;
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.Location = new System.Drawing.Point(233, 104);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(27, 13);
            this.lblLike.TabIndex = 8;
            this.lblLike.Text = "Like";
            this.lblLike.Click += new System.EventHandler(this.lblLike_Click);
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(266, 99);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(21, 21);
            this.btnComment.TabIndex = 9;
            this.btnComment.Text = ">";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // lblPoster
            // 
            this.lblPoster.AutoSize = true;
            this.lblPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.lblPoster.Location = new System.Drawing.Point(42, 9);
            this.lblPoster.Name = "lblPoster";
            this.lblPoster.Size = new System.Drawing.Size(58, 12);
            this.lblPoster.TabIndex = 5;
            this.lblPoster.Text = "Naam poster";
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.SystemColors.Control;
            this.btnLike.Location = new System.Drawing.Point(206, 100);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(21, 21);
            this.btnLike.TabIndex = 7;
            this.btnLike.Text = "+";
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(223, 68);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(142, 68);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload file";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(16, 32);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(286, 69);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.Text = "New Message\r\n";
            this.tbMessage.Enter += new System.EventHandler(this.tbMessage_Enter);
            this.tbMessage.Leave += new System.EventHandler(this.tbMessage_Leave);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(455, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnReactieImage
            // 
            this.btnReactieImage.Location = new System.Drawing.Point(119, 357);
            this.btnReactieImage.Name = "btnReactieImage";
            this.btnReactieImage.Size = new System.Drawing.Size(75, 23);
            this.btnReactieImage.TabIndex = 20;
            this.btnReactieImage.Text = "Image";
            this.btnReactieImage.UseVisualStyleBackColor = true;
            this.btnReactieImage.Click += new System.EventHandler(this.btnReactieImage_Click);
            // 
            // MediaSharingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 454);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MediaSharingForm";
            this.Text = "MediaSharingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Label lblPoster;
        private System.Windows.Forms.Label lblLike;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.ListBox lbCategorie;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbMessage1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lblReactie;
        private System.Windows.Forms.TextBox tbReactieMessage;
        private System.Windows.Forms.TextBox tbReactieTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReactieImage;
    }
}