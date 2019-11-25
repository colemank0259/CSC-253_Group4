using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Combat
    {
        public static List<Mob> CurrentMobs = GameAttributes.mobs;

        public static Mob GetCurrentMob(List<Mob> mobs)
        {
            Mob mob = mobs[RandomNumber.NumberBetween(0, 4)];

            return mob;
        }
    }
}
