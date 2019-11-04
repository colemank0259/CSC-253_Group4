using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class CurrentPlayer : Player
    {
        public int PlayerHP { get; set; }
        public static Room CurrentRoom { get; set; }

        public CurrentPlayer(int playerID, string playerName, string playerPassword, string playerClass, string playerRace, int playerHP) 
            : base(playerID, playerName, playerPassword, playerClass, playerRace)
        {
            PlayerHP = playerHP;
            CurrentRoom = GameAttributes.rooms[0];
        }
    }
}
