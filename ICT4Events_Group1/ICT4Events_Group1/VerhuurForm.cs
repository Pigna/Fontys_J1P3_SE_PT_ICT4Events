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
        VerhuurDatabase db = new VerhuurDatabase();
        string cat = null;
       

        public VerhuurForm()
        {
            InitializeComponent();
           

            

            printList(db.getCatAantal(VerhuurDatabase.Soort.Alles));
        }

        internal VerhuurDatabase VerhuurDatabase
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void printList(Dictionary<string, int> list)
        {
            lbxRentList.Items.Clear();

            foreach (KeyValuePair<string, int> entry in list)
            {
                lbxRentList.Items.Add(entry.Key + " (" + entry.Value + ")");
            }
        }

        private void VerhuurForm_Load(object sender, EventArgs e)
        {

        }

       



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cat == null)
                printList(db.getCatAantal(getSoort(), tbxSearch.Text));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort(), tbxSearch.Text).ToArray());
            }
        }

        private VerhuurDatabase.Soort getSoort()
        {
            if (radAlles.Checked)
                return VerhuurDatabase.Soort.Alles;
            if (radHuurbaar.Checked)
                return VerhuurDatabase.Soort.Huurbaar;

            return VerhuurDatabase.Soort.Verhuurd;
        }

        private void tbxItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radVerhuurd_CheckedChanged(object sender, EventArgs e)
        {
            if (cat == null) printList(db.getCatAantal(getSoort()));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void radAlles_CheckedChanged(object sender, EventArgs e)
        {
            if (cat == null) printList(db.getCatAantal(getSoort()));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void radHuurbaar_CheckedChanged(object sender, EventArgs e)
        {
            if (cat == null) printList(db.getCatAantal(getSoort()));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void lbxRentList_DoubleClick(object sender, EventArgs e)
        {
            if (lbxRentList.SelectedItem != null && cat == null)
            {
                cat = ((string)lbxRentList.SelectedItem).Substring(0, ((string)lbxRentList.SelectedItem).IndexOf(" ("));
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void lbxRentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cat = null;
            lbxRentList.Items.Clear();
            printList(db.getCatAantal(getSoort()));
        }

        private void btnRentItem_Click(object sender, EventArgs e)
        {
            if (tbxRFID.Text == "" || tbxItemID.Text == "")
            {
                MessageBox.Show("niet alle gegevens zijn ingevult!");
            }
            else
            {
                try
                {
                    int itemID = Convert.ToInt32(tbxItemID.Text);
                    if (db.checkrfid(tbxRFID.Text))
                    {
                        MessageBox.Show("rfid is niet gelinkt aan een gebruiker");
                    }

                    else if (!db.addVerhuur(Convert.ToInt16(itemID), tbxRFID.Text, dtpVan.Value, dtpTot.Value))
                        MessageBox.Show("Item is al uitgeleend");
                    else
                        MessageBox.Show("Item is op rfid gezet");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                    MessageBox.Show("de ingevulde gegevens zijn niet correct");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!db.brengTerug(Convert.ToInt16(txtItem.Text), ckbBetaald_b.Checked))
                MessageBox.Show("n");
        }

        public void rfidget(string tag)
        {
            tbxRFID.Text = tag;
        }
        public void rfidLost()
        {
            tbxRFID.Text = "";
        }



      
    }
}
