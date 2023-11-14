using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userWins = 0;
            int computerWins = 0;
            int totalRounds = 3;

            Console.WriteLine("Let's play Rock, Paper, Scissors!");

            for (int round = 1; round <= totalRounds; round++)
            {
                Console.WriteLine($"\nRound {round}:");

                // Get user's choice with input validation
                string userChoice;
                do
                {
                    Console.Write("Enter your move (Rock, Paper, or Scissors): ");
                    userChoice = Console.ReadLine()?.ToLower();
                    if (!IsValidChoice(userChoice))
                    {
                        Console.WriteLine("Please enter a valid response (Rock, Paper, or Scissors).");
                    }
                } while (!IsValidChoice(userChoice));

                // Generate computer's move randomly
                string[] choices = { "rock", "paper", "scissors" };
                Random random = new Random();
                int randomIndex = random.Next(choices.Length);
                string computerChoice = choices[randomIndex];

                Console.WriteLine($"Computer chooses {computerChoice}");

                // Determine the winner of the round
                string roundWinner = DetermineRoundWinner(userChoice, computerChoice);

                // Display round result
                if (roundWinner == "user")
                {
                    Console.WriteLine("You win this round!");
                    userWins++;
                }
                else if (roundWinner == "computer")
                {
                    Console.WriteLine("Computer wins this round!");
                    computerWins++;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Repeating the current round...");
                    continue; // Jump to the next iteration of the loop
                }
            }

            // Determine the overall winner
            Console.WriteLine("\nGame Over!");

            if (userWins > computerWins)
            {
                Console.WriteLine("Congratulations! You win the game!");

            }
            else if (computerWins > userWins)
            {
                Console.WriteLine("Sorry, the computer wins the game.");

            }
            else
            {
                Console.WriteLine("The game is a tie!");
            }
            Console.ReadLine();
        }

        static string DetermineRoundWinner(string userChoice, string computerChoice)
        {
            if ((userChoice == "rock" && computerChoice == "scissors") ||
                (userChoice == "paper" && computerChoice == "rock") ||
                (userChoice == "scissors" && computerChoice == "paper"))
            {
                return "user";
            }
            else if ((computerChoice == "rock" && userChoice == "scissors") ||
                     (computerChoice == "paper" && userChoice == "rock") ||
                     (computerChoice == "scissors" && userChoice == "paper"))
            {
                return "computer";
            }
            else
            {
                return "tie";
            }
        }

        static bool IsValidChoice(string choice)
        {
            return choice == "rock" || choice == "paper" || choice == "scissors";
        }
    }
}