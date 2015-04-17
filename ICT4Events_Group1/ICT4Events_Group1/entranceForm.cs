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
          OracleDataReader result =  endata.GetContact(Convert.ToInt32(tbxSearch.Text));
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
    }
}
