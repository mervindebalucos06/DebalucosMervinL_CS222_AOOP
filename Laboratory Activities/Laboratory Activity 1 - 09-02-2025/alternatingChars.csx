
        // Get user input
     

        Console.Write("First character: ");
        char firstChar = Console.ReadLine()[0];

        Console.Write("Second character: ");
        char secondChar = Console.ReadLine()[0];
        
        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        // Loop through rows
for (int i = 0; i < size; i++)
{
  // Print leading hyphens based on row index
  Console.Write(new string('-', i));

  // Choose character based on row index
  char currentChar = (i % 2 == 0) ? firstChar : secondChar;

  // Print the character for the row (one per line)
  Console.WriteLine(currentChar);
}
  
