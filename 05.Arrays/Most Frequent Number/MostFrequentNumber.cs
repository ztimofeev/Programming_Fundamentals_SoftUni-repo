namespace Most_Frequent_Number
{
    using System;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxCount = 1;
            int mostFreq = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                        if (maxCount < currentCount)
                        {
                            maxCount = currentCount;
                            mostFreq = numbers[i];
                        }
                    }
                }
            }

            Console.WriteLine(mostFreq);
        }
    }
}
