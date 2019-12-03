using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class StandardMessages
    {
        public static void DisplayOpeningMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Run Program");
            Console.WriteLine("2. Exit");
            Console.Write("Enter 1 or 2 to select: ");
        }

        public static void DisplayOpeningMenuError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You must enter 1 or 2.");
        }

        public static void DisplayIntError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You must enter an integer.");
        }

        public static void DisplayProgramDescription()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This program is a dungeon crawl game.");
        }

        public static void DisplayMainMenu()
        {
        }

        public static void DisplayMainMenuError()
        {
            Console.WriteLine("");
        }

        public static void PromptPlayerSignIn()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Create new player profile");
            Console.WriteLine("2. Load player profile");
            Console.Write("Enter a number to select: ");
        }

        public static void PromptNewPlayerSignUp()
        {
            // TODO Write prompt to create new player profile
        }

        public static string PromptReturningPlayerSignIn()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your existing Player Name: ");

            return Console.ReadLine();
        }

        public static string PromptPlayerName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your name: ");

            return Console.ReadLine();
        }

        public static string PromptPlayerPassword()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your password: ");

            return Console.ReadLine();
        }

        public static string PromptPlayerRace()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Techie");
            Console.WriteLine("2. Metahuman");
            Console.WriteLine("3. Magic");
            Console.Write("Enter a number to choose your character type: ");

            return Console.ReadLine();
        }

        public static string PromptPlayerClass()
        {
            //Console.WriteLine("1. Gadgeteer");
            //Console.WriteLine("2. Speedster");
            //Console.WriteLine("3. Assassin");
            //Console.WriteLine("4. Wizard");
            //Console.WriteLine("5. Ninja");
            //Console.WriteLine("6. Tank");
            //Console.WriteLine("7. Banshee");
            //Console.WriteLine("8. Samurai");

            int index = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (PlayerClass classCount = PlayerClass.Gadgeteer; classCount <= PlayerClass.Samurai; classCount++)
            {
                index++;

                Console.WriteLine($"{index}. {classCount.ToString()}");
            }
            Console.Write("Enter a number to choose your character class: ");

            return Console.ReadLine();
        }
    }
}
