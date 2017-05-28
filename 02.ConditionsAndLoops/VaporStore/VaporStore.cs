namespace VaporStore
{
    using System;

    public class VaporStore
    {
        public static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var command = Console.ReadLine();

            double spends = 0;
            double balance = money;

            while (command != "Game Time")
            {
                double price = 0;
                bool exists = true;

                switch (command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        exists = false;
                        break;
                }

                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (balance >= price && exists)
                {
                    spends += price;
                    balance -= price;
                    Console.WriteLine($"Bought {command}");
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (balance > 0)
            {
                var remainder = money - spends;
                Console.WriteLine($"Total spent: ${spends:f2}. Remaining: ${remainder:f2}");
            }
        }
    }
}
