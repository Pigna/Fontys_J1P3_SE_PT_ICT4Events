﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets.Events;
using Phidgets;

namespace ICT4Events_Group1
{
    public partial class UserLogin : Form
    {
        Database db = new Database();
        RFID rfid = new RFID();
        MenuForm MF = null;

        public UserLogin()
        {
            InitializeComponent();
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);


            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);

            openCmdLine(rfid);


        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if(!db.logIn(txtUsername.Text, txtPassword.Text))
            {
                lblMsg.Text = "Gebruiker login niet gelukt.";
                txtPassword.Text = "";
            }
            else
            {
                this.Hide();
                Form open = new MediaSharingForm(this);
                open.Closed += (s, args) => this.Close();
                open.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (!db.empLogIn(txtUsername.Text, txtPassword.Text))
            {
                lblMsg.Text = "Beheerder login niet gelukt.";
                txtPassword.Text = "";
            }
            else
            {
                this.Hide();
                MF = new MenuForm(this);
                MF.Closed += (s, args) => this.Close();
                MF.Show();
            }
        }



        // als de tag gescant is wordt het veld gevult met de code
        void rfid_Tag(object sender, TagEventArgs e)
        {
            // e.Tag;
            if (MF != null)
                MF.RfidGet(e.Tag);

        }

        //als de tag weg is word het veld weer blank
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            if (MF != null)
                MF.rfidLost();
           

        }
        void rfid_Attach(object sender, AttachEventArgs e)
        {

        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {

        }
        public void clear()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        #region Command line open functions
        private void openCmdLine(Phidget p)
        {
            openCmdLine(p, null);
        }
        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            String logFile = null;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try
            { //Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "l":
                                logFile = (args[++i]);
                                break;
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }
                if (logFile != null)
                    Phidget.enableLogging(Phidget.LogLevel.PHIDGET_LOG_INFO, logFile);
                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return; //success
            }
            catch { }
        usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-l   logFile\tEnable phidget21 logging to logFile.");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }
        #endregion
    }
}
