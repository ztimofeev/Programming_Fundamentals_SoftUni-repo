using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            Regex pattern = new Regex(@"\b(0x)?[0-9A-F]+\b");

            string numbers = Console.ReadLine();

            MatchCollection matchedNumbers = pattern.Matches(numbers);

            List<string> matched = matchedNumbers
                .Cast<Match>()
                .Select(x => x.Value)
                .ToList();

            Console.WriteLine(string.Join(" ", matched));
        }
    }
}
