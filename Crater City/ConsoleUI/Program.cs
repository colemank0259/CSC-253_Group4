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
            Player myPlayer = new Player();

            

            bool exit = false;

            do
            {
                Console.WriteLine(Player.CurrentRoom.Description);
                Console.Write("Which direction do you want to move? ");
                string userInput = Console.ReadLine();
                PlayerMovement.GetMovement(userInput);
                Console.ReadLine();
            } while (exit == false);

            Console.ReadLine();

            

            //do
            //{
            //    // Ask user to either run the program or exit
            //    GameLibrary.StandardMessages.DisplayOpeningMenu();

            //    // Declare varible to hold user input
            //    string input = Console.ReadLine();

            //    if (input == "1")
            //    {
            //        // Local variables

            //        // Display description of the program
            //        GameLibrary.StandardMessages.DisplayProgramDescription();

            //        // Consume the next line for appearance
            //        Console.WriteLine("");

            //    }
            //    else if (input == "2")
            //    {
            //        exit = true;
            //    }
            //    else
            //    {
            //        GameLibrary.StandardMessages.DisplayOpeningMenuError();
            //    }

            //} while (exit == false); 
        }
    }
}
