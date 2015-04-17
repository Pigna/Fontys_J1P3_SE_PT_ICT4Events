using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class Event
    {
        //fields
        public int id;

        public string Name;
        public string Desc;
        public DateTime startDate;
        public DateTime endDate;
        public float price;

        //propperties
        //constructor
        public Event(int id, string Name, string Desc, DateTime startDate, DateTime endDate, float price)
        {
            this.id = id;
            this.Name = Name;
            this.Desc = Desc;
            this.startDate = startDate;
            this.endDate = endDate;
            this.price = price;
        }

        //methodes
    }
}
