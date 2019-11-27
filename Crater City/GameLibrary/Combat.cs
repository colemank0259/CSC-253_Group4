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

        public 

        public static Mob PerformPlayerAttack(Player myPlayer, Mob currentMob)
        {
            PerformAttack(myPlayer, currentMob);

            return currentMob;
        }

        public static Player PerformMobAttack(Player myPlayer, Mob currentMob)
        {
            PerformAttack(currentMob, myPlayer);

            return myPlayer;
        }

        public static LivingBeing PerformAttack(LivingBeing attacker, LivingBeing enemy)
        {
            // Local variable
            int diceRoll = RandomNumber.NumberBetween(1, 100);

            if (diceRoll > enemy.AC)
            {
                enemy.HP -= attacker.Damage;

                Console.WriteLine($"{attacker} has hit {enemy}.");
                Console.WriteLine($"{enemy}'s HP is {enemy.HP}.");
            }
            else
            {
                Console.WriteLine($"{attacker} has hit {enemy}.");
                Console.WriteLine($"{enemy}'s HP is {enemy.HP}.");
            }


            return enemy;

        }
    }
}
