using System;

class LeapYearChecker
{
    static void Main()
    {
        /*
         * Leap Year Checker:
         * A leap year is:
         * - Divisible by 4
         * - Not divisible by 100, unless also divisible by 400
         * 
         * If the given year meets these conditions, print "Year is a Leap Year."
         * Otherwise, print "Year is not a Leap Year."
         */

        Console.Write("Enter a year: ");
        if (int.TryParse(Console.ReadLine(), out int year) && year > 0)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive year.");
        }
    }
}

