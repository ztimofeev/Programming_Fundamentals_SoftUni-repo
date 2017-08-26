using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            Regex regex = new Regex(@"\+359([ -])2\1\d{3}\1\d{4}\b");

            string phones = Console.ReadLine();

            MatchCollection phoneMatches = regex.Matches(phones);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
