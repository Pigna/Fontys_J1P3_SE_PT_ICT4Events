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
        public GebruikerToevoegForm()
        {
            InitializeComponent();
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
                //check password en email en of gebruiersnaam al bestaad
                //email check
                
                //User user = new User(1, );
            }
            else
            {
                MessageBox.Show("Vul alle verplichte velden in.");
            }
        }
    }
}
