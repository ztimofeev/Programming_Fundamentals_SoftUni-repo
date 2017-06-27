namespace Sequence_of_Commands
{
    using System;
    using System.Linq;

    public class SequenceOfCommands
    {
        public static void Main()
        {
            var countNumbers = int.Parse(Console.ReadLine());
            var numbersArray = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var command = Console.ReadLine().Split().ToArray();

            while (command[0] != "stop")
            {
                var manipulatedArray = new long[numbersArray.Length];

                if (command[0] == "multiply" || command[0] == "add" || command[0] == "subtract")
                {
                    var action = command[0];
                    var index = long.Parse(command[1]) - 1;
                    var value = long.Parse(command[2]);

                    manipulatedArray = PerformAction(numbersArray, action, index, value);

                }
                else if (command[0] == "lshift")
                {
                    manipulatedArray = ArrayShiftLeft(numbersArray, countNumbers);
                }
                else if (command[0] == "rshift")
                {
                    manipulatedArray = ArrayShiftRight(numbersArray, countNumbers);
                }

                Console.WriteLine(string.Join(" ", manipulatedArray));

                command = Console.ReadLine().Split().ToArray();
            }
        }

        public static long[] PerformAction(long[] numbers, string action, long index, long value)
        {
            switch (action)
            {
                case "multiply":
                    numbers[index] *= value;
                    break;
                case "add":
                    numbers[index] += value;
                    break;
                case "subtract":
                    numbers[index] -= value;
                    break;
            }

            return numbers;
        }

        public static long[] ArrayShiftRight(long[] numbers, int len)
        {
            var temp = numbers[len - 1];
            for (int i = len - 1; i >= 1; i--)
            {
                numbers[i] = numbers[i - 1];
            }
            numbers[0] = temp;

            return numbers;
        }

        private static long[] ArrayShiftLeft(long[] numbers, int len)
        {
            var temp = numbers[0];

            for (int i = 0; i < len - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[len - 1] = temp;

            return numbers;
        }
    }
}
