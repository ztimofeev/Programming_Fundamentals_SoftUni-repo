namespace CubicsMessages
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class CubicsMessages
    {
        public static void Main()
        {
            var inputMessage = Console.ReadLine();

            while (inputMessage != "Over!")
            {
                int countLetters = int.Parse(Console.ReadLine());

                string pattern = @"^(\d+)([a-zA-Z]+)([^a-zA-Z]*)$";
                Regex regex = new Regex(pattern);

                Match matchedInput = regex.Match(inputMessage);

                string firstDigitsGroup = matchedInput.Groups[1].Value;
                string encryptedMessage = matchedInput.Groups[2].Value;
                string lastDigitsGroup = matchedInput.Groups[3].Value;

                if (encryptedMessage.Length == countLetters)
                {
                    string decryptedMessage = DecryptingMessage(encryptedMessage, firstDigitsGroup, lastDigitsGroup);
                    Console.WriteLine($"{encryptedMessage} == {decryptedMessage}");
                }

                inputMessage = Console.ReadLine();
            }
        }

        private static string DecryptingMessage(string encryptedMessage, string firstDigits, string lastDigits)
        {
            List<int> frontDigits = GetDigitsAsList(firstDigits);
            List<int> rearDigits = GetDigitsAsList(lastDigits);

            string message = "";

            foreach (var digit in frontDigits)
            {
                if (digit < encryptedMessage.Length)
                {
                    message += encryptedMessage[digit];
                }
                else
                {
                    message += " ";
                }
            }

            foreach (var digit in rearDigits)
            {
                if (digit < encryptedMessage.Length)
                {
                    message += encryptedMessage[digit];
                }
                else
                {
                    message += " ";
                }
            }

            return message;
        }

        private static List<int> GetDigitsAsList(string digits)
        {
            List<int> result = new List<int>();
            foreach (var digit in digits)
            {
                int number;
                if (int.TryParse(digit.ToString(), out number))
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }
}
