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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbxRentList = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbxItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.btnRentItem = new System.Windows.Forms.Button();
            this.dtpVan = new System.Windows.Forms.DateTimePicker();
            this.dtpTot = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbBetaald = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKosten = new System.Windows.Forms.Label();
            this.tbxRFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbBetaald_b = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radAlles = new System.Windows.Forms.RadioButton();
            this.radHuurbaar = new System.Windows.Forms.RadioButton();
            this.radVerhuurd = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(26, 20);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 4;
            // 
            // lbxRentList
            // 
            this.lbxRentList.FormattingEnabled = true;
            this.lbxRentList.Location = new System.Drawing.Point(130, 20);
            this.lbxRentList.Name = "lbxRentList";
            this.lbxRentList.Size = new System.Drawing.Size(284, 134);
            this.lbxRentList.TabIndex = 9;
            this.lbxRentList.SelectedIndexChanged += new System.EventHandler(this.lbxRentList_SelectedIndexChanged);
            this.lbxRentList.DoubleClick += new System.EventHandler(this.lbxRentList_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(26, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 18);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(167, 28);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 13);
            this.lblDesc.TabIndex = 11;
            // 
            // tbxItemID
            // 
            this.tbxItemID.Location = new System.Drawing.Point(68, 18);
            this.tbxItemID.Name = "tbxItemID";
            this.tbxItemID.Size = new System.Drawing.Size(80, 20);
            this.tbxItemID.TabIndex = 12;
            this.tbxItemID.TextChanged += new System.EventHandler(this.tbxItemID_TextChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(9, 20);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(41, 13);
            this.lblItemID.TabIndex = 15;
            this.lblItemID.Text = "Item ID";
            this.lblItemID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(171, 20);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(26, 13);
            this.lblDate1.TabIndex = 16;
            this.lblDate1.Text = "Van";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(174, 48);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(23, 13);
            this.lblDate2.TabIndex = 17;
            this.lblDate2.Text = "Tot";
            // 
            // btnRentItem
            // 
            this.btnRentItem.Location = new System.Drawing.Point(429, 39);
            this.btnRentItem.Name = "btnRentItem";
            this.btnRentItem.Size = new System.Drawing.Size(58, 23);
            this.btnRentItem.TabIndex = 18;
            this.btnRentItem.Text = "Huur item";
            this.btnRentItem.UseVisualStyleBackColor = true;
            this.btnRentItem.Click += new System.EventHandler(this.btnRentItem_Click);
            // 
            // dtpVan
            // 
            this.dtpVan.Location = new System.Drawing.Point(202, 16);
            this.dtpVan.Name = "dtpVan";
            this.dtpVan.Size = new System.Drawing.Size(100, 20);
            this.dtpVan.TabIndex = 19;
            // 
            // dtpTot
            // 
            this.dtpTot.Location = new System.Drawing.Point(202, 44);
            this.dtpTot.Name = "dtpTot";
            this.dtpTot.Size = new System.Drawing.Size(100, 20);
            this.dtpTot.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbBetaald);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRentItem);
            this.groupBox1.Controls.Add(this.lblKosten);
            this.groupBox1.Controls.Add(this.tbxRFID);
            this.groupBox1.Controls.Add(this.dtpTot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpVan);
            this.groupBox1.Controls.Add(this.lblDate2);
            this.groupBox1.Controls.Add(this.tbxItemID);
            this.groupBox1.Controls.Add(this.lblItemID);
            this.groupBox1.Controls.Add(this.lblDate1);
            this.groupBox1.Location = new System.Drawing.Point(26, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(492, 73);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item uitlenen";
            // 
            // ckbBetaald
            // 
            this.ckbBetaald.AutoSize = true;
            this.ckbBetaald.Location = new System.Drawing.Point(429, 20);
            this.ckbBetaald.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbBetaald.Name = "ckbBetaald";
            this.ckbBetaald.Size = new System.Drawing.Size(62, 17);
            this.ckbBetaald.TabIndex = 24;
            this.ckbBetaald.Text = "Betaald";
            this.ckbBetaald.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "  ";
            // 
            // lblKosten
            // 
            this.lblKosten.AutoSize = true;
            this.lblKosten.Location = new System.Drawing.Point(507, 20);
            this.lblKosten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKosten.Name = "lblKosten";
            this.lblKosten.Size = new System.Drawing.Size(0, 13);
            this.lblKosten.TabIndex = 21;
            // 
            // tbxRFID
            // 
            this.tbxRFID.Location = new System.Drawing.Point(68, 46);
            this.tbxRFID.Name = "tbxRFID";
            this.tbxRFID.Size = new System.Drawing.Size(80, 20);
            this.tbxRFID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "RFID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ckbBetaald_b);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 257);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(492, 54);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Terugbrengen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Neem item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbBetaald_b
            // 
            this.ckbBetaald_b.AutoSize = true;
            this.ckbBetaald_b.Location = new System.Drawing.Point(173, 20);
            this.ckbBetaald_b.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbBetaald_b.Name = "ckbBetaald_b";
            this.ckbBetaald_b.Size = new System.Drawing.Size(62, 17);
            this.ckbBetaald_b.TabIndex = 27;
            this.ckbBetaald_b.Text = "Betaald";
            this.ckbBetaald_b.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "  ";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(68, 20);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(80, 20);
            this.txtItem.TabIndex = 25;
            this.txtItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Item ID";
            // 
            // radAlles
            // 
            this.radAlles.AutoSize = true;
            this.radAlles.Checked = true;
            this.radAlles.Location = new System.Drawing.Point(11, 20);
            this.radAlles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radAlles.Name = "radAlles";
            this.radAlles.Size = new System.Drawing.Size(47, 17);
            this.radAlles.TabIndex = 23;
            this.radAlles.TabStop = true;
            this.radAlles.Text = "Alles";
            this.radAlles.UseVisualStyleBackColor = true;
            this.radAlles.CheckedChanged += new System.EventHandler(this.radAlles_CheckedChanged);
            // 
            // radHuurbaar
            // 
            this.radHuurbaar.AutoSize = true;
            this.radHuurbaar.Location = new System.Drawing.Point(11, 43);
            this.radHuurbaar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radHuurbaar.Name = "radHuurbaar";
            this.radHuurbaar.Size = new System.Drawing.Size(69, 17);
            this.radHuurbaar.TabIndex = 24;
            this.radHuurbaar.Text = "Huurbaar";
            this.radHuurbaar.UseVisualStyleBackColor = true;
            this.radHuurbaar.CheckedChanged += new System.EventHandler(this.radHuurbaar_CheckedChanged);
            // 
            // radVerhuurd
            // 
            this.radVerhuurd.AutoSize = true;
            this.radVerhuurd.Location = new System.Drawing.Point(11, 66);
            this.radVerhuurd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radVerhuurd.Name = "radVerhuurd";
            this.radVerhuurd.Size = new System.Drawing.Size(68, 17);
            this.radVerhuurd.TabIndex = 25;
            this.radVerhuurd.Text = "Verhuurd";
            this.radVerhuurd.UseVisualStyleBackColor = true;
            this.radVerhuurd.CheckedChanged += new System.EventHandler(this.radVerhuurd_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radAlles);
            this.groupBox3.Controls.Add(this.radVerhuurd);
            this.groupBox3.Controls.Add(this.radHuurbaar);
            this.groupBox3.Location = new System.Drawing.Point(418, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(99, 93);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toon";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(26, 136);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 18);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Terug";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // VerhuurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 333);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbxRentList);
            this.Controls.Add(this.tbxSearch);
            this.Name = "VerhuurForm";
            this.Text = "VerhuurForm";
            this.Load += new System.EventHandler(this.VerhuurForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxRentList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbxItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Button btnRentItem;
        private System.Windows.Forms.DateTimePicker dtpVan;
        private System.Windows.Forms.DateTimePicker dtpTot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbBetaald;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKosten;
        private System.Windows.Forms.TextBox tbxRFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbBetaald_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radAlles;
        private System.Windows.Forms.RadioButton radHuurbaar;
        private System.Windows.Forms.RadioButton radVerhuurd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
    }
}