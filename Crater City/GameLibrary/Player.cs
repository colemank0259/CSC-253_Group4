using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Player: LivingBeing
    {
        public string PlayerPassword { get; set; }
        public string PlayerClass { get; set; }
        public string PlayerRace { get; set; }
        public static Weapon CurrentWeapon { get; set; }

        public Player(int playerID, string playerName, int damage, int ac, int hp, int xp, string playerPassword, string playerClass, string playerRace)
            : base(playerID, playerName, damage, ac, hp, xp)
        {
            PlayerPassword = playerPassword;
            PlayerClass = playerClass;
            PlayerRace = playerRace;
            HP = hp;
            XP = xp;
            CurrentRoom = GameAttributes.rooms[0];
            CurrentWeapon = GameAttributes.weapons[0];
        }

        public static Weapon GetCurrentWeapon(Player myPlayer)
        {
            bool exit = false;

            do
            {
                switch (myPlayer.PlayerClass)
                {
                    case "Gadgeteer":
                        CurrentWeapon = GameAttributes.weapons[0];
                        exit = true;
                        return CurrentWeapon;
                    case "Speedster":
                        CurrentWeapon = GameAttributes.weapons[6];
                        exit = true;
                        return CurrentWeapon;
                    case "Assassin":
                        CurrentWeapon = GameAttributes.weapons[1];
                        exit = true;
                        return CurrentWeapon;
                    case "Wizard":
                        CurrentWeapon = GameAttributes.weapons[5];
                        exit = true;
                        return CurrentWeapon;
                    case "Ninja":
                        CurrentWeapon = GameAttributes.weapons[7];
                        exit = true;
                        return CurrentWeapon;
                    case "Tank":
                        CurrentWeapon = GameAttributes.weapons[4];
                        exit = true;
                        return CurrentWeapon;
                    case "Banshee":
                        CurrentWeapon = GameAttributes.weapons[2];
                        exit = true;
                        return CurrentWeapon;
                    case "Samurai":
                        CurrentWeapon = GameAttributes.weapons[3];
                        exit = true;
                        return CurrentWeapon;
                    default:
                        Console.WriteLine("ERROR: Invalid Player Job Class");
                        return CurrentWeapon;
                }
            } while (exit == false);
            
        }

        public static int GetPlayerDamage(Player myPlayer)
        {
            int damage;
            bool exit = false;

            do
            {
                switch (myPlayer.PlayerClass)
                {
                    case "Gadgeteer":
                        damage = 50;
                        exit = true;
                        return damage;
                    case "Speedster":
                        damage = 50;
                        exit = true;
                        return damage;
                    case "Assassin":
                        damage = 50;
                        exit = true;
                        return damage;
                    case "Wizard":
                        damage = 50;
                        exit = true;
                        return damage;
                    case "Ninja":
                        damage = 50;
                        exit = true;
                        return damage;
                    case "Tank":
                        damage = 50;
                        exit = true;
                        return damage;
                    case "Banshee":
                        damage = 50;
                        exit = true;
                        return damage;
                    case "Samurai":
                        damage = 50;
                        exit = true;
                        return damage;
                    default:
                        Console.WriteLine("ERROR: Invalid Player Job Class");
                        return 0;
                }
            } while (exit == false);

            
        }

        public static int GetPlayerAC(Player myPlayer)
        {
            int ac;
            bool exit = false;

            do
            {
                switch (myPlayer.PlayerClass)
                {
                    case "Gadgeteer":
                        ac = 50;
                        exit = true;
                        return ac;
                    case "Speedster":
                        ac = 50;
                        exit = true;
                        return ac;
                    case "Assassin":
                        ac = 50;
                        exit = true;
                        return ac;
                    case "Wizard":
                        ac = 50;
                        exit = true;
                        return ac;
                    case "Ninja":
                        ac = 50;
                        exit = true;
                        return ac;
                    case "Tank":
                        ac = 50;
                        exit = true;
                        return ac;
                    case "Banshee":
                        ac = 50;
                        exit = true;
                        return ac;
                    case "Samurai":
                        ac = 50;
                        exit = true;
                        return ac;
                    default:
                        Console.WriteLine("ERROR: Invalid Player Job Class");
                        return 0;
                }
            } while (exit == false);

            
        }

        public static int GetPlayerHP(Player myPlayer)
        {
            int hp;
            bool exit = false;

            do
            {
                switch (myPlayer.PlayerClass)
                {
                    case "Gadgeteer":
                        hp = 100;
                        exit = true;
                        return hp;
                    case "Speedster":
                        hp = 100;
                        exit = true;
                        return hp;
                    case "Assassin":
                        hp = 100;
                        exit = true;
                        return hp;
                    case "Wizard":
                        hp = 100;
                        exit = true;
                        return hp;
                    case "Ninja":
                        hp = 100;
                        exit = true;
                        return hp;
                    case "Tank":
                        hp = 100;
                        exit = true;
                        return hp;
                    case "Banshee":
                        hp = 100;
                        exit = true;
                        return hp;
                    case "Samurai":
                        hp = 100;
                        exit = true;
                        return hp;
                    default:
                        Console.WriteLine("ERROR: Invalid Player Job Class");
                        return 0;
                }
            } while (exit == false);

           
        }

    }
}
