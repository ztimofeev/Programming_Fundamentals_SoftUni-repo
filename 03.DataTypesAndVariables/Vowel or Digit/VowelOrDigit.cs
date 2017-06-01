namespace Vowel_or_Digit
{
    using System;

    public class VowelOrDigit
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var letter = input.ToLower();

            int num;
            if (int.TryParse(input, out num))
            {
                Console.WriteLine("digit");
            }

            else if (letter == "a" || letter == "o" || letter == "u" || letter == "e" || letter == "i" || letter == "y")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
