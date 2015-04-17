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
    public partial class GebruikerToevoegForm : Form
    {
        UserDatabase userDatabase;
        public GebruikerToevoegForm()
        {
            InitializeComponent();
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
        private void btnAanmaken_Click(object sender, EventArgs e)
        {
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
            //Check of verplichte velden niet leeg zijn.
            if
            (
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
            passwordcheck != ""
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
                        if (CheckPasswordFormat(password))
                        {
                            User user = new User(1, username, voornaam, tussenvoegsel, achternaam);
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
    }
}
