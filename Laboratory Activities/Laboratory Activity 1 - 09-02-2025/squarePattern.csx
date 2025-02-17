Console.Write("Enter the size of the square (n): ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter the row to skip (y): ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("\nSquare Pattern:\n");

for (int i = 1; i <= n; i++)
{
  if (i == y)
    continue;

  for (int j = 1; j <= n; j++)
  {
    Console.Write("* ");
  }
  Console.WriteLine();
}