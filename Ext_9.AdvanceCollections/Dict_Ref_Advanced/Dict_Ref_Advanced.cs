namespace Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dict_Ref_Advanced
    {
        public static void Main()
        {
            Dictionary<string, List<int>> result = new Dictionary<string, List<int>>();

            var inputData = Console.ReadLine();

            while (inputData != "end")
            {
                var inputTokens = inputData.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var firstElement = inputTokens[0];
                var secondElement = inputTokens[1];

                if (IsName(secondElement))
                {
                    if (result.ContainsKey(secondElement))
                    {
                        List<int> secondValues = result[secondElement];

                        if (! result.ContainsKey(firstElement))
                        {
                            result.Add(firstElement, new List<int>());
                        }

                        result[firstElement].Clear();
                        result[firstElement].AddRange(secondValues);
                    }
                }
                else
                {
                    var numbers = secondElement
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                    if (!result.ContainsKey(firstElement))
                    {
                        result[firstElement] = new List<int>();
                    }

                    result[firstElement].AddRange(numbers);
                }
                
                inputData = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
            }
        }

        public static bool IsName(string input)
        {
            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
