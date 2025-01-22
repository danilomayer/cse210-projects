using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.WriteLine("What is your first name?"); // Prompt the user to enter FIRST NAME
        string fname = Console.ReadLine(); // Store the user input FIRST NAME in a variable

        Console.WriteLine("What is your last name?"); // Prompt the user to enter LAST NAME
        string lname = Console.ReadLine(); //Store the user input LAST NAME in a variable

        Console.WriteLine($"My name is {lname}, {fname} {lname}."); // Output a string that concatenates the First and Last names in a James Bond sentence.
    }
}