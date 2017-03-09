using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int spaces = n - 1;
        int stars = 1;

        Console.WriteLine("{0}|{0}", new string(' ', n + 1));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1} | {1}{0}", new string(' ',spaces), new string('*', stars));
            spaces--;
            stars++;
        }
    }
}

