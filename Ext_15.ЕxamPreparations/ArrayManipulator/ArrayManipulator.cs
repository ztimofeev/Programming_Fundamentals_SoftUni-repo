using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                var commandTokens = command.Split();
                var baseCommand = commandTokens[0];

                switch (baseCommand)
                {
                    case "exchange":
                        var exchangeIndex = int.Parse(commandTokens[1]);
                        if (exchangeIndex >= input.Count || exchangeIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            var subList = input.Skip(exchangeIndex + 1).Take(input.Count).ToList();

                            var temp = input.Take(exchangeIndex + 1).ToList();
                            input.Clear();
                            input.AddRange(subList);
                            input.AddRange(temp);
                        }
                        break;

                    case "max":
                        string evenOrOdd = commandTokens[1];
                        int maxIndex = GetMaxIndexOfEvenOrOddElement(input, evenOrOdd);

                        if (maxIndex > -1)
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }

                        break;

                    case "min":
                        string minEvenOdd = commandTokens[1];
                        var minIndex = GetMinIndexOfEvenOrOddElement(input, minEvenOdd);

                        if (minIndex > -1)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }

                        break;

                    case "first":
                        int count = int.Parse(commandTokens[1]);
                        evenOrOdd = commandTokens[2];

                        List<int> firstInts = GetFirstEvenOrOddElements(input, count, evenOrOdd);

                        if (count <= input.Count)
                        {
                            if (firstInts.Count > 0)
                            {
                                Console.WriteLine($"[{string.Join(", ", firstInts)}]");
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;

                    case "last":
                        count = int.Parse(commandTokens[1]);
                        evenOrOdd = commandTokens[2];

                        List<int> lastInts = GetLastEvenOrOddElements(input, count, evenOrOdd);

                        if (count <= input.Count)
                        {
                            if (lastInts.Count > 0)
                            {
                                Console.WriteLine($"[{string.Join(", ", lastInts)}]");
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        public static List<int> GetLastEvenOrOddElements(List<int> input, int count, string evenOrOdd)
        {
            List<int> result = new List<int>();

            if (evenOrOdd == "even")
            {
                result = input.Where(n => n % 2 == 0).Reverse().Take(count).Reverse().ToList();
            }
            else if (evenOrOdd == "odd")
            {
                result = input.Where(n => n % 2 != 0).Reverse().Take(count).Reverse().ToList();
            }

            return result;
        }

        public static List<int> GetFirstEvenOrOddElements(List<int> input, int count, string evenOrOdd)
        {
            List<int> result = new List<int>();

            if (evenOrOdd == "even")
            {
                result = input.Where(n => n % 2 == 0).Take(count).ToList();
            }
            else if (evenOrOdd == "odd")
            {
                result = input.Where(n => n % 2 != 0).Take(count).ToList();
            }

            return result;
        }

        public static int GetMinIndexOfEvenOrOddElement(List<int> input, string evenOrOdd)
        {
            int minIndex = -1;
            int minElement = int.MaxValue;

            if (evenOrOdd == "even")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        if (minElement >= input[i])
                        {
                            minElement = input[i];
                            minIndex = i;
                        }
                    }
                }
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 != 0)
                    {
                        if (minElement >= input[i])
                        {
                            minElement = input[i];
                            minIndex = i;
                        }
                    }
                }
            }

            return minIndex;
        }

        public static int GetMaxIndexOfEvenOrOddElement(List<int> input, string evenOrOdd)
        {
            int maxIndex = -1;
            int maxElement = int.MinValue;

            if (evenOrOdd == "even")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        if (input[i] >= maxElement)
                        {
                            maxElement = input[i];
                            maxIndex = i;
                        }
                    }
                }
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 != 0)
                    {
                        if (input[i] >= maxElement)
                        {
                            maxElement = input[i];
                            maxIndex = i;
                        }
                    }
                }
            }

            return maxIndex;
        }
    }
}
