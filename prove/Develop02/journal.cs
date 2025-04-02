using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response, string weather)
    {
        entries.Add(new JournalEntry(prompt, response, weather));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date.ToShortDateString()}");
            Console.WriteLine($"Weather: {entry.Weathers}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveToFile(string filename, string format)
    {
        if (format.ToLower() == "csv")
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Weather,Prompt,Response");
                foreach (var entry in entries)
                {
                    writer.WriteLine($"\"{entry.Date}\",\"{entry.Weather}\",\"{entry.Prompt}\",\"{entry.Response}\"");
                }
            }
        }
        else if (format.ToLower() == "json")
        {
            string jsonString = JsonSerializer.Serialize(entries);
            File.WriteAllText(filename, jsonString);
        }
        else
        {
            Console.WriteLine("Invalid format. Only CSV and JSON are supported.");
        }
    }

    public void LoadFromFile(string filename, string format)
    {
        entries.Clear();
        if (format.ToLower() == "csv")
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine(); // Skip header
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    DateTime date = DateTime.Parse(values[0].Trim('\"'));
                    string weather = values[1].Trim('\"');
                    string prompt = values[2].Trim('\"');
                    string response = values[3].Trim('\"');
                    entries.Add(new JournalEntry(prompt, response, weather) { Date = date });
                }
            }
        }
        else if (format.ToLower() == "json")
        {
            string jsonString = File.ReadAllText(filename);
            entries = JsonSerializer.Deserialize<List<JournalEntry>>(jsonString);
        }
        else
        {
            Console.WriteLine("Invalid format. Only CSV and JSON are supported.");
        }
    }
}