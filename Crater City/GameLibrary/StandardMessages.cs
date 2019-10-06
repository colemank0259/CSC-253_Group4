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
            Console.Write("Enter 1 or 2 to select: ");
            Console.Write("");
            Console.WriteLine("1. Run Program");
            Console.WriteLine("2. Exit");
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
            Console.WriteLine("This program stores student infomation and calculates grade averages.");
        }

        public static void DisplayMainMenu()
        {
            Console.Write("Enter 1, 2 or 3 to select: ");
            Console.WriteLine("");
            Console.WriteLine("1. Enter Student");
            Console.WriteLine("2. Get Average");
            Console.WriteLine("3. Exit");
        }

        public static void DisplayMainMenuError()
        {
            Console.WriteLine("You must enter 1, 2 or 3.");
        }
    }
}
