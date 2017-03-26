using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class RegisterUsers
{
    static void Main()
    {
        var userRegister = new Dictionary<string, DateTime>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var name = tokens[0];
            var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            userRegister[name] = date;

        }

        foreach (var user in userRegister.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value))
        {
            var username = user.Key;
            var date = user.Value;
            Console.WriteLine($"{username}");
        }
    }
}

