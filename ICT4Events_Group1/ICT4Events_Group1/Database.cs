﻿using Oracle.DataAccess.Client;
using Oracle.DataAccess;
//using Oracle.DataAccess.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1


    /* USERS:
     * user: 'Kevinisswag', 'geenswag'
     * Emp.: 'Nick', 'Cactus'
     * Admin: 'Martijn', 'xxxxxx'
     * */
{
    class Database
    {
        //fields
        protected OracleConnection con;

        private static User current;
        private static Employee loggedInEmployee;
        public Object Logged { get { if (loggedInEmployee == null) return current; return loggedInEmployee; } }

        internal Employee Employee
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //properties

        //constructor
        public Database()
        {

        }

        //methodes
        private void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "Data Source=fhictora01.fhict.local/fhictora;Persist Security Info=True;User ID=dbi329331;Password=vbNEA73jMt";
            
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
                OracleTransaction transact = cmd.Connection.BeginTransaction();
                cmd.Transaction = transact;
                int ret = cmd.ExecuteNonQuery();
                transact.Commit();
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
                current = new User(Convert.ToInt16(cur["id"]), (string) cur["username"], (string) cur["voornaam"], (string) cur["tussenvoegsel"], (string) cur["achternaam"]);
            }

            return data.Count > 0;
        }
        public bool empLogIn(string username, string password)
        {
             List<Dictionary<string, object>> data = getQuery("SELECT Id, Username, Adminrights, Password From Employee WHERE Username = '" + username + "' AND Password = '" + password + "'");

             if (data == null)
                 return false;

             if (data.Count > 0) // Logged in!
             {
                 Dictionary<string, object> cur = data[0];
                 loggedInEmployee = new Employee(Convert.ToInt16(cur["id"]), (string)cur["username"], (string)cur["password"], Convert.ToInt16(cur["adminrights"]) == 1);
             }

            return data.Count > 0;
        }

        public int getLatestId(String table)
        {
            List<Dictionary<string, object>> data = getQuery("SELECT MAX(Id) + 1 AS ID FROM " + table);

            if (data == null)
                return 0;

            if (data.Count > 0)
                return Convert.ToInt16(data[0]["id"]);
            return -1;
        }

        public void logOut()
        {
            current = null;
            loggedInEmployee = null;
        }
    }
}
