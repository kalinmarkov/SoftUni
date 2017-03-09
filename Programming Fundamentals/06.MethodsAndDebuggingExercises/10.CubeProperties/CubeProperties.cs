using System;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            if (parameter == "face")
            {
                PrdoubleFaceDiagonalsOfCube(side);
            }
            else if (parameter == "space")
            {
                PrdoubleSpaceDiagonalsOfCube(side);
            }
            else if (parameter == "volume")
            {
                PrdoubleVolumeOfCube(side);
            }
            else if (parameter == "area")
            {
                PrdoubleAreaOfCube(side);
            }

        }

        public static void PrdoubleFaceDiagonalsOfCube(double side)
        {
            double diagonal = Math.Sqrt(Math.Pow(side, 2) * 2);

            Console.WriteLine("{0:f2}", diagonal); ;

        }

        public static void PrdoubleSpaceDiagonalsOfCube(double side)
        {
            double spaceDiagonal = Math.Sqrt(Math.Pow(side, 2) * 3);

            Console.WriteLine("{0:f2}", spaceDiagonal); ;

        }

        public static void PrdoubleVolumeOfCube(double side)
        {
            double volume = Math.Pow(side, 3);

            Console.WriteLine("{0:f2}", volume); ;
        }

        public static void PrdoubleAreaOfCube(double side)
        {
            double area = 6 * Math.Pow(side, 2);

            Console.WriteLine("{0:f2}", area); ;
        }

    }
}
