namespace TriangleFormations
{
    using System;

    public class TriangleFormations
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }

            if (a == Math.Sqrt(b * b + c * c))
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (b == Math.Sqrt(a * a + c * c))
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else if (c == Math.Sqrt(b * b + a * a))
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }
}
