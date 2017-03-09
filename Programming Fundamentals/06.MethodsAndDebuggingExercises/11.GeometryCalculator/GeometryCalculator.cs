using System;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main()
        {
            string figure = Console.ReadLine().ToLower();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", GetAreaOfTriangle(side, height));
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", GetAreaOfSquare(side));
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", GetAreaOfRectangle(width, height));

            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", GetAreaOfCircle(radius));
            }

        }

        public static double GetAreaOfTriangle(double side, double height)
        {
            double area = side * height / 2d;

            return area;
        }

        public static double GetAreaOfSquare(double side)
        {
            double area = side * side;

            return area;
        }

        public static double GetAreaOfRectangle(double width, double height)
        {
            double area = width * height;

            return area;
        }

        public static double GetAreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

    }
}
