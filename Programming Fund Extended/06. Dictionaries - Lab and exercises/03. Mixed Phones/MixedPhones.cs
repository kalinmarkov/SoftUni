using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MixedPhones
{
    static void Main()
    {
        var phonebook = new Dictionary<string, long>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "Over")
            {
                break;
            }

            var tokens = input.Trim().Split();
            var firstElement = tokens[0];
            var lastElement = tokens[tokens.Length - 1];
            long number = 0;

            if (long.TryParse(lastElement, out number))
            {
                var name = firstElement;
                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                phonebook[name] = number;

            }
            else if (long.TryParse(firstElement, out number))
            {
                var name = lastElement;
                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                phonebook[name] = number;

            }
        }

        foreach (var item in phonebook.OrderBy(x => x.Key))
        {
            var name = item.Key;
            var phoneNumber = item.Value;
            Console.WriteLine($"{name} -> {phoneNumber}");

        }
    }
}

