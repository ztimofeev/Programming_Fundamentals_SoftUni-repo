using System;
using System.Collections.Generic;
using System.Linq;

namespace Be_Positive
{
    public class BePositive
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                var numbers = Console.ReadLine().Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                var positivNumbers = new List<int>();
                bool isFound = false;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] < 0)
                    {
                        if (j < numbers.Length - 1)
                        {
                            var sumWithNext = numbers[j] + numbers[j + 1];

                            if (sumWithNext >= 0)
                            {
                                positivNumbers.Add(sumWithNext);
                                isFound = true;
                            }
                        }

                        j++;
                    }
                    else
                    {
                        positivNumbers.Add(numbers[j]);
                        isFound = true;
                    }
                }

                if (isFound)
                {
                    Console.WriteLine(string.Join(" ", positivNumbers));
                }
                else
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}
