using System;

class Program
{
    static void Main()
    {
        int total = 10; // Initialize total to 10

        /*
         * The final total. An integer variable, total, is initialized to 10 in the code editor. 
         * Ask the user to input an integer and check if it is positive, negative, or zero.
         * If positive, check if it is even or odd.
         * - If it is even, add its square to total.
         * - Otherwise, add its cube to total.
         * If negative, ask the user to input another integer as an exponent to this negative number 
         * and add the result to total.
         * If zero, print "Nothing happened."
         * Lastly, only print the value of total if the inputted integer is positive or negative.
         */

        // Ask the user to input an integer
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (num > 0) // Positive number
            {
                if (num % 2 == 0)
                {
                    total += num * num; // Add square if even
                }
                else
                {
                    total += num * num * num; // Add cube if odd
                }
            }
            else if (num < 0) // Negative number
            {
                Console.Write("Enter an exponent: ");
                if (int.TryParse(Console.ReadLine(), out int exponent))
                {
                    total += (int)Math.Pow(num, exponent); // Add exponentiation result
                }
            }
            else // Zero
            {
                Console.WriteLine("Nothing happened.");
                return;
            }

            // Print final total only if the input was positive or negative
            Console.WriteLine("Final Total: " + total);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}
