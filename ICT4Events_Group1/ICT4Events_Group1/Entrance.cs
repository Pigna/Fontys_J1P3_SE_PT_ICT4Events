using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class Entrance
    {
        //fields
        private Employee employee;
        private List<RFID> tags;
        private int code;

        //propperties

        //constructor

        //methodes
        public List<RFID> GetActiveRFID()
        {
            return null;
        }
        public List<RFID> GetInactiveRFID()
        {
            return null;
        }
        public bool CheckIn(int code)
        {
            return true;
        }
        public bool CheckOut(int code)
        {
            return true;
        }
        public bool ScanRFID(int code)
        {
            return true;
        }
        public User SearchUser()
        {
            return null;
        }
        public bool LinkRFID()
        {
            return true;
        }
    }
}
