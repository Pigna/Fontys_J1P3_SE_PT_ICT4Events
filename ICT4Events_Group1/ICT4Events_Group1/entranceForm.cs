using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Phidgets.Events;
using Phidgets;

namespace ICT4Events_Group1
{
    public partial class EntranceForm : Form
    {
        EntranceDatabase endata = new EntranceDatabase();
        private RFID rfid;

        public EntranceForm()
        {
            InitializeComponent();

            rfid = new RFID();

         //   rfid.Attach += new AttachEventHandler(rfid_Attach);
         //   rfid.Detach += new DetachEventHandler(rfid_Detach);
       

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);

            openCmdLine(rfid);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    //  current = new User(Convert.ToInt16(cur["ID"]), (string) cur["USERNAME"], (string) cur["VOORNAAM"], (string) cur["TUSSENVOEGSEL"], (string) cur["ACHTERNAAM"]);
            
                    List<Dictionary<string, object>> data = endata.GetContact(Convert.ToInt32(tbxSearch.Text));
                    Dictionary<string, object> cur = data[0];

                    lb_naam.Text = (string)cur["voornaam"] + " " + (string)cur["tussenvoegsel"] + " " + (string)cur["achternaam"];
                    lb_adress.Text = (string)cur["woonplaats"];
                    pb_paspoort.ImageLocation = (string)cur["paspoort"];
                    pb_profile.ImageLocation = (string)cur["foto"];
                    if ((int)cur["betaald"] == 0)
                    {
                        lb_payed.Text = "nog niet betaald";
                    }
                    else
                    {
                        lb_payed.Text = "betaald";
                    }
                }
                catch
                {
                    MessageBox.Show("database connect niet");
                }
            }
            catch
            {
                MessageBox.Show("data is niet goed ingevult");
            }
        }

        private void btn_rlink_Click(object sender, EventArgs e)
        {
            try
            {
                if (endata.GetCode(Convert.ToInt32(tbxRFID.Text)))
                {
                    bool result = endata.activateCode(Convert.ToInt32(tbxSearch.Text), tbxRFID.Text);
                    if (result)
                    { MessageBox.Show("linken van rfid gelukt"); }
                    else
                    {
                        MessageBox.Show("linken is niet gelukt");
                    }
                }
                else
                {
                    MessageBox.Show("rfid is al gelinkt");
                }
            }
            catch
            {
                MessageBox.Show("data niet goed ingevoerd");
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {

            MediaSharingForm msf = new MediaSharingForm();
          msf.ShowDialog();

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            VerhuurForm verhuur = new VerhuurForm();
            verhuur.ShowDialog();
           
        }

        private void btnevent_Click(object sender, EventArgs e)
        {
            EventManagement ev = new EventManagement();
            ev.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.ShowDialog();
         
            
        }

        //Tag event handler...we'll display the tag code in the field on the GUI
        void rfid_Tag(object sender, TagEventArgs e)
        {
            tbxRFID.Text = e.Tag;
            tb_proto.Text = e.protocol.ToString();

          
        }

        //Tag lost event handler...here we simply want to clear our tag field in the GUI
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            tbxRFID.Text = "";
            tb_proto.Text = "";
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
