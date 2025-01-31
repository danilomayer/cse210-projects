using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Please select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do? ");

        // Prompt to type a number and call each function
        Entry();
    }

    static void Entry()
    {
        // Display prompt 
        // Ask for entry
        // Store it with date in a list
        Console.WriteLine("");


        private List<string> prompts = new List<string>
        {
            "What was the most memorable part of your day?",
            "Did you face any challenges today? How did you handle them?",
            "What is something new you learned today?",
            "Describe a moment that made you smile today.",
            "If you could relive one part of today, what would it be and why?",
            "What is one thing you’re grateful for today?",
            "What goal or task do you want to accomplish tomorrow?"
        };
}
}