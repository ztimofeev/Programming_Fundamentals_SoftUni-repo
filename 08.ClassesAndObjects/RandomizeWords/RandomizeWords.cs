using System;
using System.Linq;

namespace RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();

            var rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var rndPositin = rnd.Next(0, words.Length);
                var temp = words[i];
                words[i] = words[rndPositin];
                words[rndPositin] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
