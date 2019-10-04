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

        public int ID { get; set; }
        public string Description { get; set; }

        public Potion(int id, string description)
        {
            ID = id;
            Description = description;
        }
    }
}
