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

            for(int c = 0; c < ret.Count; c++)
                ret.Add(new Employee((int)data[c]["id"], (string)data[c]["Username"], (string)data[c]["Password"], (int)data[c]["Adminrights"] == 1));

            return ret;
        }

        public List<Employee> getEmployees(string filter)
        {
            List<Employee> ret = new List<Employee>();

            List<Dictionary<string, object>> data = getQuery("SELECT Id, Username, Password, Adminrights FROM Employee WHERE Username LIKE '%" + filter + "%' OR Id LIKE '%" + filter + "%';");

            for (int c = 0; c < ret.Count; c++)
                ret.Add(new Employee((int)data[c]["id"], (string)data[c]["Username"], (string)data[c]["Password"], (int)data[c]["Adminrights"] == 1));

            return ret;
        }

        public bool deleteEmployee(Employee e)
        {
            //return doQuery("DELETE FROM Employee WHERE Id = " + e.id).Count > 0;
            return false;
        }

        public bool createEmployee(Employee e)
        {
            //return doQuery("INSERT INTO Employee (Id, Username, Password) VALUES (" + e.id + ", " + e.username + ", " + e.password + ");").Count > 0;
            return false;
        }


        public List<Event> getEvents()
        {
            List<Event> ret = new List<Event>();

            List<Dictionary<string, object>> data = getQuery("SELECT Id, Naam, Startdatum, Einddatum, Beschrijving, Kosten FROM Employee");

            for (int c = 0; c < ret.Count; c++)
                ret.Add(new Event((int)data[c]["id"], (string)data[c]["Naam"], (string)data[c]["Beschrijving"], (DateTime)data[c]["STARTDATUM"], (DateTime)data[c]["EINDDATUM"], (float) data[c]["Kosten"]));
            
            return ret;
        }

        public List<Event> getEvents(string filter)
        {
            /*List<Event> ret = new List<Event>();

            OracleDataReader data = getQuery("SELECT Id, Naam, Startdatum, Einddatum, Beschrijving, Kosten FROM Employee WHERE Naam LIKE '%"+filter+"%' OR Beschrijving LIKE '%"+filter+"%' OR Id LIKE '%"+filter+"%'");

            while (data.Read())
            {
                ret.Add(new Event(data.GetInt16(0), data.GetString(1), data.GetString(4), data.GetDateTime(2), data.GetDateTime(2), (float)data.GetDecimal(5)));
            }
            return ret;*/
            return null;
        }

        public bool deleteEvent(Event e)
        {
            return false;
            //return doQuery("DELETE FROM Event WHERE Id = " + e.id).Count > 0;
        }

        public bool createEvent(Event e)
        {
            return false;
            //return doQuery("INSERT INTO Event (Id, Naam, Startdatum, Einddatum, Beschrijving, Kosten) VALUES (" + e.id + ", '" + e.Name + "', to_date('" + e.startDate + "','MM-DD-YYYY hh24:MI'),  to_date('" + e.endDate + "','MM-DD-YYYY hh24:MI'), "+e.price+")").Count > 0;
        }
    }
}
