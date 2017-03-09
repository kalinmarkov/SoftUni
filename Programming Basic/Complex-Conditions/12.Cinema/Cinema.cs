using System;

class Program
{
    static void Main()
    {
        string projection = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        double price = 0;
        double result = 0;

        if (projection == "Premiere") price = 12.00;
        result = row * col * price;
        if (projection == "Normal") price = 7.50;
        result = row * col * price;
        if (projection == "Discount") price = 5.00;
        result = row * col * price;

        if (result > 0)
        {
            Console.WriteLine("{0:f2} leva", result);
        }
        else
        {
            Console.WriteLine("Error");
        }



    }
}

