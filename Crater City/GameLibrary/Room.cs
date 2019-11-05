using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Room : GameObject
    {
        //public string ID { get; set; }
        //public string Description { get; set; }
        public int North { get; set; }

        public int South { get; set; }

        public int East { get; set; }

        public int West { get; set; }

        public Room(int id, string name, int north, int south, int east, int west) : base (id, name)
        {
            //ID = id;
            //Description = description;
            North = north;
            South = south;
            East = east;
            West = west;
        }
    }
}
