using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameAttributes
    {
        // TODO Write text file with Game Attribute data

        public static List<Room> rooms = new List<Room>()
        {
            new Room("R1", "Mayor's Office", 1, -1, -1, -1),
            new Room("R2", "Sewers",-1, -1, -1, -1),
            new Room("R3", "Robot Factory", -1, -1, -1, -1),
            new Room("R4", "Genetics Lab", -1, -1, -1, -1),
            new Room("R5", "Rooftop", -1, -1, -1, -1),
            new Room("R6", "Bank", -1, -1, -1, -1),
            new Room("R7", "Main Street", -1, -1, -1, -1),

            /**
             * TODO: new room names
             * 1. Hero's Base
             * 2. (Multiple Streets to connect locations)
             * 3. Museum
             * 4. Gas Station
             * 5. Grocery Store
             * 6. Police Station
             */
        };

        public static List<Weapon> weapons = new List<Weapon>()
        {
            new Weapon("W1","Energy Blaster", "Melee", 0),
            new Weapon("W2","Power Gauntlets", "Melee", 0),
            new Weapon("W3","Sonic Cannon", "Projectile", 0),
            new Weapon("W4","Pulse Blade", "Projectile", 0),
        };

        public static List<Potion> potions = new List<Potion>()
        {
            new Potion("P1","Health"),
            new Potion("P2","Ability Boost"),
        };

        public static List<Treasure> treasures = new List<Treasure>()
        {
            new Treasure("T1","Evidence of Alter Ego"),
            new Treasure("T2","Proof of Criminal Activity"),
            new Treasure("T3","Stolen Goods"),
        };

        public static List<Item> items = new List<Item>()
        {
            new Item("I1","Disguise"),
            new Item("I2","Office Lunch"),
            new Item("I3","Key Card"),
            new Item("I4","ID Card"),
        };

        public static List<Mob> mobs = new List<Mob>()
        {
            new Mob("M1","Robots", 0, 0, 0),
            new Mob("M2","Police", 0, 0, 0),
            new Mob("M3","Mutant Dogs", 0, 0, 0),
            new Mob("M4","Gang Members", 0, 0, 0),
            new Mob("M5","Supervillains", 0, 0, 0),
        };

        
        
        
        
        
    }
}
