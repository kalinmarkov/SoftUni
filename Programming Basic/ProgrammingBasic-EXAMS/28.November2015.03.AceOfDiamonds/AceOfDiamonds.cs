using System;

class AceOfDiamonds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dashes = (n - 2) / 2;
        int at = 1;
        Console.WriteLine("{0}", new string('*', n));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*", new string('-', dashes), new string('@', at));
            dashes--;
            at += 2;
        }
        dashes++;
        at -= 2;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            dashes++;
            at -= 2;
            Console.WriteLine("*{0}{1}{0}*", new string('-', dashes), new string('@', at));
        }

        Console.WriteLine("{0}", new string('*', n));

    }
}

