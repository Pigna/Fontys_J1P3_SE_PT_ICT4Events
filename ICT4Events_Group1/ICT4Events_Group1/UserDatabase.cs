using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class UserDatabase
    {
        //methodes
        public bool adduser(User user)
        {
//connect!
            /*
            try
            {
                
                //This is the mysql command that we will query into the db.
                //It uses Prepared statements and the Placeholder is @name.
                //Using prepared statements is faster and secure.
                String cmdText = "INSERT INTO Gebruiker(Id, Event, Voornaam, Tussenvoegsel, Achternaam, Straat, Huisnummer, Postcode, Woonplaats, Paspoort, Rekeningnr, Foto, Email, Telefoon, Mobiel, Username, Password, Startdatum, Einddatum, Betaald) VALUES(@Id, @Event, @Voornaam, @Tussenvoegsel, @Achternaam, @Straat, @Huisnummer, @Postcode, @Woonplaats, @Paspoort, @Rekeningnr, @Foto, @Email, @Telefoon, @Mobiel, @Username, @Password, @Startdatum, @Einddatum, @Betaald)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                //we will bound a value to the placeholder
                //Id, Event, Voornaam, Tussenvoegsel, Achternaam, Straat, Huisnummer, Postcode, Woonplaats, Paspoort, Rekeningnr, Foto, Email, Telefoon, Mobiel, Username, Password, Startdatum, Einddatum, Betaald
                cmd.Parameters.AddWithValue("@vorm", figuur.vorm);
                cmd.Parameters.AddWithValue("@x", figuur.x);
                cmd.Parameters.AddWithValue("@y", figuur.y);
                cmd.Parameters.AddWithValue("@w", figuur.w);
                cmd.Parameters.AddWithValue("@h", figuur.h);
                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            finally
            {
                Close();
            } //remember to close the connection after accessing the database
            */
            return true;
        }

        public bool modifyUser(User newuser, User olduser)
        {
            return true;
        }

        public bool deleteUser(User user)
        {
            return true;
        }
    }
}
