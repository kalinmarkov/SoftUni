using System;

class Program
{
    static void Main()
    {
        int bitcoin = int.Parse(Console.ReadLine());
        double uan = double.Parse(Console.ReadLine());
        double commission = double.Parse(Console.ReadLine());
        double euro = 0.00;
        double dollar = 1.76;
        double leva = (bitcoin * 1168) + (uan * 0.15 * dollar);
        euro = leva / 1.95;

        Console.WriteLine(euro - (euro * commission / 100.00));        
    }
}

