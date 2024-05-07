using System;
public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        numerator = wholeNumber;
        denominator = 1;
    }

    public Fraction (int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public int Numerator
    {
        get { return numerator; }
        get { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value != 0)
                denominator = value;
            else 
                throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue();
    {
        return (double)numerator / denominator;
    }

}