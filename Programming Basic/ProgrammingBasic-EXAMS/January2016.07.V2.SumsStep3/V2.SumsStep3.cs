using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            switch (i % 3)
            {
                case 0: sum1 += num; break;
                case 1: sum2 += num; break;
                case 2: sum3 += num; break;
            }
        }

        Console.WriteLine($"sum1 = {sum1}");
        Console.WriteLine($"sum2 = {sum2}");
        Console.WriteLine($"sum3 = {sum3}");
    }
}

