namespace Convert_Speed_Units
{
    using System;

    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            var distance = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            float timeSecunds = hours * 3600 + minutes * 60 + seconds;
            float timeHours = timeSecunds / 3600;

            float meterPerSec = distance / timeSecunds;
            float kilometerPerHour = distance / 1000 / timeHours;
            float milePerHour = (distance / 1609) / timeHours;

            Console.WriteLine(meterPerSec);
            Console.WriteLine(kilometerPerHour);
            Console.WriteLine(milePerHour);
        }
    }
}
