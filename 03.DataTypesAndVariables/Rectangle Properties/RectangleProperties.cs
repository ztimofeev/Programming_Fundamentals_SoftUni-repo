namespace Rectangle_Properties
{
    using System;

    public class RectangleProperties
    {
        public static void Main()
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());

            double perimeter = (sideA + sideB) * 2;
            double area = sideA * sideB;
            double diagonal = Math.Sqrt(sideA * sideA + sideB * sideB);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
