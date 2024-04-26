using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 95)
        {
            letter = "A+";
        }
        else if (percentage >= 90)
        {
            letter = "A-";
        }
        else if (percentage >= 85)
        {
            letter = "B+";
        }
        else if (percentage >= 80)
        {
            letter = "B-";
        }
        else if (percentage >= 75)
        {
            letter = "C+";
        }
          else if (percentage >= 70)
        {
            letter = "C-";
        }
        else if (percentage >= 65)
        {
            letter = "D+";
        }
        else if (percentage >= 60)
        {
            letter = "D-";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulation, you passed!!!");
        }
        else
        {
            Console.WriteLine("Sorry, you don't passed, try again in the next term!!");
        }
    }
}