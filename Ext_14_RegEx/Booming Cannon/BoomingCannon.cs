using System;
using System.Collections.Generic;
using System.Linq;

namespace Booming_Cannon
{
    public class BoomingCannon
    {
        public static void Main()
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int distance = data[0];
            int shotRange = data[1];

            var inputString = Console.ReadLine();

            List<string> output = new List<string>();

            string startSubstring = inputString.Substring(0, 4);

            var splitedString = inputString.Split(new string[] {"\\<<<"}, StringSplitOptions.RemoveEmptyEntries).ToList();
           
            if (startSubstring != "\\<<<")
            {
                splitedString = splitedString.Skip(1).ToList();
            }

            foreach (var content in splitedString)
            {
                var word = ExtractContent(content, distance, shotRange);
                if (word != String.Empty)
                {
                    output.Add(word);
                }
            }

            Console.WriteLine(string.Join("/\\", output));
        }

        public static string ExtractContent(string content, int distance, int shotRange)
        {
            var end = Math.Min(distance + shotRange, content.Length);
            string str = "";

            for (int i = 0; i < end; i++)
            {
                if (i >= distance)
                {
                    str += content[i];
                }
            }

            return str;
        }
    }
}
