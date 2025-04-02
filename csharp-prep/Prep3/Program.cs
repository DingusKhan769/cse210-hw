using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random magic number between 1 and 100
            int magicNumber = random.Next(1, 101);
            int guess = -1; // Initialize guess to a value that is not the magic number
            int guessCount = 0; // Initialize guess count

            // Loop until the guess matches the magic number
            while (guess != magicNumber)
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Determine if the guess is higher, lower, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }
    }
}