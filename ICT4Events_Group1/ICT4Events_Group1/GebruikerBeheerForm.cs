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
    public partial class GebruikerBeheerForm : Form
    {
        List<User> userlist = new List<User>();
        UserDatabase userdb = new UserDatabase();
        public GebruikerBeheerForm()
        {
            InitializeComponent();
            userlist = userdb.getUserlist();
            foreach (User user in userlist)
            {
                lbxUsers.Items.Add(user);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            GebruikerToevoegForm adduser = new GebruikerToevoegForm();
            adduser.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbxUsers.Items.Clear();
            foreach (User user in userlist)
            {
                lbxUsers.Items.Add(user);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (userdb.deleteUser((User)lbxUsers.SelectedItem))
            {
                lbxUsers.Items.Remove(lbxUsers.SelectedItem);
                foreach (User user in userlist)
                {
                    userlist.Clear();
                    userlist = userdb.getUserlist();
                }
                MessageBox.Show("Employee verwijdert.");
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User asd = (User)lbxUsers.SelectedItem;
            GebruikerToevoegForm editUser = new GebruikerToevoegForm(asd.Id);
            editUser.ShowDialog();
        }
    }
}
