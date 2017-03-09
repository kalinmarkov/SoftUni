using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerContainer = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();          
                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());
                if (!minerContainer.ContainsKey(resource))
                {
                    minerContainer[resource] = 0;
                }

                minerContainer[resource] += quantity;
                

            }

            foreach (var item in minerContainer)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
