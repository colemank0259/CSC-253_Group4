using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class PotionFile
    {
        public static List<Potion> GetPotions()
        {
            // Local variables
            string id = null;
            string description = null;

            try
            {
                List<Potion> myPotions = new List<Potion>();

                List<string> lines = File.ReadAllLines("Potions.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Potion newPotion = new Potion(id, description);

                    newPotion.ID = splitter[0];
                    newPotion.Description = splitter[1];

                    // TODO add more details to potions (i.e. HP gained, damage buff gained, duration of damage buff, etc.). Add to both the file and the class.

                    myPotions.Add(newPotion);
                }

                return myPotions;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error from PotionFile.cs");
                throw new ApplicationException("Data Read Error from PotionFile.cs", ex);
            }
        }
    }
}
