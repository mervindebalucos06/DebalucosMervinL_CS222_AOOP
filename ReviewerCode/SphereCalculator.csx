/* A sphere is a three-dimensional shape. 
   Its surface area is calculated using the formula: 4πr². 
   Its volume is determined by the formula: (4/3)πr³. 
   Given the sphere's diameter, this program computes and displays 
   its surface area and volume rounded to two decimal places. 

   Additionally, this program generates and displays the first N terms 
   of the Tribonacci sequence, where each term is the sum of the three 
   preceding numbers, starting with 0, 1, and 1. */

   
using System;

class SphereCalculator
{
    static void Main()
    {
        // Prompt the user to enter the diameter of the sphere
        Console.Write("Enter the diameter of the sphere: ");
        double diameter = Convert.ToDouble(Console.ReadLine());
        
        // Calculate the radius (radius is half of the diameter)
        double radius = diameter / 2;
        
        // Calculate the surface area using the formula: 4 * π * r^2
        double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
        
        // Calculate the volume using the formula: (4/3) * π * r^3
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        
        // Display the results rounded to two decimal places
        Console.WriteLine($"Surface Area: {surfaceArea:F2}");
        Console.WriteLine($"Volume: {volume:F2}");

        // Prompt the user for the number of Tribonacci terms to generate
        Console.Write("\nEnter the number of Tribonacci terms to generate: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Generate and display the Tribonacci sequence
        PrintTribonacci(n);
    }

    static void PrintTribonacci(int n)
    {
        // Initial terms of the Tribonacci sequence
        long a = 0, b = 1, c = 1;
        
        Console.WriteLine("Tribonacci Sequence:");
        
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            long next = a + b + c; // Compute the next term
            a = b;
            b = c;
            c = next;
        }
        Console.WriteLine();
    }
}


