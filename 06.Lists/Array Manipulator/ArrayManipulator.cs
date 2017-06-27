namespace Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split().ToList();

            var result = new List<int>();

            while (commands[0] != "print")
            {
                switch (commands[0])
                {
                    case "add":
                        numbers.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                        break;

                    case "addMany":
                        var index = int.Parse(commands[1]);
                        for (int i = commands.Count - 1; i > 1; i--)
                        {
                            numbers.Insert(index, int.Parse(commands[i]));
                        }
                        break;

                    case "contains":
                        var element = int.Parse(commands[1]);
                        if (numbers.Contains(element))
                        {
                            Console.WriteLine(numbers.IndexOf(element));
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }
                        break;

                    case "remove":
                        var indexToRemove = int.Parse(commands[1]);
                        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        break;

                    case "shift":
                        var position = int.Parse(commands[1]);
                        numbers = ShiftedNumbers(numbers, position);
                        break;

                    case "sumPairs":

                        if (numbers.Count > 1)
                        {
                            for (int i = 0; i < numbers.Count - 1; i++)
                            {
                                numbers[i] += numbers[i + 1];
                                numbers.RemoveAt(i + 1);
                            }
                        }
                        break;
                }

                commands = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        public static List<int> ShiftedNumbers(List<int> nums, int p)
        {
            for (int i = 0; i < p; i++)
            {
                var temp = nums[0];
                for (int j = 0; j < nums.Count - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }
                nums[nums.Count - 1] = temp;
            }

            return nums;
        }
    }
}
