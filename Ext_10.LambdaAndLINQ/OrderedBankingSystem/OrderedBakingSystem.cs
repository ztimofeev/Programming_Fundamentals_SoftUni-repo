namespace OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderedBakingSystem
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, decimal>> bankSystem = 
                new Dictionary<string, Dictionary<string, decimal>>();

            var inputData = Console.ReadLine();

            while (inputData != "end")
            {
                var tokens = inputData.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var bank = tokens[0];
                var account = tokens[1];
                var balance = decimal.Parse(tokens[2]);

                if (! bankSystem.ContainsKey(bank))
                {
                    bankSystem[bank] = new Dictionary<string, decimal>();
                }

                if (! bankSystem[bank].ContainsKey(account))
                {
                    bankSystem[bank][account] = balance;
                }
                else
                {
                    bankSystem[bank][account] += balance;
                }
                
                inputData = Console.ReadLine();
            }

            //bankSystem
            //    .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
            //    .ThenByDescending(bank => bank.Value.Max(account => account.Value))
            //    .ToList()
            //    .ForEach(bank => bank.Value.OrderByDescending(account => account.Value)
            //    .ToList()
            //    .ForEach(account => Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})")));

            foreach (var bank in bankSystem.OrderByDescending(bank => bank.Value.Sum(account => account.Value)).ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {
                foreach (var account in bank.Value.OrderByDescending(account => account.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            }
        }
    }
}
