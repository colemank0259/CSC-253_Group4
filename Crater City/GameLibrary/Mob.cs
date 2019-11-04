using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Mob
    {
        // TODO copy Mobs and add position and movement; may need addtional class

        public string ID { get; set; }
        public string Description { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int HP { get; set; }

        public Mob(string id, string description, int strength, int speed, int hp)
        {
            ID = id;
            Description = description;
            Strength = strength;
            Speed = speed;
            HP = hp;
        }
    }
}
