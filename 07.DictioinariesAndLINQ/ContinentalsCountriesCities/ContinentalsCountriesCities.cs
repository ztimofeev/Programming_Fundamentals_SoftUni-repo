namespace ContinentalsCountriesCities
{
    using System;
    using System.Collections.Generic;

    public class ContinentalsCountriesCities
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> globalData = 
                new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var infoLine = Console.ReadLine().Split();
                var continent = infoLine[0];
                var country = infoLine[1];
                var city = infoLine[2];

                if (! globalData.ContainsKey(continent))
                {
                    globalData[continent] = new Dictionary<string, List<string>>();
                }
                
                if (! globalData[continent].ContainsKey(country))
                {
                    globalData[continent][country] = new List<string>();
                }

                globalData[continent][country].Add(city);
            }

            foreach (var continentCountries in globalData)
            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;

                Console.WriteLine($"{continentName}:");

                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;

                    Console.WriteLine("  {0} -> {1}", countryName, string.Join(", ", cities));
                }
            }
        }
    }
}
