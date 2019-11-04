using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class PlayerMovement
    {
        public static void GetMovement(string input)
        {
            if (input.ToLower() == "north")
            {
                if (CurrentPlayer.CurrentRoom.North != -1)
                {
                    CurrentPlayer.CurrentRoom = GameAttributes.rooms[CurrentPlayer.CurrentRoom.North];
                }
                else
                {
                    Console.WriteLine("You can't go that way. Choose another direction.");
                }
            }
            else if (input.ToLower() == "south")
            {
                if (CurrentPlayer.CurrentRoom.South != -1)
                {
                    CurrentPlayer.CurrentRoom = GameAttributes.rooms[CurrentPlayer.CurrentRoom.South];
                }
                else
                {
                    Console.WriteLine("You can't go that way. Choose another direction.");
                }
            }
            else if (input.ToLower() == "east")
            {
                if (CurrentPlayer.CurrentRoom.East != -1)
                {
                    CurrentPlayer.CurrentRoom = GameAttributes.rooms[CurrentPlayer.CurrentRoom.East];
                }
                else
                {
                    Console.WriteLine("You can't go that way. Choose another direction.");
                }
            }
            else if (input.ToLower() == "west")
            {
                if (CurrentPlayer.CurrentRoom.West != -1)
                {
                    CurrentPlayer.CurrentRoom = GameAttributes.rooms[CurrentPlayer.CurrentRoom.West];
                }
                else
                {
                    Console.WriteLine("You can't go that way. Choose another direction.");
                }
            }
            else
            {
                Console.WriteLine("Error: You must enter north, south, east, or west.");
            }
        }
    }
}
