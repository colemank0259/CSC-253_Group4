using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GameLibrary;

namespace ConsoleUI
{
    public class MobWriteFile
    {
        public static void CreateFile(MobClass myMob)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("Mob.txt");

                outputFile.WriteLine(myMob.MobClass);

                outputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not created!");
            }
        }
    }
}
 