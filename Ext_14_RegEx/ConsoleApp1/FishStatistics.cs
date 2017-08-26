namespace FishStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Fish
    {
        public string Shape { get; set; }
        public int TailLenght { get; set; }
        public int BodyLenght { get; set; }
        public string Status { get; set; }
    }

    public class FishStatistics
    {

        public static void Main()
        {
            Regex fishPattern = new Regex(@"(>*)<(\(+)('|-|x)>");

            List<Fish> fishes = new List<Fish>();

            string input = Console.ReadLine();

            var matchedFishes = fishPattern.Matches(input);

            if (matchedFishes.Count > 0)
            {
                foreach (Match fish in matchedFishes)
                {
                    int fishTail = 0;
                    if (fish.Groups[1].Value != "")
                    {
                        fishTail = fish.Groups[1].Value.Length;
                    }

                    int fishBody = fish.Groups[2].Length;

                    string fishStatus = "";
                    var fishState = fish.Groups[3].Value;
                    if (fishState == "'")
                    {
                        fishStatus = "Awake";
                    }
                    else if (fishState == "-")
                    {
                        fishStatus = "Asleep";
                    }
                    else if (fishState == "x")
                    {
                        fishStatus = "Dead";
                    }

                    Fish currentFish = new Fish();
                    currentFish.Shape = fish.Groups[0].Value;
                    currentFish.TailLenght = fishTail;
                    currentFish.BodyLenght = fishBody;
                    currentFish.Status = fishStatus;

                    fishes.Add(currentFish);
                }

                int counter = 1;
                foreach (var fish in fishes)
                {
                    string tail;
                    string body;

                    Console.WriteLine($"Fish {counter}: {fish.Shape}");

                    if (fish.TailLenght > 5)
                    {
                        tail = "Long";
                    }
                    else if (fish.TailLenght > 1)
                    {
                        tail = "Medium";
                    }
                    else if (fish.TailLenght == 1)
                    {
                        tail = "Short";
                    }
                    else
                    {
                        tail = "None";
                    }

                    if (fish.TailLenght > 0)
                    {
                        Console.WriteLine($"  Tail type: {tail} ({fish.TailLenght * 2} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"  Tail type: {tail}");
                    }

                    if (fish.BodyLenght > 10)
                    {
                        body = "Long";
                    }
                    else if (fish.BodyLenght > 5)
                    {
                        body = "Medium";
                    }
                    else
                    {
                        body = "Short";
                    }

                    Console.WriteLine($"  Body type: {body} ({fish.BodyLenght * 2} cm)");
                    Console.WriteLine($"  Status: {fish.Status}");
                    counter++;
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
