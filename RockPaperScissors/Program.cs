using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome user kindly
            Console.WriteLine("Welcome to Rock-Paper-Scissors!\n");
           

            // The game is being commenced
            int playerScore = 0, computerScore = 0;

            // Infitine loop starts so we can continue this program forever
            while (true)
            {
                // Show the options of game 
                Console.WriteLine("1. Rock \n2. Paper \n3. Scissors \n4. Quit \nEnter your choice:");
                
                // Take the player's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                // If the player prefer to quit, break the loop
                if (choice == 4)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Your choice: {0}", GetChoiceName(choice)); //We are going to show what option user prefer and show it to user by doing interpolation.

                // Take the computer's choice
                int computerChoice = GetComputerChoice();
                Console.WriteLine("Computer's choice: {0}", GetChoiceName(computerChoice));

                // Calculate the result
                int result = (choice - computerChoice + 3) % 3;

                // If the result is 1, the player wins
                if (result == 1)
                {
                    playerScore++; // Add to score of player
                }
                // If the result is 2, the computer wins
                else if (result == 2)
                {
                    computerScore++; // Add to score of computer
                }

                // Display the result of the game
                Console.WriteLine("Result: {0}", result == 0 ? "Draw" : result == 1 ? "You won" : "Computer won"); //Instead of using lots of If loop I made an short-way to build it.
                Console.WriteLine("Score: You {0}, Computer {1}\n", playerScore, computerScore);
               
            }
        }

        static int GetComputerChoice()
        {
            // Create a random number for the computer
            Random random = new Random();
            return random.Next(1, 4);
        }

        static string GetChoiceName(int choice)
        {
            // Return the choice
            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                default:
                    return "Invalid";
            }
        }
    }
}
