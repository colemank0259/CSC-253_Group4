using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class CurrentPlayer: GameObject
    {
        public string PlayerPassword { get; set; }
        public string PlayerClass { get; set; }
        public string PlayerRace { get; set; }
        public int PlayerHP { get; set; }
        public int PlayerXP { get; set; }
        public static Room CurrentRoom { get; set; }
        public static Weapon CurrentWeapon { get; set; }

        public CurrentPlayer(int playerID, string playerName, string playerPassword, string playerClass, string playerRace, int playerHP, int playerXP)
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

        public static Weapon GetCurrentWeapon(CurrentPlayer currentPlayer)
        {
            foreach (Weapon weapon in GameAttributes.weapons)
            {
                if (weapon.Type.ToLower() == currentPlayer.PlayerClass.ToLower())
                {
                     CurrentWeapon = weapon;
                }
            }

            return CurrentWeapon;
        }

    }
}
