using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var users = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] lineArgs = Console.ReadLine().Split().ToArray();

                string username = lineArgs[1];
                string ipAddress = lineArgs[0];
                int duration = int.Parse(lineArgs[2]);

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new SortedDictionary<string, int>());
                }

                if (!users[username].ContainsKey(ipAddress))
                {
                    users[username].Add(ipAddress, 0);
                }

                users[username][ipAddress] += duration;
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{string.Join(", ", user.Value.Keys)}]");
            }
        }
    }
}
