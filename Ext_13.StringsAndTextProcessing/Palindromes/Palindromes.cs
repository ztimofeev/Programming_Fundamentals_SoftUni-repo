namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            char[] separators = new[] {' ', ',', '.', '!', '?'};
            string[] text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (var str in text)
            {
                if (IsPalindrome(str))
                {
                    palindromes.Add(str);
                }
            }

            palindromes = palindromes.Distinct().OrderBy(str => str).ToList();

            Console.WriteLine(string.Join(", ", palindromes));
        }

        public static bool IsPalindrome(string str)
        {
            var leftHalf = str.Substring(0, str.Length / 2);
            var temp = new string(str.Reverse().ToArray());
            var rightHalf = temp.Substring(0, str.Length / 2);

            if (leftHalf == rightHalf)
            {
                return true;
            }

            return false;
        }
    }
}
