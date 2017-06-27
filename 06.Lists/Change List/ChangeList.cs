namespace Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChangeList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split().ToList();

            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    var numberToDelete = int.Parse(commands[1]);
                    numbers.RemoveAll(n => n == numberToDelete);
                }
                else if (commands[0] == "Insert")
                {
                    var numberToAdd = int.Parse(commands[1]);
                    var indexToAdd = int.Parse(commands[2]);
                    numbers.Insert(indexToAdd, numberToAdd);
                }

                commands = Console.ReadLine().Split().ToList();
            }

            var result = new List<int>();

            if (commands[0] == "Odd")
            {
                result = numbers.Where(n => n % 2 == 1).ToList();
            }
            else if (commands[0] == "Even")
            {
                result = numbers.Where(n => n % 2 == 0).ToList();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
