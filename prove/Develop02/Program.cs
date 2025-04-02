using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file (CSV or JSON)");
            Console.WriteLine("4. Load the journal from a file (CSV or JSON)");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Random random = new Random();
                    string prompt = prompts[random.Next(prompts.Count)];
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Current weather: ");
                    string weather = Console.ReadLine();
                    journal.AddEntry(prompt, response, weather);
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter the filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    Console.Write("Enter the format (CSV or JSON): ");
                    string saveFormat = Console.ReadLine();
                    journal.SaveToFile(saveFilename, saveFormat);
                    break;

                case "4":
                    Console.Write("Enter the filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    Console.Write("Enter the format (CSV or JSON): ");
                    string loadFormat = Console.ReadLine();
                    journal.LoadFromFile(loadFilename, loadFormat);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

/*
 * Exceeded Requirements:
 * 1. Added weather information to each journal entry.
 * 2. Implemented saving and loading journal entries in CSV format.
 * 3. Implemented saving and loading journal entries in JSON format.
 */