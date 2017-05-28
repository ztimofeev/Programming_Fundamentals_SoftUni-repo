namespace TestNumbers
{
    using System;

    public class TestNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());

            var counter = 0;
            var sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    counter += 1;
                    sum += 3 * i * j;
                    if (sum >= stop)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", sum, stop);

                        return;
                    }
                }
            }

            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
