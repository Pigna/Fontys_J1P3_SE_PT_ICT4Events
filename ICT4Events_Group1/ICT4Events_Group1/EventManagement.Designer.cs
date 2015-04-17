namespace ICT4Events_Group1
{
    partial class EventManagement
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbxLastEvents = new System.Windows.Forms.ListBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.grpEvent = new System.Windows.Forms.GroupBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.txtBeschrijving = new System.Windows.Forms.RichTextBox();
            this.datTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.datTimeStart = new System.Windows.Forms.DateTimePicker();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.grpEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(171, 174);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 13);
            this.lblDesc.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(551, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 18);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbxLastEvents
            // 
            this.lbxLastEvents.FormattingEnabled = true;
            this.lbxLastEvents.Location = new System.Drawing.Point(458, 154);
            this.lbxLastEvents.Name = "lbxLastEvents";
            this.lbxLastEvents.Size = new System.Drawing.Size(156, 199);
            this.lbxLastEvents.TabIndex = 21;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Location = new System.Drawing.Point(30, 48);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(242, 78);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogo.TabIndex = 17;
            this.pbxLogo.TabStop = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(457, 132);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(538, 75);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnEntrance
            // 
            this.btnEntrance.Location = new System.Drawing.Point(458, 75);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(75, 23);
            this.btnEntrance.TabIndex = 14;
            this.btnEntrance.Text = "Entree";
            this.btnEntrance.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(376, 75);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 13;
            this.btnRent.Text = "Huren";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(296, 75);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 23);
            this.btnMessage.TabIndex = 12;
            this.btnMessage.Text = "Berichten";
            this.btnMessage.UseVisualStyleBackColor = true;
            // 
            // grpEvent
            // 
            this.grpEvent.Controls.Add(this.btnCreateEvent);
            this.grpEvent.Controls.Add(this.label5);
            this.grpEvent.Controls.Add(this.label4);
            this.grpEvent.Controls.Add(this.label3);
            this.grpEvent.Controls.Add(this.label2);
            this.grpEvent.Controls.Add(this.label1);
            this.grpEvent.Controls.Add(this.lblEuro);
            this.grpEvent.Controls.Add(this.numCost);
            this.grpEvent.Controls.Add(this.txtBeschrijving);
            this.grpEvent.Controls.Add(this.datTimeEnd);
            this.grpEvent.Controls.Add(this.datTimeStart);
            this.grpEvent.Controls.Add(this.txtNaam);
            this.grpEvent.Location = new System.Drawing.Point(30, 132);
            this.grpEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEvent.Size = new System.Drawing.Size(422, 136);
            this.grpEvent.TabIndex = 24;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Maak nieuw event";
            this.grpEvent.Enter += new System.EventHandler(this.grpEvent_Enter);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(266, 105);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(145, 19);
            this.btnCreateEvent.TabIndex = 11;
            this.btnCreateEvent.Text = "Maak";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Beschrijving";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Van";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kosten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.BackColor = System.Drawing.Color.White;
            this.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEuro.Location = new System.Drawing.Point(52, 45);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Padding = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.lblEuro.Size = new System.Drawing.Size(15, 18);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "€";
            this.lblEuro.Click += new System.EventHandler(this.lblEuro_Click);
            // 
            // numCost
            // 
            this.numCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCost.DecimalPlaces = 2;
            this.numCost.Location = new System.Drawing.Point(65, 45);
            this.numCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(118, 20);
            this.numCost.TabIndex = 4;
            this.numCost.ValueChanged += new System.EventHandler(this.numCost_ValueChanged);
            // 
            // txtBeschrijving
            // 
            this.txtBeschrijving.Location = new System.Drawing.Point(266, 22);
            this.txtBeschrijving.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBeschrijving.Name = "txtBeschrijving";
            this.txtBeschrijving.Size = new System.Drawing.Size(146, 77);
            this.txtBeschrijving.TabIndex = 3;
            this.txtBeschrijving.Text = "";
            // 
            // datTimeEnd
            // 
            this.datTimeEnd.Location = new System.Drawing.Point(52, 103);
            this.datTimeEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datTimeEnd.Name = "datTimeEnd";
            this.datTimeEnd.Size = new System.Drawing.Size(132, 20);
            this.datTimeEnd.TabIndex = 2;
            this.datTimeEnd.ValueChanged += new System.EventHandler(this.datTimeEnd_ValueChanged);
            // 
            // datTimeStart
            // 
            this.datTimeStart.Location = new System.Drawing.Point(52, 80);
            this.datTimeStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datTimeStart.Name = "datTimeStart";
            this.datTimeStart.Size = new System.Drawing.Size(132, 20);
            this.datTimeStart.TabIndex = 1;
            this.datTimeStart.ValueChanged += new System.EventHandler(this.datTimeStart_ValueChanged);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(52, 22);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(132, 20);
            this.txtNaam.TabIndex = 0;
            this.txtNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateEmployee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(30, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 95);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voeg medewerker toe";
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(7, 63);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(176, 19);
            this.btnCreateEmployee.TabIndex = 4;
            this.btnCreateEmployee.Text = "Voeg toe";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Naam";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(52, 41);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '-';
            this.txtPassword.Size = new System.Drawing.Size(132, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(52, 18);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.Location = new System.Drawing.Point(232, 310);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(100, 69);
            this.lbxEmployees.TabIndex = 26;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(232, 283);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(100, 20);
            this.txtEmployee.TabIndex = 27;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(344, 283);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(62, 18);
            this.btnEmployee.TabIndex = 28;
            this.btnEmployee.Text = "Zoeken";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(344, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 20);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 20);
            this.button1.TabIndex = 30;
            this.button1.Text = "Verwijder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.lbxEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEvent);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbxLastEvents);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnMessage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventManagement";
            this.Text = "EventManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbxLastEvents;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.GroupBox grpEvent;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.RichTextBox txtBeschrijving;
        private System.Windows.Forms.DateTimePicker datTimeEnd;
        private System.Windows.Forms.DateTimePicker datTimeStart;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
    }
}