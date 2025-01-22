using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage?"); // Prompt the user to enter their grade
        string input = Console.ReadLine();

        int grade = int.Parse(input);
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
    }
}