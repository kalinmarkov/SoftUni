using System;

class FlowerShop
{
    static void Main()
    {
        int magnolii = int.Parse(Console.ReadLine());
        int ziumbiuli = int.Parse(Console.ReadLine());
        int rozi = int.Parse(Console.ReadLine());
        int kaktusi = int.Parse(Console.ReadLine());
        double giftPrice = double.Parse(Console.ReadLine());

        double magnoliiPrice = 3.25 * magnolii;
        double ziumbiuliPrice = 4.0 * ziumbiuli;
        double roziPrice = 3.5 * rozi;
        double kaktusPrice = 8.0 * kaktusi;
        double sum = magnoliiPrice + ziumbiuliPrice + roziPrice + kaktusPrice;
        sum -= sum * 0.05;

        if (sum >= giftPrice)
        {
            Console.WriteLine("She is left with {0:0} leva.", Math.Floor(sum - giftPrice));
        }
        else
        {
            Console.WriteLine("She will have to borrow {0:0} leva.", Math.Ceiling(giftPrice - sum));
        }
    }
}

