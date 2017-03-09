using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Number0._._._100toText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int tens = num / 10;
            int ones = num % 10;

            string numberAsWord = "";

            if (num < 0 || 100 < num)
            {
                numberAsWord = "invalid number";
            }
            if (num == 0)
            {
                numberAsWord = "zero";
            }
            if (num == 10)
            {
                numberAsWord = "ten";
            }

            if (num == 11)
            {
                numberAsWord = "eleven";
            }
            if (num == 12)
            {
                numberAsWord = "twelve";
            }
            if (num == 13)
            {
                numberAsWord = "thirteen";
            }
            if (num == 14)
            {
                numberAsWord = "fourteen";
            }
            if (num == 15)
            {
                numberAsWord = "fifteen";
            }
            if (num == 16)
            {
                numberAsWord = "sixteen";
            }
            if (num == 17)
            {
                numberAsWord = "seventeen";
            }
            if (num == 18)
            {
                numberAsWord = "eighteen";
            }
            if (num == 19)
            {
                numberAsWord = "nineteen";
            }

            if (numberAsWord != "")
            {
                Console.WriteLine(numberAsWord);
                return;
            }


            if (tens == 2)
            {
                numberAsWord = "twenty";
            }
            if (tens == 3)
            {
                numberAsWord = "thirty";
            }
            if (tens == 4)
            {
                numberAsWord = "fourty";
            }
            if (tens == 5)
            {
                numberAsWord = "fifty";
            }
            if (tens == 6)
            {
                numberAsWord = "sixty";
            }
            if (tens == 7)
            {
                numberAsWord = "seventy";
            }
            if (tens == 8)
            {
                numberAsWord = "eighty";
            }
            if (tens == 9)
            {
                numberAsWord = "ninety";
            }

            
            if (ones == 1)
            {
                numberAsWord += " one";
            }
            if (ones == 2)
            {
                numberAsWord += " two";
            }
            if (ones == 3)
            {
                numberAsWord += " three";
            }
            if (ones == 4)
            {
                numberAsWord += " four";
            }
            if (ones == 5)
            {
                numberAsWord += " five";
            }
            if (ones == 6)
            {
                numberAsWord += " six";
            }
            if (ones == 7)
            {
                numberAsWord += " seven";
            }
            if (ones == 8)
            {
                numberAsWord += " eight";
            }
            if (ones == 9)
            {
                numberAsWord += " nine";
            }

            if (num == 100)
            {
                numberAsWord = "one hundred";
            }
            
            Console.WriteLine(numberAsWord.Trim());

        }
    }
}
