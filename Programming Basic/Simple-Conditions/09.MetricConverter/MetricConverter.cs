using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var inputValue = double.Parse(Console.ReadLine());
            var inputMetricUnit = Console.ReadLine().ToLower();
            var outputMetricUnit = Console.ReadLine().ToLower();
            double result;

            if (inputMetricUnit == "m" && outputMetricUnit == "mm")
            {
                result = inputValue * 1000;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "m" && outputMetricUnit == "cm")
            {
                result = inputValue * 100;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "m" && outputMetricUnit == "m")
            {
                result = inputValue;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "m" && outputMetricUnit == "mi")
            {
                result = inputValue / 1609.34;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "m" && outputMetricUnit == "in")
            {
                result = inputValue * 39.3700787;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "m" && outputMetricUnit == "km")
            {
                result = inputValue / 1000;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "m" && outputMetricUnit == "ft")
            {
                result = inputValue / 0.3048;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "m" && outputMetricUnit == "yd")
            {
                result = inputValue * 1.0936;
                Console.WriteLine(result);
            }
            //     -------------------------------------------------------
            else if (inputMetricUnit == "mm" && outputMetricUnit == "mm")
            {
                result = inputValue;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mm" && outputMetricUnit == "m")
            {
                result = inputValue / 1000;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mm" && outputMetricUnit == "cm")
            {
                result = inputValue / 10;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mm" && outputMetricUnit == "mi")
            {
                result = inputValue * 0.00000062137;
                Console.WriteLine(result);
            }

            else if (inputMetricUnit == "mm" && outputMetricUnit == "in")
            {
                result = inputValue * 0.03937007;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mm" && outputMetricUnit == "km")
            {
                result = inputValue / 1000000;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mm" && outputMetricUnit == "ft")
            {
                result = inputValue * 0.0032808399;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mm" && outputMetricUnit == "yd")
            {
                result = inputValue * 0.0010936133;
                Console.WriteLine(result);
            }
            //          --------------------------------------------------------------
            else if (inputMetricUnit == "cm" && outputMetricUnit == "cm")
            {
                result = inputValue;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "cm" && outputMetricUnit == "m")
            {
                result = inputValue / 100;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "cm" && outputMetricUnit == "mm")
            {
                result = inputValue * 10;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "cm" && outputMetricUnit == "mi")
            {
                result = inputValue * 0.00000621371;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "cm" && outputMetricUnit == "in")
            {
                result = inputValue * 0.3937007;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "cm" && outputMetricUnit == "km")
            {
                result = inputValue / 100000;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "cm" && outputMetricUnit == "ft")
            {
                result = inputValue * 0.032808399;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "cm" && outputMetricUnit == "yd")
            {
                result = inputValue * 0.010936133;
                Console.WriteLine(result);
            }
            //      --------------------------------------------------------------------
            else if (inputMetricUnit == "mi" && outputMetricUnit == "mi")
            {
                result = inputValue;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mi" && outputMetricUnit == "mm")
            {
                result = inputValue * 1609344;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mi" && outputMetricUnit == "cm")
            {
                result = inputValue * 160934.4;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mi" && outputMetricUnit == "m")
            {
                result = inputValue * 1609.344;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mi" && outputMetricUnit == "km")
            {
                result = inputValue * 1.609344;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mi" && outputMetricUnit == "ft")
            {
                result = inputValue * 5280;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mi" && outputMetricUnit == "in")
            {
                result = inputValue * 63360;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "mi" && outputMetricUnit == "yd")
            {
                result = inputValue * 1760;
                Console.WriteLine(result);
            }
            //    ----------------------------------------------------------------------
            else if (inputMetricUnit == "km" && outputMetricUnit == "km")
            {
                result = inputValue;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "km" && outputMetricUnit == "mm")
            {
                result = inputValue * 1000000;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "km" && outputMetricUnit == "cm")
            {
                result = inputValue * 100000;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "km" && outputMetricUnit == "m")
            {
                result = inputValue * 1000;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "km" && outputMetricUnit == "mi")
            {
                result = inputValue * 0.621371192;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "km" && outputMetricUnit == "in")
            {
                result = inputValue * 39370.0787;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "km" && outputMetricUnit == "ft")
            {
                result = inputValue * 3280.8399;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "km" && outputMetricUnit == "yd")
            {
                result = inputValue * 1093.6133;
                Console.WriteLine(result);
            }
            //    --------------------------------------------------------------------------
            else if (inputMetricUnit == "in" && outputMetricUnit == "in")
            {
                result = inputValue;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "in" && outputMetricUnit == "mm")
            {
                result = inputValue * 25.4;
                Console.WriteLine(result);
            }

            else if (inputMetricUnit == "in" && outputMetricUnit == "cm")
            {
                result = inputValue * 2.54;
                Console.WriteLine(result);
            }

            else if (inputMetricUnit == "in" && outputMetricUnit == "m")
            {
                result = inputValue * 0.0254;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "in" && outputMetricUnit == "km")
            {
                result = inputValue * 0.0000254;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "in" && outputMetricUnit == "mi")
            {
                result = inputValue * 0.0000157828283;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "in" && outputMetricUnit == "ft")
            {
                result = inputValue * 0.08333333;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "in" && outputMetricUnit == "yd")
            {
                result = inputValue * 0.0277777;
                Console.WriteLine(result);
            }
            //     -------------------------------------------------------------------
            else if (inputMetricUnit == "ft" && outputMetricUnit == "ft")
            {
                result = inputValue;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "ft" && outputMetricUnit == "mm")
            {
                result = inputValue * 304.8;
                Console.WriteLine(result);
            }

            else if (inputMetricUnit == "ft" && outputMetricUnit == "cm")
            {
                result = inputValue * 30.48;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "ft" && outputMetricUnit == "m")
            {
                result = inputValue * 0.3048;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "ft" && outputMetricUnit == "km")
            {
                result = inputValue * 0.0003048;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "ft" && outputMetricUnit == "mi")
            {
                result = inputValue * 0.0001893939;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "ft" && outputMetricUnit == "in")
            {
                result = inputValue * 12;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "ft" && outputMetricUnit == "yd")
            {
                result = inputValue * 0.333333;
                Console.WriteLine(result);
            }
            //  ------------------------------------------------------------------------
            else if (inputMetricUnit == "yd" && outputMetricUnit == "yd")
            {
                result = inputValue;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "yd" && outputMetricUnit == "mm")
            {
                result = inputValue * 914.4;
                Console.WriteLine(result);
            }

            else if (inputMetricUnit == "yd" && outputMetricUnit == "cm")
            {
                result = inputValue * 91.44;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "yd" && outputMetricUnit == "m")
            {
                result = inputValue * 0.9144;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "yd" && outputMetricUnit == "km")
            {
                result = inputValue * 0.0009144;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "yd" && outputMetricUnit == "mi")
            {
                result = inputValue * 0.0005681818;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "yd" && outputMetricUnit == "in")
            {
                result = inputValue * 36;
                Console.WriteLine(result);
            }
            else if (inputMetricUnit == "yd" && outputMetricUnit == "ft")
            {
                result = inputValue * 3;
                Console.WriteLine(result);
            }
        }
    }
}
