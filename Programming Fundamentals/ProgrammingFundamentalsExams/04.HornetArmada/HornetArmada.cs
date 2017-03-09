using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Armada
{
    public long Activity { get; set; }
    public string Legion { get; set; }
    public string Soldier { get; set; }
    public long SoldierCount { get; set; }
}
    class HornetArmada
{
    static void Main()
    {
        
        var legions = new Dictionary<string, int>();
        var soldiers = new Dictionary<string, int>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            if (input == "Guards")
            {
               
                break;
            }
            var command = input.Split('\\');
            //if (command[1] == "Soldier")
            //{
            //    foreach (var pair in legions)
            //    {
            //        Console.WriteLine($"{pair.Value} -> {pair.Key}");
            //    }
            //    break;
            //}
            var tokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var arg1 = tokens[0].Split("=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var arg2 = tokens[1].Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var lastActivity = int.Parse(arg1[0].Trim());
            var legionName = arg1[1].Trim().ToString();
            var soldierType = arg2[0].Trim().ToString();
            var soldierCount = int.Parse(arg2[1].Trim());

            
            if (!legions.ContainsKey(legionName))
            {
                legions.Add(legionName, lastActivity);                

            }
            else
            {
                var max = int.MinValue;
                if (lastActivity > max)
                {
                    max = lastActivity;
                    legions[legionName] = lastActivity;
                }
            }

            if (!soldiers.ContainsKey(soldierType))
            {
                soldiers.Add(soldierType, soldierCount);
            }
            else
            {
                soldiers[soldierType] += soldierCount;
            }

        }
        foreach (var pair in legions.OrderByDescending(a => a.Value))
        {
            Console.WriteLine($"{pair.Value} -> {pair.Key}");
        }
    }
}

