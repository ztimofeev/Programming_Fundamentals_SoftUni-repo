namespace Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            string numStr = factorial.ToString();
            var countZeros = 0;

            for (int i = numStr.Length - 1; i > 0; i--)
            {
                if (numStr[i] == '0')
                {
                    countZeros++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(countZeros);
        }
    }
}
