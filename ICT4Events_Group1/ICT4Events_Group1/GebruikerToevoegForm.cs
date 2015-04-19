using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//makes it posible to get path of files
using System.IO;

namespace ICT4Events_Group1
{
    public partial class GebruikerToevoegForm : Form
    {
        UserDatabase userDatabase = new UserDatabase();
        EventDatabase eventDatabase = new EventDatabase();
        string[] filesPaspoort;
        string[] filesProfielfoto;
        List<Event> eventlist = new List<Event>();
        public GebruikerToevoegForm()
        {
            InitializeComponent();
            //getlist of all events
            eventlist = eventDatabase.getEvents();
            foreach (Event e in eventlist)
            {
                cbEvent.Items.Add(e.Name);
            }

        }
        private bool CheckEmailFormat(string email)
        {
            //nog te maken! checken of email wel een email format is
            return true;
        }
        private bool CheckUsernameFormat(string username)
        {
            //nog te maken! checken of Username wel correct format is
            return true;
        }
        private bool CheckPasswordFormat(string password)
        {
            //nog te maken! checken of Password wel correct format is
            return true;
        }
        private Event GetEvent(string eventname)
        {
            //get eventname
            foreach (Event e in eventlist)
            {
                if(e.Name == eventname)
                {
                    return e;
                }
            }
            return null;
        }
        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            string selectedEvent = (string)cbEvent.SelectedValue;
            string voornaam = tbVoornaam.Text;
            string tussenvoegsel = tbTussenvoegsel.Text; //niet verplicht
            string achternaam = tbAchternaam.Text;
            string straat = tbStraat.Text;
            string huisnummer = tbHuisnummer.Text;
            string postcode = tbPostcode.Text;
            string woonplaats = tbWoonplaats.Text;
            string rekeningnr = tbRekeningnr.Text;
            string email = tbEmail.Text;
            string vastnr = tbVastnr.Text;
            string mobielnr = tbMobielnr.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string passwordcheck = tbPasswordCheck.Text;
            DateTime startdatum = dtpStartdatum.Value;
            DateTime einddatum = dtpEinddatum.Value;
            bool betaald = cbBetaald.Checked;
            string Paspoort = filesPaspoort[0];
            string Profielfoto = filesProfielfoto[0];
            //Check of verplichte velden niet leeg zijn.
            if
            (
            selectedEvent != "" &
            voornaam != "" &
            achternaam != "" &
            straat != "" &
            huisnummer != "" &
            postcode != "" &
            woonplaats != "" &
            rekeningnr != "" &
            email != "" &
            username != "" &
            password != "" &
            passwordcheck != "" &
            startdatum != null &
            einddatum != null &
            Paspoort != "" &
            Profielfoto != ""
            )
            {
                //check password en email en of gebruikersnaam al bestaad
                //email check
                if(!userDatabase.emailExist(email) & CheckEmailFormat(email))
                {
                    //check username
                    if (!userDatabase.usernameExist(username) & CheckUsernameFormat(username))
                    {
                        //check password
                        if (CheckPasswordFormat(password) && password == passwordcheck)
                        {
                            userDatabase.adduser(1, GetEvent(selectedEvent), voornaam, tussenvoegsel, achternaam, straat, huisnummer, postcode, woonplaats, Paspoort, rekeningnr, Profielfoto, email, vastnr, mobielnr, username, password, startdatum, einddatum, betaald);
                            User user = new User(1, username, voornaam, tussenvoegsel, achternaam);
                            tbVoornaam.Clear();
                            tbTussenvoegsel.Clear(); //niet verplicht
                            tbAchternaam.Clear();
                            tbStraat.Clear();
                            tbHuisnummer.Clear();
                            tbPostcode.Clear();
                            tbWoonplaats.Clear();
                            tbRekeningnr.Clear();
                            tbEmail.Clear();
                            tbVastnr.Clear();
                            tbMobielnr.Clear();
                            tbUsername.Clear();
                            tbPassword.Clear();
                            tbPasswordCheck.Clear();
                            cbBetaald.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Wachtwoord voldoet niet aan de eisen.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gebruikersnaam bestaat al of voldoet niet aan de eisen.");
                    }
                }
                else
                {
                    MessageBox.Show("Email bestaat al of voldoet niet aan de eisen.");
                }
            }
            else
            {
                MessageBox.Show("Vul alle verplichte velden in.");
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPaspoortLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            filesPaspoort = Directory.GetFiles(fbd.SelectedPath);
        }

        private void btnFotoLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            filesProfielfoto = Directory.GetFiles(fbd.SelectedPath);
        }
    }
}
