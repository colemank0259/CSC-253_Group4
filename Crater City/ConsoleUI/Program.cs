using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            bool exit = false;

            do
            {
                // Ask user to either run the program or exit
                Console.WriteLine("1. Run the program");
                Console.WriteLine("2. Exit");
                Console.Write("Enter 1 or 2 to select: ");

                // Declare varible to hold user input
                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Local variables


                    // Display description of the program
                    Console.WriteLine("This program is a dungeon crawl game.");

                    // Consume the next line for appearance
                    Console.WriteLine("");

                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("ERROR: You must enter 1 or 2.");
                }

            } while (exit == false);
        }
    }
}
