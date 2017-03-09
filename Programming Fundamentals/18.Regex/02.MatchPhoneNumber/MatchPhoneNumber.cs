using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var pattern = @"\+\d{3}(\s|-)\d{1}\1\d{3}\1\d{4}(?!\d)";
            var input = Console.ReadLine();
            var reg = new Regex(pattern);

            var matches = reg.Matches(input);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
