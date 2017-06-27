using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary <string, decimal> priceList = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split('-');
                var product = inputLine[0];
                var productPrice = decimal.Parse(inputLine[1]);

                if (! priceList.ContainsKey(product))
                {
                    priceList[product] = 0;
                }
                priceList[product] = productPrice;
            }

            List<Customer> customersList = new List<Customer>();

            var inputCustomers = Console.ReadLine().Split('-', ',');
            var customerName = inputCustomers[0];
            var customersChoice = inputCustomers[1];
            var quantity = double.Parse(inputCustomers[2]);

            while (customerName != "end of clients")
            {
                

            }


        }
    }
}
