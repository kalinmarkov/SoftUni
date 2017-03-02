using System;

class Rocket
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outer = (3 * n - 2) / 2;
        int inner = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}", new string('.', outer), new string(' ', inner));
            outer--;
            inner += 2;
        }

        outer++;
        Console.WriteLine("{0}{1}{0}", new string('.', outer), new string('*', inner));

        inner -= 2;

        for (int i = 0; i < 2 * n; i++)
        {
            Console.WriteLine("{0}|{1}|{0}", new string('.', outer), new string('\\', inner));
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}", new string('.', outer), new string('*', inner));
            outer--;
            inner += 2;
        }
    }
}

