using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Potion : LivingBeing
    {
        //List<string> potions = new List<string>() {"Health", "Ability Boost"};

        //public string ID { get; set; }
        //public string Description { get; set; }

        public Potion(int id, string name, int damage, int ac, int hp, int xp) : base(id, name, damage, ac, hp, xp)
        {
            CurrentRoom = GameAttributes.rooms[RandomNumber.NumberBetween(0, 6)];
        }
    }
}
