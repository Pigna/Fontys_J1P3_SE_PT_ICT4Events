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
        public bool active;
        //properties
        public int Code { get; }
        public User Owner { get; }
        public bool active { get; set; }
        //constructors
        public RFID (int code)
        { this.code = code; }
    }
}
