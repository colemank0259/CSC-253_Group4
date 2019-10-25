using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class PlayerFile
    {
        public static void CreatePlayerFile(Player myPlayer)
        {
            try
            {
                StreamWriter outputFile;

                outputFile = File.AppendText("UserClasses.txt");

                outputFile.WriteLine(myPlayer.PlayerID);
                outputFile.WriteLine(myPlayer.PlayerName);
                outputFile.WriteLine(myPlayer.PlayerPassword);
                outputFile.WriteLine(myPlayer.PlayerClass);
                outputFile.WriteLine(myPlayer.PlayerRace);

                outputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not created!");
            }
        }

        public static void ReadPlayerFile(Player myPlayer)
        {
            // TODO Finish StreamReader

            // Local variables
            int playerID = 0;
            string playerName = null;
            string playerPassword = null;
            string playerClass = null;
            string playerRace = null;

            List<Player> myPlayers = new List<Player>();

            StreamReader inputFile;

            inputFile = File.OpenText("PlayerFile.txt");

            while (!inputFile.EndOfStream)
            {
                playerID = int.Parse(inputFile.ReadLine());
                playerName = inputFile.ReadLine();
                playerPassword = inputFile.ReadLine();
                playerClass = inputFile.ReadLine();
                playerRace = inputFile.ReadLine();
                myPlayer = new Player(playerID, playerName, playerPassword, playerClass, playerRace);
                myPlayers.Add(myPlayer);
            }

            foreach (Player player in myPlayers)
            {
                Console.WriteLine($"");
            }

        }
           
    }
}
