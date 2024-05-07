using System;
using System.Xml.Schema;

class Program
{
    static void Main (string[] args)
    {
       Fraction fraction1 = new Fraction();
       Fraction fraction2 = new Fraction(5);
       Fraction Fraction3 = new Fraction(6,7);

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetFractionString());

 
    }
}