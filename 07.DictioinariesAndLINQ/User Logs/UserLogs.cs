using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            SortedDictionary<string, Dictionary<string, int>> names = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string ip = input[0].Substring(3);
                string user = input[2].Substring(5);

                if (!names.ContainsKey(user))
                {
                    names[user] = new Dictionary<string, int>();
                }

                if (!names[user].ContainsKey(ip))
                {
                    names[user][ip] = 0;
                }

                names[user][ip]++;
                
                input = Console.ReadLine().Split(' ');
            }

            foreach (var member in names.Keys)
            {
                Console.WriteLine($"{member}: ");

                var idAndMessages = new List<string>();

                foreach (var item in names[member])
                {
                    var str = item.Key + " => " + item.Value;
                    idAndMessages.Add(str);
                }

                Console.Write(string.Join(", ", idAndMessages));
                Console.WriteLine(".");
            }
        }
    }
}
