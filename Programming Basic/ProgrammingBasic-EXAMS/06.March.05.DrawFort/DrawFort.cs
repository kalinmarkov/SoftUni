using System;

class DrawFort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int midSize = 2 * n - 2 * (n / 2) - 4;

        Console.WriteLine("/{0}\\{1}/{0}\\",
                         new string('^', (n / 2)),
                         new string('_', midSize));

        for (int i = 1; i <= n - 3; i++)
            Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));

        Console.WriteLine("|{0}{1}{0}|",
                          new string(' ', (n / 2) + 1),
                          new string('_', midSize));

        Console.WriteLine("\\{0}/{1}\\{0}/",
                          new string('_', (n / 2)),
                          new string(' ', midSize));
    }
}
