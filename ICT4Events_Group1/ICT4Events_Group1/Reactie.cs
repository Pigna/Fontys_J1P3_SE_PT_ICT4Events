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
    public partial class Reactie : Form
    {
        MediaSharingDatabase mediasharing = new MediaSharingDatabase();
       int idcount = 101;

        string path;

        public Reactie()
        {            
            InitializeComponent();            
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Message bericht = new Message(idcount, tbTitle.Text + tbMessage.Text);
            mediasharing.sendMessage(bericht, idcount, tbTitle.Text + tbMessage.Text);
            idcount++;
            this.Close();
        }

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Title")
            {
                tbTitle.Clear();
            }
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMessage_Enter(object sender, EventArgs e)
        {
            tbMessage.Clear();
        }

        public string GetTitle()
        {
            string title = tbTitle.Text;
            return title;
        }

        public string GetMessage()
        {
            string message = tbMessage.Text;
            return message;
        }

        public string GetPath()
        {
            return path;
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
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
                path = openfile.FileName;

            }
        }
    }
}
