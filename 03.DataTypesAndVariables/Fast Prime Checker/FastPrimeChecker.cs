namespace Fast_Prime_Checker
{
    using System;

    public class FastPrimeChecker
    {
        public static void Main()
        {
            int endOfRange = int.Parse(Console.ReadLine());
            for (int i = 2; i <= endOfRange; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime);
            }
        }
    }
}
