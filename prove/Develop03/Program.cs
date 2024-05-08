using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "I will go and do");

        ScriptureMemorizer memorizer = new ScriptureMemorizer(scripture);
        memorizer.Start();
    }
}