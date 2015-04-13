using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class MediaSharing
    {
        //fields
        List<Message> messages = new List<Message>();
        int MessageLike = 0;
        //properties
        //constructors

        //methoden
        public bool SendMessages(Message bericht)
        {
            return true;
        }
        public List<Message> LoadMessages()
        {
            return messages;
        }
        public List<Message> ReportedMessages()
        {
            List<Message> Reportedmessages = new List<Message>();

            //SELECT *
            //FROM Message
            //WHERE MessageState = "Reported";
            return Reportedmessages;
        }
        public bool LikePost(Message message)
        {
            //INSERT INTO Message(Messagestate)
            //VALUES ('Like');
            if (MessageLike == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PublishMessage(string title, string message)
        {       
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool PublishFile(string title, string message/*File*/)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool PublishReaction(string reaction, Message message)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ReportPost(string reason, Message message)
        {
            //INSERT INTO Message(Messagestate)
            //VALUES ('Reported');
            return true;
        }
    }
}
