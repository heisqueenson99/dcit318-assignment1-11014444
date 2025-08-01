using System;

namespace TicketCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MOVIE TICKET CALCULATOR");
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            int age;                                     // declare first
            if (int.TryParse(input, out age))            // classic out-var syntax
            {
                decimal price = CalculateTicketPrice(age);
                Console.WriteLine("Your ticket price is: GHC" + price); // plain concatenation
            }
            else
            {
                Console.WriteLine("Age must be a valid number.");
            }

            Console.ReadLine();  // keeps the window open so you can see the result
        }

        static decimal CalculateTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
                return 7.00m;
            else
                return 10.00m;
        }
    }
}