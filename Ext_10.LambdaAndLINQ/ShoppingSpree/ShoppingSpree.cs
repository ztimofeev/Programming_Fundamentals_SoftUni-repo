namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingSpree
    {
        public static void Main()
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            var budget = decimal.Parse(Console.ReadLine());
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(' ');
                var snack = tokens[0];
                var price = decimal.Parse(tokens[1]);

                if (!products.ContainsKey(snack))
                {
                    products.Add(snack, price);
                }
                else
                {
                    if (products[snack] > price)
                    {
                        products[snack] = price;
                    }
                }

                inputLine = Console.ReadLine();
            }

            var sumPrices = products.Sum(x => x.Value);

            if (budget < sumPrices)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (KeyValuePair<string, decimal> product in products.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{product.Key} costs {product.Value:F2}");
                }
            }
        }
    }
}
