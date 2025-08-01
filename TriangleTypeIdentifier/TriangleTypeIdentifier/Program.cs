using System;

namespace TriangleIdentifierApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRIANGLE TYPE IDENTIFIER");

            int side1 = GetSideInput("Enter length of side 1: ");
            int side2 = GetSideInput("Enter length of side 2: ");
            int side3 = GetSideInput("Enter length of side 3: ");

            string type = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine("Triangle type: " + type);

            Console.ReadLine(); // Keeps console open
        }

        static int GetSideInput(string prompt)
        {
            int value;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }
            return value;
        }

        static string DetermineTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || b == c || a == c)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}