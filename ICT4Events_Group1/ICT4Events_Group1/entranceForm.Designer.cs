namespace ICT4Events_Group1
{
    partial class entranceForm
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
            this.pb_paspoort = new System.Windows.Forms.PictureBox();
            this.pb_profile = new System.Windows.Forms.PictureBox();
            this.lb_naam = new System.Windows.Forms.Label();
            this.tb_adress = new System.Windows.Forms.Label();
            this.lb_payed = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_zoeken = new System.Windows.Forms.Button();
            this.bt_scan = new System.Windows.Forms.Button();
            this.bt_verlopen = new System.Windows.Forms.Button();
            this.profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_paspoort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.Controls.Add(this.lb_payed);
            this.profile.Controls.Add(this.tb_adress);
            this.profile.Controls.Add(this.lb_naam);
            this.profile.Controls.Add(this.pb_profile);
            this.profile.Controls.Add(this.pb_paspoort);
            this.profile.Location = new System.Drawing.Point(117, 153);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(460, 279);
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            this.profile.Text = "profiel";
            // 
            // pb_paspoort
            // 
            this.pb_paspoort.Location = new System.Drawing.Point(248, 129);
            this.pb_paspoort.Name = "pb_paspoort";
            this.pb_paspoort.Size = new System.Drawing.Size(157, 115);
            this.pb_paspoort.TabIndex = 0;
            this.pb_paspoort.TabStop = false;
            // 
            // pb_profile
            // 
            this.pb_profile.Location = new System.Drawing.Point(325, 19);
            this.pb_profile.Name = "pb_profile";
            this.pb_profile.Size = new System.Drawing.Size(80, 89);
            this.pb_profile.TabIndex = 1;
            this.pb_profile.TabStop = false;
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
            // tb_adress
            // 
            this.tb_adress.AutoSize = true;
            this.tb_adress.Location = new System.Drawing.Point(19, 67);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(41, 13);
            this.tb_adress.TabIndex = 3;
            this.tb_adress.Text = "adress:";
            // 
            // lb_payed
            // 
            this.lb_payed.AutoSize = true;
            this.lb_payed.Location = new System.Drawing.Point(19, 153);
            this.lb_payed.Name = "lb_payed";
            this.lb_payed.Size = new System.Drawing.Size(45, 13);
            this.lb_payed.TabIndex = 4;
            this.lb_payed.Text = "betaald:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bt_zoeken
            // 
            this.bt_zoeken.Location = new System.Drawing.Point(145, 39);
            this.bt_zoeken.Name = "bt_zoeken";
            this.bt_zoeken.Size = new System.Drawing.Size(75, 23);
            this.bt_zoeken.TabIndex = 2;
            this.bt_zoeken.Text = "zoeken";
            this.bt_zoeken.UseVisualStyleBackColor = true;
            // 
            // bt_scan
            // 
            this.bt_scan.Location = new System.Drawing.Point(29, 74);
            this.bt_scan.Name = "bt_scan";
            this.bt_scan.Size = new System.Drawing.Size(75, 23);
            this.bt_scan.TabIndex = 3;
            this.bt_scan.Text = "scan";
            this.bt_scan.UseVisualStyleBackColor = true;
            // 
            // bt_verlopen
            // 
            this.bt_verlopen.Location = new System.Drawing.Point(29, 103);
            this.bt_verlopen.Name = "bt_verlopen";
            this.bt_verlopen.Size = new System.Drawing.Size(75, 23);
            this.bt_verlopen.TabIndex = 4;
            this.bt_verlopen.Text = "expired";
            this.bt_verlopen.UseVisualStyleBackColor = true;
            // 
            // entranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 477);
            this.Controls.Add(this.bt_verlopen);
            this.Controls.Add(this.bt_scan);
            this.Controls.Add(this.bt_zoeken);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.profile);
            this.Name = "entranceForm";
            this.Text = "entranceForm";
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_paspoort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox profile;
        private System.Windows.Forms.Label lb_payed;
        private System.Windows.Forms.Label tb_adress;
        private System.Windows.Forms.Label lb_naam;
        private System.Windows.Forms.PictureBox pb_profile;
        private System.Windows.Forms.PictureBox pb_paspoort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_zoeken;
        private System.Windows.Forms.Button bt_scan;
        private System.Windows.Forms.Button bt_verlopen;
    }
}