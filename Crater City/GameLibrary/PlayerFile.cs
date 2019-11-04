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
        public static Player GetPlayer(Player myPlayer, List<Player> myPlayers)
        {
            // TODO Move GetPlayer() to CurrentPlayer.cs

            // Local variables
            string inputString;

            StandardMessages.PromptPlayerSignIn();
            inputString = Console.ReadLine();
            switch (inputString)
            {
                case "1":
                    myPlayer = CreatePlayerFile(myPlayer);
                    return myPlayer;
                case "2":
                    GetReturningPlayer(myPlayer, myPlayers);
                    return myPlayer;
                default:
                    Console.WriteLine("ERROR: You must enter 1 or 2 to select an option.");
                    return null;
            }
        }
        public static Player CreatePlayerFile(Player myPlayer)
        {
            // Local variables
            int playerCount = 0;

            try
            {

                List<Player> myPlayers = new List<Player>();

                List<string> lines = File.ReadAllLines("Players.csv").ToList();
                
                foreach(var line in lines)
                {
                    playerCount++;
                }

                myPlayer.PlayerID = playerCount + 1;
                StandardMessages.PromptPlayerName();
                myPlayer.PlayerName = Console.ReadLine();
                StandardMessages.PromptPlayerPassword();
                myPlayer.PlayerPassword = Console.ReadLine();
                // TODO validate password
                StandardMessages.PromptPlayerClass();
                myPlayer.PlayerClass = Console.ReadLine();
                // TODO validate class with  enumerators
                StandardMessages.PromptPlayerRace();
                myPlayer.PlayerRace = Console.ReadLine();
                // TODO validate race with  enumerators

                lines.Add($"{myPlayer.PlayerID},{myPlayer.PlayerName},{myPlayer.PlayerPassword},{myPlayer.PlayerClass},{myPlayer.PlayerRace}");

                return myPlayer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Write Error from PlayerFile.cs", ex);
                return null;
            }
        }

        public static List<Player> GetPlayers(Player newPlayer)
        {
            try
            {
                List<Player> myPlayers = new List<Player>();

                List<string> lines = File.ReadAllLines("Players.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    newPlayer.PlayerID = int.Parse(splitter[0]);
                    newPlayer.PlayerName = splitter[1];
                    newPlayer.PlayerPassword = splitter[2];
                    newPlayer.PlayerClass = splitter[3];
                    newPlayer.PlayerRace = splitter[4];

                    myPlayers.Add(newPlayer);
                }

                return myPlayers;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error from PlayerFile.cs");
                throw new ApplicationException("Data Read Error from PlayerFile.cs", ex);
            }
        }

        public static Player GetReturningPlayer(Player myPlayer, List<Player> myPlayers)
        {
            // Local variables
            int playerCount = 0;
            myPlayers = GetPlayers(myPlayer);

            foreach (Player player in myPlayers)
            {
                Console.WriteLine($"Player ID: {myPlayer.PlayerID}");
                Console.WriteLine($"Player Name: {myPlayer.PlayerName}");
                Console.WriteLine("");
                playerCount++;
            }

            // TODO finish GetReturningPlayer method

            return myPlayer;
        }

    }
}
