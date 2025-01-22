using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage?"); // Prompt the user to enter their grade
        string input = Console.ReadLine();

        int grade = int.Parse(input); // Store the grade percentage from input
        string letter;
        // Conditions to determine the letter grade according to the grade percentage from input
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F"; ;
        }
        Console.WriteLine($"Letter grade: {letter}");

        // Conditions to determine if student has passed or not, min grade it 70
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You have passed!");
        }
        else
        {
            Console.WriteLine("You haven't passe. Don't give up, continue studying and you will make if next time!");
        }
    }
}