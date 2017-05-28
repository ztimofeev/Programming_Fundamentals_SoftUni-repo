
namespace CakeIngredients
{
    using System;

    public class CakeIngredients
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var count = 0;

            while (line != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {line}.");
                count++;

                line = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
