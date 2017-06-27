namespace BigInteger
{
    using System;
    using System.Numerics;

    public class BigIntegerSample
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger fact = 1;

            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
