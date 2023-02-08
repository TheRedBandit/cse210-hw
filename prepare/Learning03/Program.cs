using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions MyFractions = new Fractions();
        Console.WriteLine(MyFractions.GetFractionString());
        Console.WriteLine(MyFractions.GetDecimalValue());
    }
}