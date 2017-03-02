using System;

class HungryGarfield
{
    static void Main()
    {
        decimal moneyInDollars = decimal.Parse(Console.ReadLine());
        decimal dollarExchangeRate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
        decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
        decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

        decimal moneyForFood = (pizzaPrice / dollarExchangeRate * pizzaQuantity +
                              lasagnaPrice / dollarExchangeRate * lasagnaQuantity +
                              sandwichPrice / dollarExchangeRate * sandwichQuantity);
        decimal result = Math.Abs(moneyInDollars - moneyForFood);

        if (moneyForFood <= moneyInDollars)
        {
            Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${result:f2}.");
        }
        else
        {
            Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${result:f2}.");
        }
    }
}

