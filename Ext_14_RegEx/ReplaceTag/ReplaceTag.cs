using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReplaceTag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            string pattern = @"<a.+?href=(.+?)>(.+?)<\/a>";

            Regex regex = new Regex(pattern);
            List<string> output = new List<string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var replacement = "[URL href=$1]$2[/URL]";

                inputLine = regex.Replace(inputLine, replacement);

                output.Add(inputLine);

                inputLine = Console.ReadLine();
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
