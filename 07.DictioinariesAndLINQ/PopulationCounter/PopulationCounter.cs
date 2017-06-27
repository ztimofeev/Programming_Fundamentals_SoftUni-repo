using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split('|');

            Dictionary<string, Dictionary<string, long>> countryPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (data[0] != "report")
            {
                var country = data[1];
                var city = data[0];
                var population = long.Parse(data[2]);

                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation[country] = new Dictionary<string, long>();
                }

                if (!countryPopulation[country].ContainsKey(city))
                {
                    countryPopulation[country][city] = population;
                }
                
                data = Console.ReadLine().Split('|');
            }

            Dictionary<string, long> sortedPopulation = new Dictionary<string, long>();

            foreach (var line in countryPopulation)
            {
                long totalPopulation = CalcTotalPopulation(line.Value);
                var country = line.Key;
                sortedPopulation[country] = totalPopulation;
            }

            var sortedDict = sortedPopulation.OrderByDescending(p => p.Value);


            foreach (var line in sortedDict)
            {
                var sortedCountry = line.Key;

                foreach (var country in countryPopulation)
                {
                    
                    if (country.Key == sortedCountry)
                    {
                        long totalPopulation = line.Value;

                        Console.WriteLine("{0} (total population: {1})", country.Key, totalPopulation);

                        foreach (var city in countryPopulation[country.Key].OrderByDescending(x => x.Value))
                        {
                            Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                        }
                    }
                }
            }
        }

        public static long CalcTotalPopulation(Dictionary<string, long> country)
        {
            long totalPopulation = 0;
            foreach (var city in country)
            {
                totalPopulation += city.Value;
            }

            return totalPopulation;
        }
    }
}
