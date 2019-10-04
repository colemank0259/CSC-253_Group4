using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameAttributes
    {
        public static List<Room> rooms = new List<Room>()
        {
            new Room(1, "Mayor's Office", 1, -1, -1, -1),
            new Room(2, "Sewers",-1, -1, -1, -1),
            new Room(3, "Robot Factory", -1, -1, -1, -1),
            new Room(4, "Genetics Lab", -1, -1, -1, -1),
            new Room(5, "Rooftop", -1, -1, -1, -1),
            new Room(6, "Bank", -1, -1, -1, -1),
            new Room(7, "Main Street", -1, -1, -1, -1),
        };

        public static List<Weapon> weapons = new List<Weapon>()
        {
            new Weapon(1,"Energy Blaster", 0),
            new Weapon(2,"Power Gauntlets", 0),
            new Weapon(3,"Sonic Cannon", 0),
            new Weapon(4,"Pulse Blade", 0),
        };

        public static List<Potion> potions = new List<Potion>()
        {
            new Potion(1,"Health"),
            new Potion(2,"Ability Boost"),
        };

        public static List<Treasure> treasures = new List<Treasure>()
        {
            new Treasure(1,"Evidence of Alter Ego"),
            new Treasure(2,"Proof of Criminal Activity"),
            new Treasure(3,"Stolen Goods"),
        };

        public static List<Item> items = new List<Item>()
        {
            new Item(1,"Disguise"),
            new Item(2,"Office Lunch"),
            new Item(3,"Key Card"),
            new Item(4,"ID Card"),
        };

        public static List<Mob> mobs = new List<Mob>()
        {
            new Mob(1,"Robots", 0, 0, 0),
            new Mob(2,"Police", 0, 0, 0),
            new Mob(3,"Mutant Dogs", 0, 0, 0),
            new Mob(4,"Gang Members", 0, 0, 0),
            new Mob(5,"Supervillains", 0, 0, 0),
        };

        
        
        
        
        
    }
}
