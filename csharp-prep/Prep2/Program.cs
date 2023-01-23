using System;

class Program
{
    static void Main(string[] args)
    {
        // Get Percentage
        Console.Write("Type a grade percenage: ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);
        string message = "";
        string letterGrade = "";


        if (grade >= 70)
        {
            message = ("Passed!");
        }
        else
        {
            message = ("Mission Failed, we'll get em next time!");
        }

        if (grade >= 90)
        {
            letterGrade = ("A");
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = ("B");
        }
        else if (grade >= 70 && grade < 80)
        {
            letterGrade = ("C");
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = ("D");
        }
        else if (grade < 60)
        {
            letterGrade = ("F");
        }

        Console.Write($"{letterGrade}, {message}");
    }
}