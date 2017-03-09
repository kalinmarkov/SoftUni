using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.October2016._01.CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int lenghtOfMarathon = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int averageNumberOfLabsPerRunner = int.Parse(Console.ReadLine());
            int lenghtOfTrack = int.Parse(Console.ReadLine());
            int capacityOfTrack = int.Parse(Console.ReadLine());
            double amountOfMoneyPerKilometer = double.Parse(Console.ReadLine());

            if (capacityOfTrack * lenghtOfMarathon < numberOfRunners)
            {
                numberOfRunners = capacityOfTrack * lenghtOfMarathon;
            }

            double totalMeters = numberOfRunners * averageNumberOfLabsPerRunner * lenghtOfTrack;
            double totalKilometers = totalMeters / 1000;
            double raisedMoney = totalKilometers * amountOfMoneyPerKilometer;

            Console.WriteLine($"Money raised: {raisedMoney}");
        }
    }
}
