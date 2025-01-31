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

    public void AddEntry()
    {
        Random rand = new Random(); // Creates a new random object
        string prompt = prompts[rand.Next(prompts.Count)]; // Picks a random prompt
        Console.WriteLine(prompt); // Displays the prompt
        string response = Console.ReadLine(); // Gets user input
        Entries.Add(new Entry(prompt, response)); // Stores the entry
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }

        Entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                string date = parts[0].Trim();
                string prompt = parts[1].Trim();
                string response = parts[2].Trim();

                Entries.Add(new Entry(prompt, response) { Date = date });
            }
            else
            {
                Console.WriteLine($"Skipping invalid line: {line}");
            }
        }

        Console.WriteLine("Journal successfully loaded.");
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