using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
/**
* 09/15/19
* CSC 253
* Group 4
* This program is a dungeon crawl game.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player(0, null, 0, 0, 0, null, null, null, 0, 0);
            List<Player> myPlayers = new List<Player>();
            Mob currentMob = new Mob(0, null, 0, 0, 0);
            bool exit = false;


            do
            {
                // Ask user to either run the program or exit
                StandardMessages.DisplayOpeningMenu();

                // Declare varible to hold user input
                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Local variables

                    // Display description of the program
                    StandardMessages.DisplayProgramDescription();

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Get player profile
                    myPlayer = PlayerFile.GetPlayer(myPlayer, myPlayers);

                    // Get player's weapon
                    Player.CurrentWeapon = Player.GetCurrentWeapon(myPlayer);

                    // Get player's default damage
                    myPlayer.Damage = Player.GetPlayerDamage(myPlayer);

                    // Get player's default AC
                    myPlayer.AC = Player.GetPlayerAC(myPlayer);

                    // Get player's default HP
                    myPlayer.HP = Player.GetPlayerHP(myPlayer);


                    // Display player information
                    Console.WriteLine($"Player ID: {myPlayer.ID}");
                    Console.WriteLine($"Player Name: {myPlayer.Name}");
                    Console.WriteLine($"Player Type: {myPlayer.PlayerRace}");
                    Console.WriteLine($"Player Class: {myPlayer.PlayerClass}");
                    Console.WriteLine($"Player Damage: {myPlayer.Damage}");
                    Console.WriteLine($"Player AC: {myPlayer.AC}");
                    Console.WriteLine($"Player HP: {myPlayer.HP}");
                    Console.WriteLine($"Player Weapon: {Player.CurrentWeapon.Name}");

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Display room names for testing (remove later)
                    Console.WriteLine("Rooms:");
                    foreach(Room room in GameAttributes.rooms)
                    {
                        Console.WriteLine($"{room.Name}");
                    }

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Display weapon names for testing (remove later)
                    Console.WriteLine("Weapons:");
                    foreach (Weapon weapon in GameAttributes.weapons)
                    {
                        Console.WriteLine($"{weapon.Type} - {weapon.Name}");
                    }

                    // Consume the next line for appearance
                    Console.WriteLine("");



                    // Get player movement
                    Console.WriteLine("Enter 'north', 'south', 'east', or 'west' to move between locations.");
                    GetPlayerMovement(myPlayer, currentMob);

                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    StandardMessages.DisplayOpeningMenuError();
                }

            } while (exit == false);
        }

        static void GetPlayerMovement(Player myPlayer, Mob currentMob)
        {
            currentMob = Combat.GetCurrentMob(currentMob, Combat.CurrentMobs);
            bool exit = false;

            do
            {
                Console.WriteLine(Player.CurrentRoom.Name);
                Console.Write("Which direction do you want to move? ");
                string userInput = Console.ReadLine();
                PlayerMovement.GetMovement(userInput);
                Console.ReadLine();

                if (Player.CurrentRoom == Mob.CurrentRoom)
                {
                    bool fight = true;

                    // Prevent dead Mobs from being reused; remove when you find a better way
                    while(currentMob.HP <= 0)
                    {
                        currentMob = Combat.GetCurrentMob(currentMob, Combat.CurrentMobs);
                    }

                    Console.WriteLine($"You must fight a {currentMob.Name}!");
                    Console.WriteLine($"{currentMob.Name}'s HP is {currentMob.HP}.");

                    do
                    {
                        int coinToss = RandomNumber.NumberBetween(1, 2);
                        switch (coinToss)
                        {
                            case 1:
                                Combat.PerformPlayerAttack(myPlayer, currentMob);
                                break;
                            case 2:
                                Combat.PerformMobAttack(myPlayer, currentMob);
                                break;
                        }

                        // Toss the coin again to alternate chances of attacking
                        coinToss = RandomNumber.NumberBetween(1, 2);

                        if (myPlayer.HP <= 0)
                        {
                            Console.WriteLine("You are defeated. GAME OVER");
                            fight = false;
                            exit = true;
                        }

                        if (currentMob.HP <= 0)
                        {
                            Console.WriteLine($"{currentMob.Name} is defeated.");
                            fight = false;
                            currentMob = Combat.GetCurrentMob(currentMob, Combat.CurrentMobs);
                        }

                    } while (fight == true);

                }

            } while (exit == false);

            Console.ReadLine();
        }
    }
}
