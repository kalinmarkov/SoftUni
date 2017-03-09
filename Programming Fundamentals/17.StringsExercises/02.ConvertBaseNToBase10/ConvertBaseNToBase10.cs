using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertBaseNToBase10
{
    class ConvertBaseNToBase10
    {
        static void Main()
        {
            var inputNums = Console.ReadLine().Split().ToArray();
            var baseNum = int.Parse(inputNums[0]);
            var numsToConvert = BigInteger.Parse(inputNums[1]);

            var sum = new BigInteger();
            var counter = 0;
            while (numsToConvert != 0)
            {
                var lastDigit = numsToConvert % 10;
                var num = BigInteger.Multiply(lastDigit, BigInteger.Pow(baseNum, counter));
                sum += num;
                numsToConvert /= 10;
                counter++;
            }

            Console.WriteLine(sum);
        }
    }
}
