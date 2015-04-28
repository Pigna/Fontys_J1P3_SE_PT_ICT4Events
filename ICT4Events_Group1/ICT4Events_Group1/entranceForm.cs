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


                    List<Dictionary<string, object>> data = endata.GetContact(Convert.ToInt32(tbxSearch.Text));
                    Dictionary<string, object> cur = data[0];

                    lb_naam.Text = (string)cur["voornaam"] + " " + (string)cur["tussenvoegsel"] + " " + (string)cur["achternaam"];
                    lb_adress.Text = (string)cur["woonplaats"];
                    pb_paspoort.ImageLocation = (string)cur["paspoort"];
                    pb_profile.ImageLocation = (string)cur["foto"];
                    if (Convert.ToInt32(cur["betaald"]) == 0)
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
            if (tbxRFID.Text == "")
            {
                MessageBox.Show("rfid niet gevonden");

            }
            else
            {
                try
                {
                    if (endata.GetCode(Convert.ToString(tbxRFID.Text)))
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
        }



        private void btn_scanIn_Click(object sender, EventArgs e)
        {
            int result = endata.activateCode(Convert.ToInt32(tbxRFID.Text));
            if (result == 0)
            { MessageBox.Show("linken niet gelukt"); }
            else if (result == 1)
            {
                MessageBox.Show("is al in gescant");
            }
            else
            {
                MessageBox.Show("rfid is ingescant");
            }
        }

        private void btn_scanUit_Click(object sender, EventArgs e)
        {
            int result = endata.diActivateCode(Convert.ToString(tbxRFID.Text));
            if (result == 0)
            { MessageBox.Show("linken niet gelukt"); }
            else if (result == 1)
            {
                MessageBox.Show("rfid is al uit gescant");
            }
            else
            {
                MessageBox.Show("rfid is uitgescant");
            }
        }

        private void btn_aanw_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, object>> data = endata.GenerateList();
            string aanwezig = "";
            for (int c = 0; c < data.Count; c++)
            {
                aanwezig = "\n" + (string)data[c]["voornaam"] + " " + (string)data[c]["tussenvoegsel"] + " " + (string)data[c]["achternaam"];
                MessageBox.Show(aanwezig);
            }
        }

        public void RfidGet(string tag)
        {
            tbxRFID.Text = tag;
        }
        public void rfidLost()
        {
            tbxRFID.Text = "";
        }




    }
}
