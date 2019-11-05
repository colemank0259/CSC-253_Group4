using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class TreasureFile
    {
        public static List<Treasure> GetTreasures()
        {
            // Local variables
            int id = 0;
            string description = null;

            try
            {
                List<Treasure> myTreasures = new List<Treasure>();

                List<string> lines = File.ReadAllLines("Treasures.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Treasure newTreasure = new Treasure(id, description);

                    newTreasure.ID = int.Parse(splitter[0]);
                    newTreasure.Name = splitter[1];

                    // TODO add a currency to the game (i.e. gold, credits, dollars, etc.). Players could use the currency to buy better weapons or armor.

                    myTreasures.Add(newTreasure);
                }

                return myTreasures;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error from TreasureFile.cs");
                throw new ApplicationException("Data Read Error from TreasureFile.cs", ex);
            }
        }
    }
}
