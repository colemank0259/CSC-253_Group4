using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Treasure
    {
        //List<string> treasures = new List<string>() {"Evidence of Alter Ego", "Proof of Criminal Activity", "Stolen Goods"};

        public int ID { get; set; }
        public string Description { get; set; }

        public Treasure(int id, string description)
        {
            ID = id;
            Description = description;
        }
    }
}
