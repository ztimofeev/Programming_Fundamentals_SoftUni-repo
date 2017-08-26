using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUniMessages
{
    public class SoftUniMessages
    {
        public static void Main()
        {
            Regex messagePattern = new Regex(@"^\d+(?<message>[A-Za-z]+)[^A-Za-z]+$");

            string input = Console.ReadLine();

            while (input != "Decrypt!")
            {
                int messageLenght = int.Parse(Console.ReadLine());

                if (messagePattern.IsMatch(input))
                {
                    Match match = messagePattern.Match(input);
                    string message = match.Groups["message"].Value;

                    if (message.Length == messageLenght)
                    {
                        string decryptedMessage = DecryptingText(input, message);
                        Console.WriteLine($"{message} = {decryptedMessage}");
                    }
                }

                input = Console.ReadLine();
            }
        }

        public static string DecryptingText(string input, string message)
        {
            Regex digits = new Regex(@"\d");
            var matchedDigits = digits.Matches(input);
            var arrOfDigits = matchedDigits
                .Cast<Match>()
                .Select(x => int.Parse(x.Value))
                .ToArray();

            string output = "";

            foreach (var digit in arrOfDigits)
            {
                if (digit < message.Length)
                {
                    output += message[digit];
                }
            }

            return output;
        }
    }
}
