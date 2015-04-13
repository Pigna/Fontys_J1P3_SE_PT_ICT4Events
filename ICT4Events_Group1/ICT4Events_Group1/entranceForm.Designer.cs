namespace ICT4Events_Group1
{
    partial class EntranceForm
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
            this.profile = new System.Windows.Forms.GroupBox();
            this.lb_payed = new System.Windows.Forms.Label();
            this.lb_adress = new System.Windows.Forms.Label();
            this.lb_naam = new System.Windows.Forms.Label();
            this.pb_profile = new System.Windows.Forms.PictureBox();
            this.pb_paspoort = new System.Windows.Forms.PictureBox();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnRentList = new System.Windows.Forms.Button();
            this.btnRentableList = new System.Windows.Forms.Button();
            this.btnRentedList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_paspoort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.Controls.Add(this.lb_payed);
            this.profile.Controls.Add(this.lb_adress);
            this.profile.Controls.Add(this.lb_naam);
            this.profile.Controls.Add(this.pb_profile);
            this.profile.Controls.Add(this.pb_paspoort);
            this.profile.Location = new System.Drawing.Point(347, 170);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(460, 279);
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            this.profile.Text = "profiel";
            // 
            // lb_payed
            // 
            this.lb_payed.AutoSize = true;
            this.lb_payed.Location = new System.Drawing.Point(19, 152);
            this.lb_payed.Name = "lb_payed";
            this.lb_payed.Size = new System.Drawing.Size(45, 13);
            this.lb_payed.TabIndex = 4;
            this.lb_payed.Text = "betaald:";
            // 
            // lb_adress
            // 
            this.lb_adress.AutoSize = true;
            this.lb_adress.Location = new System.Drawing.Point(19, 67);
            this.lb_adress.Name = "lb_adress";
            this.lb_adress.Size = new System.Drawing.Size(41, 13);
            this.lb_adress.TabIndex = 3;
            this.lb_adress.Text = "adress:";
            // 
            // lb_naam
            // 
            this.lb_naam.AutoSize = true;
            this.lb_naam.Location = new System.Drawing.Point(19, 37);
            this.lb_naam.Name = "lb_naam";
            this.lb_naam.Size = new System.Drawing.Size(36, 13);
            this.lb_naam.TabIndex = 2;
            this.lb_naam.Text = "naam:";
            // 
            // pb_profile
            // 
            this.pb_profile.Location = new System.Drawing.Point(325, 19);
            this.pb_profile.Name = "pb_profile";
            this.pb_profile.Size = new System.Drawing.Size(80, 89);
            this.pb_profile.TabIndex = 1;
            this.pb_profile.TabStop = false;
            // 
            // pb_paspoort
            // 
            this.pb_paspoort.Location = new System.Drawing.Point(184, 129);
            this.pb_paspoort.Name = "pb_paspoort";
            this.pb_paspoort.Size = new System.Drawing.Size(221, 115);
            this.pb_paspoort.TabIndex = 0;
            this.pb_paspoort.TabStop = false;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(292, 51);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 23);
            this.btnMessage.TabIndex = 22;
            this.btnMessage.Text = "Berichten";
            this.btnMessage.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(373, 51);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 23;
            this.btnRent.Text = "Huren";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnEntrance
            // 
            this.btnEntrance.Location = new System.Drawing.Point(454, 51);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(75, 23);
            this.btnEntrance.TabIndex = 24;
            this.btnEntrance.Text = "Entree";
            this.btnEntrance.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(535, 51);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(26, 143);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 26;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Location = new System.Drawing.Point(26, 24);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(242, 78);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogo.TabIndex = 27;
            this.pbxLogo.TabStop = false;
            // 
            // btnRentList
            // 
            this.btnRentList.Location = new System.Drawing.Point(26, 273);
            this.btnRentList.Name = "btnRentList";
            this.btnRentList.Size = new System.Drawing.Size(100, 23);
            this.btnRentList.TabIndex = 28;
            this.btnRentList.Text = "Huur";
            this.btnRentList.UseVisualStyleBackColor = true;
            // 
            // btnRentableList
            // 
            this.btnRentableList.Location = new System.Drawing.Point(26, 302);
            this.btnRentableList.Name = "btnRentableList";
            this.btnRentableList.Size = new System.Drawing.Size(100, 23);
            this.btnRentableList.TabIndex = 29;
            this.btnRentableList.Text = "Verhuurbaar";
            this.btnRentableList.UseVisualStyleBackColor = true;
            // 
            // btnRentedList
            // 
            this.btnRentedList.Location = new System.Drawing.Point(26, 331);
            this.btnRentedList.Name = "btnRentedList";
            this.btnRentedList.Size = new System.Drawing.Size(100, 23);
            this.btnRentedList.TabIndex = 30;
            this.btnRentedList.Text = "Verhuurd";
            this.btnRentedList.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(26, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 477);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.btnRentedList);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnRentableList);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnRentList);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tbxSearch);
            this.Name = "EntranceForm";
            this.Text = "entranceForm";
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_paspoort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox profile;
        private System.Windows.Forms.Label lb_payed;
        private System.Windows.Forms.Label lb_adress;
        private System.Windows.Forms.Label lb_naam;
        private System.Windows.Forms.PictureBox pb_profile;
        private System.Windows.Forms.PictureBox pb_paspoort;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnRentList;
        private System.Windows.Forms.Button btnRentableList;
        private System.Windows.Forms.Button btnRentedList;
        private System.Windows.Forms.Button btnSearch;
    }
}