namespace OptimizedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BankAccount
    {
        public BankAccount(string name, string bank, decimal balance)
        {
            Name = name;
            Bank = bank;
            Balance = balance;
        }

        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }
    }

    public class OptimazedBankingSystem
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            List<BankAccount> accounts = new List<BankAccount>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new []{ '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var bankName = tokens[0];
                var accountName = tokens[1];
                var balance = decimal.Parse(tokens[2]);

                var account = new BankAccount(accountName, bankName, balance);
                accounts.Add(account);

                inputLine = Console.ReadLine();
            }

            accounts = accounts.OrderByDescending(a => a.Balance).ThenBy(a => a.Bank).ToList();

            foreach (var account in accounts)
            {
                var client = account.Name;
                var accountsBalance = account.Balance;
                var bankName = account.Bank;

                Console.WriteLine($"{client} -> {accountsBalance} ({bankName})");
            }
        }
    }
}
