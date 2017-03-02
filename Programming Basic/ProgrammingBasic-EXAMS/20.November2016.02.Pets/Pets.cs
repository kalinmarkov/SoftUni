using System;

class Pets
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int food = int.Parse(Console.ReadLine());
        double foodForDog = double.Parse(Console.ReadLine());
        double foodForCat = double.Parse(Console.ReadLine());
        double foodForTurtle = double.Parse(Console.ReadLine()) / 1000;

        double DogNeededFood = days * foodForDog;
        double CatNeededFood = days * foodForCat;
        double TurtleNeededFood = days * foodForTurtle;
        double NeededFood = DogNeededFood + CatNeededFood + TurtleNeededFood;

        if (food >= NeededFood)
        {
            Console.WriteLine("{0} kilos of food left.", Math.Floor(food - NeededFood));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(NeededFood - food));
        }
    }
}

