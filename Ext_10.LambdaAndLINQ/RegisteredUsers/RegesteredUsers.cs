namespace RegisteredUsers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class RegesteredUsers
    {
        public static void Main()
        {
            Dictionary<string, DateTime> users = new Dictionary<string, DateTime>();

            var inputData = Console.ReadLine();

            while (inputData != "end")
            {
                var tokens = inputData.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var userName = tokens[0];
                DateTime dateOfRegistration = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                users.Add(userName, dateOfRegistration);
                
                inputData = Console.ReadLine();
            }

            Dictionary<string, DateTime> orderedUserNames = users
                .Reverse()
                .OrderBy(d => d.Value)
                .Take(5)
                .OrderByDescending(d => d.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var orderedUserName in orderedUserNames)
            {
                Console.WriteLine(orderedUserName.Key);
            }
        }
    }
}
