using System;
using System.Collections.Generic;

namespace SupermarketDatabase
{
    public class SupermarketDatabase
    {
        public static void Main()
        {
            var dataLine = Console.ReadLine().Split();

            Dictionary<string, Dictionary<double, double>> store = new Dictionary<string, Dictionary<double, double>>();

            while (dataLine[0] != "stocked")
            {
                var product = dataLine[0];
                var price = double.Parse(dataLine[1]);
                var quantity = double.Parse(dataLine[2]);

                if (!store.ContainsKey(product))
                {
                    store[product] = new Dictionary<double, double>();
                }
                else
                {
                    if (!store[product].ContainsKey(price))
                    {
                        double temp =  GetExistQuantity(store, product);
                        store[product].Clear();
                        store[product] = new Dictionary<double, double>();
                        store[product][price] = temp;
                    }
                }

                if (!store[product].ContainsKey(price))
                {
                    store[product][price] = 0;
                }

                store[product][price] += quantity;

                dataLine = Console.ReadLine().Split();
            }

            double grandTotal = 0;
            foreach (var item in store)
            {
                
                var product = item.Key;
                var productData = item.Value;
                foreach (var priveAndQuantity in productData)
                {
                    var price = priveAndQuantity.Key;
                    var quantity = priveAndQuantity.Value;
                    var productTotal = price * quantity;
                    grandTotal += productTotal;
                    Console.WriteLine($"{product}: ${price:f2} * {quantity} = ${productTotal:f2}");
                }   
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }

        public static double GetExistQuantity(Dictionary<string, Dictionary<double, double>> store, string product)
        {
            double result = 0;
            foreach (var item in store)
            {
                var prod = item.Key;
                var priceQuantity = item.Value;
                foreach (var pair in priceQuantity)
                {
                    if (product == prod)
                    {
                        result = pair.Value;
                    }
                }
            }
            return result;
        }
    }
}
