using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray().ToList();

            var startIndex = 0;
            var count = 0;

            var command = Console.ReadLine().Split(' ');

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "reverse":
                        startIndex = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (startIndex < 0 || startIndex >= input.Count || count < 0 || (startIndex + count) > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        
                        var reversedPart = input
                            .Skip(startIndex)
                            .Take(count)
                            .Reverse()
                            .ToList();

                        input.RemoveRange(startIndex, count);
                        input.InsertRange(startIndex, reversedPart);
                        break;

                    case "sort":
                        startIndex = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (startIndex < 0 || startIndex >= input.Count || count < 0 || (startIndex + count) > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        
                        var sortedPart = input
                            .Skip(startIndex)
                            .Take(count)
                            .OrderBy(str => str)
                            .ToList();

                        input.RemoveRange(startIndex, count);
                        input.InsertRange(startIndex, sortedPart);
                        break;

                    case "rollLeft":
                        count = int.Parse(command[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < count % input.Count; i++)
                        {
                            var temp = input[0];
                            input.RemoveAt(0);
                            input.Add(temp);
                        }
                        break;

                    case "rollRight":
                        count = int.Parse(command[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < count % input.Count; i++)
                        {
                            var temp = input[input.Count - 1];
                            input.RemoveAt(input.Count - 1);
                            input.Insert(0, temp);
                        }
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }

            string output = string.Join(", ", input);
            Console.WriteLine($"[{output}]");
        }
    }
}
