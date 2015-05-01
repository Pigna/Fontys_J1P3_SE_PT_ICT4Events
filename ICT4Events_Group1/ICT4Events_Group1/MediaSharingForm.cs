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
using System.Text.RegularExpressions;

namespace ICT4Events_Group1
{
    public partial class MediaSharingForm : Form
    {
        MediaSharingDatabase mediasharing = new MediaSharingDatabase();
        Reactie reactie = new Reactie();
        List<String> categorie = new List<String>();
        List<Message> messagelist = new List<Message>();
        List<Message> commentlist = new List<Message>();
        Event event_;
        bool click = false;
        string path;
        UserLogin login;

        public MediaSharingForm(UserLogin log)
        {
            InitializeComponent();

            login = log;

            //get event from the userdb
            event_ = mediasharing.getEvent((User)mediasharing.Logged);
            //get list of last 100 messages
            getListMessages();
            getListCategories();
        }
        //get list of last 100 messages
        private void getListMessages()
        {
            messagelist.Clear();
            messagelist = mediasharing.getMessages(event_);
            lbPosts.Items.Clear();
            lbPosts.Items.AddRange(messagelist.ToArray());
        }
        private void getListMessagesFromCat(string cat)
        {
            messagelist.Clear();
            messagelist = mediasharing.getMessagesFromCat(event_, cat);
            lbPosts.Items.Clear();
            lbPosts.Items.AddRange(messagelist.ToArray());
        }
        private void getListComments(Message selectedItem)
        {
            commentlist.Clear();
            commentlist = mediasharing.getMessages(event_, selectedItem);
            lbComments.Items.Clear();
            lbComments.Items.AddRange(commentlist.ToArray());
        }
        private void getListCategories()
        {
            categorie.Clear();
            categorie = mediasharing.getCategories();
            lbCategorie.Items.Clear();
            lbCategorie.Items.AddRange(categorie.ToArray());
        }
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //als er op enter gedrukt wordt dan...
            {
                getListMessagesFromCat(tbSearch.Text);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "" || tbMessage.Text != "")
            {
                DateTime.Now.ToString("M/d/yyyy");
                Message bericht = new Message(mediasharing.getLatestId("message"), tbTitle.Text, tbMessage.Text, (User)mediasharing.Logged);
                if (mediasharing.sendMessage(bericht)) { MessageBox.Show("goed"); }
                else { MessageBox.Show("Fout"); }
                getListMessages();
                //tbMessage1.Text = tbTitle.Text + Environment.NewLine + tbMessage.Text;
                //panelPicture.Controls.Clear();
                //lblPoster.Text = ((User)mediasharing.Logged).Username; //hier moet de naam opgevraagd worden uit de database.
                //Search #hashtags
                Regex regex = new Regex(@"#(\w+)(?=#|\s|$)");

                foreach (Match match in regex.Matches(tbMessage.Text))
                {
                    string result = match.Value.Substring(1, match.Value.Length-1);
                    mediasharing.newCategorie(result);
                    mediasharing.newCatinMsg(bericht, result);
                }
            }
            else
            {
                MessageBox.Show("Vul text in aub!");
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (!click)
            {
                btnLike.BackColor = Color.Green;
                mediasharing.sendLike((Message)lbPosts.SelectedItem, (User)mediasharing.Logged, mediasharing.getLatestId("Leuk"));
            }
            else
            {
                btnLike.BackColor = Color.Transparent;
                mediasharing.sendDislike((Message)lbPosts.SelectedItem, (User)mediasharing.Logged);
            }
            click = !click;
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
            getListMessages();
            getListCategories();
        }

        private void lbCategorie_SelectedValueChanged(object sender, EventArgs e)
        {
            string selCat = (string)lbCategorie.SelectedItem;
            getListMessagesFromCat(selCat);
        }

        private void lbPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Message message = (Message)lbPosts.SelectedItem;
            getListComments(message);
            if (mediasharing.checkLike(message, (User)mediasharing.Logged))
            {
                btnLike.BackColor = Color.Green;
                click = true;
            }
            else
            {
                btnLike.BackColor = Color.Transparent;
                click = false;
            }
        }

        private void btnReact_Click(object sender, EventArgs e)
        {
            string deReactie = tbReactieMessage.Text;
            if(lbPosts.SelectedItem != null && deReactie != "")
            {
                Message selBericht = (Message)lbPosts.SelectedItem;
                DateTime.Now.ToString("M/d/yyyy");
                Message bericht = new Message(mediasharing.getLatestId("message"), deReactie, (User)mediasharing.Logged, selBericht.Id);
                if (mediasharing.sendMessage(bericht)) { MessageBox.Show("goed"); }
                else { MessageBox.Show("Fout"); }
                getListComments(selBericht);
                //tbMessage1.Text = tbTitle.Text + Environment.NewLine + tbMessage.Text;
                //panelPicture.Controls.Clear();
                //lblPoster.Text = ((User)mediasharing.Logged).Username; //hier moet de naam opgevraagd worden uit de database.
                
            }
            else
            {
                MessageBox.Show("Selecteer eerst een bericht en maak een reactie");
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            mediasharing.logOut();
            login.Show();
            this.Hide();
        }
    }
}
