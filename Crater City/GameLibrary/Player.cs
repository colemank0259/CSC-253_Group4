using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Player: GameObject
    {
        public string PlayerPassword { get; set; }
        public string PlayerClass { get; set; }
        public string PlayerRace { get; set; }
        public int PlayerHP { get; set; }
        public int PlayerXP { get; set; }
        public static Room CurrentRoom { get; set; }
        public static Weapon CurrentWeapon { get; set; }

        public Player(int playerID, string playerName, string playerPassword, string playerClass, string playerRace, int playerHP, int playerXP)
            : base(playerID, playerName)
        {
            PlayerPassword = playerPassword;
            PlayerClass = playerClass;
            PlayerRace = playerRace;
            PlayerHP = playerHP;
            PlayerXP = playerXP;
            CurrentRoom = GameAttributes.rooms[0];
            CurrentWeapon = GameAttributes.weapons[0];
        }

        public static Weapon GetCurrentWeapon(Player myPlayer)
        {
            switch (myPlayer.PlayerClass)
            {
                case "Gadgeteer":
                    CurrentWeapon = GameAttributes.weapons[0];
                    return CurrentWeapon;
                case "Speedster":
                    CurrentWeapon = GameAttributes.weapons[6];
                    return CurrentWeapon;
                case "Assassin":
                    CurrentWeapon = GameAttributes.weapons[1];
                    return CurrentWeapon;
                case "Wizard":
                    CurrentWeapon = GameAttributes.weapons[5];
                    return CurrentWeapon;
                case "Ninja":
                    CurrentWeapon = GameAttributes.weapons[7];
                    return CurrentWeapon;
                case "Tank":
                    CurrentWeapon = GameAttributes.weapons[4];
                    return CurrentWeapon;
                case "Banshee":
                    CurrentWeapon = GameAttributes.weapons[2];
                    return CurrentWeapon;
                case "Samurai":
                    CurrentWeapon = GameAttributes.weapons[3];
                    return CurrentWeapon;
                default:
                    Console.WriteLine("ERROR: Invalid Player Job Class");
                    return null;
            }
        }

    }
}
