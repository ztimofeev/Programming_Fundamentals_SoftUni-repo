using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split(' ');

            int startIndex = 0;
            int count = 0;

            List<string> currList = new List<string>();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "reverse":
                        startIndex = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (startIndex < 0 || startIndex >= input.Count || (startIndex + count) > input.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        currList = input.Skip(startIndex).Take(count).Reverse().ToList();
                        input.RemoveRange(startIndex, count);
                        input.InsertRange(startIndex, currList);
                        break;

                    case "sort":
                        startIndex = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (startIndex < 0 || startIndex + count > input.Count || count < 0 || startIndex >= input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        currList = input.Skip(startIndex).Take(count).OrderBy(str => str).ToList(); 
                        input.RemoveRange(startIndex, count);
                        input.InsertRange(startIndex, currList);
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
                            string element = input[0];
                            input.RemoveAt(0);
                            input.Add(element);
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
                            string element = input[input.Count - 1];
                            input.RemoveAt(input.Count - 1);
                            input.Insert(0, element);
                        }

                        break;
                }

                command = Console.ReadLine().Split(' ');
            }

            string output = string.Join((", "), input);
            Console.WriteLine($"[{output}]");
        }
    }
}
