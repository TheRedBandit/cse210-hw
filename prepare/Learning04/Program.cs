using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment as1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(as1.GetSummary());

        MathAssignment as2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(as2.GetSummary());
        Console.WriteLine(as2.GetHomeworkList());

        WritingAssignment as3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(as3.GetSummary());
        Console.WriteLine(as3.GetWritingInformation());
    }
}