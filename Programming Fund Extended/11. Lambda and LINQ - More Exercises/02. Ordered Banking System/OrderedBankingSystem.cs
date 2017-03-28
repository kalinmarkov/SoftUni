using System;
using System.Collections.Generic;
using System.Linq;

class OrderedBankingSystem
{
    static void Main()
    {
        var bankDatabase = new Dictionary<string, Dictionary<string, decimal>>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var bankName = tokens[0];
            var account = tokens[1];
            var balance = decimal.Parse(tokens[2]);

            if (!bankDatabase.ContainsKey(bankName))
            {
                bankDatabase[bankName] = new Dictionary<string, decimal>();
            }

            if (!bankDatabase[bankName].ContainsKey(account))
            {
                bankDatabase[bankName][account] = 0;
            }

            bankDatabase[bankName][account] += balance;
        }

        foreach (var bank in bankDatabase.OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                                        .ThenByDescending(bank => bank.Value.Max(account => account.Value)))
        {
            var bankName = bank.Key;
            foreach (var bankAccount in bank.Value.OrderByDescending(account => account.Value))
            {
                var account = bankAccount.Key;
                var balance = bankAccount.Value;
                Console.WriteLine($"{account} -> {balance} ({bankName})");
            }
        }
    }
}
