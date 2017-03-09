using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BonusScore

{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score : ");
            var num = double.Parse(Console.ReadLine());
            var bonusScore = 0.0;

            if (num <= 100)
            {
                bonusScore = bonusScore + 5;
            }
            else if (num > 100 && num <= 999)
            {
                bonusScore = bonusScore + num * 0.20;
            }
            else if (num > 1000)
            {
                bonusScore = bonusScore + num * 0.10;
            }
            if (num % 2 == 0)
            {
                bonusScore = bonusScore + 1;
            }
            else if (num % 10 == 5)
            {
                bonusScore = bonusScore + 2;
            }

            Console.WriteLine("Bonus score : " + bonusScore);
            Console.WriteLine("Total score : " + (bonusScore + num));
        }
    }
}


