
using System;

class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outer = (3 * n - 3) / 2 + 1;
        int inner = 1;

        Console.WriteLine("{0}*{0}", new string('.', outer));
        for (int i = 0; i < n / 2 + 1; i++)
        {
            outer -= 1;
            Console.WriteLine("{0}*{1}*{0}", new string('.', outer), new string('.', inner));
            inner += 2;
        }

        outer ++;
        
        for (int i = 0; i < n / 2; i++)
        {
            outer -= 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.', outer), new string('.', inner));
            inner += 4;
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('.', n - 2), new string('.', n));

        inner = 1;
        outer = n - 2;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            outer -= 2;
            Console.WriteLine("*{2}*{1}*{0}*{1}*{2}*", new string('.', n), new string('.', inner), new string('.', outer));
            inner += 2;
        }

        inner = n;
        outer = n - 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outer), new string('.', inner));
            outer -= 1;
            inner += 2;
        }

        Console.WriteLine(new string('*', 3 * n));
    }
}

