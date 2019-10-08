using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Room
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int North { get; set; }

        public int South { get; set; }

        public int East { get; set; }

        public int West { get; set; }

        public Room(int id, string description, int north, int south, int east, int west)
        {
            ID = id;
            Description = description;
            North = north;
            South = south;
            East = east;
            West = west;
        }
    }
}
