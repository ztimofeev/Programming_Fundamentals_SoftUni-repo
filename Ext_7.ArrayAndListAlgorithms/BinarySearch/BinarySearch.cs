namespace BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BinarySearch
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numberToFind = int.Parse(Console.ReadLine());

            SearchingByLinearMethod(inputNumbers, numberToFind);
            SearchingByBinaryMethod(inputNumbers, numberToFind); 
        }

        public static void SearchingByLinearMethod(List<int> inputNumbers, int numberToFind)
        {
            int countIterations = 0;
            string isFound = "No";
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                countIterations++;
                if (inputNumbers[i] == numberToFind)
                {
                    isFound = "Yes";
                    break;
                }
            }

            Console.WriteLine(isFound);
            Console.WriteLine($"Linear search made {countIterations} iterations");
        }

        public static void SearchingByBinaryMethod(List<int> numbers, int seartchingNum)
        {
            int countIterations = 0;
            numbers = numbers.OrderBy(n => n).ToList();

            int lowerBound = 0;
            int upperBound = numbers.Count - 1;

            while (true)
            {
                countIterations++;
                var midPoint = lowerBound + (upperBound - lowerBound) / 2;

                if (numbers[midPoint] < seartchingNum)
                {
                    lowerBound = midPoint + 1;
                }
                else if (numbers[midPoint] > seartchingNum)
                {
                    upperBound = midPoint - 1;
                }
                else
                {
                    break;
                }

                if (upperBound < lowerBound)
                {
                    break;
                }
            }

            Console.WriteLine($"Binary search made {countIterations} iterations");
        }
    }
}
