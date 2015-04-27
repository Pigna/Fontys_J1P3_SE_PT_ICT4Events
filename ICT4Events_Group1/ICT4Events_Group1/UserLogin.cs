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
    public partial class UserLogin : Form
    {
        Database db = new Database();

        public UserLogin()
        {
            InitializeComponent();


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
                Form open = new MenuForm(this);
                open.Closed += (s, args) => this.Close();
                open.Show();
            }
        }

    }
}
