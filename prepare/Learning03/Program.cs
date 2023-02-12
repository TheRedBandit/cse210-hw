using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions Frac1 = new Fractions();
        Console.WriteLine(Frac1.GetFractionString());
        Console.WriteLine(Frac1.GetDecimalValue());

        Fractions Frac2 = new Fractions(5);
        Console.WriteLine(Frac2.GetFractionString());
        Console.WriteLine(Frac2.GetDecimalValue());

        Fractions Frac3 = new Fractions(3,4);
        Console.WriteLine(Frac3.GetFractionString());
        Console.WriteLine(Frac3.GetDecimalValue());

        Fractions Frac4 = new Fractions(1,3);
        Console.WriteLine(Frac4.GetFractionString());
        Console.WriteLine(Frac4.GetDecimalValue());
    }  
}