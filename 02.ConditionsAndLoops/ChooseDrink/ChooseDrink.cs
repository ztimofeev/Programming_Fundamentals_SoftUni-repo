
namespace ChooseDrink
{
    using System;

    public class ChooseDrink
    {
        public static void Main()
        {
            var profession = Console.ReadLine().ToLower();
            var drink = string.Empty;

            if (profession == "athlete")
            {
                drink = "Water";
            }
            else if (profession == "businessman" || profession == "businesswoman")
            {
                drink = "Coffee";
            } else if (profession == "softuni student")
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }

            Console.WriteLine(drink);
        }
    }
}
