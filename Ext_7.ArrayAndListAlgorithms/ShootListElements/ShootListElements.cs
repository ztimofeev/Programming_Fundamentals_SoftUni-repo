namespace ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShootListElements
    {
        public static void Main()
        {
            var numbers = new List<int>();
            var countBangs = 0;

            var inputData = Console.ReadLine();

            while (inputData != "stop")
            {
                if (inputData != "bang")
                {
                    var num = int.Parse(inputData);
                    numbers.Insert(0, num);
                }
                else
                {
                    countBangs++;
                    if (countBangs > numbers.Count)
                    {
                        break;
                    }
                }

                inputData = Console.ReadLine();
            }

            if (numbers.Count < countBangs)
            {
                var result = ActionBang(numbers, numbers.Count);
                Console.WriteLine($"shot {result[0]}");
                Console.WriteLine($"nobody left to shoot! last one was {result[0]}");
            }
            else if (numbers.Count == countBangs)
            {
                var result = ActionBang(numbers, numbers.Count);
                Console.WriteLine($"shot {result[0]}");
                Console.WriteLine($"you shot them all. last one was {result[0]}");
            }
            else
            {
                var result = ActionBang(numbers, countBangs + 1);
                Console.WriteLine("survivors: {0}", string.Join(" ", result));
            }
        }

        private static List<int> ActionBang(List<int> numbers, int bangs)
        {
            while (bangs > 1)
            {
                var shootingElement = GetElementAfterAverage(numbers);
                Console.WriteLine($"shot {shootingElement}");
                numbers.Remove(shootingElement);
                bangs--;

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]--;
                }
            }

            return numbers;
        }

        private static int GetElementAfterAverage(List<int> numbers)
        {
            var firstSmaller = 0;
            var average = numbers.Average();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < average)
                {
                    firstSmaller = numbers[i];
                    break;
                }
            }

            return firstSmaller;
        }
    }
}
