using System;

namespace _12.RectangleProperties
{
    public class RectangleProperties
    {
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            
            double perimeter = 2 * height + 2 * width;
            double area = height * width;
            double diagonal = Math.Sqrt((height * height) + (width * width));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
