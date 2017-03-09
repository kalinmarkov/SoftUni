using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {

            string birthDate = Console.ReadLine();
            string format = "dd-MM-yyyy";
    
            DateTime date = DateTime.ParseExact(birthDate, format, null);
            date = date.AddDays(280);
            Console.WriteLine("{0}", date.ToString(format));

        }
    }
}
