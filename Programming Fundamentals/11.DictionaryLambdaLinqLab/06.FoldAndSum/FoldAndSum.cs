using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = nums.Length / 4;

            var leftRow = nums.Take(k).Reverse();
            var rightRow = nums.Reverse().Take(k);
            int[] rowOne = leftRow.Concat(rightRow).ToArray();
            int[] rowTwo = nums.Skip(k).Take(2 * k).ToArray();

            var sumNums = rowOne.Select((x, index) => x + rowTwo[index]);

            Console.WriteLine(string.Join(" ", sumNums));

        }
    }
}
