using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Cat
{
    public string Name { get; set; }

    public int Age { get; set; }
}

class ReplaceATag
{
    static void Main(string[] args)
    {
        var cats = new List<Cat>
        {
            new Cat { Name = "A", Age = 1 },
            new Cat { Name = "B", Age = 3 },
            new Cat { Name = "C", Age = 3 },
            new Cat { Name = "D", Age = 1 }
        };

        var groupedCats = cats.GroupBy(c => c.Age);

        foreach (var group in groupedCats)
        {
            Console.WriteLine(group.Key);

            foreach (var cat in group)
            {
                Console.WriteLine($"--{cat.Name}");
            }
        }

    }
}

