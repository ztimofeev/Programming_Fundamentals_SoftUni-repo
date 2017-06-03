namespace ConvertSpeedUnits
{
    using System;

    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            var distance = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            double timeSecunds = hours * 60 * 60 + minutes * 60 + seconds;
            double timeHours = timeSecunds / 60 / 60.0;

            double meterPerSec = Math.Round(distance / timeSecunds, 6);
            double kilometerPerHour = Math.Round(meterPerSec * 3.6, 6);
            double milePerHour = Math.Round(kilometerPerHour * 0.621504, 6);

            Console.WriteLine(meterPerSec);
            Console.WriteLine(kilometerPerHour);
            Console.WriteLine(milePerHour);
        }
    }
}
