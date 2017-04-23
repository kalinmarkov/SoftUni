using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    public string BankName { get; set; }

    public string AccountName { get; set; }

    public decimal Balance { get; set; }
}

class OptimizedBankingSystem
{
    static void Main()
    {
        var bankAccounts = new List<BankAccount>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split(" |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var bankName = tokens[0];
            var accountName = tokens[1];
            var balance = decimal.Parse(tokens[2]);

            if (!bankAccounts.Any(x => x.AccountName == accountName && x.BankName == bankName))
            {
                var newBankAccount = new BankAccount()
                {
                    BankName = bankName,
                    AccountName = accountName,
                    Balance = balance
                };

                bankAccounts.Add(newBankAccount);
            }
            else
            {
                bankAccounts.Where(a => a.BankName == bankName).First().Balance += balance;
            }
        }

        bankAccounts = bankAccounts
             .OrderByDescending(x => x.Balance)
             .ThenBy(x => x.BankName.Length)
             .ToList();

        foreach (var account in bankAccounts)
        {
            Console.WriteLine($"{account.AccountName} -> {account.Balance} ({account.BankName})");
        }
    }
}

