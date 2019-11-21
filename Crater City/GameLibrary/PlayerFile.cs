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
        public static CurrentPlayer GetPlayer(Player newPlayer, List<Player> myPlayers)
        {
            // Local variables
            string inputString;
            CurrentPlayer myPlayer = new CurrentPlayer(0, null, null, null, null, 0, 0);

            StandardMessages.PromptPlayerSignIn();
            inputString = Console.ReadLine();
            switch (inputString)
            {
                case "1":
                    newPlayer = CreatePlayerFile(newPlayer);
                    myPlayer.ID = newPlayer.ID;
                    myPlayer.Name = newPlayer.Name;
                    myPlayer.PlayerPassword = newPlayer.PlayerPassword;
                    myPlayer.PlayerClass = newPlayer.PlayerClass;
                    myPlayer.PlayerRace = newPlayer.PlayerRace;
                    return myPlayer;
                case "2":
                    GetReturningPlayer(newPlayer, myPlayers);
                    myPlayer.ID = newPlayer.ID;
                    myPlayer.Name = newPlayer.Name;
                    myPlayer.PlayerPassword = newPlayer.PlayerPassword;
                    myPlayer.PlayerClass = newPlayer.PlayerClass;
                    myPlayer.PlayerRace = newPlayer.PlayerRace;
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

                myPlayer.ID = playerCount + 1;
                StandardMessages.PromptPlayerName();
                myPlayer.Name = Console.ReadLine();
                StandardMessages.PromptPlayerPassword();
                myPlayer.PlayerPassword = Console.ReadLine();
                // TODO validate password
                StandardMessages.PromptPlayerRace();
                myPlayer.PlayerRace = Console.ReadLine();
                // TODO validate race with  enumerators
                StandardMessages.PromptPlayerClass();
                myPlayer.PlayerClass = GetNewPlayerClass(Console.ReadLine());
                // TODO validate class with  enumerators
                

                lines.Add($"{myPlayer.ID},{myPlayer.Name},{myPlayer.PlayerPassword},{myPlayer.PlayerClass},{myPlayer.PlayerRace}");

                return myPlayer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Write Error from PlayerFile.cs", ex);
                return null;
            }
        }

        public static string GetNewPlayerClass(string input)
        {
            string playerClass;

            switch (input)
            {
                case "1":
                    playerClass = PlayerClass.Gadgeteer.ToString();
                    return playerClass;
                case "2":
                    playerClass = PlayerClass.Speedster.ToString();
                    return playerClass;
                case "3":
                    playerClass = PlayerClass.Assassin.ToString();
                    return playerClass;
                case "4":
                    playerClass = PlayerClass.Wizard.ToString();
                    return playerClass;
                case "5":
                    playerClass = PlayerClass.Ninja.ToString();
                    return playerClass;
                case "6":
                    playerClass = PlayerClass.Tank.ToString();
                    return playerClass;
                case "7":
                    playerClass = PlayerClass.Banshee.ToString();
                    return playerClass;
                case "8":
                    playerClass = PlayerClass.Samurai.ToString();
                    return playerClass;
                default:
                    Console.WriteLine("ERROR: You must enter 1 or 2 to select an option.");
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

                    newPlayer.ID = int.Parse(splitter[0]);
                    newPlayer.Name = splitter[1];
                    newPlayer.PlayerPassword = splitter[2];
                    newPlayer.PlayerRace = splitter[3];
                    newPlayer.PlayerClass = splitter[4];
                    

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
            string inputString;

            myPlayers = GetPlayers(myPlayer);

            // Prompt user to enter an existing Player Name
            StandardMessages.PromptReturningPlayerSignIn();
            inputString = Console.ReadLine();

            foreach (Player player in myPlayers)
            {
                if (inputString.ToLower() == player.Name.ToLower())
                {
                    StandardMessages.PromptPlayerPassword();
                    if (inputString == player.PlayerPassword)
                    {
                        myPlayer = player;
                    }
                }
            }

            // TODO finish GetReturningPlayer method

            return myPlayer;
        }

    }
}
