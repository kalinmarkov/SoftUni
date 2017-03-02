using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outer = n;
        int inner = 3 * n - 2;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outer), new string('*', inner));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outer), new string('.', inner));
            }

            outer--;
            inner += 2;
        }

        Console.WriteLine(new string('*', 5 * n));

        int loops = 2 * n + 1;
        for (int i = 0; i < loops; i++)
        {
            outer++;
            inner -= 2;
            if (i < loops - 1)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outer), new string('.', inner));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outer), new string('*', inner));
            }

        }
    }
}

