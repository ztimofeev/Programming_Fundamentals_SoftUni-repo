namespace Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            var start = long.Parse(Console.ReadLine());
            var end = long.Parse(Console.ReadLine());

            var primeNumbers = IsPrime(start, end);

            Console.WriteLine(string.Join(", ", primeNumbers));
        }

        public static List<long> IsPrime(long start, long end)
        {
            List<long> primes = new List<long>();

            for (long i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i != 0 && i != 1)
                {
                    for (long j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                else
                {
                    isPrime = false;
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
