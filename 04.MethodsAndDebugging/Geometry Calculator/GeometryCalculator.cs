namespace Geometry_Calculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            var figure = Console.ReadLine().ToLower();

            switch (figure)
            {
                case "triangle":
                    var side = double.Parse(Console.ReadLine());
                    var height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", TriangleAreaCalculation(side, height));
                    break;

                case "square":
                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", SquareAreaCalculate(side));
                    break;

                case "rectangle":
                    var width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", RectangleAreaCalculation(width, height));
                    break;

                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CircleAreaCalculation(radius));
                    break;
            }
        }

        public static double TriangleAreaCalculation(double param1, double param2)
        {
            return param1 * param2 / 2;
        }

        public static double SquareAreaCalculate(double param1)
        {
            return param1 * param1;
        }

        public static double RectangleAreaCalculation(double param1, double param2)
        {
            return param1 * param2;
        }

        public static double CircleAreaCalculation(double param1)
        {
            return Math.PI * param1 * param1;
        }
    }
}
