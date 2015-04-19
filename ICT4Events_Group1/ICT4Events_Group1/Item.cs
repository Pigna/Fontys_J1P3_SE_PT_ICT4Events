using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_Group1
{
    class Item
    {
        //fields
        public int id;
        public string naam;
        public string beschrijving;
        public float prijs;

        //propperties
        //constructor
        public Item(int id, string naam, string beschrijving, float prijs)
        {
            this.id = id;
            this.naam = naam;
            this.beschrijving = beschrijving;
            this.prijs = prijs;
        }
        //methodes
        public override string ToString()
        {
            return id + ": " + naam + " - " + beschrijving + " [" + prijs + "]";
        }
    }
}
