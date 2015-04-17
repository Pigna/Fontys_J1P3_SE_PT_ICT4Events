using System;
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
            
            List<Dictionary<string, object>> messages = getQuery("SELECT Id, Inhoud FROM Message");
            if (messages == null)
            {
                return null;
            }
            for (int i = 0; i < messages.Count; i++)
            {
                Dictionary<string, object> cur = messages[i];
                mes.Add(new Message(Convert.ToInt16(cur["id"]), (string)cur["inhoud"]));
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
