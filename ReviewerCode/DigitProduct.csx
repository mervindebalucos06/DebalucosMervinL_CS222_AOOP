using System;

class DigitProductCalculator
{
    static void Main()
    {
        /*
         * Digit Product:
         * Given an integer N (1 <= N <= 10^9), compute the product of its digits (ignoring zeros).
         * Input: An integer N
         * Output: Print the product of the digits of N (ignoring zeros).
         */

        Console.Write("Enter an integer N: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N >= 1 && N <= 1000000000)
        {
            int product = 1;
            bool hasNonZeroDigit = false;
            
            // Iterate through each digit of N
            foreach (char digit in N.ToString())
            {
                if (digit != '0') // Ignore zeros
                {
                    product *= digit - '0'; // Convert char to int and multiply
                    hasNonZeroDigit = true; // Mark that at least one non-zero digit exists
                }
            }
            
            // Print the computed product, or 0 if there were no non-zero digits
            Console.WriteLine("Product of digits (ignoring zeros): " + (hasNonZeroDigit ? product : 0));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
