using System;
using System.Xml.Schema;

class Program
{
    static void Main (string[] args)
    {
       Fraction fraction1 = new Fraction();
       Fraction fraction2 = new Fraction(5);
       Fraction Fraction3 = new Fraction(6,7);

       Console.WriteLine(fraction1.GetFractionString());
       Console.WriteLine(fraction1.GetDecimalValue());

       Console.WriteLine(fraction1.GetFractionString());
       Console.WriteLine(fraction1.GetDecimalValue());

    
 
    }
}