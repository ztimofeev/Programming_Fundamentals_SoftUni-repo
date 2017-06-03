namespace BeerKegs
{
    using System;

    public class BeerKegs
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            string biggestKeg = String.Empty;
            double biggestVolume = 0; 

            for (int i = 0; i < n; i++)
            {
                var model = Console.ReadLine();
                var radius = float.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (biggestVolume <= volume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
