using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        bool click = false;
        string path;
        
        public MediaSharingForm()
        {
            InitializeComponent();
        }
              
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            int i = 0;
           
            if (e.KeyCode == Keys.Enter)    //als er op enter gedrukt wordt dan...
            {
                if (lbCategorie.Items.Contains(tbSearch.Text))
                {                    
                    //doe niets
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
                tbMessage1.Text = tbTitle.Text + Environment.NewLine + tbMessage.Text;
                panelPicture.Controls.Clear();
                lblPoster.Text = "Nick"; //hier moet de naam opgevraagd worden uit de database.
            }
            else
            {
                MessageBox.Show("Vul text in aub!");
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (click == false)
            {
                btnLike.BackColor = Color.Green;
                click = true;
            }
            else if (click == true)
            {
                btnLike.BackColor = Color.Transparent;
                click = false;
            }
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

        private void btnHide_Click(object sender, EventArgs e)
        {   //checkt of button hide nog niet is geklikt.
            if (click == false)
            {
                groupBox3.Visible = false;
                click = true;
            }
            else if (click == true)
            {
                groupBox3.Visible = true;
                click = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();                   
            DialogResult dr = openfile.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files 
                foreach (String file in openfile.FileNames)
                {
                    // Create a PictureBox. 
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image loadedImage = Image.FromFile(file);
                        pb.Height = loadedImage.Height;
                        pb.Width = loadedImage.Width;
                        pb.Image = loadedImage;
                        panelPicture.Controls.Add(pb);
                    }                    
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
            path = openfile.FileName;
        }        

        private void btnImage_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("No image here!");
            }
            else
            {

                Form form = new Form();

                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = Image.FromFile(path);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                form.Controls.Add(pictureBox);

                form.ShowDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbReactieTitle.Text = reactie.GetTitle();
            tbReactieMessage.Text = reactie.GetMessage();
        }

        private void btnReactieImage_Click(object sender, EventArgs e)
        {
            if (reactie.GetPath() == null)
            {
                MessageBox.Show("No image here!");
            }
            else
            {

                Form form = new Form();

                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = Image.FromFile(reactie.GetPath());
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                form.Controls.Add(pictureBox);

                form.ShowDialog();
            }
        }

        private void lbCategorie_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
