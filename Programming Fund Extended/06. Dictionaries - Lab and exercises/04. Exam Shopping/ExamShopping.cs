using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var products = new Dictionary<string, int>();

        var input = Console.ReadLine();
        while (input != "shopping time")
        {
            var tokens = input.Split();
            var command = tokens[0];
            var product = tokens[1];
            var quantity = int.Parse(tokens[2]);
            if (!products.ContainsKey(product))
            {
                products[product] = 0;
            }
            products[product] += quantity;
            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input != "exam time")
        {
            
            var tokens = input.Split();
            var command = tokens[0];
            var product = tokens[1];

                    
            if (tokens.Length > 2)
            {
                var quantity = int.Parse(tokens[2]);


                if (!products.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (products[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        products[product] -= quantity;
                        if (products[product] < 0)
                        {
                            products[product] = 0;
                        }
                    }
                }
            }

            input = Console.ReadLine();
        }

        foreach (var item in products)
        {
            var product = item.Key;
            var quantity = item.Value;
            if (quantity > 0)
            {
                Console.WriteLine($"{product} -> {quantity}");
            }
        }
    }
}

