using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class RFID_
    {
        //fields
        private string code;
        private User owner;
        public bool activex;

        //properties
        public string Code { get{return "";} }       //return tijdelijk toegevoegd verander dit nog
        public User Owner { get{return null;} }  //return tijdelijk toegevoegd verander dit nog
        public bool active { get; set; }

        //constructors
        public RFID_ (string code)
        { this.code = code; }
    }
}
