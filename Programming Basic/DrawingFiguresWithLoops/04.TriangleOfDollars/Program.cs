using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string dollar = "$";

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(dollar);
            dollar += " $";
        }
    }
}

