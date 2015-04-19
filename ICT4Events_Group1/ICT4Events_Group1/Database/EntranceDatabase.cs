﻿using System;
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
        public List<Dictionary<string, object>> GetContact(int id)
        {
            
            
              List< Dictionary<string, object>> data = getQuery("SELECT voornaam, tussenvoegsel, achternaam, woonplaats, foto, paspoort, betaald FROM gebruiker WHERE id = " + id);

                return data;
           
            
          
        }

        
        public bool PaymentCheck(string code)
        {
            
            return false;
            
        }
        public int activateCode(int rfid)
        {
            try
            {
                List<Dictionary<string, object>> data = getQuery("SELECT avtivate FROM gebruikers WHERE rfid = " + rfid);
                if (Convert.ToString(data) == "0")
                {
                    doQuery("UPDATE gebruiker SET activate TO 1 WHERE rfid = " + rfid);
                    return (2);
                }
                else
                {
                    return (1);
                }


            }
            catch
            {
                return (0);
            }
        }


               
        public int diActivateCode(int rfid)
        {
            try
            {
                 List<Dictionary<string, object>> data = getQuery("SELECT activate FROM gebruikers WHERE rfid = " + rfid);
                 if (Convert.ToString(data) == "1")
               {
                   doQuery("UPDATE gebruiker SET activate TO 0 WHERE rfid = " + rfid);
                   return (2);
               }
               else
               {
                   return (1);
               }
            
                  
                }
                catch
                {
                    return (0);
                }


      
            
        }
        public bool GetCode(int code)
        {
           List<Dictionary<string, object>> data = getQuery("SELECT id FROM gebruikers WHERE rfid = " + code);

            if ( data == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public bool activateCode(int id, string rfid)
        {
            try
            {
                doQuery("UPDATE gebruiker SET rfid TO " + rfid + "WHERE id = " + id);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
