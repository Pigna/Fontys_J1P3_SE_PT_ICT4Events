namespace ICT4Events_Group1
{
    partial class VerhuurForm
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
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnRentList = new System.Windows.Forms.Button();
            this.btnRentableList = new System.Windows.Forms.Button();
            this.btnRentedList = new System.Windows.Forms.Button();
            this.lbxRentList = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(304, 39);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 23);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Berichten";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(385, 39);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Huren";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnEntrance
            // 
            this.btnEntrance.Location = new System.Drawing.Point(466, 39);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(75, 23);
            this.btnEntrance.TabIndex = 2;
            this.btnEntrance.Text = "Entree";
            this.btnEntrance.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(547, 39);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(38, 131);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 4;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Location = new System.Drawing.Point(38, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(242, 78);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // btnRentList
            // 
            this.btnRentList.Location = new System.Drawing.Point(38, 261);
            this.btnRentList.Name = "btnRentList";
            this.btnRentList.Size = new System.Drawing.Size(100, 23);
            this.btnRentList.TabIndex = 6;
            this.btnRentList.Text = "Huurbaar";
            this.btnRentList.UseVisualStyleBackColor = true;
            this.btnRentList.Click += new System.EventHandler(this.btnRentList_Click);
            // 
            // btnRentableList
            // 
            this.btnRentableList.Location = new System.Drawing.Point(38, 290);
            this.btnRentableList.Name = "btnRentableList";
            this.btnRentableList.Size = new System.Drawing.Size(100, 23);
            this.btnRentableList.TabIndex = 7;
            this.btnRentableList.Text = "Verhuurbaar";
            this.btnRentableList.UseVisualStyleBackColor = true;
            this.btnRentableList.Click += new System.EventHandler(this.btnRentableList_Click);
            // 
            // btnRentedList
            // 
            this.btnRentedList.Location = new System.Drawing.Point(38, 319);
            this.btnRentedList.Name = "btnRentedList";
            this.btnRentedList.Size = new System.Drawing.Size(100, 23);
            this.btnRentedList.TabIndex = 8;
            this.btnRentedList.Text = "Verhuurd";
            this.btnRentedList.UseVisualStyleBackColor = true;
            this.btnRentedList.Click += new System.EventHandler(this.btnRentedList_Click);
            // 
            // lbxRentList
            // 
            this.lbxRentList.FormattingEnabled = true;
            this.lbxRentList.Location = new System.Drawing.Point(182, 157);
            this.lbxRentList.Name = "lbxRentList";
            this.lbxRentList.Size = new System.Drawing.Size(440, 186);
            this.lbxRentList.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(38, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(179, 138);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 13);
            this.lblDesc.TabIndex = 11;
            // 
            // VerhuurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 364);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbxRentList);
            this.Controls.Add(this.btnRentedList);
            this.Controls.Add(this.btnRentableList);
            this.Controls.Add(this.btnRentList);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnMessage);
            this.Name = "VerhuurForm";
            this.Text = "VerhuurForm";
            this.Load += new System.EventHandler(this.VerhuurForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnRentList;
        private System.Windows.Forms.Button btnRentableList;
        private System.Windows.Forms.Button btnRentedList;
        private System.Windows.Forms.ListBox lbxRentList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDesc;
    }
}