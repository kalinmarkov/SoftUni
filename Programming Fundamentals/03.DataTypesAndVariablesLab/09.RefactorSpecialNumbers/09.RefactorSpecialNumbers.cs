using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        int newNum = 0;
        bool isSpecial = true;
        for (int i = 1; i <= num; i++)
        {
            newNum = i;
            while (newNum > 0)
            {
                sum += newNum % 10;
                newNum = newNum / 10;
            }

            isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{i} -> {isSpecial}");
            sum = 0;
            
        }

    }
}
