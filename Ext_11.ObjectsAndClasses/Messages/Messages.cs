using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages
{
    public class User
    {
        public string Username { get; set; }
        public List<Message> Messages { get; set; }

        public User(string username)
        {
            Username = username;
            Messages = new List<Message>();
        }
    }

    public class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }

        public Message(string content, User sender)
        {
            Content = content;
            Sender = sender;
        }
    }

    public class Messages
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string sender;
            string recipient;
            var users = new Dictionary<string, User>();

            while (input != "exit")
            {
                var tokens = input.Split(' ');

                if (tokens[0] == "register")
                {
                    var username = tokens[1];

                    users.Add(username, new User(username));
                }
                else
                {
                    sender = tokens[0];
                    recipient = tokens[2];
                    var content = tokens[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        Message message = new Message(content, users[sender]);
                        users[recipient].Messages.Add(message);
                    }
                }

                input = Console.ReadLine();
            }

            var chatTokens = Console.ReadLine().Split(' ');
            sender = chatTokens[0];
            recipient = chatTokens[1];

            Message[] senderMessages = users[recipient].Messages.Where(m => m.Sender.Username == sender).ToArray();
            Message[] recipientMessages = users[sender].Messages.Where(m => m.Sender.Username == recipient).ToArray();

            if (senderMessages.Length == 0 && recipientMessages.Length == 0)
            {
                Console.WriteLine("No messages");
            }

            var index = 0;

            while (index < senderMessages.Length && index < recipientMessages.Length)
            {
                Console.WriteLine($"{sender}: {senderMessages[index].Content}");
                Console.WriteLine($"{recipientMessages[index].Content} :{recipient}");

                index++;
            }

            while (index < senderMessages.Length)
            {
                Console.WriteLine($"{sender}: {senderMessages[index].Content}");
                index++;
            }

            while (index < recipientMessages.Length)
            {
                Console.WriteLine($"{recipientMessages[index].Content} :{recipient}");
                index++;
            }
        }
    }
}
