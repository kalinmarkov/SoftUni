using System;

class HousePrice
{
    static void Main()
    {
        double smallestRoomArea = double.Parse(Console.ReadLine());
        double kitchenArea = double.Parse(Console.ReadLine());
        double pricePerSquare = double.Parse(Console.ReadLine());

        double secondRoom = smallestRoomArea * 1.1;
        double thirdRoom = secondRoom * 1.1;
        double bathroom = smallestRoomArea / 2;
        double houseArea = (smallestRoomArea + secondRoom + thirdRoom + bathroom + kitchenArea) * 1.05;
        double totalPrice = houseArea * pricePerSquare;

        Console.WriteLine(smallestRoomArea);
        Console.WriteLine(secondRoom);
        Console.WriteLine(thirdRoom);
        Console.WriteLine(bathroom);
        Console.WriteLine(houseArea);
        Console.WriteLine("{0:f2}", totalPrice);
    }
}

