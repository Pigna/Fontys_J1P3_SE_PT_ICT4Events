﻿using System;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class MediaSharingDatabase : Database
    {       
        //fields
        //propperties
        //constructor
        //methodes
        public bool sendMessage(Message bericht, int id, string inhoud)
        {
            try
            {
                doQuery("INSERT INTO Message(Id, Inhoud) VALUES(id, inhoud)");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Message> getMessages(Event eventnaam)
        {
            List<Message> mes = new List<Message>();
            OracleDataReader data = getQuery("SELECT Id, Inhoud FROM Message");

            while (data.Read())
            {
                mes.Add(new Message());
            }
            return mes;
           
        }
        public bool sendLike(Message message, User user, int id)
        {
            try
            {
                doQuery("INSERT INTO Like(Id, User, Message) VALUES(id, user, message");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
