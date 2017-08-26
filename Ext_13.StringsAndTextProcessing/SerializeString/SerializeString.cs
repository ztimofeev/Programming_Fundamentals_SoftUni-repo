using System;
using System.Collections.Generic;

namespace SerializeString
{
    public class SerializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Dictionary<char, List<int>> letterPosition = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                if (!letterPosition.ContainsKey(input[i]))
                {
                    letterPosition[currentChar] = new List<int>();
                }

                letterPosition[currentChar].Add(i);
            }

            foreach (var record in letterPosition)
            {
                var letter = record.Key;
                var positions = record.Value;

                Console.WriteLine("{0}:{1}", letter, string.Join("/", positions));
            }
        }
    }
}
