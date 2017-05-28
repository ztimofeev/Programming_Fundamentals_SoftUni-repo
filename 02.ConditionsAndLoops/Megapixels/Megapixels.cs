namespace Megapixels
{
    using System;

    public class Megapixels
    {
        public static void Main()
        {
            var imgWidth = int.Parse(Console.ReadLine());
            var imgHeight = int.Parse(Console.ReadLine());

            double result = imgWidth * imgHeight / 1000000.00;
            Console.WriteLine($"{imgWidth}x{imgHeight} => {Math.Round(result, 1)}MP");
        }
    }
}
