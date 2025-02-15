using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment object
        Assignment assignment1 = new Assignment("John", "Math");
        Console.WriteLine(assignment1.GetSummary());

        // MathAssignment object
        MathAssignment mathAssignment1 = new MathAssignment("John", "Math", "Chapter 1", "1-10");
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        // WritingAssignment object
        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}