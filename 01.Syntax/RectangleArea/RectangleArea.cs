namespace RectangleArea
{
    using System;

    public class RectangleArea
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;
            Console.WriteLine($"{area:f2}");
        }
    }
}
