using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class RoomFile
    {
        public static List<Room> GetRooms()
        {
            // TODO finish StreamReader for Rooms.csv

            // Local variables
            string id = null;
            string description = null;
            int north = 0;
            int south = 0;
            int east = 0;
            int west = 0;

            try
            {
                List<Room> myRooms = new List<Room>();

                List<string> lines = File.ReadAllLines("Rooms.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Room newRoom = new Room(id, description, north, south, east, west);

                    newRoom.ID = splitter[0];
                    newRoom.Description = splitter[1];
                    newRoom.North = int.Parse(splitter[2]);
                    newRoom.South = int.Parse(splitter[3]);
                    newRoom.East = int.Parse(splitter[4]);
                    newRoom.West = int.Parse(splitter[5]);

                    myRooms.Add(newRoom);
                }

                return myRooms;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error from RoomFile.cs");
                throw new ApplicationException("Data Read Error from RoomFile.cs", ex);
            }
        }
    }
}
