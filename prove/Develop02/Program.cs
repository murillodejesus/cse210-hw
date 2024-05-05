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
}