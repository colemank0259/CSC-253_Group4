﻿using System;
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
    }
}
