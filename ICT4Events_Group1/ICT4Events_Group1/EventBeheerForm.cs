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
    public partial class EventBeheerForm : Form
    {
        EventDatabase db = new EventDatabase();

        public EventBeheerForm()
        {

            InitializeComponent();

            lbxEmployees.Items.Clear();
            lbxEmployees.Items.AddRange(db.getEmployees().ToArray());
            lbxLastEvents.Items.AddRange(db.getEvents().ToArray());
        }

        internal EventDatabase EventDatabase
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
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

        private void btnVerwijderEvent_Click(object sender, EventArgs e)
        {
            if (db.deleteEvent((Event)lbxLastEvents.SelectedItem))
            {
                lbxLastEvents.Items.Remove(lbxLastEvents.SelectedItem);
                MessageBox.Show("Event verwijdert.");
            }
            else
            {
                MessageBox.Show("Dit event kan niet verwijdert worden. (Heeft al plaatsgevonden / inschrijvingen");
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            string eventnaam = tbxNaam.Text;
            string eventbeschrijving = txtBeschrijving.Text;
            DateTime eventstart = datTimeStart.Value;
            DateTime eventeind = datTimeStart.Value;
            float eventkoste = (float)numCost.Value;
            if
            (
            eventnaam != "" &
            eventbeschrijving != "" &
            eventstart != null &
            eventeind != null &
            eventkoste != null
            )
            {
                Event new_event = new Event(db.getLatestId("Event"), eventnaam, eventbeschrijving, eventstart, eventeind, eventkoste);
                if (db.createEvent(new_event))
                {
                    MessageBox.Show(new_event.Name + " is aangemaakt!");
                    tbxNaam.Text = "";
                    txtBeschrijving.Text = "";
                    numCost.Value = new Decimal(0.00);

                    lbxLastEvents.Items.Clear();
                    lbxLastEvents.Items.AddRange(db.getEvents().ToArray());
                }
                else
                {
                    MessageBox.Show("Event is niet aangemaakt.");
                }
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

                lbxEmployees.Items.Clear();
                lbxEmployees.Items.AddRange(db.getEmployees().ToArray());
            }
            else
            {
                MessageBox.Show("Employee is niet aangemaakt.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxLastEvents.Items.Clear();
            lbxLastEvents.Items.AddRange(db.getEvents(tbxSearch.Text).ToArray());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
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
