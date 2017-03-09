using System;

class Program
{
    static void Main()
    {
        double lenght, width, height, v = 0;
        Console.Write("Length: ");
        lenght = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine());
        v = (lenght * width * height) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", v);

    }
}

