namespace Safe_Manipulatioin
{
    using System;
    using System.Linq;

    public class SafeManipulatioin
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();

            var command = Console.ReadLine().Split().ToArray();

            while (command[0] != "END")
            {
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

                        if (index >= 0 && index < words.Length)
                        {
                            words[index] = command[2];
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}