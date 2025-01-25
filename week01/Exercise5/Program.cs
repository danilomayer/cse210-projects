using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcome();

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?"); // Prompt the user to enter their NAME
            string name = $"Hello {Console.ReadLine()}."; //Store the user input in a variable
            return name; // Returns the users name
        }
        string greeting = PromptUserName();
        Console.WriteLine(greeting);

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
        Console.WriteLine($"Your favorite number is {PromptUserNumber()}.");
    }
}