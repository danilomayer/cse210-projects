using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true; // Condition to keep the game running

        while (playAgain) // This loop will make sure the game keeps running as look as the user desires
        {
            Console.WriteLine("Hello World! This is the Exercise3 Project.");

            // Generate a random number between 1 and 100
            Random random = new Random();
            int magic_num = random.Next(1, 101); // 1 to 100 inclusive

            Console.WriteLine("A magic number between 1 and 100 has been chosen. Can you guess it?");

            int attempts = 0; // Store the amount of attempts made

            bool guessed = false;
            while (!guessed) // Look to make sure the user keeps trying until they guess the right number
            {

                Console.WriteLine("Guess the magic number.");
                string input = Console.ReadLine();

                // Validate the guess input
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                attempts++; // Add the number of attempts to variable

                // Conditions to make sure the guess matches the magic number
                if (guess > magic_num)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic_num)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You've guessed it! You made {attempts} attempts.");
                    guessed = true;
                }

            }

            // Give player option to play again or to quit the game
            Console.WriteLine("Would you like to play again? Type 'yes' to restart or 'no' to exit.");
            string response = Console.ReadLine()?.Trim().ToLower();

            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thankyou for playing! Goodbye!");
            }
        }
    }
}