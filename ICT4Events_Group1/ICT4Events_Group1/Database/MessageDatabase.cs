using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class MessageDatabase : Database
    {
        public bool hidemessage(Message bericht)
        {
            return true;
        }

        public bool deleteMessage(Message bericht)
        { 
            return true; 
        }
    }
}
