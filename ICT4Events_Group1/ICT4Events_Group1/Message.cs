﻿using System;
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
        private User auteur;
        private int id;
        private string title;
        private string content;
        private int reactieOp;
        private string attachment; // file
        public int Id { get { return id; } }
        public string Inhoud { get { return content; } }
        public string Title { get { return title; } }
        public string Attachment { get { return attachment; } }
        public User Auteur { get { return auteur; } }
        public int ReactieOp { get { return reactieOp; } }
        public Message(int id, string titel, string inhoud, User auteur)
        {
            this.id = id;
            this.title = titel;
            this.content = inhoud;
            this.auteur = auteur;
        }
        public Message (int id, string inhoud, User auteur, int reactieOp)
        {
            this.id = id;
            this.content = inhoud;
            this.auteur = auteur;
            this.reactieOp = reactieOp;
        }
        public void addReactie(Message reactie)
        {
            commentlist.Add(reactie);
        }

        public void addReacties(List<Message> reacties)
        {
            commentlist.AddRange(reacties);
        }
        public override string ToString()
        {
            string str = "";
            if (Title != null)
            {
                str += "[" + Title + "]";
            }
            str += " " + Auteur.Username + ":";
            str += " " + Inhoud;

            return str;
        }
    }
}
