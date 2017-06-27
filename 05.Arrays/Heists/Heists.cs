namespace Heists
{
    using System;
    using System.Linq;

    public class Heists
    {
        public static void Main()
        {
            var prices = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var lootAndExpenses = Console.ReadLine().Split(' ').ToArray();

            long lootsAmount = 0;
            long expensesAmount = 0;

            while (lootAndExpenses[0] != "Jail")
            {
                expensesAmount += long.Parse(lootAndExpenses[1]);
                string loot = lootAndExpenses[0];

                foreach (var symbol in loot)
                {
                    if (symbol == '%')
                    {
                        lootsAmount += prices[0];
                    }
                    else if (symbol == '$')
                    {
                        lootsAmount += prices[1];
                    }
                }

                lootAndExpenses = Console.ReadLine().Split().ToArray();
            }

            if (lootsAmount >= expensesAmount)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {lootsAmount - expensesAmount}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expensesAmount - lootsAmount}.");
            }
        }
    }
}
