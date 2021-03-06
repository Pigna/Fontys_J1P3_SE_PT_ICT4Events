﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class User
    {
        //fields
        private string username;
        private int id;
        private string naam;
        List<Item> itemlist = new List<Item>();
        UserDatabase userdatabase = new UserDatabase();

        //properties
        public string Username { get { return username; } }
        public int Id { get { return id; } }

        internal UserDatabase UserDatabase
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //constructors
        public User ( int id, string username, string voornaam, string tussenvoegsel, string achternaam)
        {
            this.id = id;
            this.username = username;
            this.naam = createNaam(voornaam, tussenvoegsel, achternaam);
        }
        
        //methoden
        public string createNaam(string v, string tv, string a)
        {
            if (tv == "")
                return v + " " + a;
            else
                return v + " " + tv + " " + a;
        }
        public bool additem(int itemid)
        {
            return true;
        }

        public override string ToString()
        {
            return id + ": " + username;
        }
    }
}
