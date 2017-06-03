namespace TravelingAtLightSpeed
{
    using System;

    public class TravelingAtLightSpeed
    {
        public static void Main()
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal total = lightYears * (9450000000000 / 300000);

            decimal weeks = Math.Floor(total / 60 / 60 / 24 / 7);
            decimal days = Math.Floor(total / 60 / 60 / 24 % 7);
            decimal hours = Math.Floor(total / 60 / 60 % 24);
            decimal mins = Math.Floor(total / 60 % 60);
            decimal sec = Math.Floor(total % 60);

            Console.WriteLine("{0} weeks", weeks);
            Console.WriteLine("{0} days", days);
            Console.WriteLine("{0} hours", hours);
            Console.WriteLine("{0} minutes", mins);
            Console.WriteLine("{0} seconds", sec);
        }
    }
}
