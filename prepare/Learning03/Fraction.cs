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

    public Fraction(int num, int denom)
    {
        numerator = num;
        denominator = denom;
    }

    public string GetFractionString()
    {
        string fraction = $"{numerator}/{denominator}";
        return fraction;
    }

    public double GetDecimal()
    {
        return (double)numerator / (double)denominator;
    }
}