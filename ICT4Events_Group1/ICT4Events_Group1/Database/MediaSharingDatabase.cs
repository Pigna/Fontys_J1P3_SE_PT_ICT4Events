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
        public bool sendMessage(Message bericht)
        {
            try
            {
                doQuery("INSERT INTO Message(id, gebruiker, reaction, titel, inhoud, path, datum, zichtbaar) VALUES(" + bericht.Id + ", " + bericht.Auteur.Id + ", null, " + bericht.Title + ", " + bericht.Inhoud + ", " + bericht.Attachment + ", TIMESTAMP'1999-12-01 10:00:00', 1)");
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
            
            List<Dictionary<string, object>> messages = getQuery("SELECT m.id as id, Titel, Inhoud, g.id as gebruiker, username, voornaam, tussenvoegsel, achternaam FROM Message m JOIN Gebruiker g ON m.Gebruiker = g.id WHERE reaction IS NULL AND zichtbaar = 1 ORDER BY id DESC");
            if (messages == null)
            {
                return null;
            }

            int count = messages.Count;

            if (count > 100)
                count = 100;

            Dictionary<int, User> users = new Dictionary<int, User>();

            for (int i = 0; i < count; i++)
            {
                Dictionary<string, object> data = messages[i];
                User auteur;
                int id = Convert.ToInt32(data["gebruiker"]);
                if(users.ContainsKey(id))
                    auteur = users[id];
                else {
                    auteur = new User(Convert.ToInt32(data["id"]), (string)data["username"], (string)data["voornaam"], (string)data["tussenvoegsel"], (string)data["achternaam"]);
                    users.Add(Convert.ToInt32(id), auteur);
                }

                Dictionary<string, object> cur = messages[i];
                mes.Add(new Message(Convert.ToInt16(cur["gebruiker"]), (string)cur["inhoud"], auteur));
            }
            return mes;
           
        }
        public bool sendLike(Message message, User user, int id)
        {
            try
            {
                doQuery("INSERT INTO Leuk(ID, GEBRUIKER, MESSAGE, DATUM) VALUES(4, " + user.Id + ", " + message.Id + ", TIMESTAMP'1999-12-01 10:00:00');");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sendDislike(Message message, User user)
        {
            try
            {
                doQuery("DELETE FROM LEUK WHERE GEBRUIKER = " + user.Id + " AND MESSAGE = " + message.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Event getEvent(User user)
        {
            //GET EVENT FROM USER + DATA FROM THE EVENT
            List<Dictionary<string, object>> events = getQuery("SELECT * FROM Event WHERE id IN (SELECT event FROM Gebruiker WHERE id = " + user.Id + ")");
            //CHECK IF IT CONTAINS DATA
            if (events == null)
            {
                return null;
            }
            //GET FIRST RESULT
                Dictionary<string, object> data = events[0];
            //CREATE THE EVENT
                Event e = new Event(Convert.ToInt16(data["id"]), (string)data["naam"], (string)data["beschrijving"], Convert.ToDateTime(data["startdatum"]), Convert.ToDateTime(data["einddatum"]), (float)data["kosten"]);

            return e;
        }
    }
}
