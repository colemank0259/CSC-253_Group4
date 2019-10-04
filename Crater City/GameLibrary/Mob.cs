using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Mob
    {
        //List<string> mobs = new List<string>() {"Robots", "Police", "Mutant Dogs", "Gang Members", "Supervillains"};

        public int ID { get; set; }
        public string Description { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int HP { get; set; }

        public Mob(int id, string description, int strength, int speed, int hp)
        {
            ID = id;
            Description = description;
            Strength = strength;
            Speed = speed;
            HP = hp;
        }
    }
}
