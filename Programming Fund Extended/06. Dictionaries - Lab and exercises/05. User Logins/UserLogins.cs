using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UserLogins
{
    static void Main()
    {
        var usersInformation = new Dictionary<string, string>();

        var input = Console.ReadLine();
        while (input != "login")
        {
            var tokens = input.Split();
            var userName = tokens[0];
            var userPassword = tokens[tokens.Length - 1];

            usersInformation[userName] = userPassword;

            input = Console.ReadLine();
        }

        var count = 0;
        while (true)
        {
            input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            var tokens = input.Split();
            var userName = tokens[0];
            var userPassword = tokens[tokens.Length - 1];
            if (usersInformation.ContainsKey(userName))
            {
                if (usersInformation[userName] == userPassword)
                {
                    Console.WriteLine($"{userName}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{userName}: login failed");
                    count++;
                }
            }
            else
            {
                Console.WriteLine($"{userName}: login failed");
                count++;
            }
        }

        Console.WriteLine($"unsuccessful login attempts: {count}");
    }
}

