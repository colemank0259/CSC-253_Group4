using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class RoomFile : IRoom
    {
        public static List<Room> GetRooms()
        {
            // TODO finish StreamReader for Rooms.csv

            try
            {
                List<Room> myRooms = new List<Room>();

                StreamReader inputFile;

                inputFile = File.OpenText("Rooms.csv");

                while (!inputFile.EndOfStream)
                {
                    char[] delim = { ',' };
                    //string[] commaDemo = demo1.Split(delim);

                    Room myRoom = new Room();
                    myRooms.Add(myRoom);
                }

                inputFile.Close();

                return myRooms;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error");
                return null;
            }
        }
    }
}
