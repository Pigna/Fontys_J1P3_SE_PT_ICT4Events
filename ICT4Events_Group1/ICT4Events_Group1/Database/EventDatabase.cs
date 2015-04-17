using System;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class EventDatabase : Database
    {
        public List<Employee> getEmployees()
        {
            List<Employee> ret = new List<Employee>();

            List<Dictionary<string, object>> data = getQuery("SELECT Id, Username, Password, Adminrights FROM Employee");

            for(int c = 0; c < data.Count; c++)
                ret.Add(new Employee(Convert.ToInt16(data[c]["id"]), (string)data[c]["username"], (string)data[c]["password"], Convert.ToInt16(data[c]["ddminrights"]) == 1));

            return ret;
        }

        public List<Employee> getEmployees(string filter)
        {
            List<Employee> ret = new List<Employee>();

            List<Dictionary<string, object>> data = getQuery("SELECT Id, Username, Password, Adminrights FROM Employee WHERE Username LIKE '%" + filter + "%' OR Id LIKE '%" + filter + "%';");

            for (int c = 0; c < data.Count; c++)
                ret.Add(new Employee(Convert.ToInt16(data[c]["id"]), (string)data[c]["username"], (string)data[c]["password"], Convert.ToInt16(data[c]["adminrights"]) == 1));

            return ret;
        }

        public bool deleteEmployee(Employee e)
        {
            return doQuery("DELETE FROM Employee WHERE Id = " + e.id) > 0;
        }

        public bool createEmployee(Employee e)
        {
            return doQuery("INSERT INTO Employee (Id, Username, Password) VALUES (" + e.id + ", " + e.username + ", " + e.password + ");") > 0;
        }


        public List<Event> getEvents()
        {
            List<Event> ret = new List<Event>();

            List<Dictionary<string, object>> data = getQuery("SELECT Id, Naam, Startdatum, Einddatum, Beschrijving, Kosten FROM event");

            for (int c = 0; c < data.Count; c++)
                ret.Add(new Event(Convert.ToInt16(data[c]["id"]), (string)data[c]["naam"], (string)data[c]["beschrijving"], (DateTime)data[c]["startdatum"], (DateTime)data[c]["einddatum"], (float) data[c]["kosten"]));
            
            return ret;
        }

        public List<Event> getEvents(string filter)
        {
            List<Event> ret = new List<Event>();

            List<Dictionary<string, object>> data = getQuery("SELECT Id, Naam, Startdatum, Einddatum, Beschrijving, Kosten FROM Employee WHERE Naam LIKE '%"+filter+"%' OR Beschrijving LIKE '%"+filter+"%' OR Id LIKE '%"+filter+"%'");

            for (int c = 0; c < data.Count; c++)
                ret.Add(new Event(Convert.ToInt16(data[c]["id"]), (string)data[c]["naam"], (string)data[c]["beschrijving"], (DateTime)data[c]["startdatum"], (DateTime)data[c]["einddatum"], (float)data[c]["kosten"]));

            return ret;
        }

        public bool deleteEvent(Event e)
        {
            return doQuery("DELETE FROM Event WHERE Id = " + e.id) > 0;
        }

        public bool createEvent(Event e)
        {
            return doQuery("INSERT INTO Event (Id, Naam, Startdatum, Einddatum, Beschrijving, Kosten) VALUES (" + e.id + ", '" + e.Name + "', to_date('" + e.startDate + "','MM-DD-YYYY hh24:MI'),  to_date('" + e.endDate + "','MM-DD-YYYY hh24:MI'), "+e.price+")") > 0;
        }
    }
}
