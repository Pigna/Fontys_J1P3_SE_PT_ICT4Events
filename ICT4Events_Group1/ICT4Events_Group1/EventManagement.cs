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

    // Create event
    // INSERT INTO Event (Naam, Startdatum, Einddatum, Beschrijving, Kosten) VALUES ('NAAM', to_date('00-00-0000 00:00','MM-DD-YYYY hh24:MI'), 00-00-0000, 'BESCHRIJVING', 000.00);
    // Delete event
    // DELETE FROM Event WHERE Id = %SelectedItem%.Id;

    // Create Employee
    // INSERT INTO Employee (Username, Password) VALUES ('NAAM', 'PASSWORD');
    // Delete Employee
    // DELETE FROM Employee WHERE Id = %SelectedItem%.Id;

    public partial class EventManagement : Form
    {
        public EventManagement()
        {
            InitializeComponent();
        }

        private void lblEuro_Click(object sender, EventArgs e)
        {

        }

        private void txtNaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void numCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datTimeStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datTimeEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpEvent_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
