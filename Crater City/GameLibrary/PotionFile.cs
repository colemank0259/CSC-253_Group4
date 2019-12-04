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
            int id = 0;
            string name = null;
            int damage = 0;
            int ac = 0;
            int hp = 0;
            int xp = 0;

            try
            {
                List<Potion> myPotions = new List<Potion>();

                List<string> lines = File.ReadAllLines("Potions.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Potion newPotion = new Potion(id, name, damage, ac, hp, xp);

                    newPotion.ID = int.Parse(splitter[0]);
                    newPotion.Name = splitter[1];
                    newPotion.Damage = int.Parse(splitter[2]);
                    newPotion.AC = int.Parse(splitter[3]);
                    newPotion.HP = int.Parse(splitter[4]);
                    newPotion.XP = int.Parse(splitter[5]);

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
