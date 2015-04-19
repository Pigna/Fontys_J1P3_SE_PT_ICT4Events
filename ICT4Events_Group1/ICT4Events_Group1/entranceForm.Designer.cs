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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btn_scanUit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxRFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rlink = new System.Windows.Forms.Button();
            this.tb_proto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_paspoort)).BeginInit();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.Controls.Add(this.lb_payed);
            this.profile.Controls.Add(this.lb_adress);
            this.profile.Controls.Add(this.lb_naam);
            this.profile.Controls.Add(this.pb_profile);
            this.profile.Controls.Add(this.pb_paspoort);
            this.profile.Location = new System.Drawing.Point(372, 58);
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
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(104, 36);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 26;
            // 
            // btn_scanUit
            // 
            this.btn_scanUit.Location = new System.Drawing.Point(210, 95);
            this.btn_scanUit.Name = "btn_scanUit";
            this.btn_scanUit.Size = new System.Drawing.Size(100, 23);
            this.btn_scanUit.TabIndex = 30;
            this.btn_scanUit.Text = "scan uit";
            this.btn_scanUit.UseVisualStyleBackColor = true;
            this.btn_scanUit.Click += new System.EventHandler(this.btn_scanUit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(210, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxRFID
            // 
            this.tbxRFID.Location = new System.Drawing.Point(104, 65);
            this.tbxRFID.Name = "tbxRFID";
            this.tbxRFID.Size = new System.Drawing.Size(100, 20);
            this.tbxRFID.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "RFID";
            // 
            // btn_rlink
            // 
            this.btn_rlink.Location = new System.Drawing.Point(210, 63);
            this.btn_rlink.Name = "btn_rlink";
            this.btn_rlink.Size = new System.Drawing.Size(100, 23);
            this.btn_rlink.TabIndex = 36;
            this.btn_rlink.Text = "link RFID";
            this.btn_rlink.UseVisualStyleBackColor = true;
            this.btn_rlink.Click += new System.EventHandler(this.btn_rlink_Click);
            // 
            // tb_proto
            // 
            this.tb_proto.Location = new System.Drawing.Point(104, 97);
            this.tb_proto.Name = "tb_proto";
            this.tb_proto.Size = new System.Drawing.Size(100, 20);
            this.tb_proto.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "prot";
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_proto);
            this.Controls.Add(this.btn_rlink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRFID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.btn_scanUit);
            this.Controls.Add(this.tbxSearch);
            this.Name = "EntranceForm";
            this.Text = "entranceForm";
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_paspoort)).EndInit();
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
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btn_scanUit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxRFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rlink;
        private System.Windows.Forms.TextBox tb_proto;
        private System.Windows.Forms.Label label3;
    }
}