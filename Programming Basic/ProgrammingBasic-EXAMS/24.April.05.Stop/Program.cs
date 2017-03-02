using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outer = n + 1;
        int inner = 2 * n - 3;

        Console.WriteLine("{0}__{1}__{0}", new string('.', outer), new string('5', inner));

        for (int i = 0; i < n; i++)
        {
            outer -= 1;
            inner += 2;
            Console.WriteLine("{0}//{1}\\\\{0}", new string('.', outer), new string('_', inner));
            if (i == n - 1)
            {
                Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (n * 2 - 3)));
            }
        }

        outer = 0;
        inner = 4 * n - 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\\\{1}//{0}", new string('.', outer), new string('_', inner));
            outer += 1;
            inner -= 2;
        }
    }
}

