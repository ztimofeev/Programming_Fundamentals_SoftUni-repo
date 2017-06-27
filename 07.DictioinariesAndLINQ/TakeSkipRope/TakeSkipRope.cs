namespace TakeSkipRope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TakeSkipRope
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var digits = input.Where(x => char.IsDigit(x))
                .Select(x => int.Parse(x.ToString()))
                .ToList();

            var nonDigitsText = input.Where(l => ! char.IsDigit(l)).ToList();
            var textToString = String.Empty;

            foreach (var symbol in nonDigitsText)
            {
                textToString += symbol;
            }

            List<int> skipList = new List<int>();
            List<int> takeList = new List<int>();

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 1)
                {
                    skipList.Add(digits[i]);
                }
                else
                {
                    takeList.Add(digits[i]);
                }
            }

            string decriptedText = String.Empty;
            var startIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                var skipNumber = skipList[i];
                var takeNumber = takeList[i];

                if (textToString.Length < startIndex + takeNumber)
                {
                    takeNumber = textToString.Length - startIndex;
                }
                
                var substring = textToString.Substring(startIndex, takeNumber);
                decriptedText += substring;

                startIndex += skipNumber + takeNumber;
            }

            Console.WriteLine(decriptedText);
        }
    }
}
