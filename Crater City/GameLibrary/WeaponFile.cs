using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class WeaponFile
    {
        public static List<Weapon> GetWeapons()
        {
            // Local variables
            string id = null;
            string description = null;
            string type = null;
            int damage = 0;

            try
            {
                List<Weapon> myWeapons = new List<Weapon>();

                List<string> lines = File.ReadAllLines("Weapons.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Weapon newWeapon = new Weapon(id, description, type, damage);

                    newWeapon.ID = splitter[0];
                    newWeapon.Description = splitter[1];
                    newWeapon.Type = splitter[2];
                    newWeapon.Damage = int.Parse(splitter[3]);

                    myWeapons.Add(newWeapon);
                }

                return myWeapons;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error from WeaponFile.cs");
                throw new ApplicationException("Data Read Error from WeaponFile.cs", ex);
            }
        }
    }
}
