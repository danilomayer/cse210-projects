using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage?"); // Prompt the user to enter their grade
        string input = Console.ReadLine();

        int grade = int.Parse(input); // Store the grade percentage from input

        // Conditions to determine the letter grade according to the grade percentage from input
        if (grade >= 90)
        {
            Console.WriteLine("Letter grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Letter grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Letter grade: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Letter grade: D");
        }
        else
        {
            Console.WriteLine("Letter grade: F");
        }

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