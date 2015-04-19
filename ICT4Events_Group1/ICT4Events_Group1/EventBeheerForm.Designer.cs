namespace ICT4Events_Group1
{
    partial class EventBeheerForm
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
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
            this.tbxNaam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnVerwijderMedewerker = new System.Windows.Forms.Button();
            this.btnVerwijderEvent = new System.Windows.Forms.Button();
            this.grpEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(228, 78);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 17);
            this.lblDesc.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(735, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 22);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbxLastEvents
            // 
            this.lbxLastEvents.FormattingEnabled = true;
            this.lbxLastEvents.ItemHeight = 16;
            this.lbxLastEvents.Location = new System.Drawing.Point(611, 54);
            this.lbxLastEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxLastEvents.Name = "lbxLastEvents";
            this.lbxLastEvents.Size = new System.Drawing.Size(207, 244);
            this.lbxLastEvents.TabIndex = 21;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(609, 26);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(132, 22);
            this.tbxSearch.TabIndex = 16;
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
            this.grpEvent.Controls.Add(this.tbxNaam);
            this.grpEvent.Location = new System.Drawing.Point(40, 26);
            this.grpEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEvent.Size = new System.Drawing.Size(563, 167);
            this.grpEvent.TabIndex = 24;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Maak nieuw event";
            this.grpEvent.Enter += new System.EventHandler(this.grpEvent_Enter);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(355, 129);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(193, 23);
            this.btnCreateEvent.TabIndex = 11;
            this.btnCreateEvent.Text = "Maak";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Beschrijving";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Van";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kosten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.BackColor = System.Drawing.Color.White;
            this.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEuro.Location = new System.Drawing.Point(69, 55);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Padding = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.lblEuro.Size = new System.Drawing.Size(18, 22);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "€";
            this.lblEuro.Click += new System.EventHandler(this.lblEuro_Click);
            // 
            // numCost
            // 
            this.numCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCost.DecimalPlaces = 2;
            this.numCost.Location = new System.Drawing.Point(87, 55);
            this.numCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(157, 22);
            this.numCost.TabIndex = 4;
            this.numCost.ValueChanged += new System.EventHandler(this.numCost_ValueChanged);
            // 
            // txtBeschrijving
            // 
            this.txtBeschrijving.Location = new System.Drawing.Point(355, 27);
            this.txtBeschrijving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBeschrijving.Name = "txtBeschrijving";
            this.txtBeschrijving.Size = new System.Drawing.Size(193, 94);
            this.txtBeschrijving.TabIndex = 3;
            this.txtBeschrijving.Text = "";
            // 
            // datTimeEnd
            // 
            this.datTimeEnd.Location = new System.Drawing.Point(69, 127);
            this.datTimeEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datTimeEnd.Name = "datTimeEnd";
            this.datTimeEnd.Size = new System.Drawing.Size(175, 22);
            this.datTimeEnd.TabIndex = 2;
            this.datTimeEnd.ValueChanged += new System.EventHandler(this.datTimeEnd_ValueChanged);
            // 
            // datTimeStart
            // 
            this.datTimeStart.Location = new System.Drawing.Point(69, 98);
            this.datTimeStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datTimeStart.Name = "datTimeStart";
            this.datTimeStart.Size = new System.Drawing.Size(175, 22);
            this.datTimeStart.TabIndex = 1;
            this.datTimeStart.ValueChanged += new System.EventHandler(this.datTimeStart_ValueChanged);
            // 
            // tbxNaam
            // 
            this.tbxNaam.Location = new System.Drawing.Point(69, 27);
            this.tbxNaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNaam.Name = "tbxNaam";
            this.tbxNaam.Size = new System.Drawing.Size(175, 22);
            this.tbxNaam.TabIndex = 0;
            this.tbxNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateEmployee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(40, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(261, 117);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voeg medewerker toe";
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(9, 78);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(235, 23);
            this.btnCreateEmployee.TabIndex = 4;
            this.btnCreateEmployee.Text = "Voeg toe";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Naam";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(69, 50);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '-';
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(69, 22);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(175, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 16;
            this.lbxEmployees.Location = new System.Drawing.Point(309, 246);
            this.lbxEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(132, 84);
            this.lbxEmployees.TabIndex = 26;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(309, 212);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(132, 22);
            this.txtEmployee.TabIndex = 27;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(459, 212);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(83, 22);
            this.btnSearchEmployee.TabIndex = 28;
            this.btnSearchEmployee.Text = "Zoeken";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnVerwijderMedewerker
            // 
            this.btnVerwijderMedewerker.Location = new System.Drawing.Point(459, 305);
            this.btnVerwijderMedewerker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerwijderMedewerker.Name = "btnVerwijderMedewerker";
            this.btnVerwijderMedewerker.Size = new System.Drawing.Size(83, 25);
            this.btnVerwijderMedewerker.TabIndex = 29;
            this.btnVerwijderMedewerker.Text = "Verwijder";
            this.btnVerwijderMedewerker.UseVisualStyleBackColor = true;
            this.btnVerwijderMedewerker.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVerwijderEvent
            // 
            this.btnVerwijderEvent.Location = new System.Drawing.Point(611, 305);
            this.btnVerwijderEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerwijderEvent.Name = "btnVerwijderEvent";
            this.btnVerwijderEvent.Size = new System.Drawing.Size(207, 25);
            this.btnVerwijderEvent.TabIndex = 30;
            this.btnVerwijderEvent.Text = "Verwijder";
            this.btnVerwijderEvent.UseVisualStyleBackColor = true;
            this.btnVerwijderEvent.Click += new System.EventHandler(this.btnVerwijderEvent_Click);
            // 
            // EventBeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 363);
            this.Controls.Add(this.btnVerwijderEvent);
            this.Controls.Add(this.btnVerwijderMedewerker);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.lbxEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEvent);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbxLastEvents);
            this.Controls.Add(this.tbxSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventBeheerForm";
            this.Text = "EventManagement";
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
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox grpEvent;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.RichTextBox txtBeschrijving;
        private System.Windows.Forms.DateTimePicker datTimeEnd;
        private System.Windows.Forms.DateTimePicker datTimeStart;
        private System.Windows.Forms.TextBox tbxNaam;
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
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnVerwijderMedewerker;
        private System.Windows.Forms.Button btnVerwijderEvent;
    }
}