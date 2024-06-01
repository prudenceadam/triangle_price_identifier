using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string input = Console.ReadLine();

        try
        {
            int grade = int.Parse(input);

            if (grade >= 0 && grade <= 100)
            {
                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Please enter a grade between 0 and 100.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade.");
        }
    }

    static string GetLetterGrade(int grade)
    {
        if (grade >= 90)
            return "A";
        else if (grade >= 80)
            return "B";
        else if (grade >= 70)
            return "C";
        else if (grade >= 60)
            return "D";
        else
            return "F";
    }
}