using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set;}
    public string Response {get; set;}
    public string Date {get; set;}
}

class Journal
{ 
    private List<JournalEntry> entries;

    public Journal ()
    {
        entries = new List<JournalEntry>();
    }
    public void AddEntry (string prompt, string response, string date)
    {
        JournalEntry entry = new JournalEntry
        {
            Prompt = prompt,
            Response = response,
            Date = date
        };
        entries.Add(entry);
    }

    public void DisplayEntries()
    { 
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}/n");
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                AddEntry(parts[1], parts[2], parts[0]);
            }
        }
    }
}

class Program
{
    static void Main (string[] args)
    {
        Journal journal = new Journal();

        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rand = new Random ();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

        }
    }
}

