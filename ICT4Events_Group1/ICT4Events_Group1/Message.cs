using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class Message
    {
        List<Message> commentlist = new List<Message>();
        List<User> liked = new List<User>();
        List<Report> reported = new List<Report>();
        private User sent;
        private string title;
        private string content;
        private string attachment; // file
        private int id;
        string Inhoud { get; set; }
        public int Id { get { return id; } }
        public Message (int id, string inhoud)
        {
            this.id = id;
            this.Inhoud = inhoud;
        }
        
    }
}
