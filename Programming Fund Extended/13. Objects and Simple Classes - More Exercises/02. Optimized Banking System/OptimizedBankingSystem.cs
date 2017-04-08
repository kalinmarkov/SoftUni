using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    public string BankName { get; set; }

    public string AccountName { get; set; }

    public List<decimal> Balance { get; set; }
}

class OptimizedBankingSystem
{
    static void Main()
    {
        //  60/100

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
            var balance = new List<decimal>();
            balance.Add(decimal.Parse(tokens[2]));

            var newBankAccount = new BankAccount()
            {
                BankName = bankName,
                AccountName = accountName,
                Balance = balance
            };

            bankAccounts.Add(newBankAccount);
        }

        foreach (var bank in bankAccounts.OrderByDescending(x => x.Balance.Sum()))
        {
            var accountName = bank.AccountName;
            var bankName = bank.BankName;
            var balance = bank.Balance;

            Console.WriteLine($"{accountName} -> {balance} ({bankName})");
        }
    }
}

