using System;
using System.Globalization;

namespace SoftUniCoffeeOrders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());

            decimal result = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime currentDate = DateTime.ParseExact(Console.ReadLine(), "s/M/yyyy", CultureInfo.InvariantCulture);
                long coffeeCapsules = long.Parse(Console.ReadLine());

                var daysOfMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
                decimal currentAmount = daysOfMonth * coffeeCapsules * price;

                Console.WriteLine($"The price for the coffee is: ${currentAmount:f2}");

                result += currentAmount;
            }
            
            Console.WriteLine($"Total: ${result:f2}");
        }
    }
}
