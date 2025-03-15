using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        /*
         * Simple Interest Calculation:
         * This program accepts the principal amount, rate of interest, and time (in years)
         * from the user and calculates the simple interest using the formula:
         * Simple Interest = (Principal * Rate * Time) / 100
         */

        Console.Write("Enter Principal Amount: ");
        if (double.TryParse(Console.ReadLine(), out double principal) && principal > 0)
        {
            Console.Write("Enter Rate of Interest (in %): ");
            if (double.TryParse(Console.ReadLine(), out double rate) && rate > 0)
            {
                Console.Write("Enter Time (in years): ");
                if (double.TryParse(Console.ReadLine(), out double time) && time > 0)
                {
                    // Calculate Simple Interest
                    double simpleInterest = (principal * rate * time) / 100;
                    Console.WriteLine($"Simple Interest: {simpleInterest:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Time must be a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Rate of Interest must be a positive number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Principal amount must be a positive number.");
        }
    }
}
