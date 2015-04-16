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
        public bool PaymentCheck(string code)
        {
            string sql = "SELECT betaald FROM Gebruikers WHERE id = " + code;
            /*string resultaat = getQuery(sql);
            if (resultaat == "0")
            { return false; }
            else
            { return true; }*/
            return false;
            
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
