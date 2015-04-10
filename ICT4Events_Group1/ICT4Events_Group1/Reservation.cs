using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class Reservation
    {
        private List<Item> itemlist;
        private Employee employee;

        public Reservation(Employee employee)
        {
            this.employee = employee;
        }

        //methoden
        public List<Item> getstock()
        {
            return null;
        }

        public List<Item> getgiven()
        {
            return null;
        }

        public List<Item> getlate()
        {
            return null;
        }

        public List<Item> getUnpaid()
        {
            return null;
        }
        public void rentItem(int itemID)
        { }

    }
}
