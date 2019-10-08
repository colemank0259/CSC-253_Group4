using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Potion
    {
        //List<string> potions = new List<string>() {"Health", "Ability Boost"};

        public string ID { get; set; }
        public string Description { get; set; }

        public Potion(string id, string description)
        {
            ID = id;
            Description = description;
        }
    }
}
