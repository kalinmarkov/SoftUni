using System;

class Fox
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outer = 1;
        int inner = (n * 2) - 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('*', outer), new string('-', inner));
            outer++;
            inner -= 2;
        }

        outer = n / 2;
        inner = n;

        for (int i = 0; i < n / 3; i++)
        {
            Console.WriteLine("|{0}\\{1}/{0}|", new string('*', outer), new string('*', inner));
            outer++;
            inner -= 2;
        }

        outer = 1;
        inner = (n * 2) - 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('-', outer), new string('*', inner));
            outer++;
            inner -= 2;
        }

    }
}
