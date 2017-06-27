using System;
using System.Collections.Generic;
using System.Linq;

namespace PhonebookUpgraded
{
    public class PhonebookUpgraded
    {
        public static void Main()
        {
            var dataLine = Console.ReadLine().Split();

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (dataLine[0] != "END")
            {
                var action = dataLine[0];
                

                if (action == "A")
                {
                    var name = dataLine[1];
                    var phoneNumber = dataLine[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook[name] = string.Empty;
                    }
                    phonebook[name] = phoneNumber;
                }
                else if (action == "S")
                {
                    var name = dataLine[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (action == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        var name = item.Key;
                        var phoneNumber = item.Value;
                        Console.WriteLine($"{name} -> {phoneNumber}");
                    }
                }

                dataLine = Console.ReadLine().Split();
            }
        }
    }
}
