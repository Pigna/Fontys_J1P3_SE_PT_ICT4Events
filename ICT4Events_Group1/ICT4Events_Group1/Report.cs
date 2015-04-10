using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class Report
    {
        private string reason;
        private User send;

        public string Reason { get; set; }
        public User User { get; set; }

        public Report (string reason, User send)
        {
            this.reason = reason;
            this.send = send;
        }
    }
}
