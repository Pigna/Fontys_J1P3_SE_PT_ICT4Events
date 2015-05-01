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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btn_scanUit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxRFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rlink = new System.Windows.Forms.Button();
            this.btn_aanw = new System.Windows.Forms.Button();
            this.profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.Controls.Add(this.lb_payed);
            this.profile.Controls.Add(this.lb_adress);
            this.profile.Controls.Add(this.lb_naam);
            this.profile.Location = new System.Drawing.Point(496, 71);
            this.profile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profile.Size = new System.Drawing.Size(382, 343);
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            this.profile.Text = "profiel";
            // 
            // lb_payed
            // 
            this.lb_payed.AutoSize = true;
            this.lb_payed.Location = new System.Drawing.Point(25, 187);
            this.lb_payed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_payed.Name = "lb_payed";
            this.lb_payed.Size = new System.Drawing.Size(59, 17);
            this.lb_payed.TabIndex = 4;
            this.lb_payed.Text = "betaald:";
            // 
            // lb_adress
            // 
            this.lb_adress.AutoSize = true;
            this.lb_adress.Location = new System.Drawing.Point(25, 82);
            this.lb_adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_adress.Name = "lb_adress";
            this.lb_adress.Size = new System.Drawing.Size(55, 17);
            this.lb_adress.TabIndex = 3;
            this.lb_adress.Text = "adress:";
            // 
            // lb_naam
            // 
            this.lb_naam.AutoSize = true;
            this.lb_naam.Location = new System.Drawing.Point(25, 46);
            this.lb_naam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_naam.Name = "lb_naam";
            this.lb_naam.Size = new System.Drawing.Size(47, 17);
            this.lb_naam.TabIndex = 2;
            this.lb_naam.Text = "naam:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(139, 44);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(132, 22);
            this.tbxSearch.TabIndex = 26;
            // 
            // btn_scanUit
            // 
            this.btn_scanUit.Location = new System.Drawing.Point(139, 111);
            this.btn_scanUit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_scanUit.Name = "btn_scanUit";
            this.btn_scanUit.Size = new System.Drawing.Size(133, 28);
            this.btn_scanUit.TabIndex = 30;
            this.btn_scanUit.Text = "scan uit";
            this.btn_scanUit.UseVisualStyleBackColor = true;
            this.btn_scanUit.Click += new System.EventHandler(this.btn_scanUit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 44);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 28);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxRFID
            // 
            this.tbxRFID.Location = new System.Drawing.Point(139, 80);
            this.tbxRFID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxRFID.Name = "tbxRFID";
            this.tbxRFID.Size = new System.Drawing.Size(132, 22);
            this.tbxRFID.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "RFID";
            // 
            // btn_rlink
            // 
            this.btn_rlink.Location = new System.Drawing.Point(280, 78);
            this.btn_rlink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rlink.Name = "btn_rlink";
            this.btn_rlink.Size = new System.Drawing.Size(133, 28);
            this.btn_rlink.TabIndex = 36;
            this.btn_rlink.Text = "link RFID";
            this.btn_rlink.UseVisualStyleBackColor = true;
            this.btn_rlink.Click += new System.EventHandler(this.btn_rlink_Click);
            // 
            // btn_aanw
            // 
            this.btn_aanw.Location = new System.Drawing.Point(84, 358);
            this.btn_aanw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_aanw.Name = "btn_aanw";
            this.btn_aanw.Size = new System.Drawing.Size(133, 28);
            this.btn_aanw.TabIndex = 39;
            this.btn_aanw.Text = "aanwezigen";
            this.btn_aanw.UseVisualStyleBackColor = true;
            this.btn_aanw.Click += new System.EventHandler(this.btn_aanw_Click);
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 431);
            this.Controls.Add(this.btn_aanw);
            this.Controls.Add(this.btn_rlink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRFID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.btn_scanUit);
            this.Controls.Add(this.tbxSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EntranceForm";
            this.Text = "entranceForm";
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox profile;
        private System.Windows.Forms.Label lb_payed;
        private System.Windows.Forms.Label lb_adress;
        private System.Windows.Forms.Label lb_naam;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btn_scanUit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxRFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rlink;
        private System.Windows.Forms.Button btn_aanw;
    }
}