using System;

class FallenInLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int wave = 1;
        int outer = (n * 2) - 2;
        int inner = 2;

        Console.WriteLine("##{0}##{0}##", new string('.', n * 2));
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', wave),
                                                       new string('.', outer),
                                                       new string('.', inner));
            wave++;
            inner += 2;
            outer -= 2;
        }

        outer = 1;
        wave=n;
        inner = 2 * n;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', outer),
                                                      new string('~', wave),
                                                      new string('.', inner));
            wave--;
            inner -= 2;
            outer += 2;
        }

        Console.WriteLine("{0}####{0}", new string('.', (n * 2) + 1));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}##{0}", new string('.', (n * 2) + 2));
        }
    }
}

