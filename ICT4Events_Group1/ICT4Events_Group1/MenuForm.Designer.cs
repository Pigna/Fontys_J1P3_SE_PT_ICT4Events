namespace ICT4Events_Group1
{
    partial class MenuForm
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
            this.btnVerhuur = new System.Windows.Forms.Button();
            this.btnBeheer = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.lblCur = new System.Windows.Forms.Label();
            this.btn_Entrance = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Location = new System.Drawing.Point(13, 49);
            this.btnVerhuur.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(188, 28);
            this.btnVerhuur.TabIndex = 1;
            this.btnVerhuur.Text = "Verhuur";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            this.btnVerhuur.Click += new System.EventHandler(this.btnVerhuur_Click);
            // 
            // btnBeheer
            // 
            this.btnBeheer.Location = new System.Drawing.Point(13, 85);
            this.btnBeheer.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeheer.Name = "btnBeheer";
            this.btnBeheer.Size = new System.Drawing.Size(188, 28);
            this.btnBeheer.TabIndex = 2;
            this.btnBeheer.Text = "Gebruikers";
            this.btnBeheer.UseVisualStyleBackColor = true;
            this.btnBeheer.Click += new System.EventHandler(this.btnBeheer_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(13, 157);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(188, 28);
            this.btnEvent.TabIndex = 4;
            this.btnEvent.Text = "Event";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblCur
            // 
            this.lblCur.AutoSize = true;
            this.lblCur.Location = new System.Drawing.Point(460, 187);
            this.lblCur.Name = "lblCur";
            this.lblCur.Size = new System.Drawing.Size(0, 17);
            this.lblCur.TabIndex = 7;
            // 
            // btn_Entrance
            // 
            this.btn_Entrance.Location = new System.Drawing.Point(13, 13);
            this.btn_Entrance.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Entrance.Name = "btn_Entrance";
            this.btn_Entrance.Size = new System.Drawing.Size(188, 28);
            this.btn_Entrance.TabIndex = 0;
            this.btn_Entrance.Text = "Entrance";
            this.btn_Entrance.UseVisualStyleBackColor = true;
            this.btn_Entrance.Click += new System.EventHandler(this.btn_Entrance_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Berichten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Entrance);
            this.Controls.Add(this.lblCur);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnBeheer);
            this.Controls.Add(this.btnVerhuur);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerhuur;
        private System.Windows.Forms.Button btnBeheer;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Label lblCur;
        private System.Windows.Forms.Button btn_Entrance;
        private System.Windows.Forms.Button button1;
    }
}