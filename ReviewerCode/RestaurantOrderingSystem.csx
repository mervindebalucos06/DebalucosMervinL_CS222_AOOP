

// Define an enum for food categories
enum FoodCategory
{
    Appetizers,
    MainCourse,
    Desserts,
    Beverages
}

class RestaurantOrderingSystem
{
    static void Main()
    {
        // Display food categories
        DisplayCategories();

        // Prompt user to select a category
        Console.Write("Enter the number of your chosen category: ");
        if (int.TryParse(Console.ReadLine(), out int categoryIndex) && Enum.IsDefined(typeof(FoodCategory), categoryIndex))
        {
            FoodCategory selectedCategory = (FoodCategory)categoryIndex;
            
            // Define arrays for different categories
            string[] appetizers = { "Spring Rolls", "Nachos", "Garlic Bread" };
            string[] mainCourse = { "Steak", "Pasta", "Grilled Chicken" };
            string[] desserts = { "Ice Cream", "Brownie", "Cheesecake" };
            string[] beverages = { "Coffee", "Tea", "Lemonade" };
            
            // Select the appropriate array
            string[] selectedMenu = selectedCategory switch
            {
                FoodCategory.Appetizers => appetizers,
                FoodCategory.MainCourse => mainCourse,
                FoodCategory.Desserts => desserts,
                FoodCategory.Beverages => beverages,
                _ => new string[0]
            };
            
            // Display menu for selected category
            DisplayMenu(selectedCategory, selectedMenu);
            
            // Prompt user to select a dish
            Console.Write("Enter the number of your chosen dish: ");
            if (int.TryParse(Console.ReadLine(), out int dishIndex) && dishIndex >= 0 && dishIndex < selectedMenu.Length)
            {
                Console.WriteLine($"You have ordered: {selectedMenu[dishIndex]}");
            }
            else
            {
                Console.WriteLine("Invalid dish selection.");
            }
        }
        else
        {
            Console.WriteLine("Invalid category selection.");
        }
    }

    // Function to display available food categories
    static void DisplayCategories()
    {
        Console.WriteLine("Available Food Categories:");
        foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
        {
            Console.WriteLine($"{(int)category}. {category}");
        }
    }

    // Function to display menu items for a selected category
    static void DisplayMenu(FoodCategory category, string[] menu)
    {
        Console.WriteLine($"\n{category} Menu:");
        for (int i = 0; i < menu.Length; i++)
        {
            Console.WriteLine($"{i}. {menu[i]}");
        }
    }
}