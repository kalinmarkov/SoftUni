using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double result = 0.0;

        if (year == "normal")
        {
            result = (48 - h) * 3.0 / 4 + h + p * 2.0 / 3;
            Console.WriteLine(Math.Truncate(result));
        }
        else if (year == "leap")
        {
            result = ((48 - h) * 3.0 / 4 + h + p * 2.0 / 3) + ((48 - h) * 3.0 / 4 + h + p * 2.0 / 3) * 0.15;
            Console.WriteLine(Math.Truncate(result));
        }
        else if (result <= 0)
        {
            Console.WriteLine("error");
        }
    }
}

