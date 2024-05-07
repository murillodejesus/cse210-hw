using System;
public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        top = wholeNumber;
        bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    public int Top
    {
        get { return top; }
        set { top = value; }
    }

    public int Denominator
    {
        get { return bottom; }
        set
        {
            if (value != 0)
                bottom = value;
            else 
                throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }

}