using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Potion : GameObject
    {
        //List<string> potions = new List<string>() {"Health", "Ability Boost"};

        //public string ID { get; set; }
        //public string Description { get; set; }

        public Potion(int id, string name) : base(id, name)
        {
            ID = id;
            Name = name;
        }
    }
}
