namespace MixedPhones
{
    using System;
    using System.Collections.Generic;

    public class MixedPhones
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

            while (inputLine != "Over")
            {
                var tokens = inputLine.Split();

                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                long number = 0;
                if (long.TryParse(firstElement, out number))
                {
                    firstElement = lastElement;
                    lastElement = number.ToString();
                }

                if (!phonebook.ContainsKey(firstElement))
                {
                    phonebook[firstElement] = long.Parse(lastElement);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in phonebook)
            {
                Console.WriteLine("${kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
