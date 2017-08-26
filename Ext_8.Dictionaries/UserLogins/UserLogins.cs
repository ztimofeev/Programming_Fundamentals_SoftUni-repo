namespace UserLogins
{
    using System;
    using System.Collections.Generic;

    public class UserLogins
    {
        public static void Main()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            var input = Console.ReadLine().Split();


            while (input[0] != "login")
            {
                var userName = input[0];
                var password = input[input.Length - 1];
                if (!users.ContainsKey(userName))
                {
                    users.Add(userName, password);
                }
                else
                {
                    users[userName] = password;
                }

                input = Console.ReadLine().Split();
            }

            var logins = Console.ReadLine().Split();
            var counterFailedLogins = 0;

            while (logins[0] != "end")
            {
                var logUserName = logins[0];
                var logPassword = logins[logins.Length - 1];

                if (!users.ContainsKey(logUserName) || users[logUserName] != logPassword)
                {
                    Console.WriteLine($"{logUserName}: login failed");
                    counterFailedLogins++;
                }
                else
                {
                    Console.WriteLine($"{logUserName}: logged in successfully");
                }

                logins = Console.ReadLine().Split();
            }

            Console.WriteLine($"unsuccessful login attempts: {counterFailedLogins}");
        }
    }
}
