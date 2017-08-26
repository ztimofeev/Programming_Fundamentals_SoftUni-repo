namespace DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main()
        {
            Dictionary<string, string> storedData = new Dictionary<string, string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var firstElement = tokens[0];
                var secondElement = tokens[1];

                if (!storedData.ContainsKey(firstElement))
                {
                    storedData[firstElement] = string.Empty;
                }

                storedData[firstElement] = secondElement;

                inputLine = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            Dictionary<string, string> unchanedValues = storedData
                .Where(s => s.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(s => s.Key, s => s.Value);

            Dictionary<string, string> changedValues = storedData
                .Where(s => s.Value == "null")
                .ToDictionary(s => s.Key, s => defaultValue);

            PrintResult(unchanedValues);
            PrintResult(changedValues);
        }

        public static void PrintResult(Dictionary<string, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
