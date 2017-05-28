
namespace MilesInKilometers
{
    using System;

    public class MilesInKilometers
    {
        public static void Main()
        {
            var miles = double.Parse(Console.ReadLine());

            var kilometers = miles * 1.60934;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
