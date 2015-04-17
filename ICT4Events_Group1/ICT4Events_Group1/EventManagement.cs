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
        EventDatabase db = new EventDatabase();

        public EventManagement()
        {
            InitializeComponent();

         //   lbxEmployees.Items.AddRange(db.getEmployees().ToArray());
        //    lbxLastEvents.Items.AddRange(db.getEvents().ToArray());
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
            if (db.deleteEvent((Event)lbxLastEvents.SelectedItem))
            {
                lbxLastEvents.Items.Remove(lbxLastEvents.SelectedItem);
                MessageBox.Show("Event verwijdert.");
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            Event new_event = new Event(db.getLatestId("Event"), txtNaam.Text, txtBeschrijving.Text, datTimeStart.Value, datTimeEnd.Value, (float) numCost.Value);
            if (db.createEvent(new_event))
            {
                MessageBox.Show(new_event.Name + " is aangemaakt!");
                txtNaam.Text = "";
                txtBeschrijving.Text = "";
                numCost.Value = new Decimal(0.00);

                lbxLastEvents.Items.AddRange(db.getEvents().ToArray());
            }
            else
            {
                MessageBox.Show("Event is niet aangemaakt.");
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            Employee new_emp = new Employee(db.getLatestId("Employee"), txtUsername.Text, txtPassword.Text, false);
            if (db.createEmployee(new_emp))
            {
                MessageBox.Show(new_emp.username + " is aangemaakt!");
                txtUsername.Text = "";
                txtPassword.Text = "";

                lbxEmployees.Items.AddRange(db.getEmployees().ToArray());
            }
            else
            {
                MessageBox.Show("Employee is niet aangemaakt.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxLastEvents.Items.AddRange(db.getEvents(tbxSearch.Text).ToArray());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            lbxEmployees.Items.AddRange(db.getEmployees(txtEmployee.Text).ToArray());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(db.deleteEmployee((Employee) lbxEmployees.SelectedItem))
            {
                lbxEmployees.Items.Remove(lbxEmployees.SelectedItem);
                MessageBox.Show("Employee verwijdert.");
            }
        }
    }
}
