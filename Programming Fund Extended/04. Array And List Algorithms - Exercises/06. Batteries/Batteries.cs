using System;
using System.Linq;
using System.Text;

class Batteries
{
    static void Main()
    {
        var batteriesCapacities = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var hoursToTest = int.Parse(Console.ReadLine());

        var result = new StringBuilder();

        for (int i = 0; i < batteriesCapacities.Length; i++)
        {
            var capacity = batteriesCapacities[i];
            var batteryUsagePerHour = usagePerHour[i];

            var mAh = capacity - (batteryUsagePerHour * hoursToTest);

            if (mAh > 0)
            {
                result.AppendLine($"Battery {i + 1}: {mAh:f2} mAh ({(mAh * 100.0) / capacity:f2})%");
            }
            else
            {

                result.AppendLine($"Battery {i + 1}: dead (lasted {Math.Ceiling(capacity / batteryUsagePerHour)} hours)");
            }
        }

        Console.Write(result);
    }
}

