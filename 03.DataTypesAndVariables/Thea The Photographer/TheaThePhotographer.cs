namespace Thea_The_Photographer
{
    using System;

    public class TheaThePhotographer
    {
        public static void Main()
        {
            var picturesCount = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var goodPictures = (int)Math.Ceiling(picturesCount * (double)filterFactor / 100);
            long totalSeconds = (long)picturesCount * filterTime + (long)goodPictures * uploadTime;

            var days = totalSeconds / 86400;
            var hours = (totalSeconds % 86400) / 3600;
            var minutes = (totalSeconds % 3600) / 60;
            var seconds = totalSeconds % 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
