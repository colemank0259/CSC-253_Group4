using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Weapon
    {
        //List<string> weapons = new List<string>() {"Energy Blaster", "Power Gauntlets", "Sonic Cannon", "Pulse Blade"};

        public int ID { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }

        public Weapon(int id, string description, int damage)
        {
            ID = id;
            Description = description;
            Damage = damage;
        }
    }
}
