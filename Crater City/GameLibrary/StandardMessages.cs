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
            Console.WriteLine("1. Run Program");
            Console.WriteLine("2. Exit");
            Console.Write("Enter 1 or 2 to select: ");
        }

        public static void DisplayOpeningMenuError()
        {
            Console.WriteLine("You must enter 1 or 2.");
        }

        public static void DisplayIntError()
        {
            Console.WriteLine("You must enter an integer.");
        }

        public static void DisplayProgramDescription()
        {
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
            Console.WriteLine("1. Create new player profile");
            Console.WriteLine("2. Load player profile");
            Console.Write("Enter a number to select:");
        }

        public static void PromptNewPlayerSignUp()
        {
            // TODO Write prompt to create new player profile
        }

        public static void PromptReturningPlayerSignIn()
        {
            Console.Write("Enter your existing Player Name:");
        }

        public static void PromptPlayerName()
        {
            Console.WriteLine("Enter your name: ");
        }

        public static void PromptPlayerPassword()
        {
            Console.WriteLine("Enter your password: ");
        }

        public static void PromptPlayerRace()
        {
            Console.WriteLine("1. Techie");
            Console.WriteLine("2. Metahuman");
            Console.WriteLine("3. Magic");
            Console.WriteLine("Enter a number to choose your character type:");
        }

        public static void PromptPlayerClass()
        {
            Console.WriteLine("Enter a number to choose your character class:");
        }
    }
}
