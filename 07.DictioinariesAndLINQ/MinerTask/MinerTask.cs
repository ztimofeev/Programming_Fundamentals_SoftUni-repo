namespace MinerTask
{
    using System;
    using System.Collections.Generic;

    public class MinerTask
    {
        public static void Main()
        {
            var line = Console.ReadLine();

            Dictionary<string, long> metalQuantity = new Dictionary<string, long>();

            while (line != "stop")
            {
                var quantity = long.Parse(Console.ReadLine());
                var metal = line;

                if (! metalQuantity.ContainsKey(metal))
                {
                    metalQuantity[metal] = 0;
                }
                metalQuantity[metal] += quantity;

                line = Console.ReadLine();
            }

            foreach (var member in metalQuantity)
            {
                var metal = member.Key;
                var quantity = member.Value;
                Console.WriteLine($"{metal} -> {quantity}");
            }
        }
    }
}
