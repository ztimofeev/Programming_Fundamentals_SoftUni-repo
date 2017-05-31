namespace Refactor_Special_Numbers
{
    using System;

    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int digit = i;
                int sumOfDigits = 0;

                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit /= 10;
                }

                bool isSpecialNumber = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{i} -> {isSpecialNumber}");
            }
        }
    }
}
