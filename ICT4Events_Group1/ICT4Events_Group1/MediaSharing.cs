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
        //properties
        //constructors

        //methoden
        public bool SendMessages(Message bericht)
        {
            return true;
        }
        public List<Message> LoadMessages()
        {
            return null;
        }
        public List<Message> ReportedMessages()
        {
            return null;
        }
        public bool LikePost(Message message)
        {
            return true;
        }
        public bool PublishMessage(string title, string message)
        {
            return true;
        }
        public bool PublishFile(string title, string message/*File*/)
        {
            return true;
        }
        public bool PublishReaction(string reaction, Message message)
        {
            return true;
        }
        public bool ReportPost(string reason, Message message)
        {
            return true;
        }
    }
}
