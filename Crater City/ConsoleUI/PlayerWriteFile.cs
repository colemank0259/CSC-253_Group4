using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PlayerWriteFile
    {
        public static void CreateFile(PlayerClass myPlayer)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("Player.txt");

                outputFile.WriteLine(myPlayer.Player);

                outputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not created!");
            }
        }
    }
}
