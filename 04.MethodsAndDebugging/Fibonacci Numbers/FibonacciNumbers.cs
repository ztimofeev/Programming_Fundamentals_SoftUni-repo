namespace Fibonacci_Numbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            int fibo;

            if (number == 0 || number == 1)
            {
                fibo = 1;
            }
            else if (number == 2)
            {
                fibo = 2;
            }
            else
            {
                fibo = GetCurrentFibonacciNumber(number);
            }

            Console.WriteLine(fibo);
        }

        public static int GetCurrentFibonacciNumber(int number)
        {
            var a = 1;
            var b = 2;
            var fibo = a + b;
            for (int i = 3; i < number; i++)
            {
                a = b;
                b = fibo;
                fibo = a + b;
            }

            return fibo;
        }
    }
}
