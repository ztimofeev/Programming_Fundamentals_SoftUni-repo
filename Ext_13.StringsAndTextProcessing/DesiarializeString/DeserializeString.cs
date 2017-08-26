using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DeserializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Dictionary<string, List<int>> lettersAndPositions = new Dictionary<string, List<int>>();
            var len = int.MinValue;

            while (input != "end")
            {
                var tokens = input.Split(':');
                var letter = tokens[0];
                List<int> positions = tokens[1].Split('/').Select(int.Parse).ToList();
                var maxValue = positions.OrderByDescending(x => x).First();

                if (len < maxValue)
                {
                    len = maxValue;
                }

                if (!lettersAndPositions.ContainsKey(letter))
                {
                    lettersAndPositions[letter] = positions;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i <= len; i++)
            {
                foreach (var record in lettersAndPositions)
                {
                    var letter = record.Key;
                    var positions = record.Value;

                    if (positions.Contains(i))
                    {
                        Console.Write(letter);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
