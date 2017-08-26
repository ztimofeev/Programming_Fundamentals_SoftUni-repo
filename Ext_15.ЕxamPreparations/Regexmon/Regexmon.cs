using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    public class Regexmon
    {
        public static void Main()
        {
            Regex bojomon = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");
            Regex didimon = new Regex(@"[^a-zA-Z-]+");

            var input = Console.ReadLine();

            while (true)
            {
                if (didimon.IsMatch(input))
                {
                    Match matchedString = didimon.Match(input);
                    string currentMatch = matchedString.Value;

                    Console.WriteLine(currentMatch);

                    int indexOfMatch = input.IndexOf(currentMatch);
                    int matchLength = currentMatch.Length;
                    var len = matchLength + indexOfMatch;
                    input = input.Substring(len);
                }
                else
                {
                    break;
                }

                if (bojomon.IsMatch(input))
                {
                    Match matchedString = bojomon.Match(input);
                    string currentMatch = matchedString.Value;

                    Console.WriteLine(currentMatch);

                    int indexOfMatch = input.IndexOf(currentMatch);
                    int matchLength = currentMatch.Length;
                    var len = matchLength + indexOfMatch;
                    input = input.Substring(len);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
