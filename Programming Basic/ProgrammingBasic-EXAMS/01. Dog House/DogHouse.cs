using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DogHouse
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        var sides = 2 * (a * (a / 2));
        var backSide = (a / 2) * (a / 2) + (a / 2 * (b - a / 2)) / 2;
        var entrance = (a / 5) * (a / 5);
        var frontSide = backSide - entrance;

        var totalAreaForSides = sides + backSide + frontSide;
        var greenPaint = totalAreaForSides / 3;

        var roofArea = a * (a / 2) * 2;
        var redPaint = roofArea / 5;

        Console.WriteLine($"{greenPaint:F2}");
        Console.WriteLine($"{redPaint:F2}");
    }
}

