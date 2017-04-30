using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]+)?$";

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "Over!")
            {
                break;
            }

            var match = Regex.Match(input, pattern);

            if (!match.Success)
            {
                continue;
            }

            var messageLength = int.Parse(Console.ReadLine());

            var message = match.Groups["message"].Value;

            if (message.Length != messageLength)
            {
                continue;
            }

            var leftPart = match.Groups["leftPart"].Value;
            var rightPart = match.Groups["rightPart"].Value;

            var verificationCode = string.Empty;

            var varificationIndices = leftPart + rightPart;

            foreach (var @char in varificationIndices)
            {
                var index = 0;
                var isDigit = int.TryParse(@char.ToString(), out index);
                var isValidIndex = index >= 0 && index < message.Length;

                if (isDigit && isValidIndex)
                {
                    var messageChar = message[index];
                    verificationCode += messageChar;
                }
                else
                {
                    verificationCode += " ";
                }

            }

            Console.WriteLine($"{message} == {verificationCode}");
        }
    }
}

