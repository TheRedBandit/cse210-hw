using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine(numbers.Count);
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(i);
        }*/

        List<int> numbers = new List<int>(); 

        int iNumber = -1;
        string sNumber = "";
        int sum = 0;
        float average = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (iNumber != 0)
        {
            Console.Write("Enter number: ");
            iNumber = int.Parse(sNumber = Console.ReadLine());
            numbers.Add(iNumber);
            sum += iNumber;

            if (iNumber > largest)
            {
                largest = iNumber;
            }
        }

        average = ((float)sum) / (numbers.Count - 1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}