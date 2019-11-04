using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameAttributes
    {
        // Note: The CSV files do not have headers.

        public static List<Room> rooms = RoomFile.GetRooms();

        /**
         * TODO: proposed room names
         * 1. Hero's Base
         * 2. (Multiple Streets to connect outdoor locations and/or buildings)
         * 3. Museum
         * 4. Gas Station
         * 5. Grocery Store
         * 6. Police Station
         * 7. Mayor's Office
         * 8. Sewers
         * 9. Robot Factory
         * 10. Genetics Lab
         * 11. Rooftop
         * 12. Bank
         */

        public static List<Weapon> weapons = WeaponFile.GetWeapons();

        public static List<Potion> potions = PotionFile.GetPotions();

        public static List<Treasure> treasures = TreasureFile.GetTreasures();

        public static List<Item> items = ItemFile.GetItems();

        public static List<Mob> mobs = MobFile.GetMobs();

        
        
        
        
        
    }
}
