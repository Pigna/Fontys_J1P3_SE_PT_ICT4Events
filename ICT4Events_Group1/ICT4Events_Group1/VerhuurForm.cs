﻿using System;
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

        private void printList(Dictionary<string, int> list){
            lbxRentList.Items.Clear();

            foreach(KeyValuePair<string, int> entry in list)
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
            if(cat == null) 
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
            if(cat == null) printList(db.getCatAantal(getSoort()));
            else 
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void radAlles_CheckedChanged(object sender, EventArgs e)
        {
            if(cat == null) printList(db.getCatAantal(getSoort()));
            else
            {
                lbxRentList.Items.Clear();
                lbxRentList.Items.AddRange(db.getItems(cat, getSoort()).ToArray());
            }
        }

        private void radHuurbaar_CheckedChanged(object sender, EventArgs e)
        {
            if(cat == null) printList(db.getCatAantal(getSoort()));
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
            if (!db.addVerhuur(Convert.ToInt16(tbxItemID.Text), Convert.ToInt16(txtGebruiker.Text), dtpVan.Value, dtpTot.Value))
                MessageBox.Show("n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!db.brengTerug(Convert.ToInt16(txtItem.Text), ckbBetaald_b.Checked))
                MessageBox.Show("n");
        }
    }
}
