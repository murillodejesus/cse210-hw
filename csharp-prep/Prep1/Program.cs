using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("Now i'll test my knowledge on C#");

        Console.Write("What is your First Name?");
        string firstname = Console.ReadLine();
        Console.Write("What is your Last Name?");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your Name is {lastname}, {firstname} {lastname}.");
    }
}