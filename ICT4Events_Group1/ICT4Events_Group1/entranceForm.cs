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

namespace ICT4Events_Group1
{
    public partial class EntranceForm : Form
    {
        EntranceDatabase endata = new EntranceDatabase();
      

        public EntranceForm()
        {
            InitializeComponent();
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


    }
}
