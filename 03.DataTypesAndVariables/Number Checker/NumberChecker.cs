namespace Number_Checker
{
    using System;
    using System.Numerics;


    public class NumberChecker
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            BigInteger num;
            if (BigInteger.TryParse(input, out num))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
