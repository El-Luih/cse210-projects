using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        frac1.SetTop(1);
        frac1.SetBottom(2);
        Console.WriteLine(frac1.GetTop());
        Console.WriteLine(frac1.GetBottom());
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Fraction frac2 = new Fraction(8);
        Console.WriteLine(frac2.GetTop());
        Console.WriteLine(frac2.GetBottom());
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Fraction frac3 = new Fraction(8, 98);
        Console.WriteLine(frac3.GetTop());
        Console.WriteLine(frac3.GetBottom());
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
    }
}