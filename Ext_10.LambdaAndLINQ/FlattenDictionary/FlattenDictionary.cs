namespace FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FlattenDictionary
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, string>> allItems = new Dictionary<string, Dictionary<string, string>>();
            List<string> flattenItems = new List<string>();

            var input = Console.ReadLine();
            var masterItem = string.Empty;

            while (input != "end")
            {
                var tokens = input.Split(' ');

                if (tokens[0] != "flatten")
                {
                    var primaryKey = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (!allItems.ContainsKey(primaryKey))
                    {
                        allItems[primaryKey] = new Dictionary<string, string>();
                    }

                    if (!allItems[primaryKey].ContainsKey(innerKey))
                    {
                        allItems[primaryKey].Add(innerKey, innerValue);
                    }
                    else
                    {
                        allItems[primaryKey][innerKey] = innerValue;
                    }
                }
                else
                {
                    masterItem = tokens[1];

                    foreach (var item in allItems)
                    {
                        if (item.Key == masterItem)
                        {
                            var innerTokens = item.Value;
                            foreach (var kvp in innerTokens)
                            {
                                flattenItems.Add(kvp.Key + kvp.Value);
                            }
                        }
                    }

                    allItems[masterItem].Clear();
                }

                input = Console.ReadLine();
            }

            foreach (var record in allItems.OrderByDescending(x => x.Key.Length))
            {
                var primaryKey = record.Key;
                var innerTokens = record.Value;
                var counter = 1;

                if (primaryKey != masterItem)
                {
                    Console.WriteLine(primaryKey);
                    PrintResult(innerTokens);
                }
                else
                {
                    Console.WriteLine(primaryKey);
                    counter = PrintResult(innerTokens);

                    foreach (var flattenItem in flattenItems)
                    {
                        Console.WriteLine($"{counter}. {flattenItem}");
                        counter++;
                    }
                }
            }
        }

        public static int PrintResult(Dictionary<string, string> dict)
        {
            var counter = 1;
            foreach (var kvp in dict.OrderBy(x => x.Key.Length))
            {
                Console.WriteLine($"{counter}. {kvp.Key} - {kvp.Value}");
                counter++;
            }

            return counter;
        }
    }
}
