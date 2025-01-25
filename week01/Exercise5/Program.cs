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
            Console.WriteLine("")
        }
        PromptUserNumber()
    }
}