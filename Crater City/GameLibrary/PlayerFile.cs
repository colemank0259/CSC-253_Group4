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
        public static Player GetPlayer(Player newPlayer, List<Player> myPlayers)
        {
            // Local variables
            string inputString;
            Player myPlayer = new Player(0, null, 0, 0, 0, 0, null, null, null);

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
            int playerCount = -1;

            try
            {

                List<Player> myPlayers = new List<Player>();

                List<string> lines = File.ReadAllLines("Players.csv").ToList();
                
                foreach(var line in lines)
                {
                    playerCount++;
                }

                myPlayer.ID = playerCount + 1;
                
                myPlayer.Name = StandardMessages.PromptPlayerName();
                
                myPlayer.PlayerPassword = StandardMessages.PromptPlayerPassword();
                // TODO validate password

                do
                {
                    myPlayer.PlayerRace = GetNewPlayerRace(StandardMessages.PromptPlayerRace());
                } while (myPlayer.PlayerRace == null);
                

                do
                {
                    myPlayer.PlayerClass = GetNewPlayerClass(StandardMessages.PromptPlayerClass());
                } while (myPlayer.PlayerClass == null);


                lines.Add($"{myPlayer.ID},{myPlayer.Name},{myPlayer.PlayerPassword},{myPlayer.PlayerClass},{myPlayer.PlayerRace}");

                File.WriteAllLines("Players.csv", lines);

                return myPlayer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Write Error from PlayerFile.cs", ex);
                return null;
            }
        }

        public static string GetNewPlayerRace(string input)
        {
            string playerClass;
            bool exit = false;

            do
            {
                switch (input)
                {
                    case "1":
                        playerClass = PlayerRace.Techie.ToString();
                        exit = true;
                        return playerClass;
                    case "2":
                        playerClass = PlayerRace.Metahuman.ToString();
                        exit = true;
                        return playerClass;
                    case "3":
                        playerClass = PlayerRace.Magic.ToString();
                        exit = true;
                        return playerClass;
                    default:
                        Console.WriteLine("ERROR: You must select one of the listed player races.");
                        exit = false;
                        return null;
                }
            } while (exit == false);

            
        }

        public static string GetNewPlayerClass(string input)
        {
            string playerClass;
            bool exit = false;

            do
            {
                switch (input)
                {
                    case "1":
                        playerClass = PlayerClass.Gadgeteer.ToString();
                        exit = true;
                        return playerClass;
                    case "2":
                        playerClass = PlayerClass.Speedster.ToString();
                        exit = true;
                        return playerClass;
                    case "3":
                        playerClass = PlayerClass.Assassin.ToString();
                        exit = true;
                        return playerClass;
                    case "4":
                        playerClass = PlayerClass.Wizard.ToString();
                        exit = true;
                        return playerClass;
                    case "5":
                        playerClass = PlayerClass.Ninja.ToString();
                        exit = true;
                        return playerClass;
                    case "6":
                        playerClass = PlayerClass.Tank.ToString();
                        exit = true;
                        return playerClass;
                    case "7":
                        playerClass = PlayerClass.Banshee.ToString();
                        exit = true;
                        return playerClass;
                    case "8":
                        playerClass = PlayerClass.Samurai.ToString();
                        exit = true;
                        return playerClass;
                    default:
                        Console.WriteLine("ERROR: You must select one of the listed player job classes.");
                        exit = false;
                        return null;
                }
            } while (exit == false);

            
        }

        public static List<Player> GetPlayers(Player newPlayer)
        {
            try
            {
                List<Player> myPlayers = new List<Player>();

                StreamReader reader = File.OpenText("Players.csv");
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] splitter = line.Split(',');

                    int id = int.Parse(splitter[0]);
                    string name = splitter[1];
                    string password = splitter[2];
                    string playerClass = splitter[3];
                    string race = splitter[4];

                    myPlayers.Add(new Player(id, name, 0, 0, 0, 0, password, playerClass, race));
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
            string inputString = null;
            int playerCount = 0;
            int playerChoice = 0;
            myPlayers = GetPlayers(myPlayer);
            bool playerVerified = false;
            

            do
            {
                foreach (Player player in myPlayers)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{player.ID}. {player.Name} - {player.PlayerRace} {player.PlayerClass}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    playerCount++;
                }

                do
                {
                    Console.Write("Enter a number to choose a character profile: ");
                    playerChoice = int.Parse(Console.ReadLine());
                } while (playerChoice > playerCount || playerChoice <= 0);

                myPlayer.ID = myPlayers[playerChoice - 1].ID;
                myPlayer.Name = myPlayers[playerChoice - 1].Name;
                myPlayer.PlayerPassword = myPlayers[playerChoice - 1].PlayerPassword;
                myPlayer.PlayerClass = myPlayers[playerChoice - 1].PlayerClass;
                myPlayer.PlayerRace = myPlayers[playerChoice - 1].PlayerRace;

                int passwordAttempts = 0;

                while (inputString != myPlayer.PlayerPassword && passwordAttempts < 3)
                {
                    inputString = StandardMessages.PromptPlayerPassword();

                    if (inputString == myPlayer.PlayerPassword)
                    {
                        playerVerified = true;
                    }
                    else
                    {
                        passwordAttempts++;
                    }
                }

            } while (playerVerified == false);

            return myPlayer;
        }

    }
}
