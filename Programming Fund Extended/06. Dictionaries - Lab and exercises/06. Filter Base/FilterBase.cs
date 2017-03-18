using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FilterBase
{
    static void Main()
    {
        var employeesAge = new Dictionary<string, int>();
        var employeesSalary = new Dictionary<string, double>();
        var employeesPosition = new Dictionary<string, string>();

        while (true)
        {
            var inputArgs = Console.ReadLine();
            if (inputArgs == "filter base")
            {
                break;
            }

            var tokens = inputArgs.Split();
            var name = tokens[0];
            var position = tokens[tokens.Length - 1];

            var age = 0;
            var salary = 0.0;
            if (int.TryParse(position, out age))
            {                
                employeesAge[name] = age;                
            }
            else if (double.TryParse(position, out salary))
            {
                employeesSalary[name] = salary;
            }
            else
            {
                employeesPosition[name] = position;
            }

        }

        var input = Console.ReadLine();
        switch (input)
        {
            case "Age":
                PrintEmployeesAge(employeesAge, input);
                break;
            case "Salary":
                PrintEmployeesSalary(employeesSalary, input);
                break;
            case "Position":
                PrintEmployeesPosition(employeesPosition, input);
                break;
        }
    }

    private static void PrintEmployeesAge(Dictionary<string, int> employeesAge, string input)
    {
        foreach (var pair in employeesAge)
        {
            var name = pair.Key;
            var data = pair.Value;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"{input}: {data}");
            Console.WriteLine($"====================");
        }
    }

    private static void PrintEmployeesSalary(Dictionary<string, double> employeesSalary, string input)
    {
        foreach (var pair in employeesSalary)
        {
            var name = pair.Key;
            var data = pair.Value;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"{input}: {data:F2}");
            Console.WriteLine($"====================");
        }
    }

    private static void PrintEmployeesPosition(Dictionary<string, string> employeesPosition, string input)
    {
        foreach (var pair in employeesPosition)
        {
            var name = pair.Key;
            var data = pair.Value;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"{input}: {data}");
            Console.WriteLine($"====================");
        }
    }
}

