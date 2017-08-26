namespace TravelCompany
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> travelDistinations = new Dictionary<string, Dictionary<string, int>>();

            var capacityData = Console.ReadLine().Split(':');

            while (capacityData[0] != "ready")
            {
                var cityDistination = capacityData[0];
                var transportTypesAndSeats = capacityData[1].Split(',');

                if (! travelDistinations.ContainsKey(cityDistination))
                {
                    travelDistinations[cityDistination] = new Dictionary<string, int>();
                }

                foreach (var item in transportTypesAndSeats)
                {
                    var typeAndSeats = item.Split('-');
                    var type = typeAndSeats[0];
                    var seats = int.Parse(typeAndSeats[1]);

                    if (! travelDistinations[cityDistination].ContainsKey(type))
                    {
                        travelDistinations[cityDistination].Add(type, seats);
                    }
                    else
                    {
                        travelDistinations[cityDistination][type] = seats;
                    }
                }

                capacityData = Console.ReadLine().Split(':');
            }

            var tours = Console.ReadLine().Split(' ');

            while (tours[0] != "travel")
            {
                var tourCity = tours[0];
                var touristsCount = int.Parse(tours[1]);

                foreach (var distination in travelDistinations)
                {
                    if (distination.Key == tourCity)
                    {
                        var count = 0;
                        foreach (var capacity in distination.Value)
                        {
                            count += capacity.Value;
                        }

                        if (count >= touristsCount)
                        {
                            Console.WriteLine($"{distination.Key} -> all {touristsCount} accommodated");
                        }
                        else
                        {
                            var diff = touristsCount - count;
                            Console.WriteLine($"{distination.Key} -> all except {diff} accommodated");
                        }
                    }
                }

                tours = Console.ReadLine().Split();
            }
        }
    }
}
