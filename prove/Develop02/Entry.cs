using System;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public string Weather { get; set; }

    public JournalEntry(string prompt, string response, string weather)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
        Weather = weather;
    }

    public override string ToString()
    {
        return $"Date: {Date.ToShortDateString()}\nWeather: {Weather}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}