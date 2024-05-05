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

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
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

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = prompts[rand.Next(prompts.Length)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    journal.AddEntry(prompt, response, date);
                    break;
                case 2:
                    Console.WriteLine("Journal Entries: ");
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved successfully.");
                    break;
                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded successfully.");
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}

