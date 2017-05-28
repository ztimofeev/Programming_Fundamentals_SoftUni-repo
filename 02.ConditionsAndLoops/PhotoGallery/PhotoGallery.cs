namespace PhotoGallery
{
    using System;

    public class PhotoGallery
    {
        public static void Main()
        {
            var currentNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var size = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var orientation = string.Empty;

            Console.WriteLine($"Name: DSC_{currentNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minute:D2}");

            if (size < 1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size < 1000000)
            {
                Console.WriteLine($"Size: {size / 1000.00}KB");
            }
            else
            {
                Console.WriteLine($"Size: {Math.Round(size / 1000000.00, 1)}MB");
            }

            Console.Write($"Resolution: {width}x{height} ");
            if (width > height)
            {
                Console.WriteLine("(landscape)");
            } else if (width < height)
            {
                Console.WriteLine("(portrait)");
            }
            else
            {
                Console.WriteLine("(square)");
            }
        }
    }
}
