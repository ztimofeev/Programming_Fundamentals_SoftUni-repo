namespace Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pyramidic
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<string> allStrings = new List<string>();

            for (int i = 0; i < number; i++)
            {
                allStrings.Add(Console.ReadLine());
            }

            List<string> allPyramids = new List<string>();

            for (int i = 0; i < allStrings.Count; i++)
            {
                string currentLine = allStrings[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char symbol = currentLine[j];
                    string pyramid = FindPyramid(allStrings, symbol, i);
                    allPyramids.Add(pyramid);
                }   
            }

            string biggestPyramid = allPyramids
                                        .OrderByDescending(x => x.Length)
                                        .First();

            Console.WriteLine(biggestPyramid);
        }

        public static string FindPyramid(List<string> lines, char symbol, int numberLine)
        {
            int count = 3;
            string pyramid = "" + symbol + Environment.NewLine;

            for (int i = numberLine + 1; i < lines.Count; i++)
            {
                string pattern = new string(symbol, count);

                if (lines[i].Contains(pattern))
                {
                    pyramid += pattern + Environment.NewLine;
                    count += 2;
                }
                else
                {
                    return pyramid;
                }
            }

            return pyramid;
        }
    }
}
