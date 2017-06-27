namespace PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            bool result = true;

            if (number == 0 || number == 1)
            {
                result = false;
            }
            else
            {
                result = IsPrime(number);
            }

            Console.WriteLine(result);

        }

        public static bool IsPrime(long number)
        {
            bool isPrime = true;

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
