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
    public partial class MediaSharingForm : Form
    {
        MediaSharingDatabase mediasharing = new MediaSharingDatabase();
        Reactie reactie = new Reactie();
        List<String> categorie = new List<String>();
        int idcount = 1;
        public MediaSharingForm()
        {
            InitializeComponent();
        }
              
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            int i = 0;
           
            if (e.KeyCode == Keys.Enter)
            {
                if (lbCategorie.Items.Contains(tbSearch.Text))
                {                    
                }
                else
                {
                        foreach (String text in categorie)
                    {                    
                        if (tbSearch.Text == text)
                        {
                            tbSearch.Font = new Font(DefaultFont.FontFamily, DefaultFont.Size, FontStyle.Bold);                         
                        }
                        else if(i==0)
                        {                        
                            lbCategorie.Items.Add(tbSearch.Text);
                            i++;
                        }                        
                    }
                        if (i == 0)
                        {
                            categorie.Add(tbSearch.Text);
                            lbCategorie.Items.Add(tbSearch.Text);
                        }
                        i = 0;
                }
                         
                
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "" || tbMessage.Text != "")
            {
                Message bericht = new Message(idcount, tbMessage.Text);
                mediasharing.sendMessage(bericht, idcount, tbMessage.Text);
                tbMessage1.Text = tbMessage.Text;
                lblPoster.Text = "Nick"; //hier moet de naam opgevraagd worden uit de database.
            }
            else
            {
                MessageBox.Show("Vul text in aub!");
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            btnLike.BackColor = Color.Green;
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            reactie.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // gegevens uit de database
        }

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Title")
            {
                tbTitle.Clear();
            }
        }

        private void tbMessage_Enter(object sender, EventArgs e)
        {            
                tbMessage.Clear();            
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                tbTitle.Text = "Title";
            }
        }

        private void tbMessage_Leave(object sender, EventArgs e)
        {
            if (tbMessage.Text == "")
            {
                tbMessage.Text = "New Message";
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            tbSearch.Text = "Search";
        }

        private void lblLike_Click(object sender, EventArgs e)
        {

        }
    }
}
