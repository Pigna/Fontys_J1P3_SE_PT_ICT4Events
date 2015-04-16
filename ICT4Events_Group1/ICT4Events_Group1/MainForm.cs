using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Events_Group1
{
    public partial class MainForm : Form
    {
        VerhuurForm verhuur = new VerhuurForm(); 
        GebruikerBeheerForm gb = new GebruikerBeheerForm(); 
        MediaSharingForm Media = new MediaSharingForm();
        EventManagement ev = new EventManagement();


        public MainForm()
        {
            InitializeComponent();
           
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            
            verhuur.ShowDialog();
            
        }

        private void btnBeheer_Click(object sender, EventArgs e)
        {
            gb.ShowDialog();
        }

        private void btnMediaShare_Click(object sender, EventArgs e)
        {
            Media.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database test = new Database();
            if (test.logIn(txtUser.Text, txtPass.Text))
                lblCur.Text = test.Logged.ToString();
            else
                lblCur.Text = "Nope";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ev.ShowDialog();
        }
    }
}
