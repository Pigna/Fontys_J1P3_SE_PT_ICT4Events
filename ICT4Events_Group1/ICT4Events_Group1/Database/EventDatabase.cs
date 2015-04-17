using System;
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

            OracleDataReader data = getQuery("SELECT Id, Username, Password, Adminrights FROM Employee");

            while (data.read())
            {
                ret.Add(new Employee(data.GetInt16(0), data.GetString(1), data.GetString(2), data.GetInt16(3)));
            }
            return ret;
        }

        public List<Employee> getEmployees(string filter)
        {
            List<Employee> ret = new List<Employee>();

            OracleDataReader data = getQuery("SELECT Id, Username, Password, Adminrights FROM Employee WHERE Username LIKE '%"+filter+"%' OR Id LIKE '%"+filter+"%';");

            while (data.read())
            {
                ret.Add(new Employee(data.GetInt16(0), data.GetString(1), data.GetString(2), data.GetInt16(3)));
            }
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

            OracleDataReader data = getQuery("SELECT Id, Naam, Startdatum, Einddatum, Beschrijving, Kosten FROM Employee");

            while (data.read())
            {
                ret.Add(new Event(data.GetInt16(0), data.GetString(1), data.GetString(4), data.GetValue(2), data.GetValue(2), (float) data.GetDecimal(5)));
            }
            return ret;
        }

        public List<Event> getEvents(string filter)
        {
            List<Event> ret = new List<Event>();

            OracleDataReader data = getQuery("SELECT Id, Naam, Startdatum, Einddatum, Beschrijving, Kosten FROM Employee WHERE Naam LIKE '%"+filter+"%' OR Beschrijving LIKE '%"+filter+"%' OR Id LIKE '%"+filter+"%'");

            while (data.read())
            {
                ret.Add(new Event(data.GetInt16(0), data.GetString(1), data.GetString(4), data.GetValue(2), data.GetValue(2), (float)data.GetDecimal(5)));
            }
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
