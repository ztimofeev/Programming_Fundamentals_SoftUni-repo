namespace Inventory_Matcher
{
    using System;
    using System.Linq;

    public class InventoryMatcher
    {
        public static void Main()
        {
            var goods = Console.ReadLine().Split().ToArray();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            var product = Console.ReadLine();

            while (product != "done")
            {
                for (int i = 0; i < goods.Length; i++)
                {
                    if (goods[i] == product)
                    {
                        Console.WriteLine($"{goods[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }
                }

                product = Console.ReadLine();
            }
        }
    }
}
