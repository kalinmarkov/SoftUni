using System;

class ChangeTiles
{
    static void Main()
    {
        float saveMoney = float.Parse(Console.ReadLine());
        float widthFloor = float.Parse(Console.ReadLine());
        float lenghtFloor = float.Parse(Console.ReadLine());
        float lenghtOfTriangle = float.Parse(Console.ReadLine());
        float heightOfTriangle = float.Parse(Console.ReadLine());
        float pricePerTile = float.Parse(Console.ReadLine());
        float amountForMaster = float.Parse(Console.ReadLine());

        float floorArea = widthFloor * lenghtFloor;
        float tileArea = lenghtOfTriangle * heightOfTriangle / 2;
        double neededTiles = Math.Ceiling(floorArea / tileArea) + 5;
        double totalPrice = neededTiles * pricePerTile + amountForMaster;

        if (saveMoney >= totalPrice)
        {
            Console.WriteLine("{0:f2} lv left.", saveMoney - totalPrice);
        }
        else
        {
            Console.WriteLine("You'll need {0:f2} lv more.", totalPrice - saveMoney);
        }
    }
}

