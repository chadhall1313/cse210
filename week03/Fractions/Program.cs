using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Fraction r = new Fraction(6);
        Fraction a = new Fraction(6, 7);
        Console.WriteLine(f.GetDecimalValue());
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(r.GetDecimalValue());
        Console.WriteLine(r.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());

        
    }
}