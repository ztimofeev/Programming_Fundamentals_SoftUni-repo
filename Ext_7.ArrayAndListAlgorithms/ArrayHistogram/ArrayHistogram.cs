namespace ArrayHistogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayHistogram
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToArray();

            List<string> words = new List<string>();
            List<int> countAccurances = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (words.Contains(text[i]))
                {
                    int indexWord = words.IndexOf(text[i]);
                    countAccurances[indexWord]++;
                }
                else
                {
                    words.Add(text[i]);
                    countAccurances.Add(1);
                }
            }

            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < countAccurances.Count - 1; i++)
                {

                    if (countAccurances[i] < countAccurances[i + 1])
                    {
                        var temp = countAccurances[i];
                        countAccurances[i] = countAccurances[i + 1];
                        countAccurances[i + 1] = temp;

                        string tempWord = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempWord;

                        swapped = true;
                    }
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                double currentPersetage = countAccurances[i] / (double)text.Length * 100;
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", words[i], countAccurances[i], currentPersetage);
            }
        }
    }
}