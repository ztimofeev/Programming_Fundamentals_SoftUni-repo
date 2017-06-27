namespace Pizza_Ingredients
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class PizzaIngredients
    {
        public static void Main()
        {
            var totalIngredients = Console.ReadLine().Split().ToArray();
            var maxLenghtOfString = int.Parse(Console.ReadLine());

            List<string> ingredients = new List<string>();

            for (int i = 0; i < totalIngredients.Length; i++)
            {
                if (totalIngredients[i].Length == maxLenghtOfString)
                {
                    Console.WriteLine($"Adding {totalIngredients[i]}.");
                    ingredients.Add(totalIngredients[i]);
                    if (ingredients.Count == 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredients.Count} ingredients.");
            Console.Write("The ingredients are: ");
            Console.WriteLine(string.Join(", ", ingredients) + ".");
        }
    }
}
