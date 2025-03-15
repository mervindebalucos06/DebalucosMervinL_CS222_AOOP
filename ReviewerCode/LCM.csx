using System;

class LCMCalculator
{
    // Function to calculate the Greatest Common Divisor (GCD)
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate the Least Common Multiple (LCM) of two numbers
    static int LCM(int a, int b)
    {
        return (a / GCD(a, b)) * b; // Using the formula: LCM(a, b) = (a * b) / GCD(a, b)
    }

    static void Main()
    {
        /*
         * Least Common Multiple (LCM):
         * Given an integer n that determines the number of inputs,
         * then a series of positive nonzero inputs,
         * output the least common multiple of the inputs.
         */

        Console.Write("Enter number of inputs: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.Write("Enter inputs: ");
            string[] inputs = Console.ReadLine().Split();

            if (inputs.Length != n)
            {
                Console.WriteLine("Error: Number of inputs does not match the specified count.");
                return;
            }

            int lcm = int.Parse(inputs[0]);
            for (int i = 1; i < n; i++)
            {
                lcm = LCM(lcm, int.Parse(inputs[i]));
            }

            Console.WriteLine("LCM: " + lcm);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of inputs.");
        }
    }
}
