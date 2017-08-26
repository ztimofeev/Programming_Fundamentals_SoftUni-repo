namespace Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Wardrobe
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> clothesInWardrobe = new Dictionary<string, Dictionary<string, int>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new [] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var color = inputLine[0];

                if (! clothesInWardrobe.ContainsKey(color))
                {
                    clothesInWardrobe.Add(color, new Dictionary<string, int>());
                }

                var clothes = inputLine[1].Split(',');

                foreach (var cloth in clothes)
                {
                    if (! clothesInWardrobe[color].ContainsKey(cloth))
                    {
                        clothesInWardrobe[color][cloth] = 0;
                    }
                    
                    clothesInWardrobe[color][cloth] += 1;
                }
            }

            var searchingColorAndCloth = Console.ReadLine().Split(' ');
            var searchingColor = searchingColorAndCloth[0];
            var searchingCloth = searchingColorAndCloth[1];

            foreach (var item in clothesInWardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                bool isColorPassed = item.Key == searchingColor;

                foreach (var cloth in item.Value)
                {
                    if (cloth.Key == searchingCloth && isColorPassed)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
