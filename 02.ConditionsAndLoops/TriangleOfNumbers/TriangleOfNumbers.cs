namespace TriangleOfNumbers
{
    using System;

    public class TriangleOfNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
