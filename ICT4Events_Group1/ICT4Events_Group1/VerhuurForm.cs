using System;
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
    public partial class VerhuurForm : Form
    {
        VerhuurDatabase db = new VerhuurDatabase();
        string cat = null;
         RFID rfid = new RFID();

        public VerhuurForm()
        {
            InitializeComponent();
           

            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);


            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);

            openCmdLine(rfid);

            printList(db.getCatAantal(VerhuurDatabase.Soort.Alles));
        }

        private void printList(Dictionary<string, int> list)
        {
            lbxRentList.Items.Clear();

            foreach (KeyValuePair<string, int> entry in list)
            {
                lbxRentList.Items.Add(entry.Key + " (" + entry.Value + ")");
            }
        }

        private void VerhuurForm_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cat == null)
                printList(db.getCatAantal(getSoort(), tbxSearch.Text));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort(), tbxSearch.Text).ToArray());
            }
        }

        private VerhuurDatabase.Soort getSoort()
        {
            if (radAlles.Checked)
                return VerhuurDatabase.Soort.Alles;
            if (radHuurbaar.Checked)
                return VerhuurDatabase.Soort.Huurbaar;

            return VerhuurDatabase.Soort.Verhuurd;
        }

        private void tbxItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radVerhuurd_CheckedChanged(object sender, EventArgs e)
        {
            if (cat == null) printList(db.getCatAantal(getSoort()));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void radAlles_CheckedChanged(object sender, EventArgs e)
        {
            if (cat == null) printList(db.getCatAantal(getSoort()));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void radHuurbaar_CheckedChanged(object sender, EventArgs e)
        {
            if (cat == null) printList(db.getCatAantal(getSoort()));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void lbxRentList_DoubleClick(object sender, EventArgs e)
        {
            if (lbxRentList.SelectedItem != null && cat == null)
            {
                cat = ((string)lbxRentList.SelectedItem).Substring(0, ((string)lbxRentList.SelectedItem).IndexOf(" ("));
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void lbxRentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cat = null;
            lbxRentList.Items.Clear();
            printList(db.getCatAantal(getSoort()));
        }

        private void btnRentItem_Click(object sender, EventArgs e)
        {
            if (tbxRFID.Text == "" || tbxItemID.Text == "")
            {
                MessageBox.Show("niet alle gegevens zijn ingevult!");
            }
            else
            {
                try
                {
                    int itemID = Convert.ToInt32(tbxItemID.Text);
                    if (db.checkrfid(tbxRFID.Text))
                    {
                        MessageBox.Show("rfid is niet gelinkt aan een gebruiker");
                    }

                    else if (!db.addVerhuur(Convert.ToInt16(itemID), tbxRFID.Text, dtpVan.Value, dtpTot.Value))
                        MessageBox.Show("Item is al uitgeleend");
                    else
                        MessageBox.Show("Item is op rfid gezet");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                    MessageBox.Show("de ingevulde gegevens zijn niet correct");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!db.brengTerug(Convert.ToInt16(txtItem.Text), ckbBetaald_b.Checked))
                MessageBox.Show("n");
        }




        // als de tag gescant is wordt het veld gevult met de code
        void rfid_Tag(object sender, TagEventArgs e)
        {
            tbxRFID.Text = e.Tag;



        }

        //als de tag weg is word het veld weer blank
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            tbxRFID.Text = "";

        }
        void rfid_Attach(object sender, AttachEventArgs e)
        {
         
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {

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
