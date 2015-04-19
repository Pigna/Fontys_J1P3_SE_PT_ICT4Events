﻿using System;
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
        //maak gebruiker aan
        public bool adduser(int id, Event evnt, string voornaam, string tussenvoegsel, string achternaam, string straat, string huisnummer, string postcode, string woonplaats, string paspoort, string rekeningnr, string foto, string email, string telefoon, string mobiel, string username, string password, DateTime date1, DateTime date2, bool betaald)
        {
            //connect!
            return doQuery("INSERT INTO Gebruiker (Id, Event, Voornaam, Tussenvoegsel, Achternaam, Straat, Huisnummer, Postcode, Woonplaats, Paspoort, Rekeningnr, Foto, Email, Telefoon, Mobiel, Username, Password, RFID, Startdatum, Einddatum, Betaald)" +
                           "VALUES (" + id + ", " + evnt.id + ", " + voornaam + ", " + tussenvoegsel + ", " + achternaam + ", " + straat + ", " + huisnummer + ", " + postcode + ", " + woonplaats + ", " + paspoort + ", " + rekeningnr + ", " + foto + ", " + email + ", " + telefoon + ", " + mobiel + ", " + username + ", " + password + ", NULL, " + date1 + ", " + date2 + ", " + betaald +")") > 0;
        }
        //pas gebruiker aan
        public bool modifyUser(int id, Event evnt, string voornaam, string tussenvoegsel, string achternaam, string straat, string huisnummer, string postcode, string woonplaats, string paspoort, string rekeningnr, string foto, string email, string telefoon, string mobiel, string username, string password, DateTime date1, DateTime date2, bool betaald)
        {
            //connect!
            return doQuery("UPDATE Gebruiker (Id = " + id + ", Event = " + evnt + ", Voornaam = " + voornaam + ", Tussenvoegsel = " + tussenvoegsel + ", Achternaam = " + achternaam + ", Straat = " + straat + ", Huisnummer = " + huisnummer + ", Postcode = " + postcode + ", Woonplaats = " + woonplaats + ", Paspoort = " + paspoort + ", Rekeningnr = " + rekeningnr + ", Foto = " + foto + ", Email = " + email + ", Telefoon = " + telefoon + ", Mobiel = " + mobiel + ", Username = " + username + ", Password = " + paspoort + ", Startdatum = " + date1 + ", Einddatum = " + date2 + ", Betaald = " + betaald + ")") > 0;
        }
        //verwijder gebruiker
        public bool deleteUser(User user)
        {
            int tof = doQuery("DELETE FROM Gebruiker WHERE Id = " + user.Id);
            return tof > 0;
        }
        //Verkrijg een lijst van gebruikers
        public List<User> getUserlist()
        {
            List<User> ret = new List<User>();

            List<Dictionary<string, object>> data = getQuery("SELECT Id, Username, Voornaam, Tussenvoegsel, Achternaam FROM Gebruiker");

            for (int c = 0; c < data.Count; c++)
                ret.Add(new User(Convert.ToInt32(data[c]["id"]), (string)data[c]["username"], (string)data[c]["voornaam"], (string)data[c]["tussenvoegsel"], (string)data[c]["achternaam"]));
            
            return ret;
        }
        //zoek gebruiker op RFID
        public  List<Dictionary<string, object>> getDataID(int id)
        {
            //string code = "SELECT * FROM GEBRUIKER WHERE RFID = " + rfid.Code + ";";
            List<Dictionary<string, object>> data = getQuery("SELECT * FROM Gebruiker WHERE Id = " + id);
            return data;
        }
        //Controleer of gebruikersnaam bestaat in de database
        public bool usernameExist(string username)
        {
            List<Dictionary<string, object>> data = getQuery("SELECT Id FROM Gebruiker WHERE Username = " + username);
            if ((data.Count > 0)||(data.Count == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Controleer of email bestaat in de database
        public bool emailExist(string email)
        {
            List<Dictionary<string, object>> data = getQuery("SELECT Id FROM Gebruiker WHERE Email = " + email);
            if ((data.Count > 0) || (data.Count == null))
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
