namespace Master_Number
{
    using System;

    public class MasterNumber
    {
        public static void Main()
        {
            var limit = int.Parse(Console.ReadLine());

            for (int i = 0; i <= limit; i++)
            {
                bool isPalindrome = CheckPalindrome(i);
                bool isSpecial = false;
                bool containsEvenDigit = CheckEvenDigit(i);

                if (isPalindrome)
                {
                    isSpecial = CheckIsSpecial(i);
                    if (isSpecial)
                    {
                        containsEvenDigit = CheckEvenDigit(i);
                        if (containsEvenDigit)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }

        public static bool CheckPalindrome(int num)
        {
            var numToStr = num.ToString();
            for (int i = 0; i < numToStr.Length / 2; i++)
            {
                if (numToStr[i] != numToStr[numToStr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckIsSpecial(int num)
        {
            var numToStr = num.ToString();
            int sumOfDigits = 0;
            foreach (var digit in numToStr)
            {

                sumOfDigits += (char)digit - '0';
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool CheckEvenDigit(int num)
        {
            var currentNumber = 0;
            while (num > 0)
            {
                currentNumber = num % 10;
                if (currentNumber % 2 == 0)
                {
                    return true;
                }
                num = num / 10;
            }
            return false;
        }
    }
}
