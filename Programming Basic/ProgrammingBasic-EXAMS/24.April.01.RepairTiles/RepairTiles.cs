using System;


class RepairTiles
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double tileA = double.Parse(Console.ReadLine());
        double tileB = double.Parse(Console.ReadLine());
        double benchA = double.Parse(Console.ReadLine());
        double benchB = double.Parse(Console.ReadLine());
        double area = a * a - benchA * benchB;
        double tileArea = tileA * tileB;
        double nesseseryTiles = area / tileArea;
        double time = nesseseryTiles * 0.2;

        Console.WriteLine(nesseseryTiles);
        Console.WriteLine(time); 


    }
}
