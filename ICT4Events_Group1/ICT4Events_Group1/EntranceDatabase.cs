using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class EntranceDatabase : Database
    {
        //fields
        //propperties
        //constructor
        //methodes
        public bool CheckReservarion(Reservation reservation)
        {
            return true;
        }
        public List<User> GenerateList()
        {
            return null;
        }
        public User GetContact(User user)
        {
            return null;
        }
        public bool PaymentCheck()
        {
            return true;
        }
        public bool SendCode(int code)
        {
            return true;
        }
        public int GetCode(int code)
        {
            return 0;
        }

    }
}
