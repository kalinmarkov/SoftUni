using System;

class Axe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int left = 3 * n;
        int inner = 0;
        int right = 2 * n - 2;

        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("{0}*{1}*{2}", new string('-', left), new string('-', inner), new string('-', right));
            inner++;
            right--;
        }

        for (int i = 0; i < n / 2; i++)
        {
            inner = n - 1;
            right = n - 1;
            Console.WriteLine("{0}*{1}*{2}", new string('*', left), new string('-', inner), new string('-', right));
        }

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', left), new string('-', inner), new string('-', right));
            left--;
            inner += 2;
            right--;
        }

        Console.WriteLine("{0}*{1}*{2}", new string('-', left), new string('*', inner), new string('-', right));
    }
}

