namespace Dictionaries
{
    using System;
    using System.Collections.Generic;

    public class ExamShopping
    {
        public static void Main()
        {
            Dictionary<string, int> store = new Dictionary<string, int>();

            var productLine = Console.ReadLine().Split();

            while (productLine[0] == "stock" )
            {
                var goods = productLine[1];
                var quantity = int.Parse(productLine[2]);

                if (!store.ContainsKey(goods))
                {
                    store.Add(goods, 0);
                }
                store[goods] += quantity;

                productLine = Console.ReadLine().Split();
            }

            var shopping = Console.ReadLine().Split();

            while (shopping[0] == "buy")
            {
                var productSale = shopping[1];
                var buyingQuantity = int.Parse(shopping[2]);

                if (! store.ContainsKey(productSale))
                {
                    Console.WriteLine($"{productSale} doesn't exist");
                }
                else if (store[productSale] == 0)
                {
                    Console.WriteLine($"{productSale} out of stock");
                }
                else if (store[productSale] <= buyingQuantity)
                {
                    store[productSale] = 0;
                }
                else
                {
                    store[productSale] -= buyingQuantity;
                }

                shopping = Console.ReadLine().Split();
            }

            foreach (var kvp in store)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
