using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('%', 2 * n));

        if (n % 2 == 0)
        {
            for (int i = 1; i <= n -1; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine("%{0}**{0}%", new string(' ', (2 * n - 3) / 2));
                }
                else
                {
                Console.WriteLine("%{0}%", new string(' ', (2 * n - 2)));
                }

            }
        }
        else if (n % 2 != 0)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == n / 2 + 1)
                {
                    Console.WriteLine("%{0}**{0}%", new string(' ', (2 * n - 3) / 2));
                }
                else
                {
                Console.WriteLine("%{0}%", new string(' ', (2 * n - 2)));
                }

            }
        }

        Console.WriteLine(new string('%', 2 * n));

    }
}

