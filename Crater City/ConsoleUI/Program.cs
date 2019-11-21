using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
/**
* 09/15/19
* CSC 253
* Group 4
* This program is a dungeon crawl game.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player(0, null, null, null, null);
            CurrentPlayer myPlayer = new CurrentPlayer(0, null, null, null, null, 0, 0);
            List<Player> myPlayers = new List<Player>();
            bool exit = false;


            do
            {
                // Ask user to either run the program or exit
                StandardMessages.DisplayOpeningMenu();

                // Declare varible to hold user input
                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Local variables

                    // Display description of the program
                    StandardMessages.DisplayProgramDescription();

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Get player profile
                    myPlayer = PlayerFile.GetPlayer(newPlayer, myPlayers);

                    // Display player information
                    Console.WriteLine($"Player Name: {myPlayer.Name}");
                    Console.WriteLine($"Player Type: {myPlayer.PlayerRace}");
                    Console.WriteLine($"Player Class: {myPlayer.PlayerClass}");

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Display room names for testing (remove later)
                    Console.WriteLine("Rooms:");
                    foreach(Room room in GameAttributes.rooms)
                    {
                        Console.WriteLine($"{room.Name}");
                    }

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Display weapon names for testing (remove later)
                    Console.WriteLine("Weapons:");
                    foreach (Weapon weapon in GameAttributes.weapons)
                    {
                        Console.WriteLine($"{weapon.Name}");
                    }

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Get player's weapon
                    CurrentPlayer.GetCurrentWeapon(myPlayer);

                    // Get player movement
                    GetPlayerMovement();

                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    StandardMessages.DisplayOpeningMenuError();
                }

            } while (exit == false);
        }

        static void GetPlayerMovement()
        {
            bool exit = false;

            do
            {
                Console.WriteLine(CurrentPlayer.CurrentRoom.Name);
                Console.Write("Which direction do you want to move? ");
                string userInput = Console.ReadLine();
                PlayerMovement.GetMovement(userInput);
                Console.ReadLine();
            } while (exit == false);

            Console.ReadLine();
        }
    }
}
