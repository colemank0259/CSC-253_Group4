using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class MobFile
    {
        public static List<Mob> GetMobs()
        {
            // Local variables
            string id = null;
            string description = null;
            int strength = 0;
            int speed = 0;
            int hp = 0;

            try
            {
                List<Mob> myMobs = new List<Mob>();

                List<string> lines = File.ReadAllLines("Mobs.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Mob newMob = new Mob(id, description, strength, speed, hp);

                    newMob.ID = splitter[0];
                    newMob.Description = splitter[1];
                    newMob.Strength = int.Parse(splitter[2]);
                    newMob.Speed = int.Parse(splitter[3]);
                    newMob.HP = int.Parse(splitter[4]);

                    // TODO copy Mobs and add position and movement; may need addtional class

                    myMobs.Add(newMob);
                }

                return myMobs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error from MobFile.cs");
                throw new ApplicationException("Data Read Error from MobFile.cs", ex);
            }
        }
    }
}
