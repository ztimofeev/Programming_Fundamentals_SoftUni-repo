namespace Manipulate_Array
{
    using System;
    using System.Linq;

    public class ManipulateArray
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();
            var iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                var command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Distinct":
                        words = words.Distinct().ToArray();
                        break;
                    case "Reverse":
                        words = words.Reverse().ToArray();
                        break;
                    case "Replace":
                        var index = int.Parse(command[1]);
                        words[index] = command[2];
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
