using Oracle.DataAccess.Client;
using Oracle.DataAccess;
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

        //methodes
        private void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "Data Source=ORCL;User Id=system;Password=pass;";
            con.Open();
        }

        private void Disconnect()
        {
            con.Close();
            con.Dispose();
        }

        protected OracleDataReader getQuery(string query)
        {
            Connect();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader data = cmd.ExecuteReader();
            Disconnect();

            return data;
        }

        protected int doQuery(string query)
        {
            Connect();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                int data = cmd.ExecuteNonQuery();
            Disconnect();

            return data;
        }

        public bool logIn(string username, string password)
        {
            OracleDataReader data = getQuery("SELECT Id, Username, Voornaam, Tussenvoegsel, Achternaam FROM Gebruiker WHERE Username = '" + username + "' AND Password = '" + password + "';");

            if (data.Read()) // Logged in!
            {
                current = new User(data.GetInt16(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4));
            }

            return data.Read();
        }
        public bool empLogIn(string username, string password)
        {
            OracleDataReader data = getQuery("SELECT Id, Username, Adminrights, Password From Employee WHERE Username = '" + username + "' AND Password = '" + password + "';");

            if (data.Read()) // Logged in!
            {
                loggedInEmployee = new Employee(data.GetInt16(0), data.GetString(1), data.GetString(3), data.GetBoolean(2));
            }

            return data.Read();
        }

        public int getLatestId(String table)
        {
            OracleDataReader data = getQuery("SELECT MAX(Id) + 1 FROM "+table+";");

            if (data.Read())
                return data.GetInt16(0);

            return -1;
        }
    }
}
