using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    public class MatchFullName
    {
        public static void Main()
        {
            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection matchedNames = pattern.Matches(names);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
