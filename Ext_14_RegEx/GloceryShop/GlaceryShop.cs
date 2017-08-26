using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GloceryShop
{
    public class GlaceryShop
    {
        public static void Main()
        {
            var pattern = @"^[A-Z][a-z]*:\d+\.\d{2}$";
            var regex = new Regex(pattern);

            Dictionary<string, decimal> newListOfProducts = new Dictionary<string, decimal>();

            var inputLine = Console.ReadLine();

            while (inputLine != "bill")
            {
                if (regex.IsMatch(inputLine))
                {
                    var tokens = inputLine.Split(':');
                    string productName = tokens[0];
                    decimal price = decimal.Parse(tokens[1]);

                    if (! newListOfProducts.ContainsKey(productName))
                    {
                        newListOfProducts[productName] = 0m;
                    }

                    newListOfProducts[productName] = price;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var record in newListOfProducts.OrderByDescending(x => x.Value))
            {
                var product = record.Key;
                var price = record.Value;

                Console.WriteLine($"{product} costs {price}");
            }
        }
    }
}
