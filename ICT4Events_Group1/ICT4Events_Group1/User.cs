using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class User
    {
        private string username;
        private string RFID;
        List<Item> itemlist = new List<Item>();

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public User(string username, string rfid)
        {
            this.username = username;
            this.RFID = rfid;
        }
        public bool additem(int itemid)
        {
            
            return true;
        }

    }
}
