namespace Refactor_Volume_of_Pyramid
{
    using System;

    public class RefactorVolumeOfPyramid
    {
        public static void Main()
        {
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            var widht = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());

            var volume = (length * widht * height) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}
