using System;

namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GRADE CALCULATOR");
            Console.Write("Please enter a score between 0 and 100: ");

            if (int.TryParse(Console.ReadLine(), out int score))
            {
                string grade = GetLetterGrade(score);
                Console.WriteLine($"Your letter grade is: {grade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        static string GetLetterGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 70)
                return "C";
            else if (score >= 60)
                return "D";
            else
                return "F";
        }
    }
}