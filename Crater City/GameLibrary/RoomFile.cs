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
            string id;
            string description;
            int north;
            int south;
            int east;
            int west;

            try
            {
                List<Room> myRooms = new List<Room>();

                StreamReader inputFile;

                inputFile = File.OpenText("RoomsTest.csv");

                while (!inputFile.EndOfStream)
                {
                    //char[] delim = { ',' };
                    //string[] commaDemo = demo1.Split(delim);

                    string inputData = inputFile.ReadLine();
                    string[] splitter = inputData.Split(',');

                    id = Convert.ToString(splitter[0]);
                    description = Convert.ToString(splitter[1]);
                    north = Convert.ToInt32(splitter[2]);
                    south = Convert.ToInt32(splitter[3]);
                    east = Convert.ToInt32(splitter[4]);
                    west = Convert.ToInt32(splitter[5]);

                    Room myRoom = new Room(id, description, north, south, east, west);
                    myRooms.Add(myRoom);


                }

                inputFile.Close();

                return myRooms;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error from RoomFile.cs");
                return null;
            }
        }
    }
}
