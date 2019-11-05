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
            int id = 0;
            string name = null;
            string type = null;
            int damage = 0;

            try
            {
                List<Weapon> myWeapons = new List<Weapon>();

                List<string> lines = File.ReadAllLines("Weapons.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Weapon newWeapon = new Weapon(id, name, type, damage);

                    newWeapon.ID = int.Parse(splitter[0]);
                    newWeapon.Name = splitter[1];
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
