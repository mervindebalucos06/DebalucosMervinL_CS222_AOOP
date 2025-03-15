using System;

class PatternPrinting
{
  static void Main()
  {
    Console.Write("Enter n: ");
    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
    {
      for (int i = 0; i < 2 * n - 1; i++)
      {
        for (int j = 0; j < 2 * n - 1; j++)
        {
          int value = n - Math.Min(Math.Min(i, j), Math.Min(2 * n - 2 - i, 2 * n - 2 - j));
          Console.Write(value + " ");
        }
        Console.WriteLine();
      }
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a positive integer.");
    }
  }
}
