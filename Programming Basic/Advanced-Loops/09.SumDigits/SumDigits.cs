using System;

class SumDigits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int newN = 0;
        int sum = 0;

        while (n != 0)
        {
            int oldN = newN;
            newN = n % 10;
            sum += newN;
            n = n / 10;
        }

        Console.WriteLine(sum);
    }
}

