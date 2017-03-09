using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.V2.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            string firstMetric = Console.ReadLine().ToLower();
            string secondMetric = Console.ReadLine().ToLower();

            decimal m = 1.0m;
            decimal mm = 1000.0m;
            decimal cm = 100.0m;
            decimal mi = 0.000621371192m;
            decimal inn = 39.3700787m;
            decimal km = 0.001m;
            decimal ft = 3.2808399m;
            decimal yd = 1.0936133m;

            if (firstMetric == "m")
            {
                num = num / m;
            }
            else if (firstMetric == "mm")
            {
                num = num / mm;
            }
            else if (firstMetric == "cm")
            {
                num = num / cm;
            }
            else if (firstMetric == "mi")
            {
                num = num / mi;
            }
            else if (firstMetric == "in")
            {
                num = num / inn;
            }
            else if (firstMetric == "km")
            {
                num = num / km;
            }
            else if (firstMetric == "ft")
            {
                num = num / ft;
            }
            else if (firstMetric == "yd")
            {
                num = num / yd;
            }


            if (secondMetric == "m")
            {
                num = num * m;
            }
            else if (secondMetric == "mm")
            {
                num = num * mm;
            }
            else if (secondMetric == "cm")
            {
                num = num * cm;
            }
            else if (secondMetric == "mi")
            {
                num = num * mi;
            }
            else if (secondMetric == "in")
            {
                num = num * inn;
            }
            else if (secondMetric == "km")
            {
                num = num * km;
            }
            else if (secondMetric == "ft")
            {
                num = num * ft;
            }
            else if (secondMetric == "yd")
            {
                num = num * yd;
            }
            Console.WriteLine("{0} {1}", num, secondMetric);

        }
    }
}
