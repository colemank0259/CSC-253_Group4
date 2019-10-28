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
        public static Player GetPlayer(Player myPlayer)
        {
            // Local variables
            string inputString;

            StandardMessages.PromptPlayerSignIn();
            inputString = Console.ReadLine();
            switch (inputString)
            {
                case "1":
                    CreatePlayerFile(myPlayer);
                    break;
                case "2":
                    GetReturningPlayer();
                default:
                    // TODO Write error message for GetPlayer method

            }
        }
        public static Player CreatePlayerFile(Player myPlayer)
        {
            // Local variables
            Random rand = new Random();
            try
            {
                StreamWriter outputFile;

                outputFile = File.AppendText("PlayerFile.txt");
                myPlayer.PlayerID = rand.Next(1, 100);
                outputFile.WriteLine(myPlayer.PlayerID);
                StandardMessages.PromptPlayerName();
                myPlayer.PlayerName = Console.ReadLine();
                outputFile.WriteLine(myPlayer.PlayerName);
                StandardMessages.PromptPlayerPassword();
                myPlayer.PlayerPassword = Console.ReadLine();
                outputFile.WriteLine(myPlayer.PlayerPassword);
                StandardMessages.PromptPlayerClass();
                myPlayer.PlayerClass = Console.ReadLine();
                outputFile.WriteLine(myPlayer.PlayerClass);
                StandardMessages.PromptPlayerRace();
                myPlayer.PlayerRace = Console.ReadLine();
                outputFile.WriteLine(myPlayer.PlayerRace);

                outputFile.Close();

                return myPlayer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not created!");
                return null;
            }
        }

        public static List<Player> ReadPlayerFile(Player myPlayer)
        {
            // TODO Finish StreamReader

            // Local variables
            int playerID = 0;
            string playerName = null;
            string playerPassword = null;
            string playerClass = null;
            string playerRace = null;

            try
            {
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

                inputFile.Close();

                return myPlayers;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error");
                return null;
            }

            //List<Player> myPlayers = new List<Player>();

            //StreamReader inputFile;

            //inputFile = File.OpenText("PlayerFile.txt");

            //while (!inputFile.EndOfStream)
            //{
            //    playerID = int.Parse(inputFile.ReadLine());
            //    playerName = inputFile.ReadLine();
            //    playerPassword = inputFile.ReadLine();
            //    playerClass = inputFile.ReadLine();
            //    playerRace = inputFile.ReadLine();
            //    myPlayer = new Player(playerID, playerName, playerPassword, playerClass, playerRace);
            //    myPlayers.Add(myPlayer);
            //}

            //foreach (Player player in myPlayers)
            //{
            //    Console.WriteLine($"");
            //}

        }

        public static Player GetReturningPlayer(Player myPlayer, List<Player> myPlayers)
        {
            // Local variables
            int playerCount = 0;

            foreach (Player player in myPlayers)
            {
                Console.WriteLine($"Player ID: {myPlayer.PlayerID}");
                Console.WriteLine($"Player Name: {myPlayer.PlayerName}");
                playerCount++;
            }

            // TODO finish GetReturningPlayer method

            return myPlayer;
        }

    }
}
