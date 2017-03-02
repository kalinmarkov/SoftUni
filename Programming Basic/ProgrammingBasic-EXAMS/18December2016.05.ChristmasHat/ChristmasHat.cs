using System;

class ChristmasHat
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int dashes = 0;
        int dots = 2 * size - 1;

        Console.WriteLine("{0}/|\\{0}", new string('.', 2 * size - 1));
        Console.WriteLine("{0}\\|/{0}", new string('.', 2 * size - 1));

        for (int i = 0; i < 2 * size; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots), new string('-', dashes));
            dashes++;
            dots--;
        }

        Console.WriteLine(new string('*', 4 * size + 1));

        for (int i = 0; i < 2 * size; i++)
        {
            Console.Write('*');
            Console.Write('.');
        }

        Console.WriteLine('*');

        Console.WriteLine(new string('*', 4 * size + 1));
    }
}

