using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetComm
{
    public class HornetComm
    {
        public static void Main()
        {
            List<Dictionary<string, string>> privateMessages = new List<Dictionary<string, string>>();
            List<Dictionary<string, string>> broadcasts = new List<Dictionary<string, string>>();

            Regex regexMessages = new Regex(@"^(\d+)\s\<-\>\s([A-Za-z0-9]+)$");
            Regex regexBroadcasts = new Regex(@"^([^0-9]+)\s\<-\>\s([A-Za-z0-9]+)$");

            var input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                if (regexMessages.IsMatch(input))
                {
                    var matchesMessages = regexMessages.Match(input);
                    var recipientCode = matchesMessages.Groups[1].Value;
                    var message = matchesMessages.Groups[2].Value;
                    
                    SaveMessage(privateMessages, recipientCode, message);
                }
                else if(regexBroadcasts.IsMatch(input))
                {
                    var matchesBroadcast = regexBroadcasts.Match(input);
                    var broadcastMessage = matchesBroadcast.Groups[1].Value;
                    var frequency = matchesBroadcast.Groups[2].Value;
                    
                    SaveBroadcast(broadcasts, broadcastMessage, frequency);
                }

                input = Console.ReadLine();
            }

            PrintOutput(broadcasts, "Broadcasts:");
            PrintOutput(privateMessages, "Messages:");
        }

        public static void PrintOutput(List<Dictionary<string, string>> input, string name)
        {
            Console.WriteLine(name);
            if (input.Count != 0)
            {
                foreach (var item in input)
                {
                    foreach (var record in item)
                    {
                        var code = record.Key;
                        var message = record.Value;
                        Console.WriteLine($"{code} -> {message}");
                    } 
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        public static void SaveBroadcast(List<Dictionary<string, string>> broadcasts, string broadcastMessage, string frequency)
        {
            var currentInfo = new Dictionary<string, string>();
            var modifiedFrequency = ChangeLettersCase(frequency);
            currentInfo.Add(modifiedFrequency, broadcastMessage);
            broadcasts.Add(currentInfo);
        }

        public static string ChangeLettersCase(string frequency)
        {
            string output = "";
            foreach (var ch in frequency)
            {
                if (char.IsLetter(ch))
                {
                    if (char.IsUpper(ch))
                    {
                        output += char.ToLower(ch);
                    }
                    else
                    {
                        output += char.ToUpper(ch);
                    }
                }
                else
                {
                    output += ch;
                }
            }

            return output;
        }

        public static void SaveMessage(List<Dictionary<string, string>> privateMessages, string recipientCode, string message)
        {
            var currentInfo = new Dictionary<string, string>();
            var revercedCode = ReverceNumber(recipientCode);
            currentInfo.Add(revercedCode, message);
            privateMessages.Add(currentInfo);
        }

        public static string ReverceNumber(string numberAsString)
        {
            return string.Join("", numberAsString.Reverse());
        }
    }
}
