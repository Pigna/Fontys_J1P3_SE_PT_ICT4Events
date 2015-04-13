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
            lbxRentList.Items.Clear();
            lbxRentList.Items.Add("ID -=-=- Naam -=-=- Materiaal -=-=- Van -=-=- Tot -=-=- Prijs");


//            for(int i = 0; i < /* aantal items in database (maak deze query) */; i++)
//            {
//            lbxRentList.Items.Add((string)/*item op i plek in de database*/ );
//            }
        }
        
        private void btnRentableList_Click(object sender, EventArgs e)
        {
            lblDesc.Text = ("Verhuurbaar");
            lbxRentList.Items.Clear();
            lbxRentList.Items.Add("ID -=-=- Naam -=-=- Materiaal -=-=- Van -=-=- Tot -=-=- Prijs");


//            for(int i = 0; i < /* aantal items in database waarvan de datum van uitleen en teruggave niet overlappen met de huidige datum (maak deze query) */; i++)
//            {
//            lbxRentList.Items.Add((string)/*item op i plek in de database waar datum van uitleen en teruggave niet overlappen met de huidige datum*/ );
//            }
        }

        private void btnRentedList_Click(object sender, EventArgs e)
        {
            lblDesc.Text = ("Verhuurd");
            lbxRentList.Items.Clear();
            lbxRentList.Items.Add("ID -=-=- Naam -=-=- Materiaal -=-=- Van -=-=- Tot -=-=- Prijs");

//            for(int i = 0; i < /* aantal items in database waar de datum van uitleen en teruggave overlappen met de huidige datum(maak deze query) */; i++)
//            {
//            lbxRentList.Items.Add((string)/*item op i plek in de database waar de datum van uitleen en teruggave wel overlappen met de huidige datum*/ );
//            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

//        private void btnSearch_Click(object sender, EventArgs e)
//        {
//            lbxRentList.Items.Clear();
//            lbxRentList.Items.Add(/* maak hier de query die het item laat zien met het id dat */ (int)tbxSearch.Text /* bevat */);

//        }

//        private void btnRentItem_Click(object sender, EventArgs e)
//        {
//            int itemid = (int)tbxItemID.Text;
//            DateTime vanDate = dtpVan.Value;
//            DateTime totDate = dtpTot.Value;

            /* iets van een database connectie dat hij dit item als gehuurd zet in de database */

//        }
    }
}
