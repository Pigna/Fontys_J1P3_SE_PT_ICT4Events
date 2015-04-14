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
        public GebruikerBeheerForm()
        {
            InitializeComponent();
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
    }
}
