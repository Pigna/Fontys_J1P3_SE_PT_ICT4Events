using Oracle.DataAccess.Client;
using Oracle.DataAccess;
//using Oracle.DataAccess.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class Database
    {
        //fields
        protected OracleConnection con;

        private User current;
        private Employee loggedInEmployee;
        public Object Logged { get { if (loggedInEmployee == null) return current; return loggedInEmployee; } }

        //properties

        //constructor
        public Database()
        {
            con = new OracleConnection();
            con.ConnectionString = "Data Source=fhictora01.fhict.local/fhictora;Persist Security Info=True;User ID=dbi329331;Password=vbNEA73jMt";
            
        }

        //methodes
        private void Connect()
        {
            con.Open();
        }

        private void Disconnect()
        {
            con.Close();
            con.Dispose();
        }

        protected int doQuery(string query)
        {
            try
            {
            Connect();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                int ret = cmd.ExecuteNonQuery();
            Disconnect();
                return ret;

            }
            catch (Exception e) { Console.WriteLine(e.ToString()); return -1; }
            finally { Disconnect(); }
        }

        protected List<Dictionary<string, object>> getQuery(string query)
        {
            List<Dictionary<string, object>> ret = new List<Dictionary<string, object>>();

            try
            {
                Connect();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;

                OracleDataReader data = cmd.ExecuteReader();
                

                while (data.Read())
                {
                    Dictionary<string, object> d = new Dictionary<string,object>();
                    for (int c = 0; c < data.FieldCount; c++)
                        d.Add(data.GetName(c).ToLower(), data.GetValue(c));


                    ret.Add(d);
                }

                Disconnect();
                return ret;

            }
            catch (Exception e) { 
                Console.WriteLine(e.ToString()); 
                return null; 
            }
            finally { Disconnect(); }
        }
       

        public bool logIn(string username, string password)
        {
            List<Dictionary<string, object>> data = getQuery("SELECT Id, Username, Voornaam, Tussenvoegsel, Achternaam FROM Gebruiker WHERE Username = '" + username + "' AND Password = '" + password + "'");
            if (data == null)
                return false;

            if (data.Count > 0) // Logged in!
            {
                Dictionary<string, object> cur = data[0];
                current = new User(Convert.ToInt16(cur["ID"]), (string) cur["USERNAME"], (string) cur["VOORNAAM"], (string) cur["TUSSENVOEGSEL"], (string) cur["ACHTERNAAM"]);
            }

            return data.Count > 0;
        }
        public bool empLogIn(string username, string password)
        {
           /* OracleDataReader data = getQuery("SELECT Id, Username, Adminrights, Password From Employee WHERE Username = '" + username + "' AND Password = '" + password + "';");

            if (data == null)
                return false; 

            if (data.Read()) // Logged in!
            {
                loggedInEmployee = new Employee(data.GetInt16(0), data.GetString(1), data.GetString(3), data.GetBoolean(2));
            }
            */
            return false;
        }

        public int getLatestId(String table)
        {
            /*OracleDataReader data = getQuery("SELECT MAX(Id) + 1 FROM "+table+";");

            if (data.Read())
                return data.GetInt16(0);
            */
            return -1;
        }
    }
}
