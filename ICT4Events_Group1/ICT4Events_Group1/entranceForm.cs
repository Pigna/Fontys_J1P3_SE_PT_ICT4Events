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
                    OracleDataReader result = endata.GetContact(Convert.ToInt32(tbxSearch.Text));
                    lb_naam.Text = result.GetString(0) + " " + result.GetString(1) + " " + result.GetString(2);
                    lb_adress.Text = result.GetString(3);
                    pb_paspoort.ImageLocation = result.GetString(5);
                    pb_profile.ImageLocation = result.GetString(4);
                    if (result.GetInt16(6) == 0)
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
