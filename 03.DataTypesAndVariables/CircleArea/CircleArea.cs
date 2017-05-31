namespace CircleArea
{
    using System;

    public class CircleArea
    {
        public static void Main()
        {
            var radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * radius * radius;

            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
