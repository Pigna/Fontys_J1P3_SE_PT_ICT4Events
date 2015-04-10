using System;
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
        private RFID RFID;
        List<Item> itemlist = new List<Item>();

        //properties
        public string Username { get; set; }
        public RFID rfid { get; set; }

        //constructors
        public User ( string username)
        { this.username = username; }

        //methoden
        public bool additem(int itemid)
        {
            
            return true;
        }

    }
}
