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
                if (GameObject.CurrentRoom.North != -1)
                {
                    GameObject.CurrentRoom = GameAttributes.rooms[GameObject.CurrentRoom.North];
                }
                else
                {
                    Console.WriteLine("You can't go that way. Choose another direction.");
                }
            }
            else if (input.ToLower() == "south")
            {
                if (GameObject.CurrentRoom.South != -1)
                {
                    GameObject.CurrentRoom = GameAttributes.rooms[GameObject.CurrentRoom.South];
                }
                else
                {
                    Console.WriteLine("You can't go that way. Choose another direction.");
                }
            }
            else if (input.ToLower() == "east")
            {
                if (GameObject.CurrentRoom.East != -1)
                {
                    GameObject.CurrentRoom = GameAttributes.rooms[GameObject.CurrentRoom.East];
                }
                else
                {
                    Console.WriteLine("You can't go that way. Choose another direction.");
                }
            }
            else if (input.ToLower() == "west")
            {
                if (GameObject.CurrentRoom.West != -1)
                {
                    GameObject.CurrentRoom = GameAttributes.rooms[GameObject.CurrentRoom.West];
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

            //if (input.ToLower() == "north")
            //{
            //    if (Player.CurrentRoom.North != -1)
            //    {
            //        Player.CurrentRoom = GameAttributes.rooms[Player.CurrentRoom.North];
            //    }
            //    else
            //    {
            //        Console.WriteLine("You can't go that way. Choose another direction.");
            //    }
            //}
            //else if (input.ToLower() == "south")
            //{
            //    if (Player.CurrentRoom.South != -1)
            //    {
            //        Player.CurrentRoom = GameAttributes.rooms[Player.CurrentRoom.South];
            //    }
            //    else
            //    {
            //        Console.WriteLine("You can't go that way. Choose another direction.");
            //    }
            //}
            //else if (input.ToLower() == "east")
            //{
            //    if (Player.CurrentRoom.East != -1)
            //    {
            //        Player.CurrentRoom = GameAttributes.rooms[Player.CurrentRoom.East];
            //    }
            //    else
            //    {
            //        Console.WriteLine("You can't go that way. Choose another direction.");
            //    }
            //}
            //else if (input.ToLower() == "west")
            //{
            //    if (Player.CurrentRoom.West != -1)
            //    {
            //        Player.CurrentRoom = GameAttributes.rooms[Player.CurrentRoom.West];
            //    }
            //    else
            //    {
            //        Console.WriteLine("You can't go that way. Choose another direction.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: You must enter north, south, east, or west.");
            //}
        }
    }
}
