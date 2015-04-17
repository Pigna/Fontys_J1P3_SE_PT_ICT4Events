using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class Employee
    {
        //fields
        public int id;
        public string password;
        public string username;
        private bool admin;
        //propperties
        //constructor
        public Employee(int id, string username, string Password, bool admin)
        {
            this.id = id;
            this.username = username;
            this.password = Password;
            this.admin = admin;
        }
        //methodes
    }
}
