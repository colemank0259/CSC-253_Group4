using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Player : GameObject
    {
        //public int PlayerID { get; set; }
        //public string PlayerName { get; set; }
        public string PlayerPassword { get; set; }
        public string PlayerClass { get; set; }
        public string PlayerRace { get; set; }
        //public static Room CurrentRoom { get; set; }

        public Player(int id, string name, string playerPassword, string playerClass, string playerRace) : base (id, name)
        {
            //PlayerID = playerID;
            //PlayerName = playerName;
            PlayerPassword = playerPassword;
            PlayerClass = playerClass;
            PlayerRace = playerRace;
            //CurrentRoom = GameAttributes.rooms[0];
        }
    }
}
