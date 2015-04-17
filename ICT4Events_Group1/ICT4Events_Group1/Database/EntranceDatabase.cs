using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

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
        public OracleDataReader GetContact(int id)
        {
            
            
                OracleDataReader data = getQuery("SELECT voornaam, tussenvoegsel, achternaam, woonplaats, foto, paspoort, betaald FROM gebruiker WHERE id = " + id);

                return data;
            
          
        }

        
        public bool PaymentCheck(string code)
        {
            
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
