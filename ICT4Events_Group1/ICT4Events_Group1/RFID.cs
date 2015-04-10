using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class RFID
    {
        //fields
        private int code;
        private User owner;
        public bool activex;

        //properties
        public int Code { get{return 1;} }       //return tijdelijk toegevoegd verander dit nog
        public User Owner { get{return null;} }  //return tijdelijk toegevoegd verander dit nog
        public bool active { get; set; }

        //constructors
        public RFID (int code)
        { this.code = code; }
    }
}
