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

    
}