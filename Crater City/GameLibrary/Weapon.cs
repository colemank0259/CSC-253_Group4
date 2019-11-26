using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Weapon : GameObject
    {
        //public string ID { get; set; }
        //public string Description { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }

        public Weapon(int id, string name, string type, int damage) : base (id, name)
        {
            //ID = id;
            //Description = description;
            Type = type;
            Damage = damage;
        }
    }
}
