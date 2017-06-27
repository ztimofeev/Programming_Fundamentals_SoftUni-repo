namespace Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main(string[] args)
        {
            var dataLine = Console.ReadLine().Split();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (dataLine[0] != "END")
            {
                var action = dataLine[0];
                var name = dataLine[1];

                if (action == "A")
                {
                    var phoneNumber = dataLine[2];
                    if (! phonebook.ContainsKey(name))
                    {
                        phonebook[name] = string.Empty;
                    }
                    phonebook[name] = phoneNumber;
                }
                else if (action == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                dataLine = Console.ReadLine().Split();
            }
        }
    }
}
