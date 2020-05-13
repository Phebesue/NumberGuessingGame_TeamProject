﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    public class NumberGuessing
    {
        int playerGamesWon = 0;
        int computerGamesWon = 0;

        public void Game()

        {

            Console.WriteLine("\nPlayer games won: " + playerGamesWon);
            Console.WriteLine("Computer games won: " + computerGamesWon + "\n");
            Console.WriteLine("Welcome! You have 5 chances to guess the designated number. \nThe number is between 5 - 30.");

            Random random = new Random();
            int number = random.Next(5, 30);
            Console.WriteLine("This is the generated number: " + number);


            int availableGuesses = 5;

            bool IsEqual = false;
            while (!IsEqual)
            {
                if (availableGuesses > 0)
                {
                    int numberGuess = Convert.ToInt32(Console.ReadLine());
                    if (numberGuess <= 30 && numberGuess >= 5)
                    {
                        if (numberGuess > number)
                        {
                            Console.WriteLine("Too High");
                            availableGuesses--;
                            if (numberGuess >= number + 8)
                            {
                                Console.WriteLine("Way too high..");
                            }
                            else if (numberGuess <= number + 5 && numberGuess > number + 2)
                            {
                                Console.WriteLine("Getting close..");
                            }
                            else if (numberGuess < number + 2)
                            {
                                Console.WriteLine("You're so close!");
                            }
                            Console.WriteLine("Available guesses left: " + availableGuesses);
                        }
                        else if (numberGuess < number)
                        {
                            Console.WriteLine("Too Low");
                            availableGuesses--;
                            if (numberGuess <= number - 8)
                            {
                                Console.WriteLine("Way too low..");

                            }
                            else if (numberGuess >= number - 5 && numberGuess < number - 2)
                            {
                                Console.WriteLine("Getting close..");
                            }
                            else if(numberGuess> number - 2)
                            {
                                Console.WriteLine("You're so close!");
                            }
                            Console.WriteLine("Available guesses left: " + availableGuesses);

                        }
                        else
                        {
                            Console.WriteLine("\nYou guessed correctly!!");
                            Console.WriteLine("\nThank you for playing!");
                            playerGamesWon++;
                            DoOver();
                            IsEqual = true;
                        }
                    }

                    else
                    {
                        Console.WriteLine("You're REALLY bad at this.");
                        availableGuesses--;
                        Console.WriteLine("Available guesses left: " + availableGuesses);
                    }
                }



                else
                {
                    Console.WriteLine("\nYou are out of guesses! \nGAME OVER!!");
                    computerGamesWon++;
                    DoOver();
                    IsEqual = true;
                }

            }

        }


        public void DoOver()
        {

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Would you like to play again? \n 1. Y \n 2. N");
                string playAgain = Console.ReadLine();

                switch (playAgain)
                {
                    case "1":
                    case "Y":
                    case "y":
                    case "yes":
                    case "Yes":
                        Console.Clear();
                        Game();
                        continueToRun = false;
                        break;
                    case "2":
                    case "N":
                    case "n":
                    case "no":
                    case "No":
                        Console.WriteLine("Goodbye!");
                        Thread.Sleep(2500);
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}








