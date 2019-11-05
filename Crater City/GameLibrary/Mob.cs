using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Mob : GameObject
    {
        // TODO copy Mobs and add position and movement; may need addtional class

        //public int ID { get; set; }
        //public string Description { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int HP { get; set; }

        public Mob(int id, string name, int strength, int speed, int hp) : base(id, name)
        {
            //ID = id;
            //Description = description;
            Strength = strength;
            Speed = speed;
            HP = hp;
        }
    }
}
