using System;

class Program
{
    static void Main()
    {
        double lenght = double.Parse(Console.ReadLine());
        string inputParam = Console.ReadLine();
        string outputParam = Console.ReadLine();

        double lenghtInMeters = lenght;
        if (inputParam == "mm")
        {
            lenghtInMeters = lenght / 1000;
        }
        else if (inputParam == "cm")
        {
            lenghtInMeters = lenght / 100;
        }
        else if (inputParam == "mi")
        {
            lenghtInMeters = lenght / 0.000621371192;
        }
        else if (inputParam == "inch")
        {
            lenghtInMeters = lenght / 39.3700787;
        }
        else if (inputParam == "km")
        {
            lenghtInMeters = lenght / 0.001;
        }
        else if (inputParam == "ft")
        {
            lenghtInMeters = lenght / 3.2808399;
        }
        else if (inputParam == "yd")
        {
            lenghtInMeters = lenght / 1.0936133;
        }


        double outputLenght = lenghtInMeters;
        if (inputParam == "mm")
        {
            outputLenght = lenghtInMeters * 1000;
        }
        else if (inputParam == "cm")
        {
            outputLenght = lenghtInMeters * 100;
        }
        else if (inputParam == "mi")
        {
            outputLenght = lenghtInMeters * 0.000621371192;
        }
        else if (inputParam == "inch")
        {
            outputLenght = lenghtInMeters * 39.3700787;
        }
        else if (inputParam == "km")
        {
            outputLenght = lenghtInMeters * 0.001;
        }
        else if (inputParam == "ft")
        {
            outputLenght = lenghtInMeters * 3.2808399;
        }
        else if (inputParam == "yd")
        {
            outputLenght = lenghtInMeters * 1.0936133;
        }
        Console.WriteLine(outputLenght);
    }
}

