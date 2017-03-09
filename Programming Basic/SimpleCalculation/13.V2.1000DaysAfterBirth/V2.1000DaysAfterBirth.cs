using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.V2._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            DateTime outDate = inputDate.AddDays(999);

            Console.WriteLine("{0:dd-MM-yyyy}", outDate);
        }
    }
}
