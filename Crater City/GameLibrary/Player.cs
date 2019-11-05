using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string PlayerPassword { get; set; }
        public string PlayerClass { get; set; }
        public string PlayerRace { get; set; }
        public static Room CurrentRoom { get; set; }

        public Player(int playerID, string playerName, string playerPassword, string playerClass, string playerRace)
        {
            PlayerID = playerID;
            PlayerName = playerName;
            PlayerPassword = playerPassword;
            PlayerClass = playerClass;
            PlayerRace = playerRace;
            CurrentRoom = GameAttributes.rooms[0];
        }
    }
}
