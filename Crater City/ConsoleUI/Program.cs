﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
/**
* 12/07/19
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
            Player myPlayer = new Player(0, null, 0, 0, 0, 0,  null, null, null);
            List<Player> myPlayers = new List<Player>();
            Mob currentMob = new Mob(0, null, 0, 0, 0, 0);
            Potion currentPotion = new Potion(0, null, 0, 0, 0, 0);
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
                    DisplayPlayerStats(myPlayer);

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    //// Display room names for testing (remove later)
                    //Console.WriteLine("Rooms:");
                    //foreach(Room room in GameAttributes.rooms)
                    //{
                    //    Console.WriteLine($"{room.Name}");
                    //}

                    //// Consume the next line for appearance
                    //Console.WriteLine("");

                    //// Display weapon names for testing (remove later)
                    //Console.WriteLine("Weapons:");
                    //foreach (Weapon weapon in GameAttributes.weapons)
                    //{
                    //    Console.WriteLine($"{weapon.Type} - {weapon.Name}");
                    //}

                    //// Consume the next line for appearance
                    //Console.WriteLine("");

                    // Get player movement
                    Console.WriteLine("Enter 'north', 'south', 'east', or 'west' to move between locations.");

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    GetPlayerMovement(myPlayer, currentMob, currentPotion);

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

        static void GetPlayerMovement(Player myPlayer, Mob currentMob, Potion currentPotion)
        {
            currentMob = Combat.GetCurrentMob(currentMob, Combat.CurrentMobs);
            currentPotion = Combat.GetPotion(currentPotion, GameAttributes.potions);
            bool exit = false;
            bool fight = false;

            do
            {
                // Display the player's current location
                Console.WriteLine($"Current Location: {Player.CurrentRoom.Name}");

                // Consume the next line for appearance
                Console.WriteLine("");

                // Prompt the player's movement
                Console.Write("Which direction do you want to move? ");
                string userInput = Console.ReadLine();
                PlayerMovement.GetMovement(userInput);
                //Console.ReadLine();

                int mobCoinToss = RandomNumber.NumberBetween(1, 2);
                int potionCoinToss = RandomNumber.NumberBetween(1, 2);
                switch (mobCoinToss)
                {
                    case 1:
                        fight = true;
                        // Prevent dead Mobs from being reused; remove when you find a better way
                        if (currentMob.HP <= 0)
                        {
                            currentMob = Combat.GetCurrentMob(currentMob, Combat.CurrentMobs);
                            fight = false;
                            Console.WriteLine("There are no enemies here.");
                            switch (potionCoinToss)
                            {
                                case 1:
                                    myPlayer = GetPlayerPotion(myPlayer, currentPotion);
                                    currentPotion = Combat.GetPotion(currentPotion, GameAttributes.potions);
                                    break;
                                case 2:
                                    Console.WriteLine("There are no potions here.");
                                    break;
                            }

                            // Toss the coin again to alternate chances of finding a potion
                            potionCoinToss = RandomNumber.NumberBetween(1, 2);
                        }
                        else
                        {
                            Console.WriteLine($"You must fight a {currentMob.Name}!");
                            Console.WriteLine($"{currentMob.Name}'s HP is {currentMob.HP}.");

                            do
                            {
                                int fightCoinToss = RandomNumber.NumberBetween(1, 2);
                                switch (fightCoinToss)
                                {
                                    case 1:
                                        Combat.PerformPlayerAttack(myPlayer, currentMob);
                                        break;
                                    case 2:
                                        Combat.PerformMobAttack(myPlayer, currentMob);
                                        break;
                                }

                                // Toss the coin again to alternate chances of attacking
                                fightCoinToss = RandomNumber.NumberBetween(1, 2);

                                if (myPlayer.HP <= 0)
                                {
                                    if (myPlayer.HP < 0)
                                    {
                                        myPlayer.HP = 0;
                                    }

                                    // Add color for dramatic effect
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("You are defeated. GAME OVER");
                                    fight = false;
                                    exit = true;

                                    // Return color to normal
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                if (currentMob.HP <= 0)
                                {
                                    if (currentMob.HP < 0)
                                    {
                                        currentMob.HP = 0;
                                    }

                                    // Add color for dramatic effect
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine($"{currentMob.Name} is defeated. YOU WIN!");
                                    myPlayer.XP += currentMob.XP;
                                    Console.WriteLine($"{myPlayer.Name}'s XP: {myPlayer.XP}");
                                    fight = false;
                                    currentMob = Combat.GetCurrentMob(currentMob, Combat.CurrentMobs);

                                    // Return color to normal
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (potionCoinToss)
                                    {
                                        case 1:
                                            myPlayer = GetPlayerPotion(myPlayer, currentPotion);
                                            currentPotion = Combat.GetPotion(currentPotion, GameAttributes.potions);
                                            break;
                                        case 2:
                                            Console.WriteLine("There are no potions here.");
                                            break;
                                    }

                                    // Toss the coin again to alternate chances of finding a potion
                                    potionCoinToss = RandomNumber.NumberBetween(1, 2);
                                }

                            } while (fight == true);
                        }
                        break;
                    case 2:
                        fight = false;
                        Console.WriteLine("There are no enemies here.");
                        switch (potionCoinToss)
                        {
                            case 1:
                                myPlayer = GetPlayerPotion(myPlayer, currentPotion);
                                currentPotion = Combat.GetPotion(currentPotion, GameAttributes.potions);
                                break;
                            case 2:
                                Console.WriteLine("There are no potions here.");
                                break;
                        }

                        // Toss the coin again to alternate chances of finding a potion
                        potionCoinToss = RandomNumber.NumberBetween(1, 2);
                        break;
                }

                // Toss the coin again to alternate chances of a fight
                mobCoinToss = RandomNumber.NumberBetween(1, 2);

            } while (exit == false);

            //Console.ReadLine();
        }

        static Player GetPlayerPotion(Player player, Potion potion)
        {
            Console.WriteLine($"You have found a {potion.Name} potion!");

            player.Damage += potion.Damage;
            player.AC += potion.AC;
            player.HP += potion.HP;
            player.XP += potion.XP;

            if (player.AC > 1000)
            {
                player.AC = 1000;
            }

            DisplayPlayerStats(player);

            return player;
        }

        static void DisplayPlayerStats(Player myPlayer)
        {
            // Display the player's current stats
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Player ID: {myPlayer.ID}");
            Console.WriteLine($"Player Name: {myPlayer.Name}");
            Console.WriteLine($"Player Type: {myPlayer.PlayerRace}");
            Console.WriteLine($"Player Class: {myPlayer.PlayerClass}");
            Console.WriteLine($"Player Damage: {myPlayer.Damage}");
            Console.WriteLine($"Player AC: {myPlayer.AC}");
            Console.WriteLine($"Player HP: {myPlayer.HP}");
            Console.WriteLine($"Player XP: {myPlayer.XP}");
            Console.WriteLine($"Player Weapon: {Player.CurrentWeapon.Name}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
