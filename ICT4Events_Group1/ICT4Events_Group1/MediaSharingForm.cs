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
        int i = 0;
        Reactie reactie = new Reactie();
        List<String> categorie = new List<String>();
        public MediaSharingForm()
        {
            InitializeComponent();
        }
              
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                if (lbCategorie.Items.Contains(tbSearch.Text))
                {                    
                }
                else
                {
                    categorie.Add(tbSearch.Text);
                    lbCategorie.Items.Add(tbSearch.Text);
                }
                         
                foreach (String text in categorie)
                {                    
                    if (tbSearch.Text == text)
                    {
                        tbSearch.Font = new Font(DefaultFont.FontFamily, DefaultFont.Size, FontStyle.Bold);                         
                    }
                    else
                    {                        
                        lbCategorie.Items.Add(tbSearch.Text);
                    }                        
                }                
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "" || tbMessage.Text != "")
            {
                lblTitel.Text = tbTitle.Text;
                lblTekst.Text = tbMessage.Text;
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
    }
}
