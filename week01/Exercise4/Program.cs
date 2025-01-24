using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of number, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number;

        // Loop to collect numbers until the user enters 0
        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Validate input
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            // Add the number to the list if it's not 0
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Compute the sum of the numbers in the list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        // Compute the average of the numbers in the list.
        int avg = sum / numbers.Count;


        // Print the numbers in the list
        Console.WriteLine("\nYou entered the following numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Print the total sum and the average of the numbers
        Console.WriteLine($"\nThe total sum of the numbers is: {sum}.");
        Console.WriteLine($"\nThe average of the numbers is: {avg}.");
    }
}