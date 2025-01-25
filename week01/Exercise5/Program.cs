using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // Welcome to the program function
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcome();

        // User name function
        static string PromptUserName()
        {
            Console.WriteLine("What is your name?"); // Prompt the user to enter their NAME
            string name = Console.ReadLine(); //Store the user input in a variable
            return name; // Returns the users name
        }
        string greeting = PromptUserName();
        Console.WriteLine(greeting);

        // Favorite number function
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite integer number?"); // Prompt the user to enter their favorite INTEGER NUMBER
            string input = Console.ReadLine(); // Store the user input in a variable
            int fav_num;

            // Validate and convert input to an integer 
            while (!int.TryParse(input, out fav_num))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
                input = Console.ReadLine(); // Retry input
            }
            fav_num = int.Parse(input);

            return fav_num; // Returns the users number
        }
        // Print to the user their favorite integer
        int fav_num = PromptUserNumber();
        Console.WriteLine($"Your favorite number is {fav_num}.");

        // Squared number function
        static int SquareNumber(int number)
        {
            number = number * number;
            return number;
        }
        int number = fav_num;
        Console.WriteLine($"Your favorite number squared is {SquareNumber(number)}.");

        // Display results function
        static string DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is ")
        }
    }
}