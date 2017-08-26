using System;

namespace _1.HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            int flaps = int.Parse(Console.ReadLine());
            double distancePer1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double totalDistance = flaps / 1000 * distancePer1000Flaps;
            double flapsTime = flaps / 100.0;
            double restTime = flaps / endurance * 5.0;
            double totalTimeForDistance = flapsTime + restTime;

            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine($"{totalTimeForDistance} s.");
        }
    }
}
