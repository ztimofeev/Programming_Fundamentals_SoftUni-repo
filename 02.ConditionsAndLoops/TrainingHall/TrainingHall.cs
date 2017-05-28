namespace TrainingHall
{ 
    using System;

    public class TrainingHall
    {
        public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var itemsCount = int.Parse(Console.ReadLine());

            double spends = 0;

            for (int i = 0; i < itemsCount; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());
                spends += itemPrice * itemCount;
                if (itemCount > 1)
                {
                    itemName = SetPlural(itemName);
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
            }

            Console.WriteLine($"Subtotal: ${spends:f2}");

            if (budget >= spends)
            {
                var moneyLeft = budget - spends;
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                var lack = spends - budget;
                Console.WriteLine($"Not enough. We need ${lack:f2} more.");
            }
        }

        private static string SetPlural(string str)
        {
            var outputString = string.Empty;

            if (str.EndsWith("y"))
            {
                outputString = str.Remove(str.Length - 1) + "ies";
                return outputString;
            }
            else if (str.EndsWith("o") || str.EndsWith("ch") || str.EndsWith("s") || str.EndsWith("sh") || str.EndsWith("x") || str.EndsWith("z"))
            {
                outputString = str + "es";
                return outputString;
            }
            else
            {
                outputString = str + "s";
                return outputString;
            }
        }
    }
}
