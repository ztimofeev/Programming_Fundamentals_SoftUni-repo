namespace English_Name_of_Last_Digit
{
    using System;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            Console.WriteLine(NumberToWord(number));
        }

        public static string NumberToWord(long num)
        {
            string[] digitsToWord = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var lastDigit = (int)Math.Abs(num % 10);
            string word = digitsToWord[lastDigit];

            return word;
        }
    }
}
