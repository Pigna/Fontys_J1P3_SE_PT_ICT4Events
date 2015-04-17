using System;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class UserDatabase : Database
    {
        //methodes
        public bool adduser(int id, Event evnt, string voornaam, string tussenvoegsel, string achternaam, string straat, string huisnummer, string postcode, string woonplaats, string paspoort, string rekeningnr, string foto, string email, string telefoon, string mobiel, string username, string password, DateTime date1, DateTime date2, bool betaald)
        {
            //connect!
            return doQuery("INSERT INTO Gebruiker (Id, Event, Voornaam, Tussenvoegsel, Achternaam, Straat, Huisnummer, Postcode, Woonplaats, Paspoort, Rekeningnr, Foto, Email, Telefoon, Mobiel, Username, Password, RFID, Startdatum, Einddatum, Betaald)" +
                           "VALUES (" + id + ", " + evnt.id + ", " + voornaam + ", " + tussenvoegsel + ", " + achternaam + ", " + straat + ", " + huisnummer + ", " + postcode + ", " + woonplaats + ", " + paspoort + ", " + rekeningnr + ", " + foto + ", " + email + ", " + telefoon + ", " + mobiel + ", " + username + ", " + password + ", NULL, " + date1 + ", " + date2 + ", " + betaald +");") > 0;
        }

        public bool modifyUser(User newuser, User olduser)
        {
            return true;
        }

        public bool deleteUser(User user)
        {
            return true;
        }
        public List<User> getUserlist()
        {
            List<User> ret = new List<User>();

            OracleDataReader data = getQuery("SELECT Id, Username, Voornaam, Tussenvoegsel, Achternaam FROM Gebruiker;");

            while (data.Read())
            {
                ret.Add(new User(data.GetInt16(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4)));
            }
            return ret;
        }
        public void getDataRFID(RFID rfid)
        {
            //string code = "SELECT * FROM GEBRUIKER WHERE RFID = " + rfid.Code + ";";
        }
        public bool usernameExist(string username)
        {
            OracleDataReader data = getQuery("SELECT Id FROM Gebruiker WHERE Username = " + username + ";");
            if (data.FieldCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool emailExist(string email)
        {
            OracleDataReader data = getQuery("SELECT Id FROM Gebruiker WHERE Email = " + email + ";");
            if (data.FieldCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
