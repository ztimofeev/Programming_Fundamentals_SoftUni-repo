using System.Linq;

namespace SalesReport
{
    using System;
    using System.Collections.Generic;

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    };

    public class SalesReport
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                var salesData = Console.ReadLine().Split();

                var currentSale = new Sale
                {
                    Town = salesData[0],
                    Product = salesData[1],
                    Price = decimal.Parse(salesData[2]),
                    Quantity = decimal.Parse(salesData[3])
                };

                sales.Add(currentSale);
            }

            Dictionary<string, decimal> result = new Dictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (! result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }

                result[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (KeyValuePair<string, decimal> kvp in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
