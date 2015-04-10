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
    public partial class VerhuurForm : Form
    {
        public VerhuurForm()
        {
            InitializeComponent();
            lbxRentList.Items.Add("ID -=-=- Naam -=-=- Materiaal -=-=- Van -=-=- Tot -=-=- Prijs");
        }

        private void VerhuurForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRentList_Click(object sender, EventArgs e)
        {
            lblDesc.Text = ("Huurbaar");
        }

        private void btnRentableList_Click(object sender, EventArgs e)
        {
            lblDesc.Text = ("Verhuurbaar");
        }

        private void btnRentedList_Click(object sender, EventArgs e)
        {
            lblDesc.Text = ("Verhuurd");
        }
    }
}
