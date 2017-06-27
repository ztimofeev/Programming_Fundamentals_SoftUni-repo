namespace Sieve_of_Eratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    Console.Write($"{i} ");
                    for (int j = 2; j <= n; j++)
                    {
                        if (i * j <= n)
                        {
                            isPrime[i * j] = false;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
