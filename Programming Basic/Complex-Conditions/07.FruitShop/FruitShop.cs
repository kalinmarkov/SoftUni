using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
           
                var fruit = Console.ReadLine().ToLower();
                var day = Console.ReadLine();
                var quantity = double.Parse(Console.ReadLine());

                if (fruit == "banana")
                {
                    if (day == "Monday" ||
                        day == "Tuesday" ||
                        day == "Wednesday" ||
                        day == "Thursday" ||
                        day == "Friday")
                    {
                        Console.WriteLine(Math.Round((quantity * 2.50), 2));
                    }
                    else if (day == "Saturday" ||
                             day == "Sunday" )
                    {
                        Console.WriteLine(Math.Round((quantity * 2.70), 2));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                // -----------------------------------------------------------------------------
                else if (fruit == "apple")
                {
                    if (day == "Monday" ||
                        day == "Tuesday" ||
                        day == "Wednesday" ||
                        day == "Thursday" ||
                        day == "Friday")
                    {
                        Console.WriteLine(Math.Round((quantity * 1.20), 2));
                    }
                    else if (day == "Saturday" ||
                             day == "Sunday")
                    {
                        Console.WriteLine(Math.Round((quantity * 1.25), 2));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
            }
                // -------------------------------------------------------------------------------
                else if (fruit == "orange")
                {
                    if (day == "Monday" ||
                        day == "Tuesday" ||
                        day == "Wednesday" ||
                        day == "Thursday" ||
                        day == "Friday")
                    {
                        Console.WriteLine(Math.Round((quantity * 0.85), 2));
                    }
                    else if (day == "Saturday" ||
                             day == "Sunday")
                    {
                        Console.WriteLine(Math.Round((quantity * 0.90), 2));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
            }
                //---------------------------------------------------------------------------------
                else if (fruit == "grapefruit")
                {
                    if (day == "Monday" ||
                        day == "Tuesday" ||
                        day == "Wednesday" ||
                        day == "Thursday" ||
                        day == "Friday")
                    {
                        Console.WriteLine(Math.Round((quantity * 1.45), 2));
                    }
                    else if (day == "Saturday" ||
                             day == "Sunday")
                    {
                        Console.WriteLine(Math.Round((quantity * 1.60), 2));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
            }
                // ----------------------------------------------------------------------------------
                else if (fruit == "kiwi")
                {
                    if (day == "Monday" ||
                        day == "Tuesday" ||
                        day == "Wednesday" ||
                        day == "Thursday" ||
                        day == "Friday")
                    {
                        Console.WriteLine(Math.Round((quantity * 2.70), 2));
                    }
                    else if (day == "Saturday" ||
                             day == "Sunday")
                    {
                        Console.WriteLine(Math.Round((quantity * 3.00), 2));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
            }
                // --------------------------------------------------------------------------------------
                else if (fruit == "pineapple")
                {
                    if (day == "Monday" ||
                        day == "Tuesday" ||
                        day == "Wednesday" ||
                        day == "Thursday" ||
                        day == "Friday")
                    {
                        Console.WriteLine(Math.Round((quantity * 5.50), 2));
                    }
                    else if (day == "Saturday" ||
                             day == "Sunday")
                    {
                        Console.WriteLine(Math.Round((quantity * 5.60), 2));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
            }
                // ------------------------------------------------------------------------------------
                else if (fruit == "grapes")
                {
                    if (day == "Monday" ||
                        day == "Tuesday" ||
                        day == "Wednesday" ||
                        day == "Thursday" ||
                        day == "Friday")
                    {
                        Console.WriteLine(Math.Round((quantity * 3.85), 2));
                    }
                    else if (day == "Saturday" ||
                             day == "Sunday")
                    {
                        Console.WriteLine(Math.Round((quantity * 4.20), 2));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
          
        }
    }
}
