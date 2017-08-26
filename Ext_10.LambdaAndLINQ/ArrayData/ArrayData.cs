namespace ArrayData
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ArrayData
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var averageValue = numbers.Average();

            var command = Console.ReadLine();

            switch (command)
            {
                case "Min":
                    Console.WriteLine(GetLargestOfAverage(numbers, averageValue).Min());
                    break;

                case "Max":
                    Console.WriteLine(GetLargestOfAverage(numbers, averageValue).Max());
                    break;

                case "All":
                    Console.WriteLine(string.Join(" ", GetLargestOfAverage(numbers, averageValue).OrderBy(x => x).ToArray()));
                    break;
            }
        }

        public static List<int> GetLargestOfAverage(int[] arr, double average)
        {
            return arr.Where(x => x >= average).ToList();
        }
    }
}