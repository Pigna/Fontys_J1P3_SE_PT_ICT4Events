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
    public partial class MainForm : Form
    {
        VerhuurForm verhuur = new VerhuurForm(); GebruikerBeheerForm gb = new GebruikerBeheerForm();


        public MainForm()
        {
            InitializeComponent();
           
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            
            verhuur.ShowDialog();
            
        }

        private void btnBeheer_Click(object sender, EventArgs e)
        {
            gb.ShowDialog();
        }
    }
}
