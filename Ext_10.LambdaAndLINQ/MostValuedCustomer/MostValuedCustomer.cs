namespace MostValuedCustomer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostValuedCustomer
    {
        public static void Main()
        {
            Dictionary<string, double> store = new Dictionary<string, double>();

            var inputLine = Console.ReadLine();

            while (inputLine != "Shop is open")
            {
                var inputParts = inputLine.Split();
                var product = inputParts[0];
                var price = double.Parse(inputParts[1]);

                if (! store.ContainsKey(product))
                {
                    store[product] = 0;
                }
                store[product] = price;

                inputLine = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> customersPurchases = 
                new Dictionary<string, Dictionary<string, int>>();

            var inputBuy = Console.ReadLine();

            while (inputBuy != "Print")
            {
                if (inputBuy != "Discount")
                {
                    var inputParts = inputBuy.Split(new[] {':', ' ', ','}, 
                        StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                    SetCustomer(customersPurchases, store, inputParts);
                }
                else
                {
                    SetDiscount(store);
                }

                inputBuy = Console.ReadLine();
            }

            var sortedCustomersBySpents = TheMostValuedCustomer(customersPurchases, store);

            PrintResult(sortedCustomersBySpents, store);
        }

        public static void PrintResult(Dictionary<string, Dictionary<string, double>> customers, 
                                        Dictionary<string, double> store)
        {
            foreach (var customer in customers)
            {
                Dictionary<string, double> resultToPrint = new Dictionary<string, double>();
                var mostValuedCustomer = customer.Key;

                Console.WriteLine($"Biggest spender: {mostValuedCustomer}");
                Console.WriteLine("^Products bought:");

                var mvcPurchases = customer.Value.OrderByDescending(x => x.Value);

                foreach (var mvcPurchase in mvcPurchases)
                {
                    var product = mvcPurchase.Key;
                    var currentPrice = store.Where(x => x.Key == product)
                        .ToList()[0]
                        .Value;
                    if (! resultToPrint.ContainsKey(product))
                    {
                        resultToPrint[product] = 0;
                    }
                    resultToPrint[product] = currentPrice;
                }

                foreach (var item in resultToPrint.OrderByDescending(x => x.Value))
                {
                    var product = item.Key;
                    var price = item.Value;
                    Console.WriteLine($"^^^{product}: {price:f2}");
                }

                var totalSpent = customer.Value.Select(x => x.Value).Sum();
                Console.WriteLine($"Total: {totalSpent:f2}");
                break;
            }   
        }

        public static void SetDiscount(Dictionary<string, double> store)
        {
            var counter = 0;

            foreach (var item in store.OrderByDescending(x => x.Value))
            {
                if (counter < 3)
                {
                    store[item.Key] = item.Value * 0.90;
                    counter++;
                }
                else
                {
                    break;
                }
            }
        }

        public static void SetCustomer(Dictionary<string, Dictionary<string, int>> customers,
            Dictionary<string, double> store, string[] input)
        {
            var customerName = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                var goods = input[i];

                if (!customers.ContainsKey(customerName))
                {
                    customers[customerName] = new Dictionary<string, int>();
                }

                if (!customers[customerName].ContainsKey(goods))
                {
                    customers[customerName][goods] = 0;
                }
                customers[customerName][goods] += 1;
            }
        }

        public static Dictionary<string, Dictionary<string, double>> TheMostValuedCustomer(Dictionary<string, Dictionary<string, int>> customers, Dictionary<string, double> store)
        {
            Dictionary<string, Dictionary<string, double>> sortedCustomers = 
                new Dictionary<string, Dictionary<string, double>>();

            foreach (var customer in customers)
            {
                var currentCustomer = customer.Key;
                var purchases = customer.Value.OrderByDescending(x => x.Value);
                foreach (var purchase in purchases)
                {
                    var purchasedProduct = purchase.Key;
                    var numberOfPurchasedProducts = purchase.Value;
                    var currentPrice = store.Where(product => product.Key == purchasedProduct).Select(x => x.Value).Sum();

                    if (! sortedCustomers.ContainsKey(currentCustomer))
                    {
                        sortedCustomers[currentCustomer] = new Dictionary<string, double>();
                    }
                    var productValue = numberOfPurchasedProducts * currentPrice;
                    sortedCustomers[currentCustomer].Add(purchasedProduct, productValue);
                }
            }

            sortedCustomers = sortedCustomers
                .OrderByDescending(x => x.Value.Select(y => y.Value).Sum()).ToDictionary(y => y.Key, y => y.Value);

            return sortedCustomers;
        }
    }
}
