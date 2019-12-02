using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class LivingBeing : GameObject
    {
        public int Damage { get; set; }
        public int AC { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }

        public static Room CurrentRoom { get; set; }

        public LivingBeing(int id, string name, int damage, int ac, int hp, int xp) : base (id, name)
        {
            Damage = damage;

            AC = ac;

            HP = hp;

            XP = xp;
        }
    }
}
