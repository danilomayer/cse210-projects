using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Entry
{
    public string Date { get; set; } = DateTime.Now.ToString("dd-MM-yyyy"); // Initialize with current date and time
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"[{Date}] {Prompt}\nResponse: {Response}\n";
    }
}

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

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

    public void AddEntry()
    {
        Random rand = new Random(); // Creates a new random object
        string prompt = prompts[rand.Next(prompts.Count)]; // Picks a random prompt
        Console.WriteLine(prompt); // Displays the prompt
        string response = Console.ReadLine(); // Gets user input
        Entries.Add(new Entry(prompt, response)); // Stores the entry
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.Write("No entries to display.");
        }
        else
        {
            foreach (var entry in Entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
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
}

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
        switch (choice)
        {
            case "1":
            // Generate prompt, allow user to write and store entry
            case "2":
                if (journal.Entries.Count == 0)
                {
                    Console.WriteLine("No entries to display.");
                }
                else
                {
                    journal.DisplayEntries();
                }
                break;

            case "4":
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("Journal loaded successfully.");
                break;
        }
        // Prompt to type a number and call each function
        Entry();
    }

}

public void SaveToFile(string filename)
{
    using (StreamWriter writer = new StreamWriter(filename))
    {
        foreach (var entry in Entries)
        {
            writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
        }
    }
    Console.WriteLine("Journal saved successfully.");
}




static void Entry()
{
    // Display prompt 
    // Ask for entry
    // Store it with date in a list

}